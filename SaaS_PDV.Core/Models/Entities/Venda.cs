using SaaS_PDV.Core.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SeuProjeto.Entities
{
    [Table("Vendas")]
    public class Venda
    {
        [Key]
        public int Id { get; set; }

        public DateTime DataVenda { get; set; }
        public decimal ValorTotal { get; set; }
        public string Status { get; set; } = string.Empty;

        // Chaves Estrangeiras (Foreign Keys)
        public int IdFilial { get; set; }
        public int IdUsuario { get; set; }

        // Navegação (Isso permite fazer venda.ItensVenda no código)
        // O "virtual" é pro Entity Framework fazer o carregamento inteligente (Lazy Loading)
        public virtual ICollection<ItemVenda> ItensVenda { get; set; } = null!;
    }
}