using ProjekatBaze;
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
using System.Windows.Shapes;
using TeretanaWPF.Baza;

namespace TeretanaWPF.View
{
    /// <summary>
    /// Interaction logic for OpremaUTeretaniView.xaml
    /// </summary>
    public partial class OpremaUTeretaniView : Window
    {
        public List<OpremaUteretani> opremaUteretanis = null;

        public OpremaUteretani opremaUteretani = null;

        public ProcitajIzBaze procitajDB = new ProcitajIzBaze();

        public OpremaUTeretaniView()
        {
            InitializeComponent();

            opremaUteretanis = procitajDB.ProcitajOpremu();

            dataGrid.ItemsSource = opremaUteretanis;
        }

        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            opremaUteretani = (OpremaUteretani)dataGrid.SelectedItem;
        }

        private void dodajButton_Click(object sender, RoutedEventArgs e)
        {
            DodajOpremuUTeretaniView view = new DodajOpremuUTeretaniView();
            this.Close();
            view.ShowDialog();
        }
    }
}
