using System.ComponentModel;
using System.Runtime.CompilerServices;
using MudBlazor;

namespace CokesPortfolio.Client.Utilities
{
    public class ThemeManager : INotifyPropertyChanged
    {
        private bool _isDefaultTheme;
        public bool IsDefaultTheme
        {
            get => _isDefaultTheme;
            set
            {
                _isDefaultTheme = value;
                NotifyPropertyChanged();
            }
        }

        public MudTheme CurrentTheme { get; set; } = new();
        public MudTheme DefaultTheme { get; set; } = new()
        {
            Palette = new Palette()
            {
                Black = "#272c34"
            }
        };

        public MudTheme DarkTheme { get; set; } = new()
        {
            Palette = new Palette()
            {
                Black = "#27272f",
                Background = "#32333d",
                BackgroundGrey = "#27272f",
                Surface = "#373740",
                DrawerBackground = "#27272f",
                DrawerText = "rgba(255,255,255, 0.50)",
                DrawerIcon = "rgba(255,255,255, 0.50)",
                AppbarBackground = "#27272f",
                AppbarText = "rgba(255,255,255, 0.70)",
                TextPrimary = "rgba(255,255,255, 0.70)",
                TextSecondary = "rgba(255,255,255, 0.50)",
                ActionDefault = "#adadb1",
                ActionDisabled = "rgba(255,255,255, 0.26)",
                ActionDisabledBackground = "rgba(255,255,255, 0.12)",
                Divider = "rgba(255,255,255, 0.12)",
                DividerLight = "rgba(255,255,255, 0.06)",
                TableLines = "rgba(255,255,255, 0.12)",
                LinesDefault = "rgba(255,255,255, 0.12)",
                LinesInputs = "rgba(255,255,255, 0.3)",
                TextDisabled = "rgba(255,255,255, 0.2)"
            }
        };

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
