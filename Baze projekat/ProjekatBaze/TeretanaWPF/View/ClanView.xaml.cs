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
    /// Interaction logic for ClanView.xaml
    /// </summary>
    public partial class ClanView : Window
    {

        public List<Clan> clans = null;

        public Clan clan = null;

        public ProcitajIzBaze procitajDB = new ProcitajIzBaze();
        public IzbrisiIzBaze izbrisiDB = new IzbrisiIzBaze();

        public ClanView()
        {
            InitializeComponent();

            clans = procitajDB.ProcitajClanove();

            dataGrid.ItemsSource = clans;
        }

        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            clan = (Clan)dataGrid.SelectedItem;
        }

        private void dodajButton_Click(object sender, RoutedEventArgs e)
        {
            DodajClanView view = new DodajClanView();
            this.Close();
            view.ShowDialog();
        }

        private void izbrisiButton_Click(object sender, RoutedEventArgs e)
        {
            if ((Clan)dataGrid.SelectedItem != null)
            {
                int id = clan.Kartica;

                int result = izbrisiDB.IzbrisiClana(id);
            }

        }
    }
}
