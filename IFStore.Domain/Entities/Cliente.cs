using IFStore.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFStore.Domain.Entities
{
    public class Cliente : BaseEntity<int>
    {
        public Cliente() { }
        public String Nome { get; set; }
        public String Endereco { get; set; }
        public String Documento { get; set; }
        public String Bairro { get; set; }
        public Cidade Cidade { get; set; }


    }
}
