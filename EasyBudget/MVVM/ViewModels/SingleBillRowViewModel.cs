using EasyBudget.Data.Factories;
using EasyBudget.MVVM.Models;
using EasyBudget.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EasyBudget.MVVM.ViewModels
{
    internal class SingleBillRowViewModel: BaseViewModel
    {
        private readonly AppDbContextFactory? _dbFactory;
        private readonly INavigator? _navigator;
       
        private Bill? _bill;
        public Bill? Bill
        {
            get => _bill;
            set => OnPropertyChanged(ref _bill, value);
        }

        public SingleBillRowViewModel(AppDbContextFactory? dbFactory, INavigator? navigator)
        {
            _dbFactory = dbFactory;
            _navigator = navigator;
        }
    }
}
