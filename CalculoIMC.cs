using System;
using System.Collections.Generic;
using System.Text;

namespace algoritmo2
{
    class CalculoIMC
    {
        public int peso { get; set; }
        public double altura { get; set; }

        public void calcularIMC()
        {
            double imc = peso / (altura * altura);
            string resultado = "";

            if (imc < 17)
                resultado = "Muito abaixo do peso.";

            if (imc >= 17 && imc <= 18.49)
                resultado = "Abaixo do peso.";

            if (imc > 18.49 && imc < 25)
                resultado = "Peso normal.";

            if (imc > 25 && imc < 30)
                resultado = "Acima do peso.";

            if (imc >= 30 && imc < 35)
                resultado = "Obesidade I.";

            if (imc >= 35 && imc < 40)
                resultado = "Obesidade II(severa).";

            if (imc > 40)
                resultado = "Obesidade III(morbida).";

            Console.WriteLine(resultado);
        }
    }
}
