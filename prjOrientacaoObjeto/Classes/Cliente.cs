using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjOrientacaoObjeto.Classes
{
    public partial class Cliente
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public int Tipo { get; set; }
        public DateTime DataCadastro { get; set; }
        public List<Contato> Contatos { get; set; }
    }
}