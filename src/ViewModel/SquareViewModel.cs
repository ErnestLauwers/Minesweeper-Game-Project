using Cells;
using Model.Data;
using Model.MineSweeper;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            Square = game.Derive(g => g.Board[position]);
            Uncover = new UncoverSquareCommand(game, position);
            FlagSquare = new FlagSquareCommand(game, position);
            Status = game.Derive(g =>
            {
                if(g.Status == GameStatus.Lost)
                {
                    if (g.Mines.Contains(position))
                    {
                        return SquareStatus.Mine;
                    }
                }
                return g.Board[position].Status;
            });
        }

        public ICommand Uncover { get; }

        public ICommand FlagSquare { get; }

        public int? NeighboringMineCount => Square.Derive(s => s.NeighboringMineCount).Value == 0 ? null : Square.Derive(s => s.NeighboringMineCount).Value;
    }
}
