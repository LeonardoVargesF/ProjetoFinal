using IFStore.Domain.Base;


namespace IFStore.Domain.Entities
{
    public class Cidade : BaseEntity<int>
    {
        public Cidade() { }
        public String nome { get; set; }
        public String estado { get; set; }
    }
}