using System.ComponentModel;
using System.Runtime.CompilerServices;
using MudBlazor;

namespace CokesPortfolio.Client.Utilities
{
    public class ThemeManager : INotifyPropertyChanged
    {
        private bool isDarkMode;
        public bool IsDarkMode
        {
            get => isDarkMode;
            set
            {
                //if (isDarkMode == value) return;
                isDarkMode = value;
                NotifyPropertyChanged();
            }
        }

        //public MudTheme Theme { get; } = new MudTheme()
        //{
        //    PaletteLight = new PaletteLight()
        //    {
        //        Primary =  "#4F6EF7",
        //        Secondary = "#6A5ACD",
        //        Background = "#F5F5F5",
        //        AppbarBackground = "#4F6EF7",
        //        DrawerBackground = "#ffffff",
        //        Surface = "#ffffff",
        //        Success = "#28a745",
        //        Info = "#17a2b8",
        //        Warning = "#ffc107",
        //        Error = "#dc3545",
        //        TextPrimary = "#222222",
        //        TextSecondary = "#555555"
        //    },
        //    PaletteDark = new PaletteDark()
        //    {
        //        Primary = "#4F6EF7",
        //        Secondary = "#6A5ACD",
        //        Background = "#121212",
        //        Surface = "#1E1E1E",
        //        TextPrimary = "#ffffff"
        //    }
        //};

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        // Optional helper to toggle dark mode
        public void ToggleDarkMode() => IsDarkMode = !IsDarkMode;
    }
}
