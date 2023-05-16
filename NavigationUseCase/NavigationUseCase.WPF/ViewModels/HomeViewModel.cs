using NavigationUseCase.WPF.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace NavigationUseCase.WPF.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {
        public readonly MainViewModel _mainViewModel;
        public string WelcomeMessage => "Welcome to my application.";

        private ICommand? _navigateAccountCommand;
        public ICommand NavigateAccountCommand
        {
            get
            {
                if (_navigateAccountCommand == null)
                {
                    _navigateAccountCommand = new NavigateCommand<AccountViewModel>(_mainViewModel, 
                        ()=> new AccountViewModel(_mainViewModel));
                }
                return _navigateAccountCommand;
            }

            set
            {
                _navigateAccountCommand = value;
            }
        }

        public HomeViewModel(MainViewModel mainViewModel)
        {
            _mainViewModel = mainViewModel;
        }
    }
}
