using ControlzEx.Theming;
using MahApps.Metro.Controls;
using System.Windows;

namespace Sample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            var theme = ThemeManager.Current.DetectTheme(Application.Current);
            if (theme != null && theme.BaseColorScheme.Contains("Dark"))
            {
                ThemeToggleButton.IsChecked = false;
                ThemeToggleButton.Content = "☀";
            }
            else
            {
                ThemeToggleButton.IsChecked = true;
                ThemeToggleButton.Content = "🌙";
            }
        }
        private void ThemeToggleButton_Checked(object sender, RoutedEventArgs e)
        {
            // Switch to light theme
            ThemeManager.Current.ChangeThemeBaseColor(Application.Current, "Light");
            //ThemeManager.Current.ChangeTheme(Application.Current, "Light.Blue");
            ThemeToggleButton.Content = "🌙";
        }

        private void ThemeToggleButton_Unchecked(object sender, RoutedEventArgs e)
        {
            // Switch to dark theme
            ThemeManager.Current.ChangeThemeBaseColor(Application.Current, "Dark");
            //ThemeManager.Current.ChangeTheme(Application.Current, "Dark.Blue");
            ThemeToggleButton.Content = "☀";
        }

        private void ExitMenuItem_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void AboutMenuItem_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Your application version info.", "About", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}