using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XiaFControl.Enums;
using XiaFControl.Services;
using XiaFControl.ThemeColor;

namespace XiaFControl.Extensions
{
    public class ITheme
    {
        public BaseTheme BaseTheme { get; set; } = BaseTheme.Light;
        public PrimaryColor PrimaryColor { get; set; } = PrimaryColor.XiaFBlue;
        public XiaFThemeColor XiaFThemeColor { get; set; }
    }
}
