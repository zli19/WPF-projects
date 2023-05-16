using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavigationUseCase.WPF.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private ViewModelBase? _currentViewModel;

        public ViewModelBase CurrentViewModel
        {
            get 
            { 
                if (_currentViewModel == null)
                    _currentViewModel = new HomeViewModel(this);
                return _currentViewModel; 
            }

            set
            {
                _currentViewModel = value;
                OnPropertyChanged(nameof(CurrentViewModel));
            }
        }
    }


}
