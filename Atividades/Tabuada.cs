using System;

namespace CursoCSharp.Atividades {
    class Tabuada {

        public static void Executar() {

            Console.WriteLine("Digite um número");
            int tabuada = Int32.Parse(Console.ReadLine());

            Console.WriteLine($"{tabuada} x 1 = { tabuada * 1}");
            Console.WriteLine($"{tabuada} x 2 = { tabuada * 2}");
            Console.WriteLine($"{tabuada} x 3 = { tabuada * 3}");
            Console.WriteLine($"{tabuada} x 4 = { tabuada * 4}");
            Console.WriteLine($"{tabuada} x 5 = { tabuada * 5}");
            Console.WriteLine($"{tabuada} x 6 = { tabuada * 6}");
            Console.WriteLine($"{tabuada} x 7 = { tabuada * 7}");
            Console.WriteLine($"{tabuada} x 8 = { tabuada * 8}");
            Console.WriteLine($"{tabuada} x 9 = { tabuada * 9}");
            Console.WriteLine($"{tabuada} x 10 = { tabuada * 10}");
        }
    }
}
