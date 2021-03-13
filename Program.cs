using System;
using System.Globalization;

namespace prova_de_lógica
{
    class Program
    {
        static void Main(string[] args)
        {

            // PARTE 1: ESTRUTURA SEQUENCIAL

            // Exercício 1.1:
            // Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o 
            // código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago.

            int cod1, cod2, num1, num2;
            double valor1, valor2, total;

            string[] vet1 = Console.ReadLine().Split(' ');
            cod1 = int.Parse(vet1[0]);
            num1 = int.Parse(vet1[1]);
            valor1 = double.Parse(vet1[2], CultureInfo.InvariantCulture);

            string[] vet2 = Console.ReadLine().Split(' ');
            cod2 = int.Parse(vet2[0]);
            num2 = int.Parse(vet2[1]);
            valor2 = double.Parse(vet2[2], CultureInfo.InvariantCulture);

            total = (double)(valor1 * num1) + (valor2 * num2);

            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
