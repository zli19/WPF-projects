using NavigationUseCase.WPF.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace NavigationUseCase.WPF.ViewModels
{
    public class AccountViewModel : ViewModelBase
    {
        private readonly MainViewModel _mainViewModel;

        public string Name => "Zhikun";

        private ICommand? _navigateHomeCommand;
        public ICommand NavigateHomeCommand
        {
            get
            {
                if(_navigateHomeCommand == null)
                    _navigateHomeCommand = new NavigateCommand<HomeViewModel>(_mainViewModel, 
                        ()=> new HomeViewModel(_mainViewModel));
                return _navigateHomeCommand;
            }

            set { _navigateHomeCommand = value; }
        }

        public AccountViewModel(MainViewModel mainViewModel)
        {
            _mainViewModel = mainViewModel;
        }
    }
}