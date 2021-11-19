using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ManterCurso15_11.Model
{
    public class Curso
    {
        [Key]
        public int CursoId { get; set; }
        public string Descricao { get; set; }
        [Required]
        public DateTime DataInicio { get; set; }
        [Required]
        public DateTime DataTermino { get; set; }

        public int QtdAlunosTurma { get; set; }
    
        public string NomeCategoria { get; set; }

        public Categoria Categoria { get; set; }

    }
}
