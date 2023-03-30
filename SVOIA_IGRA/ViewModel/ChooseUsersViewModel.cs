using ClassLibrary;
using SVOIA_IGRA.Commands;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace SVOIA_IGRA.ViewModel
{
    internal class ChooseUsersViewModel : ViewModelBase
    {             

        public ChooseUsersViewModel()
        {
            //CreateUsersCommand = new RelayCommand(OnCreateUsersCommandEecute);
        }

        public RelayCommand CreateUsersCommand { get; set; }
        public void OnCreateUsersCommandEecute()
        {          

        }

    }
}
