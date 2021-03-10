using System;

namespace ProjetoCarro
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro celta = new Carro("prata", 2012, "2 portas", 0, 300,false);

            celta.Ligar();
            celta.Acelerar();
            celta.Acelerar();
            celta.Frear();
            celta.Acelerar();
            
        }
    }
}
