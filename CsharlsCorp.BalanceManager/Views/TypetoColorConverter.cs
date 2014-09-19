using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Data;
using System.Windows.Media;

namespace CsharlsCorp.BalanceManager.Views
{
    public class TypetoColorConverter:IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value == null)
                return null;
                string typeId = value.ToString();
                SolidColorBrush result = new SolidColorBrush(Colors.Black);
                switch (typeId)
                {
                    case "2":
                        result = new SolidColorBrush(Colors.Red);
                        break;
                    case "3":
                        result = new SolidColorBrush(Colors.Olive);
                        break;
                    default:
                        result = new SolidColorBrush(Colors.Black);
                        break;
                }
                return result;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
