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
    /// Interaction logic for TeretaneView.xaml
    /// </summary>
    public partial class TeretaneView : Window
    {

        public List<Teratana> teretane = null;

        public Teratana teretana = null;

        public ProcitajIzBaze procitajDB = new ProcitajIzBaze();
        public IzbrisiIzBaze izbrisiDB = new IzbrisiIzBaze();


        public TeretaneView()
        {
            InitializeComponent();

            teretane = procitajDB.ProcitajTeretanu();

            dataGrid.ItemsSource = teretane;
        }

        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            teretana = (Teratana)dataGrid.SelectedItem;
        }

        private void dodajButton_Click(object sender, RoutedEventArgs e)
        {
            DodajTeretanuView view = new DodajTeretanuView();
            this.Close();
            view.ShowDialog();
        }

        private void izbrisiButton_Click(object sender, RoutedEventArgs e)
        {
            if ((Teratana)dataGrid.SelectedItem != null)
            {
                int id = teretana.Lokacija;

                int result = izbrisiDB.IzbrisiTeretanu(id);
            }
        }
    }
}
