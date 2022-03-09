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
    }
}
