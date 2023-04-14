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
            MenuItems = new ObservableCollection<MenuItem>
            {
                new MenuItem{ Name = "按钮",Key=nameof(ButtonDemo), Content=new ButtonDemo()},
                new MenuItem{ Name = "输入框",Key=nameof(InputBoxDemo), Content=new InputBoxDemo() },
                new MenuItem{ Name = "选择框",Key=nameof(SelectBoxDemo), Content=new SelectBoxDemo()},
                new MenuItem{ Name = "数据条",Key=nameof(DataBarDemo),Content=new DataBarDemo()},
                new MenuItem{ Name = "图标",Key=nameof(DataBarDemo),Content=new IconDemo(){ DataContext=new IconViewModel()} },
                new MenuItem{ Name = "分组框",Key=nameof(GroupBoxDemo),Content=new GroupBoxDemo() },
                new MenuItem{ Name = "列表与树",Key=nameof(ListsTreeDemo),Content=new ListsTreeDemo{ DataContext = new ListsViewModel()} },
                new MenuItem{ Name = "选项卡",Key=nameof(TabControlDemo),Content=new TabControlDemo{ DataContext = new TabControlViewModel()} },
                new MenuItem{ Name = "日期时间",Key=nameof(DateTimeControlDemo),Content=new DateTimeControlDemo{} },
                new MenuItem{ Name = "菜单栏",Key=nameof(DateTimeControlDemo),Content=new MenuBarDemo{} },
                new MenuItem{ Name = "文本块",Key=nameof(TextBlockDemo),Content=new TextBlockDemo{}},
                new MenuItem{ Name = "页码条",Key=nameof(PageBarDemo),Content=new PageBarDemo{ DataContext = new PageBarDemo()}},
                new MenuItem{ Name = "消息提示",Key=nameof(MessageInfoDemo),Content=new MessageInfoDemo{} },
                new MenuItem{ Name = "消息框",Key=nameof(MessageBoxDemo),Content = new MessageBoxDemo{ DataContext= new MessageBoxViewModel()} },
                new MenuItem{ Name = "对话框",Key=nameof(DialogDemo),Content = new DialogDemo{ DataContext= new DialogViewModel()} }
            };
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
        //private void SetColor(IBaseTheme baseTheme)
        //{
        //    switch (paletteHelper.PrimaryColor)
        //    {
        //        case PrimaryColor.XiaFBlue:
        //            baseTheme.Primary = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#2196F3"));
        //            baseTheme.Light = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#6EC6FF"));
        //            baseTheme.Dark = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#0069C0"));
        //            baseTheme.Accent = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#F50057"));
        //            break;
        //        case PrimaryColor.XiaFRed:
        //            baseTheme.Primary = new SolidColorBrush(Color.FromRgb(0xE5, 0x39, 0x35));
        //            baseTheme.Light = new SolidColorBrush(Color.FromRgb(0xFF, 0x6F, 0x60));
        //            baseTheme.Dark = new SolidColorBrush(Color.FromRgb(0xAB, 0x00, 0x0D));
        //            baseTheme.Accent = new SolidColorBrush(Color.FromRgb(0x39, 0x49, 0xAB));
        //            break;
        //        case PrimaryColor.XiaFGreen:
        //            baseTheme.Primary = new SolidColorBrush(Color.FromRgb(0x0B, 0xA3, 0x61));
        //            baseTheme.Light = new SolidColorBrush(Color.FromRgb(0x56, 0xD5, 0x8F));
        //            baseTheme.Dark = new SolidColorBrush(Color.FromRgb(0x00, 0x73, 0x36));
        //            baseTheme.Accent = new SolidColorBrush(Color.FromRgb(0x79, 0x55, 0x48));
        //            break;
        //        case PrimaryColor.XiaFBlack:
        //            baseTheme.Primary = new SolidColorBrush(Color.FromRgb(0x26, 0x32, 0x38));
        //            baseTheme.Light = new SolidColorBrush(Color.FromRgb(0x4F, 0x5B, 0x62));
        //            baseTheme.Dark = new SolidColorBrush(Color.FromRgb(0x00, 0x0A, 0x12));
        //            baseTheme.Accent = new SolidColorBrush(Color.FromRgb(0xAD, 0x14, 0x57));
        //            break;
        //        case PrimaryColor.XiaFPink:
        //            baseTheme.Primary = new SolidColorBrush(Color.FromRgb(0xFB, 0x72, 0x99));
        //            baseTheme.Light = new SolidColorBrush(Color.FromRgb(0xFF, 0xA4, 0xCA));
        //            baseTheme.Dark = new SolidColorBrush(Color.FromRgb(0xC4, 0x40, 0x6B));
        //            baseTheme.Accent = new SolidColorBrush(Color.FromRgb(0x73, 0xC9, 0xE5));
        //            break;
        //        case PrimaryColor.XiaFPurple:
        //            break;
        //        case PrimaryColor.XiaFOther:
        //            break;
        //        default:
        //            break;
        //    }
        //}
    }
    public class MenuItem
    {
        public string Name { get; set; }
        public string Key { get; set; }
        public object Content { get; set; }
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
