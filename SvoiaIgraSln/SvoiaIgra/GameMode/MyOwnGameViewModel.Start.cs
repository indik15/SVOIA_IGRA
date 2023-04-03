using SvoiaIgra.ViewModel;
using System;
using System.Collections.ObjectModel;
using ViewModels;
using static SvoiaIgra.GameMode.GameMode;

namespace SvoiaIgra.GameMode
{
    public partial class MyOwnGameViewModel
    {

        public RelayCommand<int> CreaTeGameCommand => GetCommand();

        private void StartGame(int count)
        {

        }
        private bool CanStartGame(int count)
        {
            UsersCount usersCount = new UsersCount();
            usersCount.UCount= count;
            if(usersCount.HasErrors == true)
            {
                return false;
            }
        }
    }
}
