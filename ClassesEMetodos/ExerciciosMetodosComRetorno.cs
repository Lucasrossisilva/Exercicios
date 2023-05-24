using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    class ExerciciosMetodosComRetorno {

        class Conversao {
            public double CRD(double r, double d ) {
                return r / d;
            }

        }

        public static void Executar() {

            double dolar = 4.95;

            var RED  = new Conversao();

            Console.WriteLine("Digite o valor que você quer converter:");
            double reais = double.Parse(Console.ReadLine());

            Console.WriteLine(RED.CRD(reais,dolar));

        }
    }
}
