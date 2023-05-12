using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle {
    class EstruturaIf {

        public static void Executar() {

            Console.WriteLine("Digite a primeira nota:");
            int nota1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota:");
            int nota2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a terceira nota:");
            int nota3 = int.Parse(Console.ReadLine());

            int media = (nota1 + nota2 + nota3) / 3;

            if (media >= 7) {
                Console.WriteLine("O Aluno está aprovado!");
            }
            if (media < 7) {
                Console.WriteLine("O Aluno está Reprovado");
            }
        }
    }
}

