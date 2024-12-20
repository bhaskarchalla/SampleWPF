using System.Windows;
using System.Windows.Input;

namespace Test
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void ToggleLeftPaneButton_Click(object sender, RoutedEventArgs e)
        {
            ToggleLeftPane();
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.SystemKey == Key.LeftAlt || e.SystemKey == Key.RightAlt)
            {
                AltMenu.Visibility = AltMenu.Visibility == Visibility.Visible 
                    ? Visibility.Collapsed
                    : Visibility.Visible;
            }
            else if (e.Key == Key.T && Keyboard.Modifiers == ModifierKeys.Control)
            {
                ToggleLeftPane();
            }
        }

        private void Window_KeyUp(object sender, KeyEventArgs e)
        {
            //if (e.SystemKey == Key.LeftAlt || e.SystemKey == Key.RightAlt)
            //{
            //    AltMenu.Visibility = Visibility.Collapsed;
            //}
        }

        private void ToggleLeftPane()
        {
            if (LeftPaneColumn.Width == new GridLength(0))
            {
                LeftPaneColumn.Width = GridLength.Auto;
                LeftPane.Visibility = Visibility.Visible;
            }
            else
            {
                LeftPaneColumn.Width = new GridLength(0);
                LeftPane.Visibility = Visibility.Collapsed;
            }
        }

        private void Minimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Maximize_Click(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Maximized)
            {
                this.WindowState = WindowState.Normal;
            }
            else
            {
                this.WindowState = WindowState.Maximized;
            }
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}