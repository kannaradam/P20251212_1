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

namespace P20251212_1
{
    /// <summary>
    /// Interaction logic for login.xaml
    /// </summary>
    public partial class login : Window
    {
        const string felhasznalo = "info";
        const string jelszo = "Premo900";
        public login()
        {
            InitializeComponent();
        }

        private void btnIn_Click(object sender, RoutedEventArgs e)
        {
            if (felhasznalo == Textfnev.Text && jelszo == userpasswd.Password)
            {
                MessageBox.Show("Sikeres belépés!");
            }
            else
            {
                MessageBox.Show("Sikertelen belépés!");
            }
        }

        private void btnElf_Click(object sender, RoutedEventArgs e)
        {
            ujfelhasznalo uji = new ujfelhasznalo();
            uji.Show();
        }
    }
}
