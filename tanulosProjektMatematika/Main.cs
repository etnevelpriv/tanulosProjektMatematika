using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tanulosProjektMatematika
{
    class Main
    {
        String kerdes;
        String valaszA;
        String valaszB;
        String valaszC;
        String valaszD;
        String valaszHelyes;

        public Main(String kerdes, String valaszA, String valaszB, String valaszC, String valaszD, String valaszHelyes )
        {
            this.kerdes = kerdes;
            this.valaszA = valaszA;
            this.valaszB = valaszB;
            this.valaszC = valaszC;
            this.valaszD = valaszD;
            this.valaszHelyes = valaszHelyes;
        }
        
        public String getKerdes() { return kerdes; }
        public String getValaszA() { return valaszA; }
        public String getValaszB() { return valaszB; }
        public String getValaszC() { return valaszC; }
        public String getValaszD() { return valaszD; }
        public String getValaszHelyes() { return valaszHelyes; }

    }
}
