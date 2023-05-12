using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Variaveis e Constantes - Fundamentos",VariaveisEConstantes.Executar },
                {"Notação Ponto - Fundamentos ",NotacaoPonto.Executar },
                {"Lendo Dados - Fundamentos",LendoDados.Executar },
                {"Formatando Números - Fundamentos ",FormatandoNumeros.Executar},
                {"Exercício 1 - Fundamentos ",ExercicioUm.Executar},
                {"Exercício 2 - Fundamentos ",ExercicioDois.Executar},
                {"Exercício 3 - Fundamentos ",ExercicioTres.Executar},
                {"Operadores Relacionais - Fundamentos ",OperadoresRelacionais.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}