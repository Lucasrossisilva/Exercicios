using System;
using System.Collections.Generic;
using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.Atividades;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;


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
                {"Operadores Atribuição - Fundamentos ",OperadoresAtribuicao.Executar},

                //outra pasta
                 {"Estrutura If - Estruturas de Controle ",EstruturaIf.Executar},
                 {"Exercício Voto  - Estruturas de Controle",ExercicioVoto.Executar},
                 {"Exercício Senha  - Estruturas de Controle ",ExercicioSenha.Executar},
                 {"Exercício Notas  - Estruturas de Controle",ExercicioNotas.Executar},
                 {"Exercício IMC  - Estruturas de Controle",ExercicioIMC.Executar},
                 {"Estrutura Switch  - Estruturas de Controle",EstruturaSwitch.Executar},
                 {"Exercício DDD  - Estruturas de Controle",ExercicioDDD.Executar},
                 {"Exercício While e For - Estruturas de Controle",EstruturaWhileEFor.Executar},
                  {"Exercício For e Each  - Estruturas de Controle",EstruturaForEach.Executar},

                //pasta classes
                {"Membros - Classes e Métodos",Membros.Executar},
                {"Construtores - Classes e Métodos",Construtores.Executar},
                {"Metodos com Retorno - Classes e Métodos",MetodosComRetorno.Executar},
                {"Exercício Metodos com Retorno - Classes e Métodos",ExerciciosMetodosComRetorno.Executar},
                {"Exercicio Celsiu e fahrenheit - Classes e Método",ExercicioConverterCF.Executar},
                {"Metodos Estaticos - Classes e Métodos",MetodosEstaticos.Executar},
                {"Param - Classes e Métodos",Param.Executar},
                {"GetSet - Classes e Métodos",GetSet.Executar},
                {"GetSet Segundo Exemplo - Classes e Métodos",GetESetSegundoExemplo.Executar},
                
                //pasta atividades
                 {"Exercício Soma no final - Atividades",ExercicioSoma.Executar},
                 {"Tabuada - Atividades",Tabuada.Executar},
                 {"Exibir Saída - Atividades",ExibirSaida.Executar},
                 {"Exercicio Atributos - Atividades",ExercicioAtributo.Executar},
                 {"Exercicio Propriedades - Atividades",ExercicioPropriedades.Executar},
                 {"Exercicio Animais  - Atividades",ExercicioAnimais.Executar},

                 //pasta Colecoes
                 {"Queue - Coleções",Queue.Executar},




            });

            central.SelecionarEExecutar();
        }
    }
}