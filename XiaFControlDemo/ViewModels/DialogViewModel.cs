using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using XiaFControl.Controls;
using XiaFControlDemo.Views;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace XiaFControlDemo.ViewModels
{
    public class DialogViewModel : BindableBase
    {
        public DialogViewModel()
        {
            User = new User();
            Users = new ObservableCollection<User>
            {
               new User{ Name="张三",Age=18 },
               new User{ Name="李四",Age=19 }
            };
        }

        private bool dialog1IsShow;
        public bool Dialog1IsShow
        {
            get => dialog1IsShow;
            set
            {
                dialog1IsShow = value;
                RaisePropertyChanged("Dialog1IsShow");
            }
        }

        private User user;
        public User User
        {
            get => user;
            set
            {
                user = value;
                RaisePropertyChanged("User");
            }
        }

        private ObservableCollection<User> users;
        public ObservableCollection<User> Users
        {
            get => users;
            set
            {
                users = value;
                RaisePropertyChanged("Users");
            }
        }


        private DelegateCommand<object> openDialog1;
        public DelegateCommand<object> OpenDialog1 => openDialog1 ?? (openDialog1 = new DelegateCommand<object>(OpenDialog1Execute));
        // 打开 1# 对话框
        private void OpenDialog1Execute(object obj)
        {
            Dialog1IsShow = true;
        }

        private DelegateCommand<object> closeDialog1;
        public DelegateCommand<object> CloseDialog1 => closeDialog1 ?? (closeDialog1 = new DelegateCommand<object>(CloseDialog1Execute));
        // 关闭 1# 对话框
        private void CloseDialog1Execute(object obj)
        {
            Dialog1IsShow = false;
        }

        private DelegateCommand<object> beforeDialog3Open;
        public DelegateCommand<object> BeforeDialog3Open => beforeDialog3Open ?? (beforeDialog3Open = new DelegateCommand<object>(BeforeDialog3OpenExecute));
        // 2# 对话框打开前
        private void BeforeDialog3OpenExecute(object obj)
        {
            Message.Show("MessageContainer", "打开 3# 对话框");
        }

        private DelegateCommand<object> afterDialog3Close;
        public DelegateCommand<object> AfterDialog3Close => afterDialog3Close ?? (afterDialog3Close = new DelegateCommand<object>(AfterDialog3CloseExecute));
        // 2# 对话框关闭后
        private void AfterDialog3CloseExecute(object obj)
        {
            if (obj is User user)
            {
                Users.Add((User)user.Clone());
            }
        }

        private DelegateCommand<object> openDialog4;
        public DelegateCommand<object> OpenDialog4 => openDialog4 ?? (openDialog4 = new DelegateCommand<object>(OpenDialog4Execute));
        // 打开 4# 对话框
        private void OpenDialog4Execute(object obj)
        {
            var content = new DialogContent();
            DialogBox.Show("MainDialog", content, "登录", BeforeDialog4Open, AfterDialog4Close);
        }

        private void AfterDialog4Close(DialogBox dialog, object arg)
        {
            Debug.WriteLine($"4# 对话框关闭参数:{arg}");
        }

        private void BeforeDialog4Open(DialogBox dialog)
        {
            Debug.WriteLine("4# 对话框打开");
        }
    }

    public class User : ICloneable
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
