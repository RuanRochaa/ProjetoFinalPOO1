using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciamento_de_Escola
{
    // Classe que representa o curso.
    internal class Curso

    {

        // Obtém ou define o nome do curso.
        private string nomeCurso;
        public string NomeCurso
        {
            get { return nomeCurso; }
            set { nomeCurso = value; }
        }
        // Obtém ou define o ID do curso.
        private int idCurso;
        public int IDCurso
        {
            get { return idCurso; }
            set { idCurso = value; }
        }

        // Obtém a lista de cursos disponíveis.
        public List<Curso> ListaCursos { get; set; }

        // Obtém a lista de alunos matriculados no curso.
        public List<Aluno> AlunosMatriculados { get; set; }

        // Obtém a lista de disciplinas oferecidas no curso.
        public List<Disciplina> Disciplinas { get; set; }

        // Inicializa uma nova instância da classe Curso com o nome e ID do curso.

        public object Nome { get; internal set; }
        public object CodigoCurso { get; internal set; }

        public Curso(string nomeCurso, int IDCurso)
        {
            this.nomeCurso = nomeCurso;
            this.IDCurso = IDCurso;
            AlunosMatriculados = new List<Aluno>();
            Disciplinas = new List<Disciplina>();
            ListaCursos = new List<Curso>();

        }

        // Matricula um aluno no curso.
        public void MatricularAluno(Aluno aluno)
        {
            AlunosMatriculados.Add(aluno);
        }

        // Adiciona uma disciplina à lista de disciplinas oferecidas no curso.

        public void AdicionarDisciplina(Disciplina disciplina)
        {
            Disciplinas.Add(disciplina);
        }

        // Adiciona um curso à lista de cursos.
        public void ListarCursos(Curso curso)
        {
            ListaCursos.Add(curso);
        }



    }
}
