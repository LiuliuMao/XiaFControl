using Microsoft.Windows.Themes;
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
using System.Windows.Shapes;
using XiaFControl;
using XiaFControl.Controls;
using XiaFControl.Enums;
using XiaFControl.Services;

namespace XiaFControlDemo.Views
{
    /// <summary>
    /// TestWindow.xaml 的交互逻辑
    /// </summary>
    public partial class TestWindow : XiaFWindow
    {
        public TestWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<ResourceDictionary> dictionaryList = new List<ResourceDictionary>();
            foreach (ResourceDictionary dictionary in Application.Current.Resources.MergedDictionaries)
            {
                dictionaryList.Add(dictionary);
            }
            var res = dictionaryList.FirstOrDefault(p=>p is IXiaFThemeDictionary);
            var aaaa=res as BundledTheme;
            aaaa.BaseTheme = BaseTheme.Light;
            //App.Current.Resources["BodyBackground"] = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#1C1C1C"));

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            List<ResourceDictionary> dictionaryList = new List<ResourceDictionary>();
            foreach (ResourceDictionary dictionary in Application.Current.Resources.MergedDictionaries)
            {
                dictionaryList.Add(dictionary);
            }
            var res = dictionaryList.FirstOrDefault(p => p is IXiaFThemeDictionary);
            var aaaa = res as BundledTheme;
            aaaa.BaseTheme = BaseTheme.Dark;

        }
    }
}
