using System;
using System.Collections.Generic;
using System.Text;

namespace algoritmo2
{
    class NumerosPrimos
    {
        public int Limite { get; set; }
        public int[] Indices = new int[4];

        public NumerosPrimos()
        {
            Indices[0] = 2;
            Indices[1] = 3;
            Indices[2] = 5;
            Indices[3] = 7;
        }

        public void CalcularNumerosPrimos()
        {
            for (int l = 1; l < Limite; l++)
            {
                bool primo = true;

                for (int i = 0; i < 4; i++)
                {
                    int resto = l % Indices[i];

                    if (l != Indices[i] && resto == 0)
                    {
                        primo = false;
                        break;
                    }
                }

                if (primo)
                    Console.WriteLine(l);
            }
        }
    }
}
