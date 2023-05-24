using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle {
    class ExercicioVoto {
        public static void Executar() {

            Console.WriteLine("Em que ano você nasceu:");
            int nascimento = int.Parse(Console.ReadLine());

            int ano = 2023;
            int idade = (ano - nascimento);

            if (idade >= 18 && idade <= 70) {
                Console.WriteLine($"Você tem {idade} anos de idade, é obrigatório votar");
            } else {
                Console.WriteLine($"Você tem {idade} anos de idade, ainda não é obrigatório votar");
            }
        }
    }
}

     