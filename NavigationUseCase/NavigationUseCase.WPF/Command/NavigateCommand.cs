using NavigationUseCase.WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace NavigationUseCase.WPF.Command
{
    public class NavigateCommand<TViewModel> : CommandBase
        where TViewModel : ViewModelBase
    {
        private readonly MainViewModel _mainViewModel;
        private readonly Func<TViewModel> _createTViewModel;

        public NavigateCommand(MainViewModel viewModel, Func<TViewModel> createTViewModel)
        {
            _mainViewModel = viewModel;
            _createTViewModel = createTViewModel;
        }

        public override void Execute(object? parameter)
        {
            _mainViewModel.CurrentViewModel = _createTViewModel();
        }


    }
   
}
