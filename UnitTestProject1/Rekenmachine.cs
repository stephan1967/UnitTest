﻿using System;
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
    }
}