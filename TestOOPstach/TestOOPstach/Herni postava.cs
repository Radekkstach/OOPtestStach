using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestOOPstach
{
    class Herni_postava
    {
        protected string jmeno;
        protected int level = 1;
        protected int pozicex;
        protected int pozicey;

        public Herni_postava(string jmeno)
        {
            Jmeno = jmeno;
        }

        string Jmeno
        {
            get { return jmeno; }
            set
            {
                if(value.Length > 10)
                {
                    MessageBox.Show("Prilis dlouhe jmeno!");
                    
                }
                else
                {
                    jmeno = value;
                }
            }
        }

        int PoziceX
        {
            get
            {
                pozicex = 0;
                return pozicex;
            }
        }

        int PoziceY
        {
            get
            {
                pozicey = 0;
                return pozicey;
            }
        }

        public override string ToString()
        {
            return "Postava: " + jmeno + " s levelem " + level + "\nPozice X: " + pozicex + "Pozice Y:" + pozicey;
        }

        public void zmenaPozice(int xa, int ya)
        {
            pozicex = xa;
            pozicey = ya;
        }




    }
}
