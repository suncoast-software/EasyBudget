using EasyBudget.Data.Factories;
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
    internal class AddBillViewModel: BaseViewModel
    {
        private readonly AppDbContextFactory _dbFactory;
        private readonly INavigator _navigator;

        public ICommand AddBillCommand { get; set; }

        public AddBillViewModel(AppDbContextFactory dbFactory, INavigator navigator)
        {
            _dbFactory = dbFactory;
            _navigator = navigator;
            AddBillCommand = new RelayCommand(AddBill);
        }

        private void AddBill()
        {
            throw new NotImplementedException();
        }
    }
}
