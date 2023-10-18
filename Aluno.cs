using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciamento_de_Escola
{

    // Classe que representa um aluno em um sistema de gerenciamento escolar.
    internal class Aluno : Pessoa
    {
        // Obtém ou define o curso

        private string curso;
        public string Curso
        {
            get { return curso; }
            set { curso = value; }
        }

        // Obtém ou define o número de matrícula do aluno.
        private int matricula;
        public int Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }

        // Obtém a lista de cursos matriculados pelo aluno.
        public List<Curso> CursosMatriculados { get; set; }

        // Inicializa uma nova instância da classe Aluno com o nome, idade, endereço, celular e matrícula.
        public Aluno(string nome, int idade, string endereco, int celular, int matricula) : base(nome, idade, endereco, celular)
        {
            
            this.matricula = matricula;
            CursosMatriculados = new List<Curso>();
        }

        // Matricula o aluno em um curso.
        public void MatricularEmCurso(Curso curso)
    {
        CursosMatriculados.Add(curso);
    }

       

        

    }
}
