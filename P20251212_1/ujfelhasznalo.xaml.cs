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
using System.IO;

namespace P20251212_1
{
    /// <summary>
    /// Interaction logic for ujfelhasznalo.xaml
    /// </summary>
    public partial class ujfelhasznalo : Window
    {
        public string ujfnev = "";
        public string ujjelszo = "";
        public ujfelhasznalo()
        {
            InitializeComponent();
        }

        private void btnUjIn_Click(object sender, RoutedEventArgs e)
        {
            
            string ujfnev = Textujfnev.Text;
            string ujjelszo = ujpasswd.Password;
            MessageBox.Show("Sikeres regisztráció!");
            FileStream f = new FileStream("adat.txt", FileMode.Create);
            StreamWriter iras = new StreamWriter(f);
            iras.WriteLine(ujfnev);
            iras.WriteLine(ujjelszo);
            iras.Close();
            f.Close();
        }
    }
}
