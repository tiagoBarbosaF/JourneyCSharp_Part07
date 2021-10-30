using ByteBank.Modelos;
using System;

namespace ByteBank.SistemaAgencia
{
    public class ListaDeContaCorrente
    {
        private ContaCorrente[] _contas;
        private int _proximaPosicao;
        public int Tamanho
        {
            get
            {
                return _proximaPosicao;
            }
        }
        public ContaCorrente this[int indice]
        {
            get
            {
                return GetContaNoIndice(indice);
            }
        }

        public ListaDeContaCorrente(int capacidadeInicial = 5)
        {
            _contas = new ContaCorrente[capacidadeInicial];
            _proximaPosicao = 0;
        }

        public void Adicionar(ContaCorrente conta)
        {
            VerificarCapacidade(_proximaPosicao + 1);

            Console.WriteLine($"Adicionando no índice {_proximaPosicao} a conta {conta.Agencia}/{conta.Numero}");

            _contas[_proximaPosicao] = conta;
            _proximaPosicao++;
        }

        public void AdicionarVarios(params ContaCorrente[] contas)
        {
            foreach(ContaCorrente conta in contas)
                Adicionar(conta);
        }

        public void VerificarCapacidade(int tamanhoNecessario)
        {
            if(_contas.Length >= tamanhoNecessario)
                return;

            int novoTamanho = _contas.Length * 2;
            if(novoTamanho < tamanhoNecessario)
                novoTamanho = tamanhoNecessario;

            //Console.WriteLine("Aumentando capacidade da lista!");

            ContaCorrente[] novoArray = new ContaCorrente[novoTamanho];

            for(int indice = 0; indice < _contas.Length; indice++)
            {
                novoArray[indice] = _contas[indice];
                //Console.WriteLine(".");
            }

            _contas = novoArray;
        }

        public void Remover(ContaCorrente conta)
        {
            int indiceConta = -1;

            for(int i = 0; i < _proximaPosicao; i++)
            {
                ContaCorrente contaAtual = _contas[i];


                if(contaAtual.Equals(conta))
                {
                    indiceConta = i;
                    break;
                }

                if(indiceConta == -1)
                    throw new Exception("Conta não valida");
            }

            for(int i = indiceConta; i < _proximaPosicao - 1; i++)
            {
                _contas[i] = _contas[i + 1];
            }

            _proximaPosicao--;
            _contas[_proximaPosicao] = null;
        }

        public ContaCorrente GetContaNoIndice(int indice)
        {
            if(indice < 0 || indice >= _proximaPosicao)
                throw new ArgumentOutOfRangeException(nameof(indice));

            return _contas[indice];
        }
    }
}
