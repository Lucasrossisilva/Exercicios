using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {

    class Cliente {
        //atributos de Cliente
        public string Nome;
        public string Cpf;
        public string Sexo;
        public string Endereco;
        public int Idade;

        public Cliente(string nome, string cpf, string sexo, string endereco, int idade) {
            Nome = nome;
            Cpf = cpf;
            Sexo = sexo;
            Endereco = endereco;
            Idade = idade;

        }

        public Cliente() {
        }
    }

    class Construtores {

        public static void Executar() {
            var cliente1 = new Cliente(); 
            cliente1.Nome = "Cleber";
            cliente1.Cpf = "42188348800";
            cliente1.Sexo = "M";
            cliente1.Endereco = "Vila Pires";
            cliente1.Idade = 70;

            var cliente2 = new Cliente("Rogério Ceni", "12345678910", "M", "Ramiro Corleoni", 40);

            var cliente3 = new Cliente() {
                Nome = "Amanda",
                Sexo = "F",
                Endereco = "Avenida Portugal",
                Idade = 25
            };







        }
    }
}
