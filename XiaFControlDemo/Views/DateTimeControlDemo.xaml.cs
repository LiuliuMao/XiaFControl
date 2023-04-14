using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace XiaFControlDemo.Views
{
    /// <summary>
    /// DateTimeControl.xaml 的交互逻辑
    /// </summary>
    public partial class DateTimeControlDemo : UserControl
    {
        public DateTimeControlDemo()
        {
            InitializeComponent();
        }
        private void Clock_SelectedTimeChanged(object sender, RoutedPropertyChangedEventArgs<DateTime> e)
        {
            MessageBox.Show($"{e.OldValue} => {e.NewValue}");
        }
    }
}
