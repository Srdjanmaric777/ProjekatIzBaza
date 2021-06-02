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
    /// Interaction logic for DodajOpremuUTeretaniView.xaml
    /// </summary>
    public partial class DodajOpremuUTeretaniView : Window
    {

        public DodajUBazu addDB = new DodajUBazu();


        public DodajOpremuUTeretaniView()
        {
            InitializeComponent();
        }


        private void addButton_Click(object sender, RoutedEventArgs e)
        {

            int id = Convert.ToInt32(textBox.Text);
            string naziv = textBox1.Text;
            int kolicina = Convert.ToInt32(textBox2.Text);

            int result = addDB.DodajOpremu(id, naziv, kolicina);

        }



        private void goBackButton_Click(object sender, RoutedEventArgs e)
        {
            OpremaUTeretaniView view = new OpremaUTeretaniView();
            this.Close();
            view.ShowDialog();
        }


    }
}
