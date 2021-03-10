using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoNoGit
{
    class Cachorro
    {
       public string nome;
       public string raca;
       public int idade;
       public string genero;

       public void AbanarRabo()
        {
            Console.WriteLine("Rabo balançando!");
            Console.ReadLine();

        }

        public void Latir()
        {
            Console.WriteLine("Au au");
            Console.ReadLine();
        }
    }
}
