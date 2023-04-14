using System;
using System.ComponentModel;
using ViewModels;

namespace SvoiaIgra.ViewModel
{
    public class UsersCount : ValidationBase
    {
        public int UCount { get => Get<int>(); set => Set(value); }

        protected override void OnPropertyChanged(string propertyName, object? oldValue, object? newValue)
        {
            base.OnPropertyChanged(propertyName, oldValue, newValue);
            if (propertyName == nameof(UCount))
            {
                int value = (int)newValue!;
                if (value < 2 || value > 8)
                {
                    AddError("Количество игроков должно быть от 2 до 8", propertyName);
                }
                else
                {
                    ClearErrors(propertyName);
                }
            }
        }
    }
}
