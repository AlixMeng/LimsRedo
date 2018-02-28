using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace LimsRedo.Views
{
    /// <summary>
    /// Interaction logic for GetDataView.xaml
    /// </summary>
    public partial class GetDataView : UserControl
    {
        Controller controller = new Controller();
        SearchParameters sp = new SearchParameters();

        public GetDataView()
        {
            InitializeComponent();
        }
        string comboboxValue;

        private void SearchTypeCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem item = (ComboBoxItem)SearchTypeCombo.SelectedItem;
            comboboxValue = item.Content.ToString();
        }

        private void SearchBtn_Click(object sender, RoutedEventArgs e)
        {
            string searchParameter = string.Empty;
            string searchValue = SearchValueTxt.Text;
            //int idValue = Convert.ToInt32(searchValue);//make great again
            List<string> resultList = new List<string>();

            switch (comboboxValue)
            {
                case "ID":
                    searchParameter = "ID";
                    break;
                case "Initials":
                    searchParameter = sp.initials;
                    break;
                case "PI Value":
                    searchParameter = sp.pi;
                    break;
                case "Cell Type":
                    searchParameter = sp.cellType;
                    break;
                case "Treatment":
                    searchParameter = sp.treatment;
                    break;
                case "Condition":
                    searchParameter = sp.condition;
                    break;
                case "Antibody":
                    searchParameter = sp.antibody;
                    break;
            }

            if(searchParameter == "ID")
            {
                if (controller.CanConvertToDouble(searchValue))//if it converts to double it converts to int.
                {
                    resultList = controller.GetSampleByID(Convert.ToInt32(searchValue));
                }
                else
                {
                    //errorMsg wrong format
                }
            }
            else
            {
                resultList = controller.GetSampleByValue(searchValue, searchParameter);
            }

            ResultListBox.ItemsSource = resultList;
        }

        private void MenuBtn_Click(object sender, RoutedEventArgs e)
        {
            PageSwitcher.Switch(new MainMenuView());
        }
    }
}
