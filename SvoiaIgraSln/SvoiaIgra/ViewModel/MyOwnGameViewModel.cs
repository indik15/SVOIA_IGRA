using SvoiaIgra.Commands;
using SvoiaIgra.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SvoiaIgra.ViewModel;
using static SvoiaIgra.GameMode.GameMode;
using static SvoiaIgra.GameMode.MyOwnGameMode;
using SvoiaIgra.GameMode;

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
