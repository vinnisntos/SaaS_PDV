/* 
Plano (pseudocódigo detalhado):
1. Detectar erro CS0234: 'SaaS_PDV.Core.Models' não existe.
2. Remover o 'using SaaS_PDV.Core.Models;' porque os modelos reais estão em 'SaaS_PDV.Models'.
3. Manter os demais 'using' existentes ('SaaS_PDV.Data' e 'SaaS_PDV.Models').
4. Não alterar mais nada no corpo do arquivo para evitar mudanças não relacionadas.
5. Se, na sua solução, as classes (Empresa, Filial, Cargo, Usuario) estiverem realmente em outro namespace:
   - Alternativa A: adicionar/ajustar o arquivo de modelos para `namespace SaaS_PDV.Core.Models { ... }`
   - Alternativa B: trocar o 'using' para o namespace correto onde as classes estão definidas.
6. Salvar e compilar: o CS0234 deve desaparecer se os tipos estiverem acessíveis via os 'using' presentes.

(Estas instruções estão embutidas como comentário neste arquivo para documentação local.)
*/

using Microsoft.EntityFrameworkCore;
using SaaS_PDV.Data;
using SaaS_PDV.Models;
using System.Linq;

namespace SaaS_PDV.Core.Data
{
    public static class DbInitializer
    {
        public static void Seed()
        {
            using (var context = new AppDbContext())
            {
                // Garante que o banco e as tabelas novas (com Nivel e IsMasterAdmin) existam
                context.Database.EnsureCreated();

                // 1. Cadastro de Empresas (Agora com o campo 'Codigo' para o Login)
                if (!context.Empresas.Any())
                {
                    var engelo = new Empresa
                    {
                        Codigo = "m0245",
                        NomeFantasia = "Engelo Gelo",
                        CNPJ = "11.111.111/0001-11"
                    };

                    var adegaGG = new Empresa
                    {
                        Codigo = "agg01",
                        NomeFantasia = "Adega GG",
                        CNPJ = "22.222.222/0001-22"
                    };

                    context.Empresas.AddRange(engelo, adegaGG);
                    context.SaveChanges();

                    // 2. Cadastro de Filiais vinculadas
                    var matrizEngelo = new Filial { Codigo = "MATRIZ", Nome = "Engelo - Sorocaba", EmpresaId = engelo.Id };
                    var matrizAdega = new Filial { Codigo = "MATRIZ", Nome = "Adega GG - Centro", EmpresaId = adegaGG.Id };

                    context.Filiais.AddRange(matrizEngelo, matrizAdega);
                    context.SaveChanges();
                }

                // 3. Cadastro de Cargos com a nova lógica de NÍVEL
                if (!context.Cargos.Any())
                {
                    context.Cargos.AddRange(
                        new Cargo { Nome = "Vendedor", Nivel = 0 }, // Só PDV
                        new Cargo { Nome = "Gerente", Nivel = 1 },   // Relatórios e Estoque
                        new Cargo { Nome = "Dono", Nivel = 2 }       // Acesso total à empresa
                    );
                    context.SaveChanges();
                }

                // 4. Cadastro do seu usuário (O Super Admin)
                if (!context.Usuarios.Any())
                {
                    var cargoDono = context.Cargos.First(c => c.Nivel == 2);
                    var filialPrincipal = context.Filiais.First();

                    var usuarioMestre = new Usuario
                    {
                        Nome = "Vinnicius Gabriel",
                        Login = "admin",
                        Senha = "123", // Lembre de voltar o PasswordHasher depois
                        CargoId = cargoDono.Id,
                        FilialId = filialPrincipal.Id,
                        IsMasterAdmin = true // VOCÊ: Ignora todas as travas de empresa
                    };

                    context.Usuarios.Add(usuarioMestre);
                }

                context.SaveChanges();
            }
        }
    }
}