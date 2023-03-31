using SvoiaIgra.Model;
using System.Collections.ObjectModel;
using ViewModels;

namespace SvoiaIgra.ViewModel
{
    public partial class MyOwnGameViewModel : ViewModelBase
    {
        private ObservableCollection<PlayerName> _playerNamesCol;
        public ObservableCollection<PlayerName> PlayerNamesCol
        {
            get => _playerNamesCol;

            set => _playerNamesCol = value;
        }

        public RelayCommand EnterPlayerNamesCommand { get; set; }

        private void OnEnterPlayerNamesCommand()
        {
            var playerNames = new ObservableCollection<PlayerName>();
            var userCount = new UsersCount();
            
            for (int i = 1; i <= userCount.UCount; i++)
            {
                playerNames.Add(new PlayerName(i));
            }
            PlayerNamesCol = playerNames;
            //Mode = ModeEnum.PlayerNameInput;
        }


    }
}
