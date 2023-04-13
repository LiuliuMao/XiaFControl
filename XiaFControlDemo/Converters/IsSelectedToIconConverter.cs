using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows;
using XiaFControl.Enums;
using XiaFControl.Controls;

namespace XiaFControlDemo.Converters
{
    public class IsSelectedToIconConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if ((bool)value)
            {
                return new Icon { Type = IconType.CheckboxFill };
            }
            else
            {
                return new Icon { Type = IconType.CheckboxBlankFill };
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return DependencyProperty.UnsetValue;
        }
    }
}
