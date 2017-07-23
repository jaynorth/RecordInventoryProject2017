using RecordsDataModel.EntityModels;
using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Viewmodel.ViewModel;

namespace RecordsWPF.View.UserControls
{
    /// <summary>
    /// Logique d'interaction pour NewRecordUserControl.xaml
    /// </summary>
    public partial class NewRecordUserControl : UserControl
    {
        private NewRecordViewModel newRecord;
        public NewRecordUserControl()
        {
            InitializeComponent();
            newRecord = new NewRecordViewModel();
            DataContext = newRecord;
        }

        public object CurrentRecord { get; private set; }

        private void artistsCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = artistsCombo.SelectedIndex;
            newRecord.CurrentRecord.ArtistId = newRecord.ListArtists[index].Id;

        }

        private void genresCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = genresCombo.SelectedIndex;
            newRecord.CurrentRecord.GenreID = newRecord.ListGenres[index].Id;
        }

        private void labelsCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = labelsCombo.SelectedIndex;
            newRecord.CurrentRecord.LabelId = newRecord.ListLabels[index].Id;
        }

        private void countriesCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = countriesCombo.SelectedIndex;
            newRecord.CurrentRecord.CountryId = newRecord.ListCountries[index].Id;
        }

        private void albumNameTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            newRecord.CurrentRecord.Title = albumNameTextBox.Text;
        }

        private void ReleaseMonthCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = ReleaseMonthCombo.SelectedIndex;
           
            newRecord.CurrentRecord.ReleaseMonth = newRecord.MonthsArray[index];
           // MessageBox.Show(newRecord.CurrentRecord.ReleaseMonth);
        }

        private void releaseYear_TextChanged(object sender, TextChangedEventArgs e)
        {
            newRecord.CurrentRecord.ReleaseYear = releaseYear.Text;
           // MessageBox.Show(newRecord.CurrentRecord.ReleaseYear);
        }
    }
}
