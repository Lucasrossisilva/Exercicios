﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    class ExercicioTres {
        public static void Executar() {

            Console.WriteLine("Digite a primeira nota:");
            int nota1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota:");
            int nota2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a terceira nota:");
            int nota3 = int.Parse(Console.ReadLine());

            Console.WriteLine($" A média do aluno é {(nota1 + nota2 + nota3) / 2}");

            

        }

    }
}
