using System.Windows;
using System.Windows.Controls;

namespace LimsRedo.Views
{
    /// <summary>
    /// Interaction logic for EnterDataView.xaml
    /// </summary>
    public partial class EnterDataView : UserControl
    {
        
        public EnterDataView()
        {
            InitializeComponent();
        }

        SampleDataAttributes sa = new SampleDataAttributes();
        int sampleType;

        private void AtacCombo_Selected(object sender, RoutedEventArgs e)
        {
            sampleType = 0;
            //trans-pcr
        }

        private void ChipCombo_Selected(object sender, RoutedEventArgs e)
        {
            sampleType = 1;
            //antix3
        }

        private void HiCombo_Selected(object sender, RoutedEventArgs e)
        {
            sampleType = 2;
            //restEnz-pcr
        }

        private void RnaCombo_Selected(object sender, RoutedEventArgs e)
        {
            sampleType = 3;
            //prepType-rin
        }

        private void ShowCommonEntry()
        {
            GenomeTypeLabel.Visibility = Visibility.Visible;
            GenomeTypeText.Visibility = Visibility.Visible;
            CellTypeLabel.Visibility = Visibility.Visible;
            CellTypeText.Visibility = Visibility.Visible;
            TreatmentLabel.Visibility = Visibility.Visible;
            TreatmentText.Visibility = Visibility.Visible;
            ConditionLabel.Visibility = Visibility.Visible;
            ConditionText.Visibility = Visibility.Visible;
            ConcentrationLabel.Visibility = Visibility.Visible;
            ConcentrationText.Visibility = Visibility.Visible;
            VolumeLabel.Visibility = Visibility.Visible;
            VolumeText.Visibility = Visibility.Visible;
            InitialsLabel.Visibility = Visibility.Visible;
            InitialsText.Visibility = Visibility.Visible;
            PIValueLabel.Visibility = Visibility.Visible;
            PIValueText.Visibility = Visibility.Visible;
        }

        private void ClearTextFields()
        {
            GenomeTypeText.Text = string.Empty;
            CellTypeText.Text = string.Empty;
            TreatmentText.Text = string.Empty;
            ConditionText.Text = string.Empty;
            ConcentrationText.Text = string.Empty;
            VolumeText.Text = string.Empty;
            InitialsText.Text = string.Empty;
            PIValueText.Text = string.Empty;
        }
    }
}
