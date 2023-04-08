using System;
using ViewModels;

namespace SvoiaIgra.ViewModel
{
    public class UsersCount : ValidationBase
    {
        public int Count { get => Get<T>(); set => Set(value); }

        protected override void OnPropertyChanged(string propertyName, object? oldValue, object? newValue)
        {
            base.OnPropertyChanged(propertyName, oldValue, newValue);
            if (propertyName == nameof(Count))
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
