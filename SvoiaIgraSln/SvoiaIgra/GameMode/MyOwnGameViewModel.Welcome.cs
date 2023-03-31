using SvoiaIgra.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using SvoiaIgra.GameMode;
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
