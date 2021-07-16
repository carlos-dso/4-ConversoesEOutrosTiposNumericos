using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Execultar o projeto 4");

            double salario;
            salario = 1200.50;

            // O int é um tipo de variavel que suporta valores ate 32 bits.
            int salarioInteiro;
            salarioInteiro = (int)salario;

            Console.WriteLine(salarioInteiro);

            // O long é uma variavel de 64 bits.
            long idade = 140000000000000;
            Console.WriteLine(idade);

            // O short é uma variavel que suporta ate 16 bits.
            short quantidadeProduto =15000;
            Console.WriteLine(quantidadeProduto);
           
            float altura = 1.66f;
            Console.WriteLine(altura);
             

            Console.ReadLine();
        }
    }
}
