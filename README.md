# 🛒 SaaS PDV - Gestão Multi-empresa

Este é um sistema de Ponto de Venda (PDV) e Gestão Financeira focado em escalabilidade para pequenos e médios negócios. O diferencial deste projeto é a arquitetura **Multi-tenant**, permitindo que múltiplas empresas e suas respectivas filiais utilizem a mesma infraestrutura com isolamento de dados.

## 🚀 Tecnologias Utilizadas

* **Linguagem:** C#
* **Framework:** .NET 10 (Windows Forms)
* **ORM:** Entity Framework Core
* **Banco de Dados:** SQLite (Fácil portabilidade e configuração)
* **Segurança:** Criptografia de senhas com Password Hashing

## 🏗️ Arquitetura e Funcionalidades

O sistema foi desenhado para suportar um modelo de negócio SaaS:

-   **Multi-empresa & Multi-filial:** Gestão centralizada onde uma conta "Master" pode gerir várias empresas e cada empresa suas próprias lojas.
-   **Controle de Estoque:** Gestão de produtos vinculada a filiais específicas.
-   **Gestão de Utilizadores:** Sistema de cargos (Admin, Vendedor, Estoquista) com permissões distintas.
-   **Financeiro:** Base para fluxo de caixa e registo de vendas (em desenvolvimento).

## 📂 Organização do Projeto

O código segue padrões de organização para facilitar a manutenção:

- `/Models`: Entidades do domínio e regras de negócio.
- `/Data`: Contexto do banco de dados e configurações do EF Core.
- `/Forms`: Interface de utilizador organizada por módulos.
- `/Migrations`: Histórico de evolução do banco de dados.

## 🔧 Como Executar

1. Clone o repositório:
   ```bash
   git clone [https://github.com/vinnisntos/SaaS_PDV.git](https://github.com/vinnisntos/SaaS_PDV.git)

2. Certifique-se de ter o SDK do .NET 10 instalado.

3. Abra a solução .slnx no Visual Studio 2022.

4. O banco de dados SQLite será criado automaticamente ao rodar o projeto através das Migrations.



Desenvolvido por Vinnicius Gabriel – Estudante de Análise e Desenvolvimento de Sistemas (UNIP Sorocaba).
----------------------------------------------------------------------------------------------------------------
