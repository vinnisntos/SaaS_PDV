using SaaS_PDV.Core.Models.Entities;
using SeuProjeto.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SaaS_PDV.Core.Models.Entities
{
    public class Estoque
    {
        [Key]
        public int Id { get; set; }

        public int ProdutoId { get; set; }
        public virtual Produto Produto { get; set; } = null!;

        public int FilialId { get; set; }
        public virtual Filial Filial{ get; set; } = null!;

        public int Quantidade { get; set; }
    }
}
