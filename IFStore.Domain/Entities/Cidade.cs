using IFStore.Domain.Base;


namespace IFStore.Domain.Entities
{
    public class Cidade : BaseEntity<int>
    {
        public Cidade() { }
        public String Nome { get; set; }
        public String Estado { get; set; }
    }
}