using ImTools;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Media;
using System.Windows.Media.Media3D;
using XiaFControl;
using XiaFControl.Enums;
using XiaFControl.Extensions;
using XiaFControl.Services;
using XiaFControl.ThemeColor;

namespace XiaFControlDemo.ViewModels
{
    public class ColorToolViewModel : BindableBase
    {
        public ColorToolViewModel()
        {
            PaletteHelper paletteHelper = new PaletteHelper();
            ColorCommand = new DelegateCommand(SetCustomerColor);
            IBaseTheme baseTheme = new XiaFThemeColor();
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
            PaletteHelper paletteHelper = new PaletteHelper();
            ThemeColor themeColor = obj as ThemeColor;
            if (themeColor.IsSeleted)
            {
                return;
            }
            var theme = paletteHelper.GetTheme();
            theme.PrimaryColor = themeColor.PrimaryColor;


            //theme = paletteHelper.GetTheme();
            //paletteHelper.BaseTheme = theme.BaseTheme;
            //paletteHelper.PrimaryColor = themeColor.PrimaryColor;
            //paletteHelper.SetThemeColor();
            foreach (var item in ThemeColors)
            {
                item.IsSeleted = false;
            }
            themeColor.IsSeleted = true;
        }

        private DelegateCommand<bool?> changeTheme;
        public DelegateCommand<bool?> ChangeTheme => changeTheme ?? (changeTheme = new DelegateCommand<bool?>(ChangeThemeExecute));
        private void ChangeThemeExecute(bool? IsChecked)
        {
            var resourceDictionaries = Application.Current.Resources.MergedDictionaries;
            PaletteHelper paletteHelper = new PaletteHelper();
            var theme = paletteHelper.GetTheme();
            if (IsChecked == true)
            {
                theme.BaseTheme = BaseTheme.Dark;
            }
            else
            {
                theme.BaseTheme = BaseTheme.Light;
            }
            //System.Windows.Application.Current.Resources[nameof(ThemeColorKey.ThemeForegroundColor)] = (Color)ColorConverter.ConvertFromString("#FFFFFF");
            //System.Windows.Application.Current.Resources[nameof(ThemeColorKey.ThemeBackgroundColor)] = (Color)ColorConverter.ConvertFromString("#1C1C1C");
            //System.Windows.Application.Current.Resources[nameof(ThemeColorKey.WindowBackgroundColor)] = (Color)ColorConverter.ConvertFromString("#2D2D30");
            //PaletteHelper paletteHelper = new PaletteHelper();
            //var theme = paletteHelper.GetTheme();
            //if (IsChecked == true)
            //{
            //    paletteHelper.BaseTheme = BaseTheme.Dark;
            //}
            //else
            //{
            //    paletteHelper.BaseTheme = BaseTheme.Light;
            //}
            //paletteHelper.PrimaryColor = theme.PrimaryColor;
            //paletteHelper.SetTheme();
        }

        #region 自定义主题色
        public DelegateCommand ColorCommand { get; set; }
        private void SetCustomerColor()
        {
            PaletteHelper paletteHelper = new PaletteHelper();
            var theme = paletteHelper.GetTheme();
            if (!string.IsNullOrWhiteSpace(Primary))
                theme.XiaFThemeColor.Primary = new SolidColorBrush((System.Windows.Media.Color)System.Windows.Media.ColorConverter.ConvertFromString("#" + Primary));
            if (!string.IsNullOrWhiteSpace(PrimaryForeground))
                theme.XiaFThemeColor.PrimaryForeground = new SolidColorBrush((System.Windows.Media.Color)System.Windows.Media.ColorConverter.ConvertFromString("#" + PrimaryForeground));
            if (!string.IsNullOrWhiteSpace(Light))
                theme.XiaFThemeColor.Light = new SolidColorBrush((System.Windows.Media.Color)System.Windows.Media.ColorConverter.ConvertFromString("#" + Light));
            if (!string.IsNullOrWhiteSpace(LightForeground))
                theme.XiaFThemeColor.LightForeground = new SolidColorBrush((System.Windows.Media.Color)System.Windows.Media.ColorConverter.ConvertFromString("#" + LightForeground));
            if (!string.IsNullOrWhiteSpace(Dark))
                theme.XiaFThemeColor.Dark = new SolidColorBrush((System.Windows.Media.Color)System.Windows.Media.ColorConverter.ConvertFromString("#" + Dark));
            if (!string.IsNullOrWhiteSpace(DarkForeground))
                theme.XiaFThemeColor.DarkForeground = new SolidColorBrush((System.Windows.Media.Color)System.Windows.Media.ColorConverter.ConvertFromString("#" + DarkForeground));
            if (!string.IsNullOrWhiteSpace(Accent))
                theme.XiaFThemeColor.Accent = new SolidColorBrush((System.Windows.Media.Color)System.Windows.Media.ColorConverter.ConvertFromString("#" + Accent));
            if (!string.IsNullOrWhiteSpace(AccentForeground))
                theme.XiaFThemeColor.AccentForeground = new SolidColorBrush((System.Windows.Media.Color)System.Windows.Media.ColorConverter.ConvertFromString("#" + AccentForeground));
            theme.PrimaryColor = PrimaryColor.XiaFOther;
        }
        private string _Primary { get; set; }
        public string Primary
        {
            get { return _Primary; }
            set { _Primary = value; RaisePropertyChanged(); }
        }
        private string _PrimaryForeground { get; set; }
        public string PrimaryForeground
        {
            get { return _PrimaryForeground; }
            set { _PrimaryForeground = value; RaisePropertyChanged(); }
        }
        private string _Light { get; set; }
        public string Light
        {
            get { return _Light; }
            set { _Light = value; RaisePropertyChanged(); }
        }
        private string _LightForeground { get; set; }
        public string LightForeground
        {
            get { return _LightForeground; }
            set { _LightForeground = value; RaisePropertyChanged(); }
        }
        private string _Dark { get; set; }
        public string Dark
        {
            get { return _Dark; }
            set { _Dark = value; RaisePropertyChanged(); }
        }
        private string _DarkForeground { get; set; }
        public string DarkForeground
        {
            get { return _DarkForeground; }
            set { _DarkForeground = value; RaisePropertyChanged(); }
        }
        private string _Accent { get; set; }
        public string Accent
        {
            get { return _Accent; }
            set { _Accent = value; RaisePropertyChanged(); }
        }
        private string _AccentForeground { get; set; }
        public string AccentForeground
        {
            get { return _AccentForeground; }
            set { _AccentForeground = value; RaisePropertyChanged(); }
        }
        #endregion

    }
}
