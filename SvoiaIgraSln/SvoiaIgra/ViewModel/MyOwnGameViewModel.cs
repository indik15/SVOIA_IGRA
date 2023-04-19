using SvoiaIgra.Model;
using System.Collections.ObjectModel;
using System.Security.Cryptography.X509Certificates;
using static SvoiaIgra.GameMode.GameMode;

using ViewModels;

namespace SvoiaIgra.ViewModel
{
    public partial class MyOwnGameViewModel : ViewModelBase
    {
        private ObservableCollection<PlayerName> _playerNamesCol = new ObservableCollection<PlayerName>();
        public ObservableCollection<PlayerName> PlayerNamesCol
        {
            get => _playerNamesCol;

            set => _playerNamesCol = value;
        }

        public RelayCommand EnterPlayerNamesCommand => GetCommand(OnEnterPlayerNamesCommand);

        private void OnEnterPlayerNamesCommand()
        {
            var userCount = new UsersCount();           
            for (int i = 1; i <= userCount.UCount; i++)
            {
                PlayerNamesCol.Add(new PlayerName(i));
            }
            //Mode = ModeEnum.PlayerNameInput;
        }       
    }
}
