﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5_CompararNumeros
{
    class Funciones
    {
        public static int MayorMenor(int x, int y)
        {
            if (x > y)
            {
                return x;
            }
            else if (x < y)
            {
                return y;
            }
            else
            {
                return 0;
            }    
        }
    }
}
