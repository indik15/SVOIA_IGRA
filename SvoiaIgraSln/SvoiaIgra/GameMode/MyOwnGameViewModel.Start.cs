using SvoiaIgra.ViewModel;
using System;
using System.Collections.ObjectModel;
using ViewModels;
using static SvoiaIgra.GameMode.GameMode;

namespace SvoiaIgra.GameMode
{
    public partial class MyOwnGameViewModel
    {
        public RelayCommand CreateGameCommand => GetCommand(StartGame);

        private void StartGame(object p)
        {
            UsersCount usersCount = new UsersCount();
            usersCount.UCount = Convert.ToInt32(p);

            if (!usersCount.HashError)
            {
                Mode = ModeEnum.PlayerNameInput;
            }
        }

    }
}
