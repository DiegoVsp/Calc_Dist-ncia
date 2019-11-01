using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distancia
{
    class Program
    {
        static void Main(string[] args)
        {
            double PessoaLa, PessoaLo, PetLa, PetLo;

            Console.WriteLine("Digite a PessoaLa ");
            PessoaLa = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a PessoaLo ");
            PessoaLo = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a PetLa ");
            PetLa = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a PetLo ");
            PetLo = double.Parse(Console.ReadLine());


            // double resultadoDist = Math.Sqrt(Math.Pow(PessoaLa - PetLa, 2) + Math.Pow(PessoaLo - PetLo, 2));

            double arcoB = 90 - (PetLo);
            double arcoC = 90 - (PessoaLo);
            double arcoA = PetLa - (PessoaLa);

            double cosA = Math.Cos(arcoB) * Math.Cos(arcoC) + Math.Sin(arcoC) * Math.Sin(arcoB) * Math.Sin(arcoA);
            double arcCos = Math.Acos(cosA);

            double distancia = (40030 * arcCos) / 360;

            if (distancia > 20)
            {
                Console.WriteLine("Cachorro Fugiu! {0}", distancia.ToString("F"));
            }
            else
            {
                Console.WriteLine(distancia.ToString("F"));
            }

            Console.ReadKey();

        }
    }
}
