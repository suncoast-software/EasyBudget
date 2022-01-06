using EasyBudget.Data.Factories;
using EasyBudget.MVVM.Commands;
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
    internal class BillsViewModel: BaseViewModel
    {
        private readonly Navigator _navigator;
        private readonly AppDbContextFactory _dbFactory;

        public ICommand AddNewBillNavigateCommand { get; set; }

        private List<Bill> _bills;
        public List<Bill> Bills
        {
            get => _bills;
            set => OnPropertyChanged(ref _bills, value);
        }

        public BillsViewModel(AppDbContextFactory dbFactory, Navigator navigator)
        {
            _dbFactory = dbFactory;
            _navigator = navigator;
            AddNewBillNavigateCommand = new NavigateCommand<AddBillViewModel>(_navigator, () => new AddBillViewModel(_dbFactory, _navigator));
            Bills = new List<Bill>();
            LoadBills();
        }

        private void LoadBills()
        {
            for (int i = 0; i < 30; i++)
            {
                var bill = new Bill
                {
                    PayeeName = "Best Buy",
                    AccountNumber = "1234-1234-1234-1234",
                    DueAmount = 120.0M,
                    PaidAmount = 120.0M,
                    ConfirmationNumber = "000-000-000-0000",
                };
                Bills.Add(bill);
            }
        }
    }
}
