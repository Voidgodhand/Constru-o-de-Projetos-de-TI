using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Desenvolvedora
    {
        public Int64 Cnpj { get; set; }
        public String Nome { get; set; }
        public String Presidente { get; set; }
        public String Fundador { get; set; }
        public String Fundacao { get; set; }
        public Int64 NumeroEmpregados { get; set; }
        public String Tipo{ get; set; }
        public List<Jogo> jogos { get; set; }
        
    }
}
