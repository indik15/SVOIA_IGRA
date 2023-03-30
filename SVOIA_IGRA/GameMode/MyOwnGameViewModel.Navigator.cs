using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SVOIA_IGRA.GameMode.GameMode;

namespace SVOIA_IGRA.GameMode
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
