using ByteBank.Modelos;
using System;
using System.Collections.Generic;

namespace ByteBank.SistemaAgencia
{
  class Program
  {
    static void Main(string[] args)
    {
      Lista<int> idades = new Lista<int>();

      idades.AdicionarVarios(10, 20, 30, 50, 80, 99, 654);
      idades.Remover(30);

      for (int i = 0; i < idades.Tamanho; i++)
      {
        Console.WriteLine($"Lista de idades no índice {i} - {idades.GetItemNoIndice(i)}");
      }

      Lista<string> cursos = new Lista<string>();
      cursos.AdicionarVarios("C# Part 01", "C# Part 02", "C# Part 03");

      for (int i = 0; i < cursos.Tamanho; i++)
      {
        Console.WriteLine($"Curso {i} - {cursos.GetItemNoIndice(i)}");
      }

      Lista<ContaCorrente> contas = new Lista<ContaCorrente>();
      contas.AdicionarVarios(new ContaCorrente(987, 987321),
        new ContaCorrente(987, 987357),
        new ContaCorrente(987, 987159));

      for (int i = 0; i < contas.Tamanho; i++)
      {
        Console.WriteLine($"Conta {i} - {contas.GetItemNoIndice(i).Agencia}/ {contas.GetItemNoIndice(i).Numero}");
      }
    }

    static void ListaContaCorrente()
    {
      ListaDeContaCorrente lista = new ListaDeContaCorrente();

      ContaCorrente contaTiago = new ContaCorrente(111, 111111);

      lista.AdicionarVarios(contaTiago,
        new ContaCorrente(987, 987654),
        new ContaCorrente(987, 987321),
        new ContaCorrente(987, 987456),
        new ContaCorrente(987, 987951));

      //ContaCorrente conta = lista.GetContaNoIndice(2);
      //Console.WriteLine($"{conta.Agencia}/{conta.Numero}");

      for (int i = 0; i < lista.Tamanho; i++)
      {
        ContaCorrente conta = lista[i];
        Console.WriteLine($"{conta.Agencia}/{conta.Numero}");
      }
    }

    static void TestaContaCorrenteArray()
    {
      ContaCorrente[] contas = new ContaCorrente[]
      {
        new ContaCorrente(987, 987654),
        new ContaCorrente(987, 987321),
        new ContaCorrente(987, 987357)
      };

      for (int indice = 0; indice < contas.Length; indice++)
      {
        ContaCorrente contaAtual = contas[indice];
        Console.WriteLine($"Conta {indice} - {contaAtual.Numero}");
      }
    }

    static void TestaArraysInt()
    {
      // Arrays de inteiro

      int[] idades = new int[] {20, 25, 30, 35, 40};

      //idades[0] = 20;
      //idades[1] = 25;
      //idades[2] = 30;
      //idades[3] = 35;
      //idades[4] = 40;

      Console.WriteLine(idades[1]);
      Console.WriteLine(idades[2]);

      //int indice = 2;
      //int valorNoIndice = idades[indice];
      int outroValor = idades[2 + 2];
      //int maisUmValor = idades[GetNumeroInteiro()];

      int acumulador = 0;

      for (int indice = 0; indice < idades.Length; indice++)
      {
        int idade = idades[indice];
        acumulador += idades[indice];
        Console.WriteLine($"Valor da idade no índice {indice} é {idade}");
      }

      int media = acumulador / idades.Length;
      Console.WriteLine($"Média de idades: {media}");
    }
  }
}