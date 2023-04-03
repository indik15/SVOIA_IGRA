using SvoiaIgra.ViewModel;
using System;
using System.Collections.ObjectModel;
using ViewModels;
using static SvoiaIgra.GameMode.GameMode;

namespace SvoiaIgra.GameMode
{
    public partial class MyOwnGameViewModel
    {
        public RelayCommand CreaTeGameCommand => GetCommand(StartGame);

        private void StartGame()
        {
            UsersCount usersCount = new UsersCount();
            if (!usersCount.HashError)
            {
                Mode = ModeEnum.PlayerNameInput;
            }
        }

    }
}
