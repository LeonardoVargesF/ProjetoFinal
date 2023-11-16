using GerEventos.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerEventos.Domain.Entities
{
    public class Palestrante : BaseEntity<int>
    {
        public Palestrante()
        {

        }

        public Palestrante(int id, string? nome, string? email, int cpf, Cidade? Cidade, int telefone, string? especializacao) : base(id)
        {
            Nome = nome;
            Email = email;
            CPF = cpf;
            Telefone = telefone;
            Especializacao = especializacao;
        }

        public string? Nome { get; set; }
        public string? Email { get; set; }
        public int CPF { get; set; }
        public int Telefone { get; set;}
        public string? Especializacao { get; set; }
        public Cidade? Cidade { get; set; }
    }
}

