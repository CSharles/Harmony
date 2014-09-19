using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using System.Windows.Data;
using CsharlsCorp.BalanceManager.Model;



namespace CsharlsCorp.BalanceManager.ViewModels
{
    public class BalanceMannagerViewModel:ViewModel
    {
        private BManager _manager = new BManager();

        private ObservableCollection<Transaction> _transactions;

        public BalanceMannagerViewModel()
        {

        }

        public ObservableCollection<Transaction> Transactions
        {
            get 
            {
                if (_transactions==null)
                {
                    _transactions= new ObservableCollection<Transaction>();
                    CollectionView Transactions = new ListCollectionView(_transactions);
                }
                if ((bool)(DesignerProperties.IsInDesignModeProperty.GetMetadata(typeof(DependencyObject)).DefaultValue))
            	{
                    _transactions.Add(new Transaction() 
                    { amount = 10000, date = DateTime.Today, Type = new CsharlsCorp.BalanceManager.Model.Type() { typeId=1, name = "Abono" } });
                    _transactions.Add(new Transaction() 
                    { amount = -5, date = DateTime.Today, Type = new CsharlsCorp.BalanceManager.Model.Type() { typeId=2,name = "Retiro" } });
                    _transactions.Add(new Transaction() 
                    { amount = -4, date = DateTime.Today, Type = new CsharlsCorp.BalanceManager.Model.Type() { typeId=3, name = "Prestamo" } });
                    _transactions.Add(new Transaction() 
                    { amount = 0.45M, date = DateTime.Today, Type = new CsharlsCorp.BalanceManager.Model.Type() {typeId=1, name="Abono"} });
                   
	            }
                return _transactions;
            }
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
