using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            // Arrays de inteiro

            int[] idades = new int[] {20,25,30,35,40};

            //idades[0] = 20;
            //idades[1] = 25;
            //idades[2] = 30;
            //idades[3] = 35;
            //idades[4] = 40;

            Console.WriteLine(idades[1]);
            Console.WriteLine(idades[2]);

            //int indice = 2;
            //int valorNoIndice = idades[indice];
            int outroValor = idades[2+2];
            //int maisUmValor = idades[GetNumeroInteiro()];

            int acumulador = 0;

            for( int indice = 0; indice < idades.Length; indice++ )
            {
                int idade = idades[indice];
                acumulador += idades[indice];
                Console.WriteLine($"Valor da idade no índice {indice} é {idade}");
            }

            int media = acumulador / idades.Length;
            Console.WriteLine($"Média de idades: {media}");

            Console.ReadLine();
        }
    }
}
