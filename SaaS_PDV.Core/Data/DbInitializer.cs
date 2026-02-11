/* 
Plano de Ação para Implementação do DbInitializer:
1. **Criar a Classe DbInitializer**: Já temos a classe `DbInitializer` criada como um esqueleto. Vamos preenchê-la com o código necessário para popular o banco de dados.
2. **Adicionar Método Initialize**: Dentro da classe `DbInitializer`, vamos criar um método estático chamado `Initialize` que receberá uma instância do `AppDbContext`. Este método será responsável por verificar se o banco de dados já foi populado e, caso contrário, adicionar os dados iniciais.
3. **Verificar Existência de Dados**: No método `Initialize`, vamos verificar se já existem dados nas tabelas principais (como `Empresas`, `Filiais`, `Usuarios`, etc.). Se os dados já existirem, o método pode simplesmente retornar sem fazer nada.
4. **O Banco de dados no Azure ja possui dados de teste. Portanto, o código de inserção de dados iniciais pode ser omitido ou comentado, dependendo da necessidade. Se for necessário inserir dados adicionais, podemos adicionar o código de inserção aqui.
5. **Chamar o DbInitializer**: No ponto de entrada da aplicação (como no `Program.cs` ou `Startup.cs`), vamos chamar o método `DbInitializer.Initialize` passando uma instância do `AppDbContext`. Isso garantirá que o banco de dados seja inicializado com os dados necessários toda vez que a aplicação for executada.


(Estas instruções estão embutidas como comentário neste arquivo para documentação local.)
*/

using SaaS_PDV.Core.Models.Entities;
using SaaS_PDV.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System;

namespace SaaS_PDV.Core.Data
{
    public static class DbInitializer
    {
        public static void Initialize(AppDbContext context)
        {
            // 1. Aplica migrações pendentes no Azure automaticamente
            context.Database.Migrate();

            // 2. Verifica se já existem empresas cadastradas
            if (context.Empresas.Any())
            {
                return; // O banco já tem dados, não faz nada
            }

            // --- INÍCIO DA PLANTAÇÃO (SEED) ---

            // 3. Criar a Empresa Master (O dono do SaaS)
            var empresaMaster = new Empresa
            {
                Codigo = "EMP-001",
                NomeFantasia = "SaaS Admin Master",
                CNPJ = "00.000.000/0001-99",
                Ativo = true,
                DataCadastro = DateTime.Now,
                CriadoPor = "Sistema"
            };
            context.Empresas.Add(empresaMaster);
            context.SaveChanges(); // Salva para gerar o ID que a Filial vai usar

            // 4. Criar a Filial Matriz
            var filialMatriz = new Filial
            {
                // Filial não possui a propriedade 'Codigo' no modelo; usar apenas Nome e referenciar a empresa pelo IdEmpresa
                Nome = "Matriz Sorocaba",
                IdEmpresa = empresaMaster.Id
            };
            context.Filiais.Add(filialMatriz);

            // 5. Criar o Cargo Administrativo
            var cargoAdmin = new Cargo
            {
                Nome = "Master Admin",
                Nivel = 99
            };
            context.Cargos.Add(cargoAdmin);
            context.SaveChanges();

            // 6. Criar o seu Usuário de acesso
            var usuarioMaster = new Usuario
            {
                Nome = "Vinnicius Matos",
                Login = "admin",
                Senha = "123", // Lembre-se de implementar Hash depois!
                IsMasterAdmin = true,
                CargoId = cargoAdmin.Id,
                FilialId = filialMatriz.Id
            };
            context.Usuarios.Add(usuarioMaster);

            // Salva o restante
            context.SaveChanges();
        }
    }
}