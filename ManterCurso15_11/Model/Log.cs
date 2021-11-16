using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ManterCurso15_11.Model
{
    public class Log
    {

        public int ID { get; set; }

        public DateTime DataInclusao { get; set; }

        public DateTime DataUltimaAtualizacao { get; set; }


        public int CursoId { get; set; }

        public Curso Curso { get; set; }
    }
}
