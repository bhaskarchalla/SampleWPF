using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace sample2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            submenuPopup.CustomPopupPlacementCallback = new CustomPopupPlacementCallback(PlacePopup);
        }

        private CustomPopupPlacement[] PlacePopup(Size popupSize, Size targetSize, Point offset)
        {
            // Adjust the popup position relative to the menu item
            CustomPopupPlacement placement1 = new CustomPopupPlacement(new Point(0, targetSize.Height), PopupPrimaryAxis.Vertical);
            return new CustomPopupPlacement[] { placement1 };
        }

    }
}