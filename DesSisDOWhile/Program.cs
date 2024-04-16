using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace DesSisDOWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double DespesaTotal = 0;
            String stringdespesa;
            double resp = 0;
            do
            {
                Console.WriteLine("Informe a despesa: ");
                stringdespesa = Console.ReadLine();
                Console.WriteLine("Informe o seu valor: ");
                double despesa = double.Parse(Console.ReadLine());

                DespesaTotal = DespesaTotal + despesa;
                Console.WriteLine("Deseja inserir nova despesa? {Sim = 1 / não = 2}");
                resp = double.Parse(Console.ReadLine());
            }
            while (resp == 1);

            Console.WriteLine("O valor total das despesas é de: " + DespesaTotal);
            Console.WriteLine("Informe a quantiadade de pessoas que moram na casa: ");
            double pessoas = double.Parse(Console.ReadLine());
            double media;
            media = DespesaTotal / pessoas;
            Console.WriteLine("Média do valor pra cada morador: " + media);
            Console.ReadKey();
        }
    }
}
