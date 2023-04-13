using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XiaFControl.Enums
{
    public enum PrimaryColor
    {
        [Description("默认蓝")]
        XiaFBlue,
        [Description("姨妈红")]
        XiaFRed,
        [Description("酷安绿")]
        XiaFGreen,
        [Description("高端黑")]
        XiaFBlack,
        [Description("哔哩粉")]
        XiaFPink,
        [Description("基佬紫")]
        XiaFPurple,
        [Description("自定义")]
        XiaFOther
    }
}
