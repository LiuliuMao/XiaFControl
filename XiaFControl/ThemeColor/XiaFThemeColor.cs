using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using XiaFControl.Services;

namespace XiaFControl.ThemeColor
{
    public class XiaFThemeColor : IBaseTheme
    {
        public  Color ThemeForegroundColor { get; set; } = (Color)ColorConverter.ConvertFromString("#252526");

        public  Color ThemeBackgroundColor { get; set; } = (Color)ColorConverter.ConvertFromString("#E6E6E6");

        public  Color WindowBackgroundColor { get; set; } = (Color)ColorConverter.ConvertFromString("#EEEEEE");

        public  Color DialogBackground { get; set; } = (Color)ColorConverter.ConvertFromString("#CC252526");

        //public  Color BodyBackground { get;set; } = (Color)ColorConverter.ConvertFromString("#FFFFFF");

        public  SolidColorBrush Light { get; set; } = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#6EC6FF"));

        public  SolidColorBrush LightForeground { get; set; } = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#000000"));

        public  SolidColorBrush Primary { get; set; } = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#2196F3"));

        public  SolidColorBrush PrimaryForeground { get; set; } = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFFF"));

        public  SolidColorBrush Dark { get; set; } = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#F50057"));

        public  SolidColorBrush DarkForeground { get; set; } = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFFF"));

        public  SolidColorBrush Accent { get; set; } = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#F50057"));

        public  SolidColorBrush AccentForeground { get; set; } = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFFF"));

        //public  SolidColorBrush DefaultForeground { get;set; } = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#LightForegroundColor"));

        //public  SolidColorBrush DefaultBackground { get;set; } = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#LightBackgroundColor"));

        public  SolidColorBrush BackgroundGray { get; set; } = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#BDBDBD"));

        public  SolidColorBrush MouseOverBackgroundGray { get; set; } = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#BDBDBD"));

        public  SolidColorBrush PressedBackgroundGray { get; set; } = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#BDBDBD"));

        public  SolidColorBrush ButtonMouseOverBackgroundGray { get; set; } = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#BDBDBD"));

        public  SolidColorBrush ButtonPressedBackgroundGray { get; set; } = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#BDBDBD"));

        public  SolidColorBrush BorderGray { get; set; } = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#9e9e9e"));

        public  SolidColorBrush GridBackground { get; set; } = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#BDBDBD"));

        public  SolidColorBrush ErrorBrush { get; set; } = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#E53935"));

        public  SolidColorBrush InfoBrush { get; set; } = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#90A4AE"));

        public  SolidColorBrush WarningBrush { get; set; } = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF9800"));

        public  SolidColorBrush SuccessBrush { get; set; } = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#43A047"));

        public  SolidColorBrush QuestionBrush { get; set; } = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#2196F3"));

        public  SolidColorBrush ScrollBackground { get; set; } = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#BDBDBD"));

        public  SolidColorBrush ScrollForeground { get; set; } = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#757575"));

        public  SolidColorBrush ScrollMouseOverForeground { get; set; } = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#757575"));
    }
}
