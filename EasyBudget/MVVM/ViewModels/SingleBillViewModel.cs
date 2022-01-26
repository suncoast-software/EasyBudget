using EasyBudget.Data.Factories;
using EasyBudget.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EasyBudget.MVVM.ViewModels
{
    internal class SingleBillViewModel: BaseViewModel
    {
        private AppDbContextFactory? _dbFactory;
        private INavigator? _navigator;

        public BaseViewModel? CurrentViewModel => _navigator?.CurrentViewModel;

        public ICommand SaveBillCommand { get; set; }
        public ICommand CancelCommand { get; set; }

        public SingleBillViewModel(AppDbContextFactory? dbFactory, INavigator? navigator)
        {
            _dbFactory = dbFactory;
            _navigator = navigator;
            _navigator.CurrentViewModelChanged += OnCurrentViewModelChanged;
        }

        private void OnCurrentViewModelChanged()
        {
            OnPropertyChanged(nameof(CurrentViewModel));
        }
    }
}
