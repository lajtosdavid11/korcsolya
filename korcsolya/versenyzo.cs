using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace korcsolya
{
    class versenyzo
    {

        private string nev;
        private string orszag;
        private double technikai;
        private double comp;
        private double levon;
        private double pont;

        public string Nev { get { return nev; } }
        public string Orszag { get { return orszag; } }

        public double Technikai { get { return technikai; } }

        public double Comp { get { return comp; } }
        public double Levon { get { return levon; } }

        public double Pont { get { return pont; } }

        public versenyzo(string nev, string orszag, double technikai, double comp, double levon)
        {
            this.nev = nev;
            this.orszag = orszag;
            this.technikai = technikai;
            this.comp = comp;
            this.levon = levon;
            pont = (technikai + comp) - levon;
        }
    }
}
