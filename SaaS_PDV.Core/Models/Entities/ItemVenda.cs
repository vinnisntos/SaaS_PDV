using SaaS_PDV.Core.Models.Entities;
using SeuProjeto.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SaaS_PDV.Core.Models.Entities
{
    [Table("ItensVenda")]
    public class ItemVenda
    {
        [Key]
        public int Id { get; set; }

        public int Quantidade { get; set; }
        public decimal PrecoUnitario { get; set; }
        public decimal SubTotal { get; set; }

        public int IdVenda { get; set; }
        public int IdProduto { get; set; }

        // Navegação inversa (Do item pra venda)
        [ForeignKey("IdVenda")]
        public virtual Venda Venda{ get; set; } = new Venda();

        [ForeignKey("IdProduto")]
        public virtual Produto Produto { get; set; } = new Produto();
    }
}