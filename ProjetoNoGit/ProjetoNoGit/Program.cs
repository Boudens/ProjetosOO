using System;

namespace ProjetoNoGit
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Cachorro dog1 = new Cachorro();
            var dog2 = new Cachorro();
            Cachorro dog3 = new Cachorro();
            var dog4 = new Cachorro();
            Cachorro dog5 = new Cachorro();

            
            
           Cachorro[] cachorros = { dog1, dog2, dog3, dog4, dog5 };
        */

            var bidu = new Cachorro();
            bidu.nome = "Bidu da Silva";
            bidu.raca = "Pit-bull";
            bidu.genero = "Macho";
            bidu.idade = 26;

            bidu.Latir();
            bidu.AbanarRabo();
            }
    }
}
