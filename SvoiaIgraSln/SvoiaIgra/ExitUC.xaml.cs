using System.Windows;
using System.Windows.Controls;

namespace SvoiaIgra
{
    /// <summary>
    /// Логика взаимодействия для ExitUC.xaml
    /// </summary>
    public partial class ExitUC : UserControl
    {
        public ExitUC()
        {
            InitializeComponent();
        }

        private void OnExit(object sender, RoutedEventArgs e)
        {
            Window.GetWindow(this).Close();
        }
    }
}
