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

            var grid = Rows(game4.Board);
            DataContext = grid;
        }

        public IEnumerable<Square> Row(IGameBoard board, int row)
        {
            var columns = board.Height;
            var result = new List<Square>();
            for (int i = 0; i < columns; i++)
            {
                var position = new Vector2D(row, i);
                result.Add(board[position]);
            }
            return result;
        }

        public IEnumerable<IEnumerable<Square>> Rows(IGameBoard board)
        {
            var result = new List<IEnumerable<Square>>();
            var rows = board.Width;
            for (int i = 0; i < rows; i++)
            {
                result.Add(Row(board, i));
            }
            return result;
        }

    }

}
