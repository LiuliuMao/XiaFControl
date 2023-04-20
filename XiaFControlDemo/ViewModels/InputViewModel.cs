using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XiaFControlDemo.ViewModels
{
    public class InputViewModel: BindableBase
    {
        public InputViewModel()
        {
            selectedItems = new Dictionary<string, object>();
            dataList = new Dictionary<string, object>();
            for (int i = 0; i < 10; i++)
            {
                DataList.Add(i.ToString(), "00" + i);
            }
        }
        private Dictionary<string, object> selectedItems { get; set; }
        public Dictionary<string, object> SelectedItems
        {
            get { return selectedItems; }
            set { selectedItems = value; RaisePropertyChanged(); }
        }
        private Dictionary<string, object> dataList { get; set; }
        public Dictionary<string, object> DataList
        {
            get { return dataList; }
            set { dataList = value; RaisePropertyChanged(); }
        }
    }
}
