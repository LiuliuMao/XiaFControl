﻿using System;
using System.Collections.Generic;
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

namespace XiaFControlDemo.Views
{
    /// <summary>
    /// PageBarDemo.xaml 的交互逻辑
    /// </summary>
    public partial class PageBarDemo : UserControl
    {
        public PageBarDemo()
        {
            InitializeComponent();
        }
        private void PageBar_PageIndexChanged(object sender, RoutedPropertyChangedEventArgs<int> e)
        {
            Debug.WriteLine($"page index : {e.OldValue} => {e.NewValue}");
        }

        private void PageBar_PageSizeChanged(object sender, RoutedPropertyChangedEventArgs<int> e)
        {
            Debug.WriteLine($"page size : {e.OldValue} => {e.NewValue}");
        }
    }
}
