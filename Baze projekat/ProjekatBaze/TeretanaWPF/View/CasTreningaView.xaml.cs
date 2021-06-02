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
    /// Interaction logic for CasTreningaView.xaml
    /// </summary>
    public partial class CasTreningaView : Window
    {

        public List<ProjekatBaze.CasTreninga> casTreningas = null;


        public ProjekatBaze.CasTreninga casTreninga = null;


        public ProcitajIzBaze procitajDB = new ProcitajIzBaze();
        public IzbrisiIzBaze izbrisiDB = new IzbrisiIzBaze();


        public CasTreningaView()
        {
            InitializeComponent();

            casTreningas = procitajDB.ProcitajCasTreninga();

            dataGrid.ItemsSource = casTreningas;
        }

        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            casTreninga = (CasTreninga)dataGrid.SelectedItem;
        }

        private void dodajButton_Click(object sender, RoutedEventArgs e)
        {
            DodajCasTreningaView view = new DodajCasTreningaView();
            this.Close();
            view.ShowDialog();
        }

        private void izbrisiButton_Click(object sender, RoutedEventArgs e)
        {
            if ((CasTreninga)dataGrid.SelectedItem != null)
            {
                int id = casTreninga.IdCasTreninga;

                int result = izbrisiDB.IzbrisiCasTreninga(id);
            }

        }
    }
}
