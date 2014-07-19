using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CsharlsCorp.BalanceManager.Model
{
    class BalanceManager
    {
        private Transaction transaction;
        private Detail detail;

        public void AddToBalance(int type, decimal amount, DateTime date)
        {
            using (BalanceEntities balanceDb = new BalanceEntities())
            {
                try
                {
                   // Transaction transaction = new Transaction();
                    transaction.Type = balanceDb.Types.Single(t=>t.typeId==type);
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
        public void AddToBalance(int type, decimal amount)
        {
            this.AddToBalance(type, amount,DateTime.Today);
        }
        public void AddToBalance(string description)
        {
            using (BalanceEntities balanceDb=new BalanceEntities())
            {
                try
                {
                    Detail detail;
                    balanceDb.Details.AddObject(detail =
                        new Detail { description = description, transactionId = transaction.transactionId});
                    balanceDb.SaveChanges();
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }
        public void AddToBalance(int billId, int quantity)
        {
            using (BalanceEntities balanceDb = new BalanceEntities())
            {
                try
                {
                    MoneyDetail money= new MoneyDetail();
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
    }
}