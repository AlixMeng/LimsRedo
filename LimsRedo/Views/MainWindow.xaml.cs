using LimsRedo.Views;
using System.Windows;
using System.Windows.Controls;
//using LimsRedo.ViewModels;

namespace LimsRedo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            PageSwitcher.mainWindow = this;
            PageSwitcher.Switch(new MainMenuView());
        }

        public void Navigate(UserControl nextPage)
        {
            this.Content = nextPage;
        }

    }
}
