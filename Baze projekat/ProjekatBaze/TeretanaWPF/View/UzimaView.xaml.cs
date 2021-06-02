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
    /// Interaction logic for UzimaView.xaml
    /// </summary>
    public partial class UzimaView : Window
    {
        public List<ProjekatBaze.Uzima> uzimas = null;


        public ProjekatBaze.Uzima uzima = null;


        public ProcitajIzBaze procitajDB = new ProcitajIzBaze();
        public IzbrisiIzBaze izbrisiDB = new IzbrisiIzBaze();

        public UzimaView()
        {
            InitializeComponent();

            uzimas = procitajDB.ProcitajUzima();

            dataGrid.ItemsSource = uzimas;
        }

        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            uzima = (Uzima)dataGrid.SelectedItem;
        }

        private void dodajButton_Click(object sender, RoutedEventArgs e)
        {
            DodajUzimaView view = new DodajUzimaView();
            this.Close();
            view.ShowDialog();
        }

        private void izbrisiButton_Click(object sender, RoutedEventArgs e)
        {
            if ((Uzima)dataGrid.SelectedItem != null)
            {
                int id = uzima.CasTreningaIdCasTreninga;

                int result = izbrisiDB.IzbrisiCasTreninga(id);
            }

        }
    }
}
