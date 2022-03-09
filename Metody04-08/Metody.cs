using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metody04_08
{
    static class Metody
    {
        static public int Mocnina(int zaklad, int exponent)
        {
            int mocnina = 1;
            bool jeZaporne=false;
            if (exponent < 0)
            {
                jeZaporne = true;
                exponent = Math.Abs(exponent);
            }


            for (int i = 0; i <exponent; ++i)
            {
                    mocnina *= zaklad;
            }
            if (jeZaporne) return 1/mocnina;
            else return mocnina;

        }

        static public int Faktorial(int cislo)
        {
            int faktorial = 1;
            for (int i = 1; i <= cislo; ++i)
            {
                faktorial *= i;
            }
            return faktorial;
        }

        static public int CifLichSoucet(int cislo)
        {
            int cifLichSoucet = 0;
            int cifra;
            while (cislo > 0)
            {
                cifra = cislo % 10;
                if (cifra % 2 != 0) cifLichSoucet += cifra;
                cislo /= 10;
            }
            return cifLichSoucet;
        }

        static public bool JePrvocislo(int cislo)
        {
            int pocetDelitelu = 0;
            for (int i = 1; i < cislo; ++i) 
            {
                if (cislo % i == 0) ++pocetDelitelu;
            }
            if (pocetDelitelu >= 2) return false;
            else return true;
        }

        static public int PocetSudDel(int cislo)
        {
            int pocet = 0;
            for (int i = 1; i <= cislo; i++)
            {
                if (cislo % i == 0 && i % 2 == 0) ++pocet;
            }
            return pocet;
        }

        static public int NejevetsiSpolecnyDelitel(int cislo,int cislo2)
        {
            int nejvetsiSpolDel = 1;
            if (cislo2 < cislo)
            {
                int kyblik = cislo;
                cislo = cislo2;
                cislo2 = kyblik;
            }
            for (int i = 1; i <= cislo; ++i)
            {
                if (cislo % i == 0 && cislo2 % i == 0) nejvetsiSpolDel = i;
            }
            return nejvetsiSpolDel;
        }
            
    }
}
