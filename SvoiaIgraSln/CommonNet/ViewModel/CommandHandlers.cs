using System;

namespace ViewModel
{
    #region Делегаты для методов WPF команд
    public delegate void ExecuteHandler(object parameter);
    public delegate bool CanExecuteHandler(object parameter);
    #endregion

}
