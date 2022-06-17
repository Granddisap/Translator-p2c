using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace cnvrt
{
    public class Atom
    {
        public int indice;
        public string valoare;
        public int linie;
        public Atom(int indice, string valoare, int linie)
        {
            this.indice = indice;
            this.valoare = valoare;
            this.linie = linie;
        }
    }
}
