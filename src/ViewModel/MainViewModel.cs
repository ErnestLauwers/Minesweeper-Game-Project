using Cells;

namespace ViewModel
{
    public class MainViewModel
    {
        public MainViewModel()
        {
            CurrentScreen = Cell.Create<ScreenViewModel>(null);

            var firstScreen = new SettingsScreenViewModel(CurrentScreen);

            CurrentScreen.Value = firstScreen;
        }

        public ICell<ScreenViewModel> CurrentScreen { get; set; }
    }
}