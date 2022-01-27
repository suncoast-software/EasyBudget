using EasyBudget.Data.Factories;
using EasyBudget.MVVM.Commands;
using EasyBudget.MVVM.Models;
using EasyBudget.Navigation;
using EasyBudget.Services.Interfaces;
using System;
using System.Windows.Input;

namespace EasyBudget.MVVM.ViewModels
{
    internal class AppViewModel : BaseViewModel
    {
        private readonly INavigator? _navigator;
        private readonly AppDbContextFactory _dbFactory;
        private ILoggerService _logger;
        public BaseViewModel? CurrentViewModel => _navigator.CurrentViewModel;
        public ICommand NavigateDashboardCommand { get; }
        public ICommand NavigateBillsCommand { get; }
        public AppViewModel(AppDbContextFactory dbFactory, INavigator? navigator, ILoggerService logger)
        {
            _dbFactory = dbFactory;
            _navigator = navigator;
            _logger = logger;
            WriteLog(_logger);
            _navigator.CurrentViewModelChanged += OnCurrentViewModelChanged;
            NavigateDashboardCommand = new NavigateCommand<DashboardViewModel>(_navigator, () => new DashboardViewModel(_dbFactory, _navigator));
            NavigateBillsCommand = new NavigateCommand<BillsViewModel>(_navigator, () => new BillsViewModel(_dbFactory, _navigator));
        }

        private void OnCurrentViewModelChanged()
        {
            OnPropertyChanged(nameof(CurrentViewModel));
        }

        private void WriteLog(ILoggerService? logger)
        {
            Log log = new();
            log.Id = Guid.NewGuid();
            log.Message = "App View Model Loaded";
            log.Type = LogType.MESSAGE;
            log.Created = DateTime.Now;

            if (logger != null)
                logger?.Log(log);
        }
    }
}
