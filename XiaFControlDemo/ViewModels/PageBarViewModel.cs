using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XiaFControlDemo.ViewModels
{
    public class PageBarViewModel : BindableBase
    {
        public PageBarViewModel()
        {
            Total = 100;
            PageSize = 1;
            //PageIndex = 1;
        }

        private int total;
        public int Total
        {
            get => total;
            set
            {
                total = value;
                RaisePropertyChanged();
            }
        }

        private int pageSize;
        public int PageSize
        {
            get => pageSize;
            set
            {
                pageSize = value;
                RaisePropertyChanged();
            }
        }

        //private int pageIndex;
        //public int PageIndex
        //{
        //    get => pageIndex;
        //    set
        //    {
        //        pageIndex = value;
        //        RaisePropertyChanged("PageIndex");
        //    }
        //}

        private string pageBarMessage;
        public string PageBarMessage
        {
            get => pageBarMessage;
            set
            {
                pageBarMessage = value;
                RaisePropertyChanged();
            }
        }



        private DelegateCommand<object> pageIndexChanged;
        public DelegateCommand<object> PageIndexChanged => pageIndexChanged ?? (pageIndexChanged = new DelegateCommand<object>(PageIndexChangedExecute));

        private void PageIndexChangedExecute(object index)
        {
            PageBarMessage = $"当前页：{(int)index}";
        }

        private DelegateCommand<object> pageSizeChanged;
        public DelegateCommand<object> PageSizeChanged => pageSizeChanged ?? (pageSizeChanged = new DelegateCommand<object>(PageSizeChangedExecute));

        private void PageSizeChangedExecute(object size)
        {
            PageBarMessage = $"每页条数：{(int)size}";
        }
    }
}
