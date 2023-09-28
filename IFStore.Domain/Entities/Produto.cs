using IFStore.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFStore.Domain.Entities
{
    public class Produto : BaseEntity<int>
    {
        public Produto() { }
        public String Nome { get; set; }
        public Decimal Preco { get; set; }
        public int Quantidade { get; set; }
        public DateOnly Data { get; set; }
        public String UnidadeVenda { get; set; }
        public Grupo Grupo { get; set; }



    }
}
