using Gerenciamento_de_Escola;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace escola
{
    public class Program
    {
        private static string endereco;
        private static int celular;
        private static int salario;
        private static string lecionando;

        internal static List<Aluno> ListaAlunos { get; set; } = new List<Aluno>();
        internal static List<Professor> ListaProfessores { get; set; } = new List<Professor>();
        internal static List<Curso> ListaCursos { get; set; } = new List<Curso>();
        internal static List<Disciplina> ListaDisciplinas { get; set; } = new List<Disciplina>();


        static void Main(string[] args)
        {
            while (true)
            {

                Console.WriteLine("Menu:");
                Console.WriteLine("1- Cadastrar Aluno");
                Console.WriteLine("2- Cadastrar Professor");
                Console.WriteLine("3- Cadastrar Curso");
                Console.WriteLine("4- Cadastrar Disciplina");
                Console.WriteLine("5- Matricular Aluno no Curso");
                Console.WriteLine("6- Listar Alunos(as)");
                Console.WriteLine("7- Listar Proferrores(as)");
                Console.WriteLine("8- Listar Cursos");
                Console.WriteLine("9- Listar disciplinas");
                Console.WriteLine("0- Sair");

                int opcao = int.Parse(Console.ReadLine());

                try
                {
                    switch (opcao)
                    {
                        case 1:
                            CadastrarAluno();
                            break;
                        case 2:
                            CadastrarProfessor();
                            break;
                        case 3:
                            CadastrarCurso();
                            break;
                        case 4:
                            CadastrarDisciplina();
                            break;
                        case 5:
                            MatricularAlunoCurso();
                            break;
                        case 6:
                            ListarAlunos();
                            break;
                        case 7:
                            ListarProfessores();
                            break;
                        case 8:
                            ListarCursos();
                            break;
                        case 9:
                            ListarDisciplinas();
                            break;
                        case 0:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Opção inválida. Tente novamente.");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Erro: Entrada inválida. Certifique-se de inserir um número válido.");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Erro: {e.Message}");
                }



            }

            /// <summary>
            /// Cadastra um novo aluno.
            /// </summary>

            static void CadastrarAluno()
            {
                Console.WriteLine("Digite o nome do aluno(a): ");
                string nome = Console.ReadLine();
                Console.WriteLine("Digite a idade do aluno(a): ");
                int idade = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o endereço do aluno(a): ");
                string endereco = Console.ReadLine();
                Console.WriteLine("Digite o numero de celular do aluno(a): ");
                int celular = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite a matricula do aluno(a): ");
                int matricula = int.Parse(Console.ReadLine());


                Aluno aluno = new Aluno(nome, idade, endereco, celular, matricula);
                ListaAlunos.Add(aluno);

                Console.WriteLine("Aluno cadastrado com sucesso!");


            }

            /// <summary>
            /// Cadastra um novo professor.
            /// </summary>

            static void CadastrarProfessor()
            {
                Console.WriteLine("Digite o nome do professor: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Digite a idade do professor: ");
                int idade = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite a endereço do professor: ");
                string endereco = Console.ReadLine();
                Console.WriteLine("Digite o celular do professor: ");
                int celular = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o salario do professor: ");
                int salario = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite a disciplina do professor: ");
                string lecionando = Console.ReadLine();


                Professor professor = new Professor(nome, idade, endereco, celular, salario, lecionando);
                ListaProfessores.Add(professor);

                Console.WriteLine("Professor cadastrado com sucesso!");
            }

            /// <summary>
            /// Cadastra um novo curso.
            /// </summary>
            static void CadastrarCurso()
            {
                Console.WriteLine("Digite o nome do curso: ");
                string nomeCurso = Console.ReadLine();
                Console.WriteLine("Digite o código do curso: ");
                int iDCurso = int.Parse(Console.ReadLine());

                Curso curso = new Curso(nomeCurso, iDCurso);
                ListaCursos.Add(curso);

                Console.WriteLine("Curso cadastrado com sucesso!");
            }


            /// <summary>
            /// Cadastra uma nova disciplina.
            /// </summary>
            static void CadastrarDisciplina()
            {
                Console.WriteLine("Digite o título da disciplina: ");
                string titulo = Console.ReadLine();
                Console.WriteLine("Digite a carga horária da disciplina: ");
                int cargaHoraria = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite a ementa da disciplina: ");
                string ementa = Console.ReadLine();

                Disciplina disciplina = new Disciplina(titulo, cargaHoraria, ementa);
                ListaDisciplinas.Add(disciplina);

                Console.WriteLine("Disciplina cadastrada com sucesso!");
            }
            /// <summary>
            /// Matricula um aluno em um curso.
            /// </summary>

            static void MatricularAlunoCurso()
            {
                Console.WriteLine("Digite a matrícula do aluno:");
                int matriculaAluno = int.Parse(Console.ReadLine());

                Aluno aluno = ListaAlunos.FirstOrDefault(a => a.Matricula == matriculaAluno);

                if (aluno != null)
                {
                    Console.WriteLine("Digite o código do curso:");
                    string codigoCurso = Console.ReadLine();

                    Curso curso = ListaCursos.FirstOrDefault(c =>
                    {
                        return c.IDCurso.Equals(codigoCurso);
                    });

                    if (curso != null)
                    {
                        aluno.MatricularEmCurso(curso);
                        curso.MatricularAluno(aluno);
                        Console.WriteLine("Aluno matriculado no curso com sucesso.");
                    }
                    else
                    {
                        Console.WriteLine("Curso não encontrado.");
                    }
                }
                else
                {
                    Console.WriteLine("Aluno não encontrado.");
                }
            }

            /// <summary>
            /// Listar alunos.
            /// </summary>

            static void ListarAlunos()
            {
                if (ListaAlunos.Count == 0)
                {
                    Console.WriteLine("Não há alunos cadastrados.");
                }
                else
                {
                    Console.WriteLine("Lista de Alunos:");
                    foreach (var aluno in ListaAlunos)
                    {
                        Console.WriteLine($"Nome: {aluno.Nome}, Idade: {aluno.Idade}, Endereço:{aluno.Endereco}, Matrícula: {aluno.Matricula}");
                    }
                }
            }

            /// <summary>
            /// Listar professores.
            /// </summary>
            static void ListarProfessores()
            {
                if (ListaProfessores.Count == 0)
                {
                    Console.WriteLine("Não há professores cadastrados.");
                }
                else
                {
                    Console.WriteLine("Lista de Professores:");
                    foreach (var professor in ListaProfessores)
                    {
                        Console.WriteLine($"Nome: {professor.Nome}, Idade: {professor.Idade}");
                    }
                }
            }


            /// <summary>
            /// Listar cursos.
            /// </summary>


            static void ListarCursos()
            {
                if (ListaCursos.Count == 0)
                {
                    Console.WriteLine("Não há cursos cadastrados.");
                }
                else
                {
                    Console.WriteLine("Lista de Cursos:");
                    foreach (var curso in ListaCursos)
                    {
                        Console.WriteLine($"Nome: {curso.NomeCurso}, Código do Curso: {curso.IDCurso}");
                    }
                }
            }
            /// <summary>
            /// Listar disciplinas.
            /// </summary>

            static void ListarDisciplinas()
            {
                if (ListaDisciplinas.Count == 0)
                {
                    Console.WriteLine("Não há disciplinas cadastradas.");
                }
                else
                {
                    Console.WriteLine("Lista de Disciplinas:");
                    foreach (var disciplina in ListaDisciplinas)
                    {
                        Console.WriteLine($"Título: {disciplina.Titulo}, Carga Horária: {disciplina.CargaHoraria}, Ementa: {disciplina.Ementa}");
                    }
                }
            }







        }






    }
}