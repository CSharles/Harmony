using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CsharlsCorp.BalanceManager.Model
{
    class BalanceManager
    {
        /// <summary>
        /// Represent the current transaction object that will be stored in the context.
        /// </summary>
        private Transaction transaction;
        /// <summary>
        /// Represent the current transaction detail that will be stored in the context. 
        /// If it is null, no detail will be added.
        /// </summary>
        private Detail detail;

        #region AddToBalance Methods

        /// <summary>
        ///Saves the objects to the data source using System.Data.Objects.ObjectContext.SaveChanges().
        /// </summary>
        ///<param name="type">An integer value that represent the type of the transaction.</param>
        ///<param name="amount">Value of the amount that will be saved in this transaction.</param>
        ///<param name="date">Value of the date that the transaction was made.</param>
        public void AddToBalance(int type, decimal amount, DateTime date)
        {
            using (BalanceEntities balanceDb = new BalanceEntities())
            {
                try
                {
                    // Transaction transaction = new Transaction();
                    transaction.Type = balanceDb.Types.Single(t => t.typeId == type);
                    transaction.amount = amount;
                    transaction.date = date;
                    balanceDb.SaveChanges();
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }
        /// <summary>
        /// Saves the object to the data source while set a default date for the transaction.
        /// </summary>
        /// <param name="type">
        /// An integer value that represent the type of the transaction.
        /// </param>
        /// <param name="amount">
        /// The amount of money the transaction will have.
        /// </param>
        public void AddToBalance(int type, decimal amount)
        {
            this.AddToBalance(type, amount, DateTime.Today);
        }
        /// <summary>
        /// Saves the  textual detail for a transaction to the data source.
        /// </summary>
        /// <param name="description">A description of the transaction.</param>
        public void AddToBalance(string description)
        {
            using (BalanceEntities balanceDb = new BalanceEntities())
            {
                try
                {
                    Detail detail;
                    balanceDb.Details.AddObject(detail =
                        new Detail { description = description, transactionId = transaction.transactionId });
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
        /// <param name="billId"> An integer value that represents the a bill.</param>
        /// <param name="quantity">An integer value that represents how many bills will be saved.</param>
        public void AddToBalance(int billId, int quantity)
        {
            using (BalanceEntities balanceDb = new BalanceEntities())
            {
                try
                {
                    MoneyDetail money = new MoneyDetail();
                    money.Bill = balanceDb.Bills.Single(b => b.billId == billId);
                    money.billQuantity = quantity;
                    money.detailId = detail.detailId;
                    balanceDb.SaveChanges();
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        } 

        #endregion
    }
}