# 🚀 SaaS PDV - Versão 2.0 (Interface Pro)

Bem-vindo à evolução do **SaaS PDV**. Esta versão (v2.0) foca na experiência do utilizador e num design moderno, inspirado nos padrões do Figma, utilizando o que há de mais recente no ecossistema .NET.

## 🎨 O que há de novo na v2.0?

Nesta branch `guna-interface`, o sistema deixou de ter aquele aspeto padrão do Windows e passou a ter uma identidade visual de elite:
- **Dark Mode Nativo:** Interface focada em produtividade e conforto visual.
- **Guna UI2 Framework:** Componentes modernos, arredondados e animados.
- **FontAwesome Integration:** Ícones vetoriais nítidos em qualquer resolução.
- **Logon Multi-Ambiente:** Sistema preparado para múltiplos clientes (Multi-tenancy) através de códigos de ambiente (ex: `m0245`).

## 🛠️ Stack Tecnológica

- **Linguagem:** C# (Csharp)
- **Framework:** .NET 10 🚀
- **Interface:** Windows Forms com Guna.UI2
- **Banco de Dados:** SQLite (via EF Core)
- **Design:** FontAwesome.Sharp & Figma Patterns

## 📂 Estrutura do Projeto

- `SaaS_PDV.Core`: Toda a lógica de negócio, modelos de dados e contexto do banco de dados (Migrations e Seed).
- `SaaS_PDV.UI`: Camada de apresentação com os novos formulários estilizados e lógica de transição entre Splash e Login.

## 🚀 Como Executar

1. Clona este repositório:
   ```bash
   git clone [https://github.com/vinnisntos/SaaS_PDV.git](https://github.com/vinnisntos/SaaS_PDV.git)

2. Muda para a branch da versão 2.0:
   ```bash
   git checkout guna-interface
   
3. Abre a solução no Visual Studio 2022.

4. Garante que o projeto SaaS_PDV.UI está definido como projeto de inicialização.

  Credenciais De Teste:
  
    ● Ambiente: m0245
    ● Utilizador: admin
    ● Senha: 123

5. Prime F5. O sistema irá executar o Seed automático para criar o utilizador administrador.


👨‍💻 Autor
Vinnicius Gabriel Matos Dos Santos Estudante de Análise e Desenvolvimento de Sistemas - UNIP Sorocaba.
-----------------------------------------------------------------------------------------------------------
Este projeto faz parte do meu portfólio de evolução técnica em C# e arquitetura de sistemas SaaS.
