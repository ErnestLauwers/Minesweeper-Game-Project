using Cells;
using Model.Data;
using Model.MineSweeper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ViewModel
{
    public class SquareViewModel
    {
        private readonly ICell<Square> square;

        public SquareViewModel(ICell<IGame> game, Vector2D position)
        {
            this.square = game.Derive(g => g.Board).Derive(b => b[position]);
            Uncover = new UncoverSquareCommand(game, position);
        }
            
        public SquareStatus Status => square.Derive(s => s.Status).Value;

        public ICommand Uncover { get; }

        public int NeighboringMineCount => square.Derive(s => s.NeighboringMineCount).Value;
    }
}
