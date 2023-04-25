using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
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
using XiaFControl.Controls;
using XiaFControl.Enums;
using XiaFControlDemo.ViewModels;

namespace XiaFControlDemo.Views
{
    /// <summary>
    /// HamburgerMenuDemo.xaml 的交互逻辑
    /// </summary>
    public partial class HamburgerMenuDemo : UserControl
    {
        public HamburgerMenuDemo()
        {
            InitializeComponent();
            //var Models = new List<HamburgerMenuModel>();
            //Models.Add(new HamburgerMenuModel("用户", IconType.UserLine));
            //Models.Add(new HamburgerMenuModel("文档", IconType.FileLine));
            //Models.Add(new HamburgerMenuModel("图片", IconType.ImageLine));
            //Models.Add(new HamburgerMenuModel("设置", IconType.Settings2Line));
            //Models.Add(new HamburgerMenuModel("无图标", null));
            //Models.Add(new HamburgerMenuModel("不可用", IconType.EmotionUnhappyLine, false));
            //var OptionsModels = new List<HamburgerMenuModel>();
            //OptionsModels.Add(new HamburgerMenuModel("睡眠", IconType.MoonFill));
            //OptionsModels.Add(new HamburgerMenuModel("关机", IconType.ShutDownLine));
            //OptionsModels.Add(new HamburgerMenuModel("重启", IconType.RestartLine));
            //this.hamburger.ItemsSource = Models;
            //this.hamburger.OptionsItemsSource = OptionsModels;
        }
        private void HamburgerMenu_HamburgerButtonClick(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine($"Current HamburgerMenu IsExpanded:{(sender as HamburgerMenu).IsExpanded}");

            // e.Handled = true; // 取消切换
        }
    }
}
