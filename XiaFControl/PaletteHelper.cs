using ControlzEx.Theming;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Media3D;
using System.Windows.Media;
using XiaFControl.Enums;
using XiaFControl.Extensions;
using XiaFControl.Services;
using XiaFControl.ThemeColor;

namespace XiaFControl
{
    public class PaletteHelper
    {
        public PrimaryColor PrimaryColor { get; set; }
        public BaseTheme BaseTheme { get; set; }
        public virtual ITheme GetTheme()
        {
            if (Application.Current is null)
                throw new InvalidOperationException("Application.Current is null use PaletteHelper");
            return GetResourceDictionary().GetTheme();
        }

        public virtual void SetTheme()
        {
            if (BaseTheme == null) throw new ArgumentNullException(nameof(BaseTheme));
            if (PrimaryColor == null) throw new ArgumentNullException(nameof(PrimaryColor));
            if (Application.Current is null)
                throw new InvalidOperationException("Application.Current is null use PaletteHelper");
            GetResourceDictionary().SetTheme(PrimaryColor, BaseTheme, BaseTheme.GetResourceUri());
        }
        public virtual void SetTheme(Uri Source)
        {
            if (BaseTheme == null) throw new ArgumentNullException(nameof(BaseTheme));
            if (PrimaryColor == null) throw new ArgumentNullException(nameof(PrimaryColor));
            if (Application.Current is null)
                throw new InvalidOperationException("Application.Current is null use PaletteHelper");
            GetResourceDictionary().SetTheme(PrimaryColor, BaseTheme, Source);
        }

        public ThemeColorModel GetThemeColor(PrimaryColor primaryColor, IBaseTheme entity = null)
        {
            ThemeColorModel themeColor = new ThemeColorModel();
            switch (primaryColor)
            {
                case PrimaryColor.XiaFBlue:
                    themeColor = new ThemeColorModel
                    {
                        Primary = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#2196F3")),
                        Light = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#6EC6FF")),
                        Dark = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#0069C0")),
                        Accent = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#F50057")),
                    };
                    break;
                case PrimaryColor.XiaFRed:
                    themeColor = new ThemeColorModel
                    {
                        Primary = new SolidColorBrush(Color.FromRgb(0xE5, 0x39, 0x35)),
                        Light = new SolidColorBrush(Color.FromRgb(0xFF, 0x6F, 0x60)),
                        Dark = new SolidColorBrush(Color.FromRgb(0xAB, 0x00, 0x0D)),
                        Accent = new SolidColorBrush(Color.FromRgb(0x39, 0x49, 0xAB)),
                    };
                    break;
                case PrimaryColor.XiaFGreen:
                    themeColor = new ThemeColorModel
                    {
                        Primary = new SolidColorBrush(Color.FromRgb(0x0B, 0xA3, 0x61)),
                        Light = new SolidColorBrush(Color.FromRgb(0x56, 0xD5, 0x8F)),
                        Dark = new SolidColorBrush(Color.FromRgb(0x00, 0x73, 0x36)),
                        Accent = new SolidColorBrush(Color.FromRgb(0x79, 0x55, 0x48)),
                    };
                    break;
                case PrimaryColor.XiaFBlack:
                    themeColor = new ThemeColorModel
                    {
                        Primary = new SolidColorBrush(Color.FromRgb(0x26, 0x32, 0x38)),
                        Light = new SolidColorBrush(Color.FromRgb(0x4F, 0x5B, 0x62)),
                        Dark = new SolidColorBrush(Color.FromRgb(0x00, 0x0A, 0x12)),
                        Accent = new SolidColorBrush(Color.FromRgb(0xAD, 0x14, 0x57)),
                    };
                    break;
                case PrimaryColor.XiaFPink:
                    themeColor = new ThemeColorModel
                    {
                        Primary = new SolidColorBrush(Color.FromRgb(0xFB, 0x72, 0x99)),
                        Light = new SolidColorBrush(Color.FromRgb(0xFF, 0xA4, 0xCA)),
                        Dark = new SolidColorBrush(Color.FromRgb(0xC4, 0x40, 0x6B)),
                        Accent = new SolidColorBrush(Color.FromRgb(0x73, 0xC9, 0xE5)),
                    };
                    break;
                case PrimaryColor.XiaFPurple:
                    themeColor = new ThemeColorModel
                    {
                        Primary = new SolidColorBrush(Color.FromRgb(0x6A, 0x1B, 0x9A)),
                        Light = new SolidColorBrush(Color.FromRgb(0x9C, 0x4D, 0xCC)),
                        Dark = new SolidColorBrush(Color.FromRgb(0x38, 0x00, 0x6B)),
                        Accent = new SolidColorBrush(Color.FromRgb(0xE6, 0x51, 0x00)),
                    };
                    break;
                case PrimaryColor.XiaFOther:
                    themeColor = new ThemeColorModel
                    {
                        Primary = entity.Primary,
                        Light = entity.Primary,
                        Dark = entity.Primary,
                        Accent = entity.Primary,
                    };
                    break;
                default:
                    break;
            }
            return themeColor;
        }
        private static ResourceDictionary GetResourceDictionary()
            => Application.Current.Resources.MergedDictionaries.FirstOrDefault(x => x is IXiaFThemeDictionary) ??
                Application.Current.Resources;
    }
}
