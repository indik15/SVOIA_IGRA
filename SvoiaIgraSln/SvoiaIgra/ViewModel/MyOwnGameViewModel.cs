using SvoiaIgra.Commands;
using SvoiaIgra.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SvoiaIgra.ViewModel;

namespace SvoiaIgra.ViewModel
{
    public partial class MyOwnGameViewModel : ViewModelBase
    {
        private ObservableCollection<PlayerName> _playerNames;
        public ObservableCollection<PlayerName> PlayerNames
        {
            get => _playerNames;

            set => _playerNames = value;
        }

        public RelayCommand EnterPlayerNamesCommand { get; set; }

        private void OnEnterPlayerNamesCommand()
        {
            var playerNames = new ObservableCollection<PlayerName>();
            мфк 
            for (int i = 1; i <= UsersCount.UCount; i++)
            {

            }
        }


    }
}
