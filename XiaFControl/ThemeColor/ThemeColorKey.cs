using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XiaFControl.ThemeColor
{
    public class ThemeColorKey
    {
        /// <summary>
        /// 窗体背景色
        /// </summary>
        public static string BodyBackgroundColor { get; set; }
        /// <summary>
        /// light/darke 背景色
        /// </summary>
        public static string ThemeBackgroundColor { get; set; }
        /// <summary>
        /// light/darke 字体色
        /// </summary>
        public  static string ThemeForegroundColor { get; set; }
        #region 主题色
        public static string Primary { get; set; }
        public static string Dark { get; set; }
        public static string Accent { get; set; }
        public static string Light { get; set; }
        #endregion
        #region 对应主题主题字体色
        public static string PrimaryForeground { get; set; }
        public static string DarkForeground { get; set; }
        public static string AccentForeground { get; set; }
        public static string LightForeground { get; set; }
        #endregion
    }
}
