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
    /// Interaction logic for DodajZaposlenog.xaml
    /// </summary>
    public partial class DodajZaposlenog : Window
    {
        public DodajUBazu addDB = new DodajUBazu();


        public DodajZaposlenog()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            if (validate())
            {

                int idBedz = Convert.ToInt32(textBox.Text);
                string ime = textBox1.Text;
                string prezime = textBox2.Text;
                string tip = comboBox.Text;

                //string sertifikat = " ";

                //if (textBox3.Text != string.Empty)
                //  sertifikat = textBox3.Text;

                //int oprema = 22;
                //if (textBox4.Text != string.Empty)
                //{
                //  oprema = Convert.ToInt32(textBox4.Text);
                //}

                int result = addDB.DodajZaposlenog(idBedz, ime, prezime, tip/*, sertifikat, oprema*/);
            }
            else
            {
                MessageBox.Show("Polja nisu dobro popunjena!", "Greska!", MessageBoxButton.OK, MessageBoxImage.Error);
            }


        }



        private void goBackButton_Click(object sender, RoutedEventArgs e)
        {
            View.Zaposleni view = new View.Zaposleni();
            this.Close();
            view.ShowDialog();
        }

        private bool validate()
        {
            bool result = true;

            if (textBox.Text.Trim().Equals(""))
            {
                result = false;
            }
            else
            {
                try
                {
                    if (Int32.Parse(textBox.Text) < 0)
                    {
                        result = false;
                    }
                }
                catch (Exception)
                {
                    result = false;

                }

            }

            if (textBox1.Text.Trim().Equals(""))
            {
                result = false;
            }

            if (textBox2.Text.Trim().Equals(""))
            {
                result = false;
            }

            if (comboBox.SelectedItem == null)
            {
                result = false;
            }

            return result;
        }
    }
}
