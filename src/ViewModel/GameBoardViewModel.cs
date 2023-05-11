using Cells;
using Model.Data;
using Model.MineSweeper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class GameBoardViewModel
    {
        private readonly ICell<IGameBoard> gameBoard;
        private readonly ICell<IGame> game;

        public GameBoardViewModel(ICell<IGame> game)
        {
            this.gameBoard = game.Derive(g => g.Board);
            this.game = game;
        }

        public IEnumerable<RowViewModel> Rows =>
            Enumerable.Range(0, gameBoard.Derive(g => g.Width).Value)
              .Select(rowIndex => new RowViewModel(Row(rowIndex)));

        public IEnumerable<SquareViewModel> Row(int rowIndex)
        {
            var columns = gameBoard.Derive(g => g.Height).Value;
            return Enumerable.Range(0, columns)
                .Select(columnIndex => new SquareViewModel(game, new Vector2D(rowIndex, columnIndex)));
        }


    }
}
