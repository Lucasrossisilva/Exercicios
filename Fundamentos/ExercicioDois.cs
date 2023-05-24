using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    class ExercicioDois {
        public static void Executar() {

            Console.WriteLine("Digite a primeira nota:");
            double nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota:");
            double nota2 = double.Parse(Console.ReadLine());

            double nnota1 = (nota1 * 3.5)/11;

            double nnota2 = (nota2 * 3.5) /11;

            Console.WriteLine($"Números que você digitou! \n 1º numero: {nota1} \n 2º numero: {nota2}");
            Console.WriteLine($"Números que você registrou ! \n 1º numero: {nota1.ToString("#,#")} \n 2º numero:{nnota2.ToString("#,#")}");

        }

    }
}