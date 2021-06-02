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
    /// Interaction logic for DodajClanView.xaml
    /// </summary>
    public partial class DodajClanView : Window
    {
        public DodajUBazu addDB = new DodajUBazu();

        public DodajClanView()
        {
            InitializeComponent();
        }


        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            if (validate())
            {
                int id = Convert.ToInt32(textBox.Text);
                string ime = textBox1.Text;
                string prezime = textBox2.Text;
                int oprema = Convert.ToInt32(textBox3.Text);

                int result = addDB.DodajClana(id, ime, prezime, oprema);
            }
            else
            {
                MessageBox.Show("Polja nisu dobro popunjena!", "Greska!", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }


        private void goBackButton_Click(object sender, RoutedEventArgs e)
        {
            ClanView view = new ClanView();
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

            if (textBox3.Text.Trim().Equals(""))
            {
                result = false;
            }
            else
            {
                try
                {
                    if (Int32.Parse(textBox3.Text) < 0)
                    {
                        result = false;
                    }
                }
                catch (Exception)
                {
                    result = false;
                }

            }

            return result;
        }
    }
}
