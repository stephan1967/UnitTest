using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    class Rekenmachine
    {

        /// <summary>Middels de methode Optellen kunnen we 2 getallen bij elkaar optellen/// </summary>
        /// 
        public int Optellen(int A, int B)
        {
            int Som = A + B;
            Debug.WriteLine(Som);
 
            return Som;
        }

        /// <summary>Middels de methode Aftrekken kunnen we 2 getallen van elkaar aftrekken/// </summary>
        /// 
        public int Aftrekken(int A, int B)
        {
            int Verschil = A - B;
            Debug.WriteLine(Verschil);

            return Verschil;
        }

        /// <summary>Middels de methode Delen kunnen we 2 getallen door elkaar delen/// </summary>
        /// 
        public int Delen(int A, int B)
        {
            int Produkt = A / B;
            Debug.WriteLine(Produkt);

            return Produkt;
        }
    }
}
