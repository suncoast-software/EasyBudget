using EasyBudget.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBudget.MVVM.ViewModels
{
    internal class DashboardViewModel: BaseViewModel
    {
        private readonly Navigator _navigator;

        public DashboardViewModel(Navigator navigator)
        {
            _navigator = navigator;
        }
    }
}
