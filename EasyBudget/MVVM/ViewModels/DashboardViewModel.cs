using EasyBudget.Data.Factories;
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
        private readonly INavigator _navigator;
        private readonly AppDbContextFactory _dbFactory;

        public DashboardViewModel(AppDbContextFactory dbFactory, INavigator navigator)
        {
            _dbFactory = dbFactory;
            _navigator = navigator;
        }
    }
}
