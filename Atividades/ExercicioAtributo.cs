using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Atividades {
    class ExercicioAtributo {

        class Pessoa {

            private string nome;
            private DateTime nascimento;
            private double altura;

            public string Nome {
                get {
                    return nome;
                }
                set {
                    nome = value;
                }
            }

            public DateTime Nascimento {
                get {
                    return nascimento;
                }
                set {
                    nascimento = value;
                }
            }

            public double Altura {
                get {
                    return altura;
                }
                set {
                    altura = value;
                }
            }
            public void Print() {
                Console.WriteLine($"{nome}");
                Console.WriteLine($"{nascimento}");
                Console.WriteLine($"{altura}");
            }
            public int CalculoIdade() {
                //DateTime.Today.Year – Ano.Year;
                var calculo = DateTime.Now.Year - nascimento.Year;
                return calculo;
            }
        }
        //criar outro metodo int para calcular a idade
        // 2023 - nascimento


        /* public Pessoa(string nome, int nascimento, int altura){
             Nome = nome;
             Nascimento = nascimento;
             Altura = altura;   
         } */


        public static void Executar() {

            Pessoa pessoa1 = new Pessoa();

            pessoa1.Nome = "Wandinha";
            pessoa1.Nascimento = new DateTime(2001, 10, 15);
            pessoa1.Altura = 1.62;

            pessoa1.CalculoIdade();

            // Console.WriteLine($"Olá, meu nome é {nome.Nome}, eu tenho {nome.Nascimento - 2023}, e eu tenho {nome.Altura}");

        }
    }
  }
