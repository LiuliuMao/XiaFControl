using XiaFControl;
using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using XiaFControlDemo.ViewModels;
using ICSharpCode.AvalonEdit.Highlighting;
using XiaFControl.Controls;
using XiaFControl.Enums;
using System.Windows.Controls.Primitives;

namespace XiaFControlDemo.Views
{
    /// <summary>
    /// MainView.xaml 的交互逻辑
    /// </summary>
    public partial class MainView : XiaFWindow
    {
        public MainView()
        {
            InitializeComponent();
            this.DataContext = new MainViewModel();
        }

        const string PROJECT_NAME = "XiaFControlDemo";
        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                ListBox listBox = sender as ListBox;
                string name = $"Views/{(listBox.SelectedItem as ViewModels.MenuItem).Key}.xaml";

                string baseDir = AppDomain.CurrentDomain.BaseDirectory;
                int index = baseDir.IndexOf(PROJECT_NAME);

                string fileName = Path.Combine(baseDir.Substring(0, index + PROJECT_NAME.Length), name);

                textEditor.SyntaxHighlighting = HighlightingManager.Instance.GetDefinitionByExtension(".xaml");
                textEditor.Load(fileName);

                Tab.SelectedIndex = 0;
            }
            catch (Exception) { }
        }

     
        private void ToggleButton_Click(object sender, RoutedEventArgs e)
        {
            ToggleButton toggleButton = sender as ToggleButton;
            PaletteHelper paletteHelper = new PaletteHelper();
            var theme = paletteHelper.GetTheme();
            if (toggleButton.IsChecked == true)
            {
                paletteHelper.BaseTheme = BaseTheme.Dark;
            }
            else
            {
                paletteHelper.BaseTheme = BaseTheme.Light;
            }
            paletteHelper.PrimaryColor = theme.PrimaryColor;
            paletteHelper.SetTheme();
        }
    }
}
