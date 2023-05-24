using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    class ExercicioTres {
        public static void Executar() {

            Console.WriteLine("Digite seu número de funcionário:");
            int nf = int.Parse(Console.ReadLine());

            Console.WriteLine("Quantas horas você trabalha?:");
            int ht = int.Parse(Console.ReadLine());

            Console.WriteLine("Quanto você recebe por hora?:");
            double rh = double.Parse(Console.ReadLine());


            Console.WriteLine($"Seu número de funcionário é:{nf}");

            Console.WriteLine($"Seu salário{ht*rh}");

        }

    }
}
