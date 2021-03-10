using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoCarro
{
    class Carro
    {
        public string cor;
        public int anoFabricacao;
        public string modelo;
        public int velocidadeAtual;
        public int velocidadeMaxima;
        public bool seLigado;

        public Carro(string _cor, int _anoFabricacao, string _modelo, int _velocidadeAtual, int _velocidadeMaxima, bool _seLigado)
        {
            this.modelo = _modelo;
            this.cor = _cor;
            this.anoFabricacao = _anoFabricacao;
            this.velocidadeAtual = _velocidadeAtual;
            this.velocidadeMaxima = _velocidadeMaxima;
            this.seLigado = _seLigado;
        }

        public void Ligar()
        {
            Console.WriteLine("Carro Ligado!");
            seLigado = true;
            Console.ReadLine();

        }

        public void Acelerar()
        {
            velocidadeAtual += 10;
            Console.WriteLine("Velocidade atual aumentada, a Velocidade agora é de:" + velocidadeAtual);
            Console.ReadLine();
        }

        public void Frear()
        {
            velocidadeAtual -= 10;
            Console.WriteLine("Velocidade atual diminuida, a Velocidade agora é de:" + velocidadeAtual);
            Console.ReadLine();
        }

    }
}
