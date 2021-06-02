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
    /// Interaction logic for ObicanVezbacView.xaml
    /// </summary>
    public partial class ObicanVezbacView : Window
    {

        public List<ObicanVezbac> obicanVezbacs = null;

        public ObicanVezbac obicanVezbac = null;

        public ProcitajIzBaze procitajDB = new ProcitajIzBaze();
        public IzbrisiIzBaze izbrisiDB = new IzbrisiIzBaze();


        public ObicanVezbacView()
        {
            InitializeComponent();

            obicanVezbacs = procitajDB.ProcitajVezbace();

            dataGrid.ItemsSource = obicanVezbacs;
        }

        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            obicanVezbac = (ObicanVezbac)dataGrid.SelectedItem;
        }

        private void dodajButton_Click(object sender, RoutedEventArgs e)
        {
            DodajObicnogVezbacaView view = new DodajObicnogVezbacaView();
            this.Close();
            view.ShowDialog();
        }

        private void izbrisiButton_Click(object sender, RoutedEventArgs e)
        {
            if ((ObicanVezbac)dataGrid.SelectedItem != null)
            {
                int id = obicanVezbac.IdObicanVezbac;

                int result = izbrisiDB.IzbrisiVezbaca(id);
            }

        }
    }
}
