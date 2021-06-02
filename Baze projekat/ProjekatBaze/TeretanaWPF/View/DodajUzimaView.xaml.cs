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
    /// Interaction logic for DodajUzimaView.xaml
    /// </summary>
    public partial class DodajUzimaView : Window
    {
        public DodajUBazu addDB = new DodajUBazu();
        public ProcitajIzBaze procitajDB = new ProcitajIzBaze();

        List<CasTreninga> procitajIzBazes = new List<CasTreninga>();
        List<int> lista = new List<int>();
        List<Clan> clanovi = new List<Clan>();
        List<int> lista2 = new List<int>();

        public DodajUzimaView()
        {
            InitializeComponent();

            procitajIzBazes = procitajDB.ProcitajCasTreninga();

            foreach (var item in procitajIzBazes)
            {
                lista.Add(item.IdCasTreninga);
            }

            clanovi = procitajDB.ProcitajClanove();
            foreach (var item in clanovi)
            {
                lista2.Add(item.Kartica);
            }

            comboBox1.ItemsSource = lista;
            comboBox2.ItemsSource = lista2;
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            if(validate())
            {
                int idCas = Convert.ToInt32(comboBox1.Text);
                int idClan = Convert.ToInt32(comboBox2.Text);
                int result = addDB.DodajUzima(idCas, idClan);
            }
            else
            {
                MessageBox.Show("Polja nisu dobro popunjena!", "Greska!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }



        private void goBackButton_Click(object sender, RoutedEventArgs e)
        {
            UzimaView view = new UzimaView();
            this.Close();
            view.ShowDialog();
        }

        private bool validate()
        {
            bool result = true;

            if (comboBox1.SelectedItem == null)
            {
                result = false;
            }

            if (comboBox2.SelectedItem == null)
            {
                result = false;
            }

            return result;
        }
    }
}
