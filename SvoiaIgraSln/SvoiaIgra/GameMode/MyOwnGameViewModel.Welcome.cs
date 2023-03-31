using ViewModel;
using static SvoiaIgra.GameMode.GameMode;

namespace SvoiaIgra.GameMode
{
    public partial class MyOwnGameMode
    {
        public RelayCommand StartCommand => new RelayCommand(Start);
        public RelayCommand CloseCommand => new RelayCommand(Close);

        private void Start()
        {
            Mode = ModeEnum.Start;
        }
        private void Close()
        {
            Mode = ModeEnum.Close;
        }
    }
}
