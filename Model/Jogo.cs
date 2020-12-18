using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Jogo
    {
        public Int64 Codigo { get; set; }
        public String Nome { get; set; }
        public String Franquia { get; set; }
        public String Lancamento { get; set; }
        public Int32 Genero { get; set; }
        public Int32 Midia { get; set; }
        public Int64 Cnpj { get; set; }
        public Int64 Numero { get; set; }
    }
}
