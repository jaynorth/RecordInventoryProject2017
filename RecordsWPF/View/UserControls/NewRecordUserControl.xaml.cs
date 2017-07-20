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
        public NewRecordUserControl()
        {
            InitializeComponent();
            DataContext = new NewRecordViewModel();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Add Text to ComboBox ListArtist
            String artistName = artistTextBox.Text;
            NewRecordViewModel n = new NewRecordViewModel();
            n.Add(artistName);
            artistTextBox.Clear();

        }
    }
}
