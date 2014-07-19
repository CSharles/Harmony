using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CsharlsCorp.BalanceManager.Model
{
    class BalanceManager
    {
        BalanceEntities balanceContext = new BalanceEntities();
      
        public void AddtypeOfTransaction()
        {
            try
            {
                Type _type = new Type();
                _type.typeId = 2;
                _type.type = "Retiro";
                balanceContext.Types.AddObject(_type);
                balanceContext.SaveChanges();
            }
            catch (Exception e)
            {

                e.ToString();
            }
        }

        public bool AddToBalance(int type, decimal amount, DateTime date, string detail = "")
        {
            try
            {
                Transaction transaction = new Transaction();

                if (detail != string.Empty)
                {
                    Detail transactionDetail = new Detail();

                    //lastestId Saves the latest id from the TransactionDetails table before add a new value.
                    int lastestId = balanceContext.Details.LastOrDefault().detailId;
                    transactionDetail.detailId = lastestId + 1;
                    transactionDetail.description = detail;
                    balanceContext.Details.AddObject(transactionDetail);
                    balanceContext.SaveChanges();

                    //transaction.TransactionDetailId = transactionDetail.TransactionDetailId;
                }
                //lastesTransactiontId Saves the latest id from the Transactions table before add a new value.
                int lastesTransactiontId = balanceContext.Transactions.LastOrDefault().transactionId;
                transaction.transactionId = lastesTransactiontId + 1;
                transaction.typeId = type;
                transaction.amount = amount;

                balanceContext.Transactions.AddObject(transaction);
                balanceContext.SaveChanges();
            }
            catch (Exception e)
            {

            }
            return true;
        }

        public bool AddToBalance(int type, string detail, decimal amount)
        {
            return this.AddToBalance(type, amount, DateTime.Now, detail);
        }

        public bool AddToBalance(int type, decimal amount)
        {
            return this.AddToBalance(type, amount, DateTime.Now);
        }
    }
}