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
    /// Interaction logic for DodajTeretanuView.xaml
    /// </summary>
    public partial class DodajTeretanuView : Window
    {

        public DodajUBazu addDB = new DodajUBazu();


        public DodajTeretanuView()
        {
            InitializeComponent();
        }



        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            if(validate())
            {
            int id = Convert.ToInt32(textBox.Text);
            string naziv = textBox1.Text;
            int brojTelefona = Convert.ToInt32(textBox2.Text);

            //string menadzer = comboBox.Text;

            //string[] words_splitMenadzer = menadzer.Split(' ');
            //int idMenadzer = Convert.ToInt32(words_splitMenadzer[1]);

            int result = addDB.DOdajTeretanu(id, naziv, brojTelefona/*, idMenadzer*/);
            }
            else
            {
                MessageBox.Show("Polja nisu dobro popunjena!", "Greska!", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void goBackButton_Click(object sender, RoutedEventArgs e)
        {
            TeretaneView view = new TeretaneView();
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
            else
            {
                try
                {
                    if (Int32.Parse(textBox2.Text) < 0)
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
