using EstudosOO.Models;
using EstudosOO.Servicos;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Veiculo v = new Veiculo();
            v.Placa = "kpx5214";
            v.Porta = 2;
            v.Roda = 2;
            

            IdentificarVeiculo iv = new IdentificarVeiculo();

            Console.WriteLine(v.ToString());
            Console.WriteLine(v.Roda);
            Console.WriteLine(iv.identifica(v));
            Console.ReadLine();

        }
    }
}
