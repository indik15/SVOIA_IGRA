using SVOIA_IGRA.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using SVOIA_IGRA.GameMode;
using static SVOIA_IGRA.GameMode.GameMode;

namespace SVOIA_IGRA.GameMode
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
