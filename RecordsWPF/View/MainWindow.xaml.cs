using RecordsDataModel.EntityModels;
using RecordsWPF.View.UserControls;
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
using Viewmodel;

namespace RecordsWPF
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private NewRecordUserControl nruc;
        public MainWindow()
        {
            InitializeComponent();

            nruc = null;
    

            
            
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            if (nruc == null)
            {
                nruc = new NewRecordUserControl();

            }

            StackMainFrame.Children.Clear();
            StackMainFrame.Children.Add(nruc);
        }
    }
}
