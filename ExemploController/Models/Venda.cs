namespace ExemploController.Models
{
    public class Venda
    {
        public int VendaId { get; set; }
        public int ProdutoId { get; set; }
        public Produto? Produto { get; set; }
        public int ClienteId { get; set; }
        public Cliente? Cliente { get; set; }
        public int Quantidade { get; set; }

        public DateOnly Data { get; set; }
    }
}
