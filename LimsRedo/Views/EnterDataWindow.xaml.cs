﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace LimsRedo
{
    /// <summary>
    /// Interaction logic for EnterData.xaml
    /// </summary>
    public partial class EnterData : Window
    {
        int sampleType;
        public EnterData()
        {
            InitializeComponent();
        }

        private void AtacCombo_Selected(object sender, RoutedEventArgs e)
        {
            sampleType = 1;
            //showRelevantFields.
            //referToTheCheatSheet...
            //calledSpecialLabel&&SpecialText...try to databind it instead of doing it  here.....
        }

        private void ChipCombo_Selected(object sender, RoutedEventArgs e)
        {
            sampleType = 2;
        }

        private void HiCombo_Selected(object sender, RoutedEventArgs e)
        {
            sampleType = 3;
        }

        private void RnaCombo_Selected(object sender, RoutedEventArgs e)
        {
            sampleType = 4;
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

            //vantar comments..
        }

        private void ClearCommonFields()
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

        private void ClearSpecialFields(int sampleType) //1.atac,2.chip,3.hic,4.rna
        {
            //same as in the selectors...
        }
    }
}
}
