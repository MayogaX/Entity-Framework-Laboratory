using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaTPT
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = Stopwatch.StartNew();
            using (JogadoresContext jc = new JogadoresContext())
            {
                Goleiro goleiro = new Goleiro();
                goleiro.Nome = "Rogerio Ceni";
                goleiro.GolsDefendidos = 9000;
                jc.Jogadores.Add(goleiro);

                Artilheiro artilheiro = new Artilheiro();
                artilheiro.Nome = "Pele";
                artilheiro.GolsMarcados = 1000;
                jc.Jogadores.Add(artilheiro);

                jc.SaveChanges();
            }
            sw.Stop();
            Console.WriteLine("Time taken: {0}ms", sw.Elapsed.TotalMilliseconds);
            Console.ReadKey();
        }
    }
}
