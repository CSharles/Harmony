using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
namespace CsharlsCorp.BalanceManager.ViewModels
{
    class SaveComand:ICommand
    {
        public bool CanExecute(object parameter)
        {
            return !String.IsNullOrEmpty(parameter.ToString());
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            throw new NotImplementedException();
        }
    }
}
