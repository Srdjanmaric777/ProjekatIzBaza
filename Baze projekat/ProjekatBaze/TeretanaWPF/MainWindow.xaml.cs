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
using System.Windows.Navigation;
using System.Windows.Shapes;
using TeretanaWPF.View;

namespace TeretanaWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void teretanaButton_Click(object sender, RoutedEventArgs e)
        {
            TeretaneView view = new TeretaneView();
            view.ShowDialog();
        }

        public void zaposleniButton_Click(object sender, RoutedEventArgs e)
        {
            View.Zaposleni view = new View.Zaposleni();
            view.ShowDialog();
        }

        public void casTreningaButton_Click(object sender, RoutedEventArgs e)
        {
            View.CasTreningaView view = new View.CasTreningaView();
            view.ShowDialog();
        }

        public void clanButton_Click(object sender, RoutedEventArgs e)
        {
            View.ClanView view = new View.ClanView();
            view.ShowDialog();
        }

        public void obicanVezbacButton_Click(object sender, RoutedEventArgs e)
        {
            View.ObicanVezbacView view = new View.ObicanVezbacView();
            view.ShowDialog();
        }

        public void uzimaButton_Click(object sender, RoutedEventArgs e)
        {
            View.UzimaView view = new View.UzimaView();
            view.ShowDialog();
        }

        public void ideButton_Click(object sender, RoutedEventArgs e)
        {
            View.IdeView view = new View.IdeView();
            view.ShowDialog();
        }


        public void probniTreningButton_Click(object sender, RoutedEventArgs e)
        {
            View.AProbniTreningView view = new View.AProbniTreningView();
            view.ShowDialog();
        }


        public void radiButton_Click(object sender, RoutedEventArgs e)
        {
            View.RadiView view = new View.RadiView();
            view.ShowDialog();
        }


        public void opremaButton_Click(object sender, RoutedEventArgs e)
        {
            View.OpremaUTeretaniView view = new View.OpremaUTeretaniView();
            view.ShowDialog();
        }


    }
}
