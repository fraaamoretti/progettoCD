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

namespace progettoCD
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        bool flag = true;
        List<brano> listaBrani = new List<brano>();
        cd disco; //un solo disco inizializzato quando clicco il bottone;

        private void btnCreaBrano_Click(object sender, RoutedEventArgs e)
        {
            if (flag)
            {
                MessageBox.Show("compila i campi di testo per titolo autore e durata");
                flag = false;
            }
            else
            {
                brano br = new brano(txtTitolo.Text, txtAutore.Text, txtDurata.Text);
                MessageBox.Show("titolo = " + br.getTitolo().ToString());
                MessageBox.Show("autore = " + br.getAutore().ToString());
                MessageBox.Show("durata = " + br.getDurata().ToString());
                /*
                br.setTitolo("titolo");
                br.setAutore("autore");
                br.setDurata("1212");
                */
                flag = true;   
            }
        }

        private void btnCreaCD_Click(object sender, RoutedEventArgs e)
        {
            if (flag)
            {
                MessageBox.Show("compila i campi di testo per titolo e autore");
                flag = false;
            }
            else
            {
                disco = new cd(txtTitolo.Text, txtAutore.Text);
                MessageBox.Show("titolo = " + br.getTitolo().ToString());
                MessageBox.Show("autore = " + br.getAutore().ToString());
                MessageBox.Show("durata = " + br.getDurata().ToString());
                /*
                disco.setTitolo("titolo");
                disco.setAutore("autore");
                */
                flag = true; 
            }
        }
    }
}
