using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Atividades {
    class ExercicioPropriedades {

        class Aluno {

            double nota1;
            double nota2;
            double nota3;

            public double Nota1 { get; set; }
            public double Nota2 { get; set; }
            public double Nota3 { get; set; }

            public double Media() {
                return (Nota1 + Nota2 + Nota3) / 3;
            }

            public void Print() {
                Console.WriteLine($"O resultado da sua média é:");
                Console.WriteLine(Media());
            }
        }
        public static void Executar() {
            var aluno1 = new Aluno();
            aluno1.Nota1 = 6.5;
            aluno1.Nota2 = 9.6;
            aluno1.Nota3 = 3.4;
            aluno1.Print();
        }
    }
}
