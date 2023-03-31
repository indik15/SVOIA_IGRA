using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
