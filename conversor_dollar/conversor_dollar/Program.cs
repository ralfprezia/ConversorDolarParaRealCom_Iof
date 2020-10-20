using System;
using System.Globalization;

namespace conversor_dollar {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("");

            Console.WriteLine("Qual a cotação do dólar hoje?");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Quantos dólares pretende comprar?");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double result = ConversorDeMoeda.DolarParaReal(quantia, cotacao);

            Console.WriteLine("Valor pago em reais = " + result.ToString("F2", CultureInfo.InvariantCulture));


            
        }
    }
}
