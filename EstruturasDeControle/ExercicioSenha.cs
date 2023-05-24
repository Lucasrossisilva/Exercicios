using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle {
    class ExercicioSenha {
        public static void Executar() {
            
            Console.WriteLine("Digite sua senha");
            var senha = Console.ReadLine();

            Console.WriteLine("Confirme sua senha");
            var senha_E = Console.ReadLine();

            if (senha == senha_E) {
             Console.WriteLine("Acesso Permitido!");
            }
            else
                Console.WriteLine("Acesso Negado!");

         }

        }
    }


