using SaaS_PDV.Core.Models.Entities;
using SeuProjeto.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SaaS_PDV.Core.Models.Entities
{
    [Table("Filiais")]
    public class Filial
    {
        [Key]
        public int Id { get; set; }

        // Código identificador da Filial
        public string Codigo { get; set; } = string.Empty;

        [Required]
        public string Nome { get; set; } = string.Empty;

        public string CNPJ { get; set; } = string.Empty;

        // Chave estrangeira para a Empresa (Mãe)
        public int IdEmpresa { get; set; }

        [ForeignKey("IdEmpresa")]
        public virtual Empresa Empresa { get; set; } = null!;


        // --- O UPGRADE (A Novidade) ---

        // Isso diz pro C#: "Uma filial pode ter MUITAS vendas"
        public virtual ICollection<Venda> Vendas { get; set; } = null!;

        // Isso diz pro C#: "Uma filial tem MUITOS usuários"
        public virtual ICollection<Usuario> Usuarios { get; set; } = null!;

        // Isso diz pro C#: "Uma filial tem MUITO estoque"
        public virtual ICollection<Estoque> Estoques { get; set; } = null!;
    }
}