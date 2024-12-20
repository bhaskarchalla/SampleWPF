using ControlzEx.Theming;
using System.Configuration;
using System.Data;
using System.Windows;
using System.Windows.Media;

namespace Sample
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            // Set the application theme to Dark.Green
            //ThemeManager.Current.ChangeTheme(this, "Dark.Green");

            // Set the initial theme
            ThemeManager.Current.ChangeTheme(this, "Dark.Blue");

            // Subscribe to theme changes
            ThemeManager.Current.ThemeChanged += Current_ThemeChanged;
        }
        private void Current_ThemeChanged(object sender, ThemeChangedEventArgs e)
        {
            UpdateHeaderBackgroundBrush(e.NewTheme);
        }

        private void UpdateHeaderBackgroundBrush(Theme newTheme)
            //=> Resources["HeaderBackgroundBrush"] = newTheme.Resources["MahApps.Brushes.Accent"] as SolidColorBrush; // new SolidColorBrush(newTheme.BaseColorScheme == "Dark" ? Colors.DimGray : Colors.LightGray);
        => Resources["HeaderBackgroundBrush"] = new SolidColorBrush(newTheme.BaseColorScheme == "Dark" ? Colors.Black : Colors.Black);
        
    }

}
