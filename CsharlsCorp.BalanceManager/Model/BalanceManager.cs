﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CsharlsCorp.BalanceManager.Model
{
    /// <summary>
    /// Class used to interact with the data model.
    /// </summary>
    class BalanceManager
    {
        /// <summary>
        /// Represents a transaction object that will be stored in the context.
        /// </summary>
        private Transaction _transaction;
        /// <summary>
        /// Represents a transaction detail that will be stored in the context. 
        /// If it is null, no detail will be added.
        /// </summary>
        private Detail _detail;

        #region AddToBalance Methods

        /// <summary>
        /// Saves a transaction to the data source.
        /// </summary>
        /// <param name="type">Value that represents the type of the transaction.</param>
        /// <param name="amount">The total value of the transaction.</param>
        /// <param name="date">The date when the transaction was made.</param>
        public void AddToBalance(byte type, decimal amount, DateTime date)
        {
            using (BalanceEntities balanceDb = new BalanceEntities())
            {
                try
                {
                    _transaction = new Transaction();
                    _transaction.Type = balanceDb.Types.Single(t => t.typeId == type);
                    _transaction.amount = amount;
                    _transaction.date = date;
                    balanceDb.SaveChanges();
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }
        /// <summary>
        /// Saves a transaction to the data source with a default date.
        /// </summary>
        /// <param name="type">Value that represent the type of the transaction.</param>
        /// <param name="amount">The amount of money the transaction will have.</param>
        public void AddToBalance(byte type, decimal amount)
        {
            this.AddToBalance(type, amount, DateTime.Today);
        }
        /// <summary>
        /// Saves the textual detail for a transaction to the data source.
        /// </summary>
        /// <param name="description">A text that explain the transaction.</param>
        public void AddToBalance(string description)
        {
            using (BalanceEntities balanceDb = new BalanceEntities())
            {
                try
                {
                    balanceDb.Details.AddObject(_detail =
                        new Detail { description = description, transactionId = _transaction.transactionId });
                    balanceDb.SaveChanges();
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }
        /// <summary>
        /// Saves the money detail for a transaction to the data source.
        /// </summary>
        /// <param name="billId">Value that represents the type of bill.</param>
        /// <param name="quantity">Value that represents how many bills will be saved.</param>
        public void AddToBalance(byte billId, short quantity)
        {
            using (BalanceEntities balanceDb = new BalanceEntities())
            {
                try
                {
                    MoneyDetail money = new MoneyDetail();
                    money.Bill = balanceDb.Bills.Single(b => b.billId == billId);
                    money.billQuantity = quantity;
                    money.detailId = _detail.detailId;
                    balanceDb.SaveChanges();
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }

        #endregion//AddToBalance Methods

        #region GetFromBalance Methods

        public Dictionary<byte,string> GetTypes()
        {
            try
            {
                using (BalanceEntities balanceDb = new BalanceEntities())
                {
                    Dictionary<byte, string> dTypes =
                        balanceDb.Types.ToDictionary(t => t.typeId, t => t.name);
                    return dTypes;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public Dictionary<byte, string> GetBills()
        {
            try
            {
                using (BalanceEntities balanceDb=new BalanceEntities())
                {
                    Dictionary<byte,string> dBills=
                        balanceDb.Bills.ToDictionary(b => b.billId, b => b.value);
                    return dBills;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public decimal GetTotal()
        {
            using (BalanceEntities balanceDb = new BalanceEntities())
            {
                try
                {
                    decimal _savings = balanceDb.Transactions.Where(t => t.typeId == 1).Sum(t=>t.amount);
                    decimal _withdraws = balanceDb.Transactions.Where(t => t.typeId == 2).Sum(t => t.amount);
                    decimal _loans = balanceDb.Transactions.Where(t => t.typeId == 3).Sum(t => t.amount);
                    decimal _charges = balanceDb.Transactions.Where(t => t.typeId == 4).Sum(t => t.amount);

                    return (_savings - (_withdraws + _loans + _charges));
                }
                catch (Exception e)
                {

                    throw e;
                }
            }
        }
        public IEnumerable<Transaction> GetTransactions(byte ofType)
        {
            try
            {
                using (BalanceEntities balanceDb=new BalanceEntities())
                {
                   var qTransactions= 
                       balanceDb.Transactions.Where(t=>t.typeId==ofType);
                   return qTransactions.ToList();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public IEnumerable<object> GetDetails(int ofTransaction)
        {
            using (BalanceEntities balanceDb=new BalanceEntities())
            {
                var qDetail=balanceDb.Details.Where(d => d.Transaction.transactionId==ofTransaction);
                var qAllDetails =
                    balanceDb.MoneyDetails.
                    Join(qDetail, money => money.detailId, detail => detail.detailId,
                    (money, detail) => new{money,detail});
                return qAllDetails;
                
            }
        }
    

        #endregion//GetFromBalance Methods
    }
}