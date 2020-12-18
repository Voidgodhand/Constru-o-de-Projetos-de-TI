using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Console
    {
        public Int64 Numero { get; set; }
        public String Nome { get; set; }
        public String Fabricante { get; set; }
        public Int32 Tipo { get; set; }
        public String Lancamento { get; set; }
        public Int32 Geracao { get; set; }
        public Boolean TravaFisica { get; set; }
        public Boolean TravaLogica { get; set; }
        public List<Acessorio> acessorios { get; set; }
        public List<Controle> controles { get; set; }
        public List<Jogo> jogos { get; set; }

    }
}
