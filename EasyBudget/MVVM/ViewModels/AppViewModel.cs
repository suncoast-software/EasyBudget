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
    internal class AppViewModel : BaseViewModel
    {
        private readonly Navigator? _navigator;
        private readonly AppDbContextFactory _dbFactory;
        public BaseViewModel? CurrentViewModel => _navigator.CurrentViewModel;
        public ICommand NavigateDashboardCommand { get; }
        public ICommand NavigateSettingsCommand { get; }
        public AppViewModel(AppDbContextFactory dbFactory, Navigator? navigator)
        {
            _dbFactory = dbFactory;
            _navigator = navigator;
            _navigator.CurrentViewModelChanged += OnCurrentViewModelChanged;
            NavigateDashboardCommand = new NavigateCommand<DashboardViewModel>(_navigator, () => new DashboardViewModel(_dbFactory, _navigator));
        }

        private void OnCurrentViewModelChanged()
        {
            OnPropertyChanged(nameof(CurrentViewModel));
        }
    }
}
