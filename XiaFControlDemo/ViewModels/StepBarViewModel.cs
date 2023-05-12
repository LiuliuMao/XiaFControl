using Prism.Commands;
using Prism.Common;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XiaFControlDemo.ViewModels
{
    public class StepBarViewModel : BindableBase
    {
        public StepBarViewModel()
        {
            NextStepCommand=new DelegateCommand(NextStep); 
            Models = new ObservableCollection<StepModel>
            {
                new StepModel { Content = "第 1 步" , Description = "顶顶顶顶顶顶顶顶顶顶顶顶顶顶顶顶顶顶" },
                new StepModel { Content = "第 2 步" , Description = DateTime.Now.AddHours(1).ToString("HH:mm:ss") },
                new StepModel { Content = "第 3 步" , Description = DateTime.Now.AddHours(2).ToString("HH:mm:ss") },
                new StepModel { Content = "第 4 步" , Description = DateTime.Now.AddHours(3).ToString("HH:mm:ss") },
                new StepModel { Content = "第 5 步" , Description = DateTime.Now.AddHours(4).ToString("HH:mm:ss") },
            };
        }

        /// <summary>
        /// 当前步骤
        /// </summary>
        private int currentIndex = 0;
        public int CurrentIndex { get { return currentIndex; } set { currentIndex = value; RaisePropertyChanged(); } }

        /// <summary>
        /// 所有步骤
        /// </summary>
        private ObservableCollection<StepModel> models;
        public ObservableCollection<StepModel> Models { get { return models; } set { models = value; RaisePropertyChanged(); } }

        public DelegateCommand NextStepCommand { get; set; }
        /// <summary>
        /// 下一步命令
        /// </summary>
        private void NextStep()
        {
            CurrentIndex++;
            if (CurrentIndex > 5)
            {
                CurrentIndex = 0;
            }
        }
    }
    /// <summary>
    /// 步骤模型
    /// </summary>
    public class StepModel : ChangedBase
    {
        /// <summary>
        /// 内容
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; }
    }
}
