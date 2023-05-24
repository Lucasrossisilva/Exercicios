using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    class game {

        public string Nome;

        public string Apresentar() {
            return string.Format($"O melhor jogo de todos os tempos é {Nome}");
        }
         public void ApresentarNoConsole() {
            
          Console.WriteLine(Apresentar());
            }
    }
}
