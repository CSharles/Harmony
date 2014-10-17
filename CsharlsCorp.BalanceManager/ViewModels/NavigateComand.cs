using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace CsharlsCorp.BalanceManager.ViewModels
{
    public class NavigateComand:ICommand
    {
        public BalanceMannagerViewModel  BalanceViewModel { get; set; }

        public NavigateComand(BalanceMannagerViewModel viewModel) {
            BalanceViewModel = viewModel;
        
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            BalanceViewModel.Navigate(parameter.ToString());
        }
    }
}
