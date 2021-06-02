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
    /// Interaction logic for DodajRadiView.xaml
    /// </summary>
    public partial class DodajRadiView : Window
    {

        public DodajUBazu addDB = new DodajUBazu();
        public ProcitajIzBaze procitajDB = new ProcitajIzBaze();

        List<Teratana> procitajIzBazes = new List<Teratana>();
        List<int> lista = new List<int>();
        List<ProjekatBaze.Zaposleni> zaposleni = new List<ProjekatBaze.Zaposleni>();
        List<int> lista2 = new List<int>();


        public DodajRadiView()
        {
            InitializeComponent();

            procitajIzBazes = procitajDB.ProcitajTeretanu();

            foreach (var item in procitajIzBazes)
            {
                lista.Add(item.Lokacija);
            }

            zaposleni = procitajDB.ProcitajZaposlenog();
            foreach (var item in zaposleni)
            {
                lista2.Add(item.IdBedz);
            }

            comboBox1.ItemsSource = lista;
            comboBox2.ItemsSource = lista2;
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            int idTeretana = Convert.ToInt32(comboBox1.Text);
            int idZaposleni = Convert.ToInt32(comboBox2.Text);
            int result = addDB.DodajIde(idTeretana, idZaposleni);
        }

        private void goBackButton_Click(object sender, RoutedEventArgs e)
        {
            RadiView view = new RadiView();
            this.Close();
            view.ShowDialog();
        }
    }
}
