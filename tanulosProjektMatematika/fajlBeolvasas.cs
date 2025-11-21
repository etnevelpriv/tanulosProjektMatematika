using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tanulosProjektMatematika
{
    class fajlBeolvasas
    {
        public List<Main> kerdesek = new List<Main>();

        public fajlBeolvasas()
        {
            using (StreamReader sr = new StreamReader("matekKerdesek.txt"))
            {
                string sor = sr.ReadLine();
                while (sor != null)
                {
                    String[] mezok = sor.Split(';');
                    Main kerdes = new Main(mezok[0], mezok[1], mezok[2], mezok[3], mezok[4], mezok[5]);
                    kerdesek.Add(kerdes);
                    sor = sr.ReadLine();
                }
            }
        }
    }
}
