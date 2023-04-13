using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace XiaFControl.Services
{
    public interface IBaseTheme
    {
        Color ThemeForegroundColor { get; set;}
        Color ThemeBackgroundColor { get; set;}
        Color WindowBackgroundColor { get; set;}
        Color DialogBackground { get; set;}
        //SolidColorBrush BodyBackground { get; set;}
        SolidColorBrush Light { get; set;}
        SolidColorBrush LightForeground { get; set;}
        SolidColorBrush Primary { get; set;}
        SolidColorBrush PrimaryForeground { get; set;}
        SolidColorBrush Dark { get; set;}
        SolidColorBrush DarkForeground { get; set;}
        SolidColorBrush Accent { get; set;}
        SolidColorBrush AccentForeground { get; set;}
        //SolidColorBrush DefaultForeground { get; set;}
        //SolidColorBrush DefaultBackground { get; set;}
        SolidColorBrush BackgroundGray { get; set;}
        SolidColorBrush MouseOverBackgroundGray { get; set;}
        SolidColorBrush PressedBackgroundGray { get; set;}
        SolidColorBrush ButtonMouseOverBackgroundGray { get; set;}
        SolidColorBrush ButtonPressedBackgroundGray { get; set;}
        SolidColorBrush BorderGray { get; set;}
        SolidColorBrush GridBackground { get; set;}
        SolidColorBrush ErrorBrush { get; set;}
        SolidColorBrush InfoBrush { get; set;}
        SolidColorBrush WarningBrush { get; set;}
        SolidColorBrush SuccessBrush { get; set;}
        SolidColorBrush QuestionBrush { get; set;}
        SolidColorBrush ScrollBackground { get; set;}
        SolidColorBrush ScrollForeground { get; set;}
        SolidColorBrush ScrollMouseOverForeground { get; set;}
    }
}
