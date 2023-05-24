using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle {
    class ExercicioNotas {
        public static void Executar() {

            Console.WriteLine("Digite a primeira nota:");
            double nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota:");
            double nota2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a terceira nota:");
            double nota3 = double.Parse(Console.ReadLine());

            double media = (nota1 + nota2 + nota3) / 3;

            if (media >= 7) {
                Console.WriteLine("O Aluno está aprovado!");
            }
            if (media >= 5) {
               Console.WriteLine("O Aluno está de recuperação!");
            }
            if (media < 5) {
                Console.WriteLine("O Aluno está Reprovado");
            }
        }
    }
}
    

