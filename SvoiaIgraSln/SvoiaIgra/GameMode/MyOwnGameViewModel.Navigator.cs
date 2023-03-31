using static SvoiaIgra.GameMode.GameMode;

namespace SvoiaIgra.GameMode
{
    public partial class MyOwnGameMode
    {
        private ModeEnum mode;

        public ModeEnum Mode
        {
            get => mode;

            private set
            {
                mode= value;
            }
        }
    }
}
