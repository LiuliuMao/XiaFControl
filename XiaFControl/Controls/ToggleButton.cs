using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows;

namespace XiaFControl.Controls
{
    public static class ToggleButtonHelper
    {
        // 选中背景色
        public static readonly DependencyProperty CheckedBackgroundProperty =
           DependencyProperty.RegisterAttached("CheckedBackground", typeof(Brush), typeof(ToggleButtonHelper));

        public static Brush GetCheckedBackground(DependencyObject obj)
        {
            return (Brush)obj.GetValue(CheckedBackgroundProperty);
        }

        public static void SetCheckedBackground(DependencyObject obj, Brush value)
        {
            obj.SetValue(CheckedBackgroundProperty, value);
        }
    }
}
