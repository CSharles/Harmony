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

    public static class test
    {
        public static void run()
        {
           /* BalanceManager bm = new BalanceManager();
            bm.AddToBalance(1, "un dolar", 1);
            bm.AddToBalance(1, 1);
            /*BalanceManager bm = new BalanceManager();*/
            using (BalanceEntities context =new BalanceEntities())
            {
                /*context.Types.AddObject(new Type { type = "Abono" });
                context.Types.AddObject(new Type { type = "Retiro" });
                context.Types.AddObject(new Type { type = "Prestamo" });
                context.Types.AddObject(new Type { type = "Recargo" });
                
                context.Bills.AddObject(new Bill { denomination = "Dolar" });
                context.Bills.AddObject(new Bill { denomination = "Cinco" });
                */
                Bill oneDolar = context.Bills.First(b => b.denomination == "Dolar");
                Bill fiveDolar = context.Bills.First(b => b.denomination == "Cinco");
                context.Bills.DeleteObject(oneDolar);
                context.Bills.DeleteObject(fiveDolar);
                context.SaveChanges();

                try
                {
                 /*   context.SaveChanges();
                    
                    Transaction firstTransaction=new Transaction { amount = 10, date = DateTime.Today, typeId = 1 };
                    context.Transactions.AddObject(firstTransaction);
                    context.SaveChanges();

                    Detail aDetail=new Detail { description = "Prueba de conexión", transactionId = firstTransaction.transactionId };
                    context.Details.AddObject(aDetail);
                    context.SaveChanges();
                  */

                    context.Bills.AddObject(new Bill { billId=1,denomination = "Dolar" });
                    context.Bills.AddObject(new Bill { billId=2,denomination = "Cinco" });
                    context.SaveChanges();

                    int fkDetailId=context.Details.First().detailId;
                    int fkbillId=context.Bills.First(b=>b.denomination=="Cinco").billId;
                
                
                    MoneyDetail aMoneyDetail= new MoneyDetail{billQuantity=2,billId=fkbillId,
                        detailId=fkDetailId};
                    context.MoneyDetails.AddObject(aMoneyDetail);


                    context.SaveChanges();
                }
                catch (Exception e)
                {

                    e.ToString();
                }
            }

        }
    }
}