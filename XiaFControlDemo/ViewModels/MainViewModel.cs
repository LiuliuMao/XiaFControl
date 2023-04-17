using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Controls;
using XiaFControlDemo.Views;
using System.Windows.Media;
using System.Windows.Media.Media3D;
using Prism.Commands;
using XiaFControl.Enums;
using XiaFControl;
using ControlzEx.Theming;
using XiaFControl.Services;
using XiaFControl.Extensions;
using XiaFControl.ThemeColor;
using System.Windows;

namespace XiaFControlDemo.ViewModels
{
    public class MainViewModel : BindableBase
    {

        private string title;
        public string Title
        {
            get => title;
            set
            {
                title = value;
                RaisePropertyChanged();
            }
        }
        private ObservableCollection<MenuItem> menuItems;
        public ObservableCollection<MenuItem> MenuItems
        {
            get => menuItems;
            set
            {
                menuItems = value;
                RaisePropertyChanged();
            }
        }
        private MenuItem currentMenuItem;
        public MenuItem CurrentMenuItem
        {
            get => currentMenuItem;
            set
            {
                currentMenuItem = value;
                RaisePropertyChanged();
            }
        }

        PaletteHelper paletteHelper = new PaletteHelper();
        ITheme theme;
        public MainViewModel()
        {
            Title = "XiaF UI";
            theme = paletteHelper.GetTheme();
            LanguageCommand = new DelegateCommand<string>(SetLanguage);
            RefreshMenuList();
            CurrentMenuItem = MenuItems[0];
            IBaseTheme baseTheme = null;
            if (theme.BaseTheme == BaseTheme.Light)
                baseTheme = new XiaFLightTheme();
            else
                baseTheme = new XiaFDarkTheme();
            ThemeColors = new ObservableCollection<ThemeColor>
            {
                new ThemeColor
                {
                    Name = "默认蓝",
                    PrimaryColor = PrimaryColor.XiaFBlue,
                    Primary= paletteHelper.GetThemeColor(PrimaryColor.XiaFBlue,baseTheme).Primary,
                    IsSeleted =false
                },
                new ThemeColor
                {
                    Name = "酷安绿",
                    PrimaryColor = PrimaryColor.XiaFGreen,
                    Primary= paletteHelper.GetThemeColor(PrimaryColor.XiaFGreen,baseTheme).Primary,
                    IsSeleted =false
                },
                new ThemeColor
                {
                    Name = "姨妈红",
                    PrimaryColor = PrimaryColor.XiaFRed,
                    Primary= paletteHelper.GetThemeColor(PrimaryColor.XiaFRed,baseTheme).Primary,
                    IsSeleted =false
                },
                new ThemeColor
                {
                    Name = "基佬紫",
                    PrimaryColor = PrimaryColor.XiaFPurple,
                    Primary= paletteHelper.GetThemeColor(PrimaryColor.XiaFPurple,baseTheme).Primary,
                    IsSeleted =false
                },
                new ThemeColor
                {
                    Name = "哔哩粉",
                    PrimaryColor = PrimaryColor.XiaFPink,
                    Primary= paletteHelper.GetThemeColor(PrimaryColor.XiaFPink,baseTheme).Primary,
                    IsSeleted =false
                },
                new ThemeColor
                {
                    Name = "高端黑",
                    PrimaryColor = PrimaryColor.XiaFBlack,
                    Primary= paletteHelper.GetThemeColor(PrimaryColor.XiaFBlack,baseTheme).Primary,
                    IsSeleted =false
                },
            };
        }
        private void RefreshMenuList()
        {
            MenuItems = new ObservableCollection<MenuItem>
            {
                new MenuItem{ Name = GetLanguageContent(nameof(ButtonDemo)),Key=nameof(ButtonDemo), Content=new ButtonDemo()},
                new MenuItem{ Name = GetLanguageContent(nameof(InputBoxDemo)),Key=nameof(InputBoxDemo), Content=new InputBoxDemo() },
                new MenuItem{ Name = GetLanguageContent(nameof(SelectBoxDemo)),Key=nameof(SelectBoxDemo), Content=new SelectBoxDemo()},
                new MenuItem{ Name = GetLanguageContent(nameof(DataBarDemo)),Key=nameof(DataBarDemo),Content=new DataBarDemo()},
                new MenuItem{ Name = GetLanguageContent(nameof(IconDemo)),Key=nameof(IconDemo),Content=new IconDemo(){ DataContext=new IconViewModel()} },
                new MenuItem{ Name = GetLanguageContent(nameof(GroupBoxDemo)),Key=nameof(GroupBoxDemo),Content=new GroupBoxDemo() },
                new MenuItem{ Name = GetLanguageContent(nameof(ListsTreeDemo)),Key=nameof(ListsTreeDemo),Content=new ListsTreeDemo{ DataContext = new ListsViewModel()} },
                new MenuItem{ Name = GetLanguageContent(nameof(TabControlDemo)),Key=nameof(TabControlDemo),Content=new TabControlDemo{ DataContext = new TabControlViewModel()} },
                new MenuItem{ Name = GetLanguageContent(nameof(DateTimeControlDemo)),Key=nameof(DateTimeControlDemo),Content=new DateTimeControlDemo{} },
                new MenuItem{ Name = GetLanguageContent(nameof(MenuBarDemo)),Key=nameof(MenuBarDemo),Content=new MenuBarDemo{} },
                new MenuItem{ Name = GetLanguageContent(nameof(TextBlockDemo)),Key=nameof(TextBlockDemo),Content=new TextBlockDemo{}},
                new MenuItem{ Name = GetLanguageContent(nameof(PageBarDemo)),Key=nameof(PageBarDemo),Content=new PageBarDemo{ DataContext = new PageBarViewModel()}},
                new MenuItem{ Name = GetLanguageContent(nameof(MessageInfoDemo)),Key=nameof(MessageInfoDemo),Content=new MessageInfoDemo{} },
                new MenuItem{ Name = GetLanguageContent(nameof(MessageBoxDemo)),Key=nameof(MessageBoxDemo),Content = new MessageBoxDemo{ DataContext= new MessageBoxViewModel()} },
                new MenuItem{ Name = GetLanguageContent(nameof(DialogDemo)),Key=nameof(DialogDemo),Content = new DialogDemo{ DataContext= new DialogViewModel()} }
            };
        }
        private ObservableCollection<ThemeColor> themeColors;
        public ObservableCollection<ThemeColor> ThemeColors
        {
            get => themeColors;
            set
            {
                themeColors = value;
                RaisePropertyChanged();
            }
        }
        public DelegateCommand<string> LanguageCommand { get; set; }
        private void SetLanguage(string language)
        {
            var xaml = Application.Current.Resources.MergedDictionaries.FirstOrDefault(p => p.Source.LocalPath.Contains("language_")|| p.Source.LocalPath.Contains("Language_"));
            if (language == "中文简体")
            {
                if (xaml != null)
                    xaml.Source = new Uri("pack://application:,,,/XiaFControlDemo;component/resources/xamls/Language_zh.xaml");
            }
            else
            {
                if (xaml != null)
                    xaml.Source = new Uri("pack://application:,,,/XiaFControlDemo;component/resources/xamls/language_en.xaml");
            }
            foreach (var item in MenuItems)
            {
                item.Name = GetLanguageContent(item.Key);
            }
        }

