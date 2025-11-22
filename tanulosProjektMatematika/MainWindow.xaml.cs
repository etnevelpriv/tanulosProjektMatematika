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
        private List<string> feltettKerdesek = new List<string>();
        private List<string> adottValaszok = new List<string>();
        private List<string> helyesValaszok = new List<string>();
        private List<string> elmentendoSorok = new List<string>();
        private string felhasznaloNev;
        private int kerdesSzama = 0;
        private bool advaVanValasz;
        private string kivalasztottValasz;
        private string helyesValasz;
        private readonly Brush alapSzin = (Brush)new BrushConverter().ConvertFrom("#CCFFCC");
        private readonly Brush kivalasztottSzin = (Brush)new BrushConverter().ConvertFrom("#CCCFFC");
        private readonly Brush gombEngedelyezveSzin = (Brush)new BrushConverter().ConvertFrom("#CCFFCC");
        private readonly Brush gombNemEngedelyezveSzin = (Brush)new BrushConverter().ConvertFrom("#888888");
        private Button kivalasztottGomb;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void inditasButton_Click(object sender, RoutedEventArgs e)
        {
            if (nevTextBox.Text != "")
            {
                nevElmentesTeszt.Text = nevTextBox.Text;
                felhasznaloNev = nevTextBox.Text;
                kezdoGrid.Visibility = Visibility.Hidden;
                kerdesekGrid.Visibility = Visibility.Visible;
                elmentendoSorok.Add(felhasznaloNev);
                elmentendoSorok.Add("Kérdés | Felhasználó válasza | Helyes válasz");
                randomKerdesKiiras();
            }
            else
            {
                MessageBox.Show("Kérlek add meg a neved", "Hibás név", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void randomKerdesKiiras()
        {
            if (kerdesSzama == 10)
            {
                osszegzoGridMegjelenites();
            }
            else
            {
                nincsValaszAdas();
                if (kerdesSzama == 9)
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

                advaVanValasz = false;
            }
        }

        private void kovetkezoKerdesButtonAllapot()
        {
            if (advaVanValasz)
            {
                kovetkezoKerdesButton.Background = gombEngedelyezveSzin;
                kovetkezoKerdesButton.Cursor = Cursors.Arrow;
            }
            else
            {
                kovetkezoKerdesButton.Background = gombNemEngedelyezveSzin;
                kovetkezoKerdesButton.Cursor= Cursors.Cross;
            }
        }

        private void valaszAdas(Button gomb)
        {
            advaVanValasz = true;
            kivalasztottGomb = gomb;
            kivalasztottValasz = gomb.Content.ToString();
            if (kivalasztottGomb == valaszButtonA)
            {
                valaszButtonA.Background = kivalasztottSzin;
            }
            else
            {
                valaszButtonA.Background = alapSzin;
            }
            if (kivalasztottGomb == valaszButtonB)
            {
                valaszButtonB.Background = kivalasztottSzin;
            }
            else
            {
                valaszButtonB.Background = alapSzin;
            }
            if (kivalasztottGomb == valaszButtonC)
            {
                valaszButtonC.Background = kivalasztottSzin;
            }
            else
            {
                valaszButtonC.Background = alapSzin;
            }
            if (kivalasztottGomb == valaszButtonD)
            {
                valaszButtonD.Background = kivalasztottSzin;
            }
            else
            {
                valaszButtonD.Background = alapSzin;
            }
            kovetkezoKerdesButtonAllapot();
        }

        private void nincsValaszAdas()
        {
            advaVanValasz = false;
            kivalasztottGomb = null;
            kivalasztottValasz = "";
            valaszButtonA.Background = alapSzin;
            valaszButtonB.Background= alapSzin;
            valaszButtonC.Background= alapSzin;
            valaszButtonD.Background= alapSzin;
            kovetkezoKerdesButtonAllapot();
        }

        private void kovetkezoKerdesButton_Click(object sender, RoutedEventArgs e)
        {
            if (advaVanValasz)
            {
                feltettKerdesek.Add(kerdesText.Text);
                adottValaszok.Add(kivalasztottValasz);
                helyesValaszok.Add(helyesValasz);
                elmentendoSorok.Add($"{kerdesText.Text} | {kivalasztottValasz} | {helyesValasz}");
                randomKerdesKiiras();

            }
            else
            {
                MessageBox.Show("Először válassz egy válaszlehetőséget.", "Nincs kiválasztva egy válaszlehetőség sem.", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void valaszButtonA_Click(object sender, RoutedEventArgs e)
        {
            if (kivalasztottGomb == valaszButtonA)
            {
                nincsValaszAdas();
            }
            else
            {
                valaszAdas(valaszButtonA);
            }
        }

        private void valaszButtonB_Click(object sender, RoutedEventArgs e)
        {
            if (kivalasztottGomb == valaszButtonB)
            {
                nincsValaszAdas();
            }
            else
            {
                valaszAdas(valaszButtonB);
            }
        }

        private void valaszButtonC_Click(object sender, RoutedEventArgs e)
        {
            if (kivalasztottGomb == valaszButtonC)
            {
                nincsValaszAdas();
            }
            else
            {
                valaszAdas(valaszButtonC);
            }
        }

        private void valaszButtonD_Click(object sender, RoutedEventArgs e)
        {
            if (kivalasztottGomb == valaszButtonD)
            {
                nincsValaszAdas();
            }
            else
            {
                valaszAdas(valaszButtonD);
            }
        }
        private void osszegzoGridMegjelenites()
        {
            kerdesekGrid.Visibility = Visibility.Hidden;
            osszegzesGrid.Visibility = Visibility.Visible;
            
            var sb = new StringBuilder();
            for (int i = 0; i < adottValaszok.Count; i++)
            {
                sb.AppendLine($"{i + 1}. kérdés. Kérdés: {feltettKerdesek[i]} Felhasználó válasza: {adottValaszok[i]}. Helyes válasz: {helyesValaszok[i]}");
            }
            tesztKiiras.Text = sb.ToString();
        }
    }
}