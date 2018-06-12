using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obstliste
{
    class Obst
    {
        private string name;
        private double preis;
        private int obst;
        private int gemuese;

        public Obst(string n, double p, int o, int g)
        {
            name = n;
            preis = p;
            gemuese = g;
            obst = o;
        }

        public string getName()
        {
            return name;
        }

        public double getPreis()
        {
            return preis;
        }

        public int getObst()
        {
            return obst;
        }
        public int getGemuese()
        {
            return gemuese;
        }
    }
}
