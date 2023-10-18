using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciamento_de_Escola
{

    // Classe base que representa uma pessoa com atributos como nome, idade, endereço e celular.
    internal class Pessoa
    {

        // Obtém ou define o nome da pessoa.
        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        // Obtém ou define a idade da pessoa.
        private int idade;
        public int Idade
        {
            get { return idade; }
            set { idade = value; }
        }

        // Obtém ou define o endereço da pessoa.
        private string endereco;
        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }


        // Obtém ou define o número de celular da pessoa.
        private int celular;
        public int Celular
        {
            get { return celular; }
            set { celular = value; }
        }

        // Inicializa uma nova instância da classe Pessoa com o nome, idade, endereço e celular.
        public Pessoa(string nome, int idade, string endereco, int celular)
        {
            this.nome = nome;
            this.idade = idade;
            this.endereco = endereco;
            this.celular = celular;
        }


        // Exibe informações sobre a pessoa, incluindo nome, idade, endereço e número de celular.
        public void InfoPessoa()
        {
            Console.WriteLine(" Seu nome é " + nome + " você tem " + idade + " anos, mora em " + endereco + " e seu numero de contato é " + celular);
        }

    }



}
