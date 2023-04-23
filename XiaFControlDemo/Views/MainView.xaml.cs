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
            PaletteHelper paletteHelper = new PaletteHelper();
            this.version.Text = "V" + paletteHelper.GetVersion();
            this.DataContext = new MainViewModel();
        }

        const string PROJECT_NAME = "XiaFControlDemo";
        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                ListBox listBox = sender as ListBox;
                var item = listBox.SelectedItem;
                if (item == null)
                    return;
                string name = $"Views/{(item as ViewModels.MenuItem).Key}.xaml";

                string baseDir = AppDomain.CurrentDomain.BaseDirectory;
                int index = baseDir.IndexOf(PROJECT_NAME);

                string fileName = Path.Combine(baseDir.Substring(0, index + PROJECT_NAME.Length), name);

                textEditor.SyntaxHighlighting = HighlightingManager.Instance.GetDefinitionByExtension(".xaml");
                textEditor.Load(fileName);

                Tab.SelectedIndex = 0;
            }
            catch (Exception) { }
        }
    }
}
