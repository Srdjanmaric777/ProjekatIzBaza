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
    /// Interaction logic for Zaposleni.xaml
    /// </summary>
    public partial class Zaposleni : Window
    {

        public List<ProjekatBaze.Zaposleni> zaposlenis = null;

        //public List<ProjekatBaze.Trener> treners = null;

        public ProjekatBaze.Zaposleni zaposleni = null;

        //public ProjekatBaze.Trener trener = null;

        public ProcitajIzBaze procitajDB = new ProcitajIzBaze();
        public IzbrisiIzBaze izbrisiDB = new IzbrisiIzBaze();


        public Zaposleni()
        {
            InitializeComponent();

            zaposlenis = procitajDB.ProcitajZaposlenog();

            //treners = procitajDB.ProcitajZaposlenog();

            dataGrid.ItemsSource = zaposlenis;

        }

        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            zaposleni = (ProjekatBaze.Zaposleni)dataGrid.SelectedItem;
        }

        private void dodajButton_Click(object sender, RoutedEventArgs e)
        {
            DodajZaposlenog view = new DodajZaposlenog();
            this.Close();
            view.ShowDialog();
        }

        private void izbrisiButton_Click(object sender, RoutedEventArgs e)
        {
            if ((ProjekatBaze.Zaposleni)dataGrid.SelectedItem != null)
            {
                int id = zaposleni.IdBedz;

                int result = izbrisiDB.IzbrisiZaposlenog(id);
            }

        }
    }
}
