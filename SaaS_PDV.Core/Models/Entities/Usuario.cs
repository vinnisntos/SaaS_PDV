using SaaS_PDV.Core.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SaaS_PDV.Core.Models.Entities
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; } = string.Empty;
        [Required]
        public string Login { get; set; } = string.Empty;
        [Required]
        public string Senha { get; set; } = string.Empty;

        public int CargoId { get; set; }
        public virtual Cargo Cargo { get; set; } = null!;

        public bool IsMasterAdmin { get; set; } = false;

        public int FilialId { get; set; }
        public virtual Filial Filial { get; set; } = null!;
    }
}
