using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace tanulosProjektMatematika
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<int> hasznaltIndexek = new List<int>();
        private List<string> adottValaszok = new List<string>();
        private string felhasznaloNev;
        private int kerdesSzama = 0;
        private bool advaVanValasz;
        private string kivalasztottValasz;
        private string helyesValasz;
        public MainWindow()
        {
            InitializeComponent();
            randomKerdesKiiras();
        }

        private void randomKerdesKiiras()
        {
            if (kerdesSzama == 11)
            {
                kerdesekGrid.Visibility = Visibility.Hidden;
                osszegzesGrid.Visibility = Visibility.Visible;
            }
            else
            {
                if (kerdesSzama == 10)
                {
                    kovetkezoKerdesButton.Content = "Válaszok beküldése";
                }
                fajlBeolvasas be = new fajlBeolvasas();
                Random random = new Random();
                int i;
                do
                {
                    i = random.Next(be.kerdesek.Count);

                }
                while (hasznaltIndexek.Contains(i));
                hasznaltIndexek.Add(i);


                kerdesText.Text = be.kerdesek[i].getKerdes();
                valaszButtonA.Content = be.kerdesek[i].getValaszA();
                valaszButtonB.Content = be.kerdesek[i].getValaszB();
                valaszButtonC.Content = be.kerdesek[i].getValaszC();
                valaszButtonD.Content = be.kerdesek[i].getValaszD();
                helyesValasz = be.kerdesek[i].getValaszHelyes();
                kerdesSzama++;
            }
        }

        private void inditasButton_Click(object sender, RoutedEventArgs e)
        {
            if (nevTextBox.Text != "")
            {
                nevElmentesTeszt.Text = nevTextBox.Text;
                felhasznaloNev = nevTextBox.Text;
                kezdoGrid.Visibility = Visibility.Hidden;
                kerdesekGrid.Visibility = Visibility.Visible;
            }
            else
            {
                MessageBox.Show("Kérlek add meg a neved", "Hibás név", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void kovetkezoKerdesButton_Click(object sender, RoutedEventArgs e)
        {
            if (advaVanValasz)
            {
                adottValaszok.Add($"{kerdesText.Text} | {kivalasztottValasz} | {helyesValasz}");
                randomKerdesKiiras();
            }
            else
            {
                MessageBox.Show("Először válassz egy válaszlehetőséget.", "Nincs kiválasztva egy válaszlehetőség sem.", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void valaszButtonA_Click(object sender, RoutedEventArgs e)
        {
            if (advaVanValasz)
            {
                advaVanValasz = false;
                valaszButtonA.Background = (Brush)new BrushConverter().ConvertFrom("#CCFFCC");
                valaszButtonB.Background = (Brush)new BrushConverter().ConvertFrom("#CCFFCC");
                valaszButtonC.Background = (Brush)new BrushConverter().ConvertFrom("#CCFFCC");
                valaszButtonD.Background = (Brush)new BrushConverter().ConvertFrom("#CCFFCC");
                kovetkezoKerdesButton.Background = (Brush)new BrushConverter().ConvertFrom("#888888");;
                kovetkezoKerdesButton.Cursor = Cursors.Cross;
                kivalasztottValasz = "";
            }
            else
            {
                advaVanValasz = true;
                valaszButtonA.Background = (Brush)new BrushConverter().ConvertFrom("#CCCFFC");;
                valaszButtonB.Background = (Brush)new BrushConverter().ConvertFrom("#CCFFCC");
                valaszButtonC.Background = (Brush)new BrushConverter().ConvertFrom("#CCFFCC");
                valaszButtonD.Background = (Brush)new BrushConverter().ConvertFrom("#CCFFCC");
                kovetkezoKerdesButton.Background = (Brush)new BrushConverter().ConvertFrom("#CCFFCC");
                kovetkezoKerdesButton.Cursor = Cursors.Arrow;
                kivalasztottValasz = valaszButtonA.Content.ToString();
            }
        }

        private void valaszButtonB_Click(object sender, RoutedEventArgs e)
        {
            if (advaVanValasz)
            {
                advaVanValasz = false;
                valaszButtonA.Background = (Brush)new BrushConverter().ConvertFrom("#CCFFCC");
                valaszButtonB.Background = (Brush)new BrushConverter().ConvertFrom("#CCFFCC");
                valaszButtonC.Background = (Brush)new BrushConverter().ConvertFrom("#CCFFCC");
                valaszButtonD.Background = (Brush)new BrushConverter().ConvertFrom("#CCFFCC");
                kovetkezoKerdesButton.Background = (Brush)new BrushConverter().ConvertFrom("#888888");;
                kovetkezoKerdesButton.Cursor = Cursors.Cross;
                kivalasztottValasz = "";
            }
            else
            {
                advaVanValasz = true;
                valaszButtonA.Background = (Brush)new BrushConverter().ConvertFrom("#CCFFCC");
                valaszButtonB.Background = (Brush)new BrushConverter().ConvertFrom("#CCCFFC");;
                valaszButtonC.Background = (Brush)new BrushConverter().ConvertFrom("#CCFFCC");
                valaszButtonD.Background = (Brush)new BrushConverter().ConvertFrom("#CCFFCC");
                kovetkezoKerdesButton.Background = (Brush)new BrushConverter().ConvertFrom("#CCFFCC");
                kovetkezoKerdesButton.Cursor = Cursors.Arrow;
                kivalasztottValasz = valaszButtonB.Content.ToString();
            }
        }

        private void valaszButtonC_Click(object sender, RoutedEventArgs e)
        {
            if (advaVanValasz)
            {
                advaVanValasz = false;
                valaszButtonA.Background = (Brush)new BrushConverter().ConvertFrom("#CCFFCC");
                valaszButtonB.Background = (Brush)new BrushConverter().ConvertFrom("#CCFFCC");
                valaszButtonC.Background = (Brush)new BrushConverter().ConvertFrom("#CCFFCC");
                valaszButtonD.Background = (Brush)new BrushConverter().ConvertFrom("#CCFFCC");
                kovetkezoKerdesButton.Background = (Brush)new BrushConverter().ConvertFrom("#888888");;
                kovetkezoKerdesButton.Cursor = Cursors.Cross;
                kivalasztottValasz = "";
            }
            else
            {
                advaVanValasz = true;
                valaszButtonA.Background = (Brush)new BrushConverter().ConvertFrom("#CCFFCC");
                valaszButtonB.Background = (Brush)new BrushConverter().ConvertFrom("#CCFFCC");
                valaszButtonC.Background = (Brush)new BrushConverter().ConvertFrom("#CCCFFC");;
                valaszButtonD.Background = (Brush)new BrushConverter().ConvertFrom("#CCFFCC");
                kovetkezoKerdesButton.Background = (Brush)new BrushConverter().ConvertFrom("#CCFFCC");
                kovetkezoKerdesButton.Cursor = Cursors.Arrow;
                kivalasztottValasz = valaszButtonC.Content.ToString();
            }
        }

        private void valaszButtonD_Click(object sender, RoutedEventArgs e)
        {
            if (advaVanValasz)
            {
                advaVanValasz = false;
                valaszButtonA.Background = (Brush)new BrushConverter().ConvertFrom("#CCFFCC");
                valaszButtonB.Background = (Brush)new BrushConverter().ConvertFrom("#CCFFCC");
                valaszButtonC.Background = (Brush)new BrushConverter().ConvertFrom("#CCFFCC");
                valaszButtonD.Background = (Brush)new BrushConverter().ConvertFrom("#CCFFCC");
                kovetkezoKerdesButton.Background = (Brush)new BrushConverter().ConvertFrom("#888888");;
                kovetkezoKerdesButton.Cursor = Cursors.Cross;
                kivalasztottValasz = "";
            }
            else
            {
                advaVanValasz = true;
                valaszButtonA.Background = (Brush)new BrushConverter().ConvertFrom("#CCFFCC");
                valaszButtonB.Background = (Brush)new BrushConverter().ConvertFrom("#CCFFCC");
                valaszButtonC.Background = (Brush)new BrushConverter().ConvertFrom("#CCFFCC");
                valaszButtonD.Background = (Brush)new BrushConverter().ConvertFrom("#CCCFFC");;
                kovetkezoKerdesButton.Background = (Brush)new BrushConverter().ConvertFrom("#CCFFCC");
                kovetkezoKerdesButton.Cursor = Cursors.Arrow;
                kivalasztottValasz = valaszButtonD.Content.ToString();
            }
        }
    }
}