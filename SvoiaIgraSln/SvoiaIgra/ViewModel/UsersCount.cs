﻿using System;
using ViewModels;

namespace SvoiaIgra.ViewModel
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
                HashError = value < 2 || value > 8;
                if (HashError)
                    throw new ArgumentOutOfRangeException(nameof(UCount));
            }
        }
        public bool HashError { get; private set; } = true;
    }
}
