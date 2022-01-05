using EasyBudget.MVVM.Commands;
using EasyBudget.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EasyBudget.MVVM.ViewModels
{
    internal class NavbarViewModel: BaseViewModel
    {
        private readonly Navigator _navigator;
        public ICommand NavigateDashboardCommand { get; }

        public NavbarViewModel(Navigator navigator)
        {
            _navigator = navigator;
            
        }
    }
}
