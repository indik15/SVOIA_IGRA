using System.Windows;
using System.Linq;
using SVOIA_IGRA.DataBaseQ;
using ClassLibrary;
using System.Windows.Controls;

namespace SVOIA_IGRA
{
    public partial class MainWindow : UserControl
    {
        public MainWindow()
        {
            InitializeComponent();

           // DataContext = this;
        }

       // public PlayerModel PlayerModel1 { get; set; } = new PlayerModel(new Player(1, "John", 0));
    }
}
