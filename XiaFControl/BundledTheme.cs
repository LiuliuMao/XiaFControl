using ControlzEx.Theming;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Media;
using XiaFControl.Enums;
using XiaFControl.Extensions;
using XiaFControl.Services;
using XiaFControl.ThemeColor;

namespace XiaFControl
{
    public class BundledTheme : ResourceDictionary, IXiaFThemeDictionary
    {
        private BaseTheme? _baseTheme;
        public BaseTheme? BaseTheme
        {
            get => _baseTheme;
            set
            {
                if (_baseTheme != value)
                {
                    _baseTheme = value;
                    SetBaseTheme();
                }
            }
        }

        public XiaFLightTheme XiaFLightTheme = new XiaFLightTheme();
        public XiaFDarkTheme XiaFDarkTheme = new XiaFDarkTheme();

        private PrimaryColor? _primaryColor;
        public PrimaryColor? PrimaryColor
        {
            get => _primaryColor;
            set
            {
                if (_primaryColor != value)
                {
                    _primaryColor = value;
                    SetBaseTheme();
                }
            }
        }
        private void SetBaseTheme()
        {
            if (BaseTheme is BaseTheme baseTheme &&
                PrimaryColor is PrimaryColor primaryColor)
            {
                this.SetTheme(primaryColor, baseTheme, baseTheme.GetResourceUri());
            }
        }
    }
}
