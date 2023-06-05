using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CursoCSharp.ClassesEMetodos {
    class ExercicioAnimais{

        public class Animal {
            private string animal;
            private string tipo;

            public string Nome {
                get {
                    return animal;
                }
                set {
                    animal = value;
                }
            }

            public string Tipo {
                get {
                    return tipo;
                }
                set {
                    tipo = value;
                }
            }

            public Animal(string nome, string tipo) {
                Nome = nome;
                Tipo = tipo;
            }
        }
        public static void Executar() { 
            var animal1 = new Animal("Cachorro", "Amigavel");
            Console.WriteLine($"{animal1.Nome} é {animal1.Tipo}");

            var animal2 = new Animal("Gatp", "Amigavel");
            Console.WriteLine($"{animal2.Nome} é {animal2.Tipo}");

            var animal3 = new Animal("Ave", "Amigavel");
            Console.WriteLine($"{animal3.Nome} é {animal3.Tipo}");
        }
    }
}

