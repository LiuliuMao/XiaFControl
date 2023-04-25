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
using XiaFControl;
using XiaFControl.Enums;

namespace XiaFControlDemo.Views
{
    /// <summary>
    /// SelectBoxDemo.xaml 的交互逻辑
    /// </summary>
    public partial class SelectBoxDemo : UserControl
    {
        public SelectBoxDemo()
        {
            InitializeComponent();
        }

        private void day_Checked(object sender, RoutedEventArgs e)
        {
            PaletteHelper paletteHelper = new PaletteHelper();
            var theme= paletteHelper.GetTheme();
            theme.BaseTheme = BaseTheme.Light;
            //paletteHelper.PrimaryColor = theme.PrimaryColor;
            //paletteHelper.SetTheme();
        }

        private void night_Checked(object sender, RoutedEventArgs e)
        {
            PaletteHelper paletteHelper = new PaletteHelper();
            var theme = paletteHelper.GetTheme();
            theme.BaseTheme = BaseTheme.Dark;
            //paletteHelper.PrimaryColor = theme.PrimaryColor;
            //paletteHelper.SetTheme();
        }
    }
}
