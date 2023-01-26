using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestOOPstach
{
    class Hrac : Herni_postava
    {
        string specializace;
        string oblicejs;
        string vlasys;
        string barvavlasus;

        private enum Oblicej {
            velkynos,usoplesk, makeup
        }
        private enum Vlasy { drdol,culik,pleska}
        private enum BarvaVlasu { kastanova,blond,cervena}
        public int xp;

        public Hrac(string jmeno,string specializace, int oblicej,int vlasy,int barvavlasu) : base(jmeno)
        {
            Specializace = specializace;
            
            if(oblicej == 0) { oblicejs = Oblicej.velkynos.ToString(); }
            if (oblicej == 1) { oblicejs = Oblicej.usoplesk.ToString(); }
            if (oblicej == 2) { oblicejs = Oblicej.makeup.ToString(); }

            if (vlasy == 0) { vlasys = Vlasy.drdol.ToString(); }
            if (vlasy == 1) { vlasys = Vlasy.culik.ToString(); }
            if (vlasy == 2) { vlasys = Vlasy.pleska.ToString(); }

            if (barvavlasu == 0) { barvavlasus = BarvaVlasu.kastanova.ToString(); }
            if (barvavlasu == 1) { barvavlasus = BarvaVlasu.blond.ToString(); }
            if (barvavlasu == 2) { barvavlasus = BarvaVlasu.cervena.ToString(); }

        }

        string Specializace
        {
            get
            {
                return specializace;
            }
            set
            {
                if(value == "Kouzelnik" || value == "Berserker" || value == "Inzenyr" || value == "Cizak")
                {
                    specializace = value;
                }
                else
                {
                    MessageBox.Show("Spatna klasa");
                }
            }
        }
        int x = 0;
        public void PridejXP(int hodnota)
        {
            
            x = x + hodnota;
            if(x >= (level * 100))
            {
                level = level + 1;
                x = 0;
            }
        }

        public override string ToString()
        {
            return "Postava: " + jmeno + " s levelem " + level + "XP: " + x+"\nPozice X: " + pozicex + "Pozice Y:" + pozicey + "\nSpecializace: " + specializace + "\nOblicej " + oblicejs + "\nVlasy " + vlasys + "\nBarva vlasu " + barvavlasus;
        }
    }
}
