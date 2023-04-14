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
        public RelayCommand BackToChooseUsersCommand => GetCommand(BackToChooseUsers);

        private void StartGame(object p)
        {
            UsersCount usersCount = new UsersCount();
            usersCount.UCount = Convert.ToInt32(p);

            if (!usersCount.HasErrors)
            {
                Mode = ModeEnum.PlayerNameInput;
            }
        }

        private void BackToChooseUsers()
        {
            Mode = ModeEnum.PlayerCountInput;
        }

    }
}
