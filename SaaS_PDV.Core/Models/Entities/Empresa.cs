using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SaaS_PDV.Core.Models.Entities
{
    [Table("Empresas")] // Garante que o EF ache a tabela certa no SQL
    public class Empresa
    {
        [Key] // Avisa que esse é o ID (Primary Key)
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string Codigo { get; set; } = string.Empty;

        [Required]
        [MaxLength(100)]
        public string NomeFantasia { get; set; } = string.Empty;

        [Required]
        [MaxLength(18)]
        public string CNPJ { get; set; } = string.Empty;

        public bool Ativo { get; set; }
        public DateTime DataCadastro { get; set; }
        public string CriadoPor { get; set; } = string.Empty;
    }
}