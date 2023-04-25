using Prism.Commands;
using Prism.Common;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using XiaFControl.Enums;

namespace XiaFControlDemo.ViewModels
{
    public class HamburgerMenuViewModel : BindableBase
    {
        public DelegateCommand<string> SelecteCommand { get; set; }
        /// <summary>
        /// 子项集合
        /// </summary>
        private ObservableCollection<HamburgerMenuModel> _Models { get; set; }
        public ObservableCollection<HamburgerMenuModel> Models
        {
            get
            {
                return _Models;
            }
            set
            {
                _Models = value; RaisePropertyChanged();
            }
        }

        /// <summary>
        /// 选项集合
        /// </summary>
        private ObservableCollection<HamburgerMenuModel> _OptionsModels { get; set; }
        public ObservableCollection<HamburgerMenuModel> OptionsModels
        {
            get
            {
                return _OptionsModels;
            }
            set
            {
                _OptionsModels = value; RaisePropertyChanged();
            }
        }

        /// <summary>
        /// 下一步命令
        /// </summary>
        private void Selecte(string message)
        {
            Debug.WriteLine($"HamburgerMenuItem Command: {message}");
        }

        public HamburgerMenuViewModel()
        {
            SelecteCommand = new DelegateCommand<string>(Selecte);
            _Models = new ObservableCollection<HamburgerMenuModel>();
            Models.Add(new HamburgerMenuModel("用户", IconType.UserLine));
            Models.Add(new HamburgerMenuModel("文档", IconType.FileLine));
            Models.Add(new HamburgerMenuModel("图片", IconType.ImageLine));
            Models.Add(new HamburgerMenuModel("设置", IconType.Settings2Line));
            Models.Add(new HamburgerMenuModel("无图标", null));
            Models.Add(new HamburgerMenuModel("不可用", IconType.EmotionUnhappyLine, false));
            _OptionsModels = new ObservableCollection<HamburgerMenuModel>();
            OptionsModels.Add(new HamburgerMenuModel("睡眠", IconType.MoonFill));
            OptionsModels.Add(new HamburgerMenuModel("关机", IconType.ShutDownLine));
            OptionsModels.Add(new HamburgerMenuModel("重启", IconType.RestartLine));
        }
    }
    /// <summary>
    /// 汉堡包菜单模型
    /// </summary>
    public partial class HamburgerMenuModel : ChangedBase
    {
        /// <summary>
        /// 名称
        /// </summary>
        private string name;
        public string Name { get { return name; } set { UpdateProper(ref name, value); } }

        /// <summary>
        /// 图标
        /// </summary>
        private IconType? icon;
        public IconType? Icon { get { return icon; } set { UpdateProper(ref icon, value); } }

        /// <summary>
        /// 是否可用
        /// </summary>
        private bool isEnable;
        public bool IsEnable { get { return isEnable; } set { UpdateProper(ref isEnable, value); } }

        public HamburgerMenuModel(string name, IconType? icon, bool isEnable = true)
        {
            Name = name;
            Icon = icon;
            IsEnable = isEnable;
        }
    }
}
