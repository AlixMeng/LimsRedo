using System;
using System.Windows;
using System.Windows.Controls;

namespace LimsRedo.Views
{
    public partial class EnterDataView : UserControl
    {
        public EnterDataView()
        {
            InitializeComponent();
        }

        Controller controller = new Controller();
        SampleDataAttributes sda = new SampleDataAttributes();
        int sampleType = 0;

        private void AtacCombo_Selected(object sender, RoutedEventArgs e)
        {
            sampleType = 1;
            SpecialLabel1.Content = "Transposase Unit";
            SpecialLabel2.Content = "PCR Cycles";
            //trans-pcr
        }

        private void ChipCombo_Selected(object sender, RoutedEventArgs e)
        {
            sampleType = 2;
            SpecialLabel1.Content = "Antibody";
            SpecialLabel2.Content = "Antibody Lot";
            SpecialLabel3.Content = "Antibody Cat Nr";
            //antix3
        }

        private void HiCombo_Selected(object sender, RoutedEventArgs e)
        {
            sampleType = 3;
            SpecialLabel1.Content = "Restriction Enzyme";
            SpecialLabel2.Content = "PCR Cycles";
            //restEnz-pcr
        }

        private void RnaCombo_Selected(object sender, RoutedEventArgs e)
        {
            sampleType = 4;
            SpecialLabel1.Content = "Prep Type";
            SpecialLabel2.Content = "RIN";
            //prepType-rin
        }

        private void AdaptInterfaceToSampleType()
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
            CommentsLabel.Visibility = Visibility.Visible;
            CommentsText.Visibility = Visibility.Visible;
            AddSampleBtn.Visibility = Visibility.Visible;

            SpecialLabel1.Visibility = Visibility.Visible;
            SpecialLabel2.Visibility = Visibility.Visible;
            SpecialText1.Visibility = Visibility.Visible;
            SpecialText2.Visibility = Visibility.Visible;
            if (sampleType != 2)
            {
                SpecialLabel3.Visibility = Visibility.Hidden;
                SpecialText3.Visibility = Visibility.Hidden;
            }
            else
            {
                SpecialLabel3.Visibility = Visibility.Visible;
                SpecialText3.Visibility = Visibility.Visible;
            }
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
            SpecialText1.Text = string.Empty;
            SpecialText2.Text = string.Empty;
            SpecialText3.Text = string.Empty;
        }

        private void AddSampleBtn_Click(object sender, RoutedEventArgs e)
        {
            if (InputValueIsCompatible())
            {
                sda.GenomeType = GenomeTypeText.Text;
                sda.CellType = CellTypeText.Text;
                sda.Treatment = TreatmentText.Text;
                sda.Condition = ConditionText.Text;
                sda.Concentration = controller.ConvertToDouble(ConcentrationText.Text);
                sda.Volume = controller.ConvertToDouble(VolumeText.Text);
                sda.Initials = InitialsText.Text;
                sda.PIValue = PIValueText.Text;
                sda.Comments = CommentsText.Text;
                sda.DateOfAddition = DateTime.Now.ToString();
                switch (sampleType)
                {
                    case 1:
                        sda.SampleType = "ATAC-Seq";
                        sda.ATACTransposaseUnit = controller.ConvertToDouble(SpecialText1.Text);
                        sda.ATACPCRCycles = controller.ConvertToDouble(SpecialText2.Text);
                        break;
                    case 2:
                        sda.SampleType = "ChIP-Seq";
                        sda.ChIPAntibody = SpecialText1.Text;
                        sda.ChIPAntibodyLot = SpecialText2.Text;
                        sda.ChIPAntibodyCatalogueNumber = SpecialText3.Text;
                        break;
                    case 3:
                        sda.SampleType = "Hi-C";
                        sda.HIRestrictionEnzyme = controller.ConvertToDouble(SpecialText1.Text);
                        sda.HIPCRCycles = controller.ConvertToDouble(SpecialText2.Text);
                        break;
                    case 4:
                        sda.SampleType = "RNA-Seq";
                        sda.RNAPrepType = SpecialText1.Text;
                        sda.RNARIN = SpecialText2.Text;
                        break;
                }
                controller.EnterData(sda);
                ClearTextFields();
            }
            else
            {
                //displayMsgAboutFixingShits!      another class for error msgs '??
                MessageBox.Show("Number fields are not in the correct format");
                //temp
            }
        }

        private bool InputValueIsCompatible()
        {
            if(!controller.CanConvertToDouble(ConcentrationText.Text) || !controller.CanConvertToDouble(VolumeText.Text))
            {
                return false;
            }
            if (sampleType == 1 || sampleType == 3)
            {
                if(!controller.CanConvertToDouble(SpecialText1.Text) || !controller.CanConvertToDouble(SpecialText2.Text))
                {
                    return false;
                }
            }
            return true;
        }

        private void SampleTypeCombobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            AdaptInterfaceToSampleType();
            ClearTextFields();
        }

        private void MenuBtn_Click(object sender, RoutedEventArgs e)
        {
            PageSwitcher.Switch(new MainMenuView());
        }
    }
}
