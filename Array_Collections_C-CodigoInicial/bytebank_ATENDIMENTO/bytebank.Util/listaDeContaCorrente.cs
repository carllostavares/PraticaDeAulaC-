using bytebank.Modelos.Conta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ATENDIMENTO.bytebank.Util
{
    internal class listaDeContaCorrente
    {
        private ContaCorrente[] _itens = null;
        private int _proximaPosicao = 0;

        public listaDeContaCorrente( int tamanhoInicial =5 )
        {
                _itens = new ContaCorrente[tamanhoInicial]; 
        }
        public void Adicionar (ContaCorrente item)
        {
            Console.WriteLine($"Adicionado item na posição{_proximaPosicao}");
            _itens[_proximaPosicao] = item;
            _proximaPosicao++;
        }
    }
}
 