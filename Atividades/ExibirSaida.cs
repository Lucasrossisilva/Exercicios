using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Atividades {
    class ExibirSaida {

        public static void Executar() {
            
            Console.WriteLine("Digite um número:");
            int.TryParse(Console.ReadLine(), out int valor);

            int contador = 1;

            while (contador <= valor) {

                Console.WriteLine(contador++);
                
            }
            
        }
    }
}
