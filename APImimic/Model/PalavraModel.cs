using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APImimic.Model
{
    public class PalavraModel
    {
        public int Id { get; set; }
        public string Nome{ get; set; }
        public int Pontuacao { get; set; }
        public bool Ativo { get; set; }
        public DateTime CriadoDate { get; set; }
        public DateTime?AtualizadoDate { get; set; }

    }
}
