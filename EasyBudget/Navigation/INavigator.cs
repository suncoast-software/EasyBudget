using EasyBudget.MVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBudget.Navigation
{
    internal interface INavigator
    {
        public event Action CurrentViewModelChanged;
        public BaseViewModel CurrentViewModel { get; set; }
    }
}
