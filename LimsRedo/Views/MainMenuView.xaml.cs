using System.Windows;
using System.Windows.Controls;

namespace LimsRedo.Views
{
    /// <summary>
    /// Interaction logic for MainMenuView.xaml
    /// </summary>
    public partial class MainMenuView : UserControl
    {
        public MainMenuView()
        {
            InitializeComponent();
        }

        private void EnterDataBtn_Click(object sender, RoutedEventArgs e)
        {
            PageSwitcher.Switch(new EnterDataView());
        }

        private void GetDataBtn_Click(object sender, RoutedEventArgs e)
        {
            PageSwitcher.Switch(new GetDataView());
        }
    }
}
