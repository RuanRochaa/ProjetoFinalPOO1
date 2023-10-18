using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciamento_de_Escola
{
    // Classe que representa um professor.

    internal class Professor : Pessoa
    {
        // Obtém ou define o salário do professor.
        private int salario;
        public int Salario
        {
            get { return salario; }
            set { salario = value; }
        }

        // Obtém ou define as disciplinas que o professor está lecionando.

        private string lecionando;
        public string Lecionando
        {
            get { return lecionando; }
            set { lecionando = value; }
        }

        // Obtém a lista de disciplinas lecionadas pelo professor.
        public List<Disciplina> DisciplinasLecionadas { get; set; }

        // Inicializa uma nova instância da classe Professor com o nome, idade, endereço, celular, salário e disciplinas que o professor está lecionando.

        public Professor(string? nome, int idade, string endereco, int celular, int salario, string lecionando) : base(nome, idade, endereco, celular)
        {
            this.lecionando = lecionando;
            this.salario = salario;
            DisciplinasLecionadas = new List<Disciplina>();

        }
         

    }
}
