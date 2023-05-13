using Model.Data;
using Model.MineSweeper;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using ViewModel;

namespace View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var game = IGame.CreateRandom(5, 0.3);

            /*
            var game = IGame.Parse(new List<String> {
                ".....",
                "*....",
                "...*.",
                ".....",
                ".*..*",
            });
            
            var position = new Vector2D(2, 1);
            var game2 = game.UncoverSquare(position);

            var position2 = new Vector2D(1, 0);
            var game3 = game2.ToggleFlag(position2);

            var position3 = new Vector2D(2, 3);
            var game4 = game3.UncoverSquare(position3);

            var position4 = new Vector2D(3, 3);
            var game5 = game4.ToggleFlag(position4);
            */
            var gameViewModel = new GameViewModel(game);
            DataContext = gameViewModel;
        }

    }

}
