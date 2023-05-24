using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle {
    class ExercicioIMC {

        public static void Executar() {
            Console.WriteLine("Digite o seu peso");
            double peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua altura");
            double altura = double.Parse(Console.ReadLine());

            double imc = peso / (altura*altura);

            if (imc < 18.5) {
                Console.WriteLine("Abaixo do peso");
            }
            if (imc >= 18.5 && imc <= 24.9) {
                Console.WriteLine("Peso normal");
            }
            if (imc > 24.9 && imc <= 29.9) {
                Console.WriteLine("Acima do peso");
            }
            if (imc > 29.9 && imc <= 34.9) {
                Console.WriteLine("Obesidade Nivel 1");
            }
            if (imc > 34.9 && imc <= 39.9) {
                Console.WriteLine("Obesidade Nivel 2");
            }
            if (imc > 39.9) {
                Console.WriteLine("Obesidade Nivel 3");
            }
        }
    }
}