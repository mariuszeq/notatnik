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

namespace notatnik
{
    /// <summary>
    /// Logika interakcji dla klasy Kolor.xaml
    /// </summary>
    public partial class Kolor : Window
    {
        public byte R {  get; set; }
        public byte G {  get; set; }
        public byte B {  get; set; }
        public Kolor()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Kolor Kolor = new Kolor();
            byte r = 0;
            if(byte.TryParse(Label_R.Text, out r))
            {
                R = r;
            }

            byte g = 0;
            if (byte.TryParse(Label_G.Text, out g))
            {
                G = g;
            }

            byte b = 0;
            if (byte.TryParse(Label_B.Text, out b))
            {
                B = b;
            }

            Close();
        }
    }
}
