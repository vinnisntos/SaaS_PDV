using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SaaS_PDV.Models
{
    // O Cliente do seu SaaS (ex: Adega GG ou PS Bebidas)
    public class Empresa
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(10)]
        public string Codigo { get; set; } = string.Empty;

        [Required]
        public string NomeFantasia { get; set; } = string.Empty;
        public string CNPJ { get; set; } = string.Empty;
        public bool Ativo { get; set; } = true;

        // Inicializar a lista para evitar NullReferenceException
        public virtual ICollection<Filial> Filiais { get; set; } = new List<Filial>();

        public DateTime DataCadastro { get; set; } = DateTime.Now;
        public string CriadoPor { get; set; } = string.Empty;
    }


    // A Filial da Empresa (ex: Loja 1, Loja 2)
    public class Filial
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(10)]
        public string Codigo { get; set; } = string.Empty;

        [Required]
        public string Nome { get; set; } = string.Empty;

        public int EmpresaId { get; set; }
        public virtual Empresa Empresa { get; set; } = null!; // null! avisandow o compilador que o EF cuidará disso
    }

    public class Produto
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Descricao { get; set; } = string.Empty;
        public string CodigoBarras { get; set; } = string.Empty;
        public decimal PrecoVenda { get; set; }
    }

    public class Estoque
    {
        [Key]
        public int Id { get; set; }

        public int ProdutoId { get; set; }
        public virtual Produto Produto { get; set; } = null!;

        public int FilialId { get; set; }
        public virtual Filial Filial { get; set; } = null!;

        public int Quantidade { get; set; }
    }

    public class Cargo
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; } = string.Empty;
    }

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