using System.Windows;
using ViewModels;

namespace SvoiaIgra.ViewModel
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
