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
        public ICell<Square> Square;

        public ICell<SquareStatus> Status { get; }

        public SquareViewModel(ICell<IGame> game, Vector2D position)
        {
            this.Square = game.Derive(g => g.Board[position]);
            Uncover = new UncoverSquareCommand(game, position);
            ToggleFlag = new ToggleFlagSquareCommand(game, position);
            Status = game.Derive(g => g.Board[position].Status);
        }

        public ICommand Uncover { get; }

        public ICommand ToggleFlag { get; }

        public int? NeighboringMineCount => Square.Derive(s => s.NeighboringMineCount).Value == 0 ? null : Square.Derive(s => s.NeighboringMineCount).Value;
    }
}
