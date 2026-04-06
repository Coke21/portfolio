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
                isDarkMode = value;
                NotifyPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
