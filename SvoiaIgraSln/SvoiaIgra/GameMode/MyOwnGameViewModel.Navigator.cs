using ViewModels;
using static SvoiaIgra.GameMode.GameMode;

namespace SvoiaIgra.GameMode
{
    public partial class MyOwnGameViewModel : ViewModelBase
    {
        public ModeEnum Mode
        {
            get => Get<ModeEnum>();

            private set => Set(value);
        }
    }
}
