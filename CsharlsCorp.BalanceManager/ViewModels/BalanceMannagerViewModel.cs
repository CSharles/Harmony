using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using CsharlsCorp.BalanceManager.Model;



namespace CsharlsCorp.BalanceManager.ViewModels
{
    public class BalanceMannagerViewModel:ViewModel
    {
        private BManager _manager = new BManager();

        private ObservableCollection<Transaction> _transactions;

        public ObservableCollection<Transaction> Transactions
        {
            get { return _transactions; }
            set { _transactions = value; }
        }

        private ActionCommand getTransactions;

        public ActionCommand GetTransactions
        {
            get {
                if (getTransactions==null)
                {
                    getTransactions = new ActionCommand(() =>
                        {
                            Transactions = new ObservableCollection<Transaction>(_manager.AllTransactions());
                        });
                }
                return getTransactions; 
            }
            
        }


    }
}
