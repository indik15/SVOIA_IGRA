using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPFTEST
{
    /// <summary>
    /// Логика взаимодействия для NEW.xaml
    /// </summary>
    public partial class NEW : UserControl
    {
        public NEW()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            OLDCONTENT.Content = mainWindow;
            LOL2.Visibility = Visibility.Collapsed;
        }
    }
}
