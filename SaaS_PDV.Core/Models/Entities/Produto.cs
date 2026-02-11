using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SaaS_PDV.Core.Models.Entities
{
    public class Produto
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Descricao { get; set; } = string.Empty;
        public string CodigoBarras { get; set; } = string.Empty;
        public decimal PrecoVenda { get; set; }
    }
}
