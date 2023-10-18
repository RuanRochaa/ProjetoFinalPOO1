using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciamento_de_Escola
{

    public class Disciplina
    {
        //Obtém ou define o título da disciplina.
        public string Titulo { get; set; }

        // Obtém ou define a carga horária da disciplina.
        public int CargaHoraria { get; set; }

        // Obtém ou define a ementa da disciplina.
        public string Ementa { get; set; }

        // Obtém ou define o código da disciplina.
        public string? CodigoDisciplina { get; internal set; }

        // Inicializa uma nova instância da classe Disciplina com o título, carga horária e ementa.
        public Disciplina(string titulo, int cargaHoraria, string ementa)
        {
            Titulo = titulo;
            CargaHoraria = cargaHoraria;
            Ementa = ementa;
        }

    }
}
