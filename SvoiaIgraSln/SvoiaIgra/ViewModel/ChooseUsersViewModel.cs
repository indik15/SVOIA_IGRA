using ViewModel;

namespace SvoiaIgra.ViewModel
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
