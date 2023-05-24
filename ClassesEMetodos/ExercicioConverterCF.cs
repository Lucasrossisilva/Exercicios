using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    class ExercicioConverterCF {
              class Conversao {
            public double CCF(double c) {
                return (c * 9 / 5) + 32;
            }

        }

        public static void Executar() {


            var CEF = new Conversao();

            Console.WriteLine("Digite a temperatura que você quer converter:");
            double celcius = double.Parse(Console.ReadLine());

            Console.WriteLine(CEF.CCF(celcius));
        }
    }
}
