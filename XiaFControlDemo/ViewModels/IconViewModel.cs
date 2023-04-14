using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XiaFControl.Enums;

namespace XiaFControlDemo.ViewModels
{
    public class IconViewModel : BindableBase
    {
        private Lazy<IEnumerable<IconType>> _types;

        public IconViewModel()
        {
            _types = new Lazy<IEnumerable<IconType>>(() => Enum.GetValues(typeof(IconType)).OfType<IconType>().ToList());
        }

        private IEnumerable<IconType> iconTypes;
        public IEnumerable<IconType> IconTypes
        {
            get { return iconTypes ?? (iconTypes = _types.Value); }
            set
            {
                iconTypes = value;
                RaisePropertyChanged("IconTypes");
            }
        }

        private IconType currentIcon;
        public IconType CurrentIcon
        {
            get => currentIcon;
            set
            {
                currentIcon = value;
                RaisePropertyChanged("CurrentIcon");
            }
        }

        private string searchText;
        public string SearchText
        {
            get => searchText;
            set
            {
                searchText = value;
                RaisePropertyChanged("SearchText");
            }
        }

        private DelegateCommand<object> search;
        public DelegateCommand<object> Search => search ?? (search = new DelegateCommand<object>(SearchExecute));
        // 搜索
        private void SearchExecute(object obj)
        {
            if (string.IsNullOrWhiteSpace(SearchText))
            {
                IconTypes = _types.Value;
            }
            else
            {
                IconTypes = _types.Value.Where(i => i.ToString().IndexOf(SearchText, StringComparison.CurrentCultureIgnoreCase) >= 0);
            }
        }
    }
}
