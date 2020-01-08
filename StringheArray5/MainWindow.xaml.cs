using System;
using System.Collections.Generic;
using System.IO;
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

namespace StringheArray5
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
        int c = 0;
        string[] mess = new string[5];
        private void btn_inser_Click(object sender, RoutedEventArgs e)
        {
            c++;
            for (int i = 0; i < 5; i++)
                mess[c - 1] = txt_stringa.Text;
            if(c==5)
            {
               btn_inser.IsEnabled = false;
               btn_pubblica.IsEnabled = true;
               btn_stampa.IsEnabled = true;
            }
            txt_stringa.Clear();
        }

        private void btn_stampa_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                lbl_ris.Content += $" {i+1}° {mess[i]} \n";
            }
                       
        }

        private void btn_pubblica_Click(object sender, RoutedEventArgs e)
        {
            StreamWriter sw = new StreamWriter("pubblica.txt", false, Encoding.UTF8);
            sw.WriteLine(5);
            for (int i = 0; i < 5; i++)
            {
                sw.WriteLine( $" {i + 1}° {mess[i]} \n");
            }
            
            sw.Flush();
            sw.Close();

        }
    }
}
