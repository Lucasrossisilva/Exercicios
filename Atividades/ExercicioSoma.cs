using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Atividades {
    class ExercicioSoma {
        public static void Executar() {

            int cont = 0;
            int num = 0;
            int dig = 0;

            while (cont != 10) {
                Console.WriteLine("Digite um número:");
                dig = int.Parse(Console.ReadLine());

                num = num + dig;
                cont++;
            }
         }
    }
}

