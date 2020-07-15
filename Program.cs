using System;

namespace algoritmo2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Controle de acesso
            //ControleAcesso controleAcesso = new ControleAcesso();

            //bool logado = controleAcesso.EfetuarLogin();

            //if (logado)
            //    Console.WriteLine("Login efetuado com sucesso!");



            //Numeros primos
            //NumerosPrimos numerosPrimos = new NumerosPrimos();
            //Console.WriteLine("Digite um limite: ");
            //numerosPrimos.Limite = Convert.ToInt32(Console.ReadLine());
            //numerosPrimos.CalcularNumerosPrimos();


            //Calculo de IMC
            CalculoIMC calculoIMC = new CalculoIMC();
            Console.WriteLine("Digite o seu peso(Kg): ");
            calculoIMC.peso = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite sua altura(m): ");
            calculoIMC.altura = Convert.ToDouble(Console.ReadLine());
            calculoIMC.calcularIMC();
        }
    }
}
