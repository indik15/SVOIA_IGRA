using System.Windows;
using System.Linq;
using SvoiaIgra.DataBaseQ;
using ClassLibrary;
using System.Windows.Controls;

namespace SvoiaIgra
{
    public partial class GameUC : UserControl
    {
        public GameUC()
        {
            InitializeComponent();

           // DataContext = this;
        }

       // public PlayerModel PlayerModel1 { get; set; } = new PlayerModel(new Player(1, "John", 0));
    }
}
