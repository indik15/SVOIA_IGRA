using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVOIA_IGRA.ViewModel
{
    public class UsersCount : ValidationBase
    {
        private int _Ucount;

        public int UCount
        {
            get => _Ucount;

            set
            {
                _Ucount = value;
                HashError = value < 2 && value > 8;
                if (HashError)
                    throw new ArgumentOutOfRangeException(nameof(UCount));
            }
        }
        public bool HashError { get; private set; } = true;
    }
}
