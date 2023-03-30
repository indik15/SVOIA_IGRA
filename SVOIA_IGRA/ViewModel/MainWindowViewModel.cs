using MaterialDesignColors.Recommended;
using SVOIA_IGRA.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace SVOIA_IGRA.ViewModel
{
    internal class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
           // CloseMainWindowCommand = new RelayCommand(OnCloseMainWindowCommandExecuted);
        }

        public RelayCommand CloseMainWindowCommand { get; }

        private void OnCloseMainWindowCommandExecuted()
        {
            Application.Current.Shutdown();
        }

    }
}
