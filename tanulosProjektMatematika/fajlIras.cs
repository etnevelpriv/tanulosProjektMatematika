using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace tanulosProjektMatematika
{
    internal class fajlIras
    {
        public string Mentes(List<string> sorok)
        {
            var filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "eredmenyek.txt");
            File.AppendAllLines(filePath, sorok, Encoding.UTF8);
            return "Sikeres mentés";
        }
    }
}
