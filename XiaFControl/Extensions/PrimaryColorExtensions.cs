using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Media3D;
using XiaFControl.Enums;
using XiaFControl.Services;
using XiaFControl.ThemeColor;

namespace XiaFControl.Extensions
{
    internal static class PrimaryColorExtensions
    {
        private static readonly Brush primary = (Brush)Application.Current.Resources[nameof(ThemeColorKey.Primary)];
        private static readonly Brush light = (Brush)Application.Current.Resources[nameof(ThemeColorKey.Light)];
        private static readonly Brush dark = (Brush)Application.Current.Resources[nameof(ThemeColorKey.Dark)];
        private static readonly Brush accent = (Brush)Application.Current.Resources[nameof(ThemeColorKey.Accent)];
        public static bool SetThemePrimary<ITEntity>(this PrimaryColor primaryColor, ITEntity entity) where ITEntity : IBaseTheme
        {
            ThemeColorModel themeColor = new ThemeColorModel
            {
                Primary = primary,
                Light = light,
                Dark = dark,
                Accent = accent,
            };
            themeColor = primaryColor.GetThemeColor(entity);
            Application.Current.Resources[nameof(ThemeColorKey.Primary)] = themeColor.Primary;
            Application.Current.Resources[nameof(ThemeColorKey.Light)] = themeColor.Light;
            Application.Current.Resources[nameof(ThemeColorKey.Dark)] = themeColor.Dark;
            Application.Current.Resources[nameof(ThemeColorKey.Accent)] = themeColor.Accent;
            Application.Current.Resources[nameof(ThemeColorKey.PrimaryForeground)] = entity.PrimaryForeground;
            Application.Current.Resources[nameof(ThemeColorKey.LightForeground)] = entity.LightForeground;
            Application.Current.Resources[nameof(ThemeColorKey.DarkForeground)] = entity.DarkForeground;
            Application.Current.Resources[nameof(ThemeColorKey.AccentForeground)] = entity.AccentForeground;
            return true;
        }

        public static ThemeColorModel GetThemeColor(this PrimaryColor primaryColor,IBaseTheme entity = null)
        {
            ThemeColorModel themeColor = new ThemeColorModel
            {
                Primary = primary,
                Light = light,
                Dark = dark,
                Accent = accent,
            };
            switch (primaryColor)
            {
                case PrimaryColor.XiaFBlue:
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
    }
}
