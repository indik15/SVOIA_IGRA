using ViewModels;
using static SvoiaIgra.GameMode.GameMode;

namespace SvoiaIgra.GameMode
{
    public partial class MyOwnGameViewModel
    {
        public RelayCommand StartCommand => GetCommand(Start);
        public RelayCommand CloseCommand => GetCommand(Close);
        public RelayCommand WelcomeCommand => GetCommand(Welcome);

        private void Start()
        {
            Mode = ModeEnum.PlayerCountInput;
        }
        private void Close()
        {
            Mode = ModeEnum.Close;
        }
        private void Welcome()
        {
            Mode = ModeEnum.Welcome;
        }
    }
}