        private DelegateCommand<ThemeColor> changeThemeColor;
        public DelegateCommand<ThemeColor> ChangeThemeColor => changeThemeColor ?? (changeThemeColor = new DelegateCommand<ThemeColor>(ChangeThemeColorExecute));
        private void ChangeThemeColorExecute(object obj)
        {
            ThemeColor themeColor = obj as ThemeColor;

            if (themeColor.IsSeleted)
            {
                return;
            }
            theme = paletteHelper.GetTheme();
            paletteHelper.BaseTheme = theme.BaseTheme;
            paletteHelper.PrimaryColor = themeColor.PrimaryColor;
            paletteHelper.SetTheme();
            foreach (var item in ThemeColors)
            {
                item.IsSeleted = false;
            }

            themeColor.IsSeleted = true;
        }
        private string GetLanguageContent(string key)
        {
            var res = Application.Current.Resources[key];
            if (res != null)
                return res.ToString();
            else
                return "";
        }
    }
    public class MenuItem : ChangedBase
    {
        private string name;
        public string Name { get { return name; } set { UpdateProper(ref name, value); } }
        private string key;
        public string Key { get { return key; } set { UpdateProper(ref key, value); } }
        private object content;
        public object Content { get { return content; } set { UpdateProper(ref content, value); } }
    }

    public class ThemeColor
    {
        public string Name { get; set; }
        public Brush Primary { get; set; }
        //public BaseTheme BaseTheme { get; set; }
        public PrimaryColor PrimaryColor { get; set; }
        private bool isSeleted;
        public bool IsSeleted
        {
            get => isSeleted;
            set
            {
                isSeleted = value;
            }
        }
    }
}
