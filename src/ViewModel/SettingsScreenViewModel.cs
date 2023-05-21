using Cells;
using Model.MineSweeper;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ViewModel
{
    public class SettingsScreenViewModel : ScreenViewModel
    {
        public SettingsScreenViewModel(ICell<ScreenViewModel> currentScreen) : base(currentScreen)
        {
            Play = new ActionCommand(() => currentScreen.Value = new GameScreenViewModel(this.CurrentScreen, BoardSize, Flooding, MineProbability));
            PlayEasy = new ActionCommand(() => currentScreen.Value = new GameScreenViewModel(this.CurrentScreen, 5, Flooding, MineProbability));
            PlayMedium = new ActionCommand(() => currentScreen.Value = new GameScreenViewModel(this.CurrentScreen, 10, Flooding, MineProbability));
            PlayHard = new ActionCommand(() => currentScreen.Value = new GameScreenViewModel(this.CurrentScreen, 15, Flooding, MineProbability));
        }

        public int BoardSize { get; set; } = 6;
        public bool Flooding { get; set; } = true;
        public double MineProbability { get; set; } = 0.2;
        public int MaximumSize { get; } = IGame.MaximumBoardSize;
        public int MinimumSize { get; } = IGame.MinimumBoardSize;

        public ICommand Play { get; }
        public ICommand PlayEasy { get; }
        public ICommand PlayMedium { get; }
        public ICommand PlayHard { get; }
    }
}
