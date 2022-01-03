using EasyBudget.MVVM.ViewModels;
using EasyBudget.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBudget.MVVM.Commands
{
    internal class NavigateCommand<TViewModel> : CommandBase
     where TViewModel : BaseViewModel
    {
        private readonly Navigator _navigator;
        private readonly Func<TViewModel> _createViewModel;
        public NavigateCommand(Navigator navigator, Func<TViewModel> createViewModel)
        {
            _navigator = navigator;
            _createViewModel = createViewModel;
        }
        public override void Execute(object? parameter)
        {
            _navigator.CurrentViewModel = _createViewModel();
        }
    }
}
