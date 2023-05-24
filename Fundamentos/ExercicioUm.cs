using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    class ExercicioUm {
        public static void Executar() {

            double nota1, nota2, nota3;
            

            Console.WriteLine("Digite a primeira nota:");
           nota1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota:");
            nota2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a terceira nota:");
            nota3 = int.Parse(Console.ReadLine());

            Console.WriteLine($" A média do aluno é {(nota1 + nota2 + nota3)/2}");
        }
    }
}
