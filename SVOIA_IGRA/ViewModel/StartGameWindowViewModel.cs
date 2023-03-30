using ClassLibrary;
using SVOIA_IGRA.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace SVOIA_IGRA.ViewModel
{
    internal class StartGameWindowViewModel : ViewModelBase
    {

        /// <summary>
        /// Команды для использования в начальном окне
        /// </summary>
        public StartGameWindowViewModel()
        {
            CloseStartWindowComand = new RelayCommand(OnCloseStartWindowComandExecuted);
            SelectNewApplicationComand = new RelayCommand(OnSelectNewApplicationComandExecuted, CanSelectNewApplicationComandExecuted);
        }





        /// <summary>
        /// Титулка
        /// </summary>
        
        private string _Title = "Своя игра";

        public string Title
        {
            get => _Title;
            set => Set(ref _Title, value);
        }
        
       /// <summary>
       /// Добро пожаловать!
       /// </summary>
        
        private string _HText = "Добро пожаловать!";

        public string HText
        {
            get => _HText;
            set => Set(ref _HText, value);
        }


        /// <summary>
        ///Команда для кнопки
        /// </summary>
      
        public RelayCommand CloseStartWindowComand { get; }
        private void OnCloseStartWindowComandExecuted()
        {
            Application.Current.Shutdown();

        }


        /// <summary>
        /// Переход на новое окно
        /// </summary>

        public RelayCommand SelectNewApplicationComand { get; }
        private void OnSelectNewApplicationComandExecuted()
        {
            
        }
        private bool CanSelectNewApplicationComandExecuted() => true;

    }
}
