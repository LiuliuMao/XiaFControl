using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XiaFControl.Enums;
using XiaFControl.Services;
using ControlzEx.Theming;
using XiaFControl.ThemeColor;
using System.Windows;
using System.Windows.Media;
using System.IO;
using System.Windows.Markup;

namespace XiaFControl.Extensions
{
    internal static class BaseThemeExtensions
    {
        public static bool SetTheme(this ResourceDictionary resourceDictionary, PrimaryColor primaryColor, BaseTheme baseTheme, Uri Source)
        {
            resourceDictionary.Source = Source;
            if (resourceDictionary is BundledTheme bundledTheme)
            {
                bundledTheme.BaseTheme = baseTheme;
                bundledTheme.PrimaryColor = primaryColor;
                IBaseTheme colorData = null;
                switch (baseTheme)
                {
                    case BaseTheme.Light:
                        colorData = bundledTheme.XiaFLightTheme;
                        break;
                    case BaseTheme.Dark:
                        colorData = bundledTheme.XiaFDarkTheme;
                        break;
                    default:
                        colorData = bundledTheme.XiaFLightTheme;
                        break;
                }
                //resourceDictionary[nameof(ThemeColorKey.BodyBackgroundColor)] = colorData.WindowBackgroundColor;
                //resourceDictionary[nameof(ThemeColorKey.ThemeForegroundColor)] = colorData.ThemeForegroundColor;
                //resourceDictionary[nameof(ThemeColorKey.ThemeBackgroundColor)] = colorData.ThemeBackgroundColor;
                primaryColor.SetThemePrimary(colorData);
            }
            return true;
        }
        public static Uri GetResourceUri(this BaseTheme baseTheme)
        {
            string sourceName = string.Empty;
            switch (baseTheme)
            {
                case XiaFControl.Enums.BaseTheme.Light:
                    sourceName = "ColorLight";
                    break;
                case XiaFControl.Enums.BaseTheme.Dark:
                    sourceName = "ColorDark";
                    break;
                default:
                    break;
            }
            var location = typeof(BaseThemeExtensions).Assembly.Location;
            var parent = Path.GetFileNameWithoutExtension(location);
            var source = new Uri(string.Format("pack://application:,,,/{0};component/Themes/Basic/Colors/{1}.xaml", parent, sourceName));
            return source;
        }

        public static ITheme GetTheme(this ResourceDictionary resourceDictionary)
        {
            if (resourceDictionary is IXiaFThemeDictionary xiaFThemeDictionary)
            {
                if (xiaFThemeDictionary is BundledTheme dic)
                {
                    ITheme theme = new ITheme();
                    theme.BaseTheme = dic.BaseTheme ?? BaseTheme.Light;
                    theme.PrimaryColor = dic.PrimaryColor ?? PrimaryColor.XiaFBlue;
                    theme.XiaFDarkTheme = dic.XiaFDarkTheme;
                    theme.XiaFLightTheme = dic.XiaFLightTheme;
                    return theme;
                }
            }
            return new ITheme();
        }
    }
}
