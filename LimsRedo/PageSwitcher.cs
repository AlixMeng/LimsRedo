using System.Windows.Controls;

namespace LimsRedo
{
    class PageSwitcher
    {
        public static MainWindow mainWindow;

        public static void Switch(UserControl newPage)
        {
            mainWindow.Navigate(newPage);
        }
    }
}
