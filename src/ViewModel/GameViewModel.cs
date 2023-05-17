using Cells;
using Model.Data;
using Model.MineSweeper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ViewModel
{
    public class GameViewModel
    {
        private readonly ICell<IGame> game;
        private readonly GameBoardViewModel board;
        public ICell<GameStatus> Status { get; }
        public GameViewModel(IGame game)
        {
            this.game = Cell.Create(game);
            this.board = new GameBoardViewModel(this.game);
            this.Status = this.game.Derive(g => g.Status);
        }

        public GameBoardViewModel Board => board;

    }
}
