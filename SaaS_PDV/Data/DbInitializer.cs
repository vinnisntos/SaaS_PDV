using SaaS_PDV.Models;
using SaaS_PDV.Security;
using System.Linq;

namespace SaaS_PDV.Data
{
    public static class DbInitializer
    {
        public static void Seed()
        {
            using (var context = new AppDbContext())
            {
                context.Database.EnsureCreated();

                // 1. Cadastro de Empresas e Filiais (Se não existirem)
                if (!context.Empresas.Any())
                {
                    var adegaGG = new Empresa { NomeFantasia = "Adega GG", CNPJ = "11.111.111/0001-11" };
                    var psBebidas = new Empresa { NomeFantasia = "PS Bebidas", CNPJ = "22.222.222/0001-22" };
                    context.Empresas.AddRange(adegaGG, psBebidas);
                    context.SaveChanges();

                    var lojaAdega = new Filial { Nome = "Adega GG - Matriz", EmpresaId = adegaGG.Id };
                    var psLoja1 = new Filial { Nome = "PS - Loja 1 (5 De Novembro)", EmpresaId = psBebidas.Id };
                    var psLoja2 = new Filial { Nome = "PS - Loja 2 (Vila Rio Branco)", EmpresaId = psBebidas.Id };
                    var psLoja3 = new Filial { Nome = "PS - Loja 3 (Centro)", EmpresaId = psBebidas.Id };
                    context.Filiais.AddRange(lojaAdega, psLoja1, psLoja2, psLoja3);
                    context.SaveChanges();
                }

                // 2. Cadastro de Cargos (Se não existirem)
                if (!context.Cargos.Any())
                {
                    context.Cargos.AddRange(
                        new Cargo { Nome = "Admin" },
                        new Cargo { Nome = "Caixa" }
                    );
                    context.SaveChanges();
                }

                // 3. Cadastro do Usuário "Teste da Silva"
                if (!context.Usuarios.Any())
                {
                    var cargoAdmin = context.Cargos.First(c => c.Nome == "Admin");
                    var loja1PS = context.Filiais.FirstOrDefault(f => f.Nome.Contains("5 De Novembro"));

                    if (loja1PS != null) // AGORA SIM: Se a loja EXISTIR, cria o usuário
                    {
                        var usuarioTeste = new Usuario
                        {
                            Nome = "Teste da Silva",
                            Login = "teste.silva",
                            Senha = PasswordHasher.HashPassword("123456"),
                            CargoId = cargoAdmin.Id,
                            FilialId = loja1PS.Id
                        };
                        context.Usuarios.Add(usuarioTeste);
                    }
                }

                // 4. Cadastro de Produtos e Estoque (Se não existirem)
                if (!context.Produtos.Any())
                {
                    var heineken = new Produto { Descricao = "Heineken 600ml", CodigoBarras = "7891234567890", PrecoVenda = 15.50m };
                    context.Produtos.Add(heineken);
                    context.SaveChanges();

                    // Pega as filiais do PS para o estoque
                    var filiaisPS = context.Filiais.Where(f => f.Nome.Contains("PS")).ToList();

                    if (filiaisPS.Count >= 3)
                    {
                        context.Estoques.AddRange(
                            new Estoque { ProdutoId = heineken.Id, FilialId = filiaisPS[0].Id, Quantidade = 50 },
                            new Estoque { ProdutoId = heineken.Id, FilialId = filiaisPS[1].Id, Quantidade = 120 },
                            new Estoque { ProdutoId = heineken.Id, FilialId = filiaisPS[2].Id, Quantidade = 10 }
                        );
                    }
                }

                context.SaveChanges();
            }
        }
    }
}