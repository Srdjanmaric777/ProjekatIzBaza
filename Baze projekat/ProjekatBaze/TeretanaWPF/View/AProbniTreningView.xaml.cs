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
    /// Interaction logic for AProbniTreningView.xaml
    /// </summary>
    public partial class AProbniTreningView : Window
    {

        public List<ProjekatBaze.ProbniTrening> probniTrenings = null;


        public ProjekatBaze.ProbniTrening probni = null;


        public ProcitajIzBaze procitajDB = new ProcitajIzBaze();
        //public IzbrisiIzBaze izbrisiDB = new IzbrisiIzBaze();

        public AProbniTreningView()
        {
            InitializeComponent();

            probniTrenings = procitajDB.ProcitajProbniTrening();

            dataGrid.ItemsSource = probniTrenings;
        }

        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            probni = (ProbniTrening)dataGrid.SelectedItem;
        }

        private void dodajButton_Click(object sender, RoutedEventArgs e)
        {
            ADodajProbniTreningView view = new ADodajProbniTreningView();
            this.Close();
            view.ShowDialog();
        }

        /*private void izbrisiButton_Click(object sender, RoutedEventArgs e)
        {
            if ((CasTreninga)dataGrid.SelectedItem != null)
            {
                int id = casTreninga.IdCasTreninga;

                int result = izbrisiDB.IzbrisiCasTreninga(id);
            }

        }*/
    }
}
