using GerEventos.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerEventos.Domain.Entities
{
    public class Evento : BaseEntity<int>
    {
        public Evento()
        {
            Palestrantes = new List<EventoPalestrante>();
            Participantes = new List<EventoInscricao>();
        }

        public Evento(int id, string? nome, DateTime dataEvento, string? descricao, Cidade? Cidade, List<EventoPalestrante> palestrantes, List<EventoInscricao> participantes) : base(id)
        {
            Nome = nome;
            DataEvento = dataEvento;
            Descricao = descricao;
            Palestrantes = palestrantes;
            Participantes = participantes;
        }

        public string? Nome { get; set; }
        public DateTime DataEvento { get; set; }
        public string? Descricao { get; set; }
        public Cidade? Cidade { get; set; }
        public List<EventoPalestrante> Palestrantes { get; set; }
        public List<EventoInscricao> Participantes { get; set; }
    }

    public class EventoInscricao : BaseEntity<int>
    {
        public EventoInscricao()
        {

        }

        public EventoInscricao(DateTime dataInscricao, Evento? Evento, Participante? Participante) : base(id)
        {
            DataInscricao = dataInscricao;
        }

        public DateTime DataInscricao { get; set; }
        public Evento? Evento { get; set; }
        public Participante? Participante { get; set; }
    }


}
