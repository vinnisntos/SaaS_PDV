using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SaaS_PDV.Core.Models.Entities
{
    public class Cargo
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; } = string.Empty;

        // nivel de cargo 0 = vendedor, 1 = gerente, 2 = master admin
        public int Nivel { get; set; } = 0;0
    }
}
