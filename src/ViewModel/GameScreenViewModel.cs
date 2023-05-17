using Cells;
using Model.MineSweeper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ViewModel
{
    public class GameScreenViewModel : ScreenViewModel
    {
        public GameScreenViewModel(ICell<ScreenViewModel> currentScreen, int boardSize, bool flooding, double mineProbability) : base(currentScreen)
        {
            var game = IGame.CreateRandom(boardSize, mineProbability, flooding);
            var gameViewModel = new GameViewModel(game);
            this.GameViewModel = gameViewModel;

            Settings = new ActionCommand(() => currentScreen.Value = new SettingsScreenViewModel(this.CurrentScreen));

        }
        public GameViewModel GameViewModel { get; private set; }

        public ICommand Settings { get; }
    }
}
