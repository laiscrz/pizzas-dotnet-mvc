# 🍕 **Pizzas Hub MVC**

Bem-vindo ao **Pizzas Hub MVC**! Este é um sistema web desenvolvido utilizando a arquitetura **MVC** (Model-View-Controller) com **ASP.NET Core**. A aplicação permite que os usuários visualizem, adicionem e gerenciem diferentes tipos de pizzas de maneira simples e intuitiva, com uma interface moderna e responsiva.

## 🚀 **Tecnologias Utilizadas**

- **ASP.NET Core MVC** 🖥️: Framework para criação de aplicações web.
- **C#** 💻: Linguagem de programação utilizada no backend.
- **Entity Framework Core** 🛠️: ORM para interagir com o banco de dados.
- **SQL Oracle** 🗄️: Sistema de gerenciamento de banco de dados relacional utilizado.
- **Bootstrap 5** 🎨: Framework CSS para design responsivo.
- **Razor Views** ⚡: Sistema de templating para renderizar as views de forma dinâmica.
- **JavaScript** 🧩: Para adicionar interatividade nas páginas.

## 📸 **Demonstração**

![Pizzas Hub MVC](https://github.com/user-attachments/assets/5bfebb09-102a-49dc-af68-ad37e61ba5d6)

## ✨ **Funcionalidades**

- **Cadastro de Pizzas** 📋: Adicione pizzas com informações como nome, descrição, imagem e preços (por tamanho).
- **Gerenciamento de Pizzas** 🧑‍🍳: Visualize, edite ou exclua pizzas existentes no sistema.
- **Visualização de Preços** 💰: Exiba os preços das pizzas divididos por tamanho (Pequena, Média, Grande).
- **Pesquisa de Pizzas** 🔍: Busque por pizzas específicas usando filtros como nome ou preço.
- **Visualização de Imagem** 📦: Exiba imagens das pizzas de forma responsiva, com ajuste para diferentes dispositivos.

## 🔧 **Como Rodar o Projeto**

### 1. **Clonar o repositório**
Clone o repositório para a sua máquina local utilizando o comando abaixo:

```bash
git clone https://github.com/laiscrz/pizzas-dotnet-mvc.git
```

### 2. **Instalar Dependências**

- **Restaurar Pacotes NuGet**: Navegue até o diretório do projeto e execute o comando para restaurar as dependências:

```bash
dotnet restore
```

### 3. **Configurar Banco de Dados**

- No arquivo `appsettings.json`, configure as credenciais do banco de dados conforme o ambiente em que você está executando a aplicação. Exemplo de configuração para **ORACLE SQL**:

```json
"ConnectionStrings": {
  "DefaultConnection": "Data Source=oracle.fiap.com.br:1521/orcl;User ID=<USER>;Password=<SENHA>;"
}
```

- Substitua `<USER>` e `<SENHA>` pelos dados de acesso à sua instância do banco de dados **Oracle**.

- Após configurar a string de conexão corretamente, execute as migrações do banco de dados utilizando o seguinte comando para criar as tabelas necessárias:

```bash
dotnet ef database update
```

### 4. **Rodar o Projeto**

- Após configurar o banco de dados, execute o projeto com o comando:

```bash
dotnet run
```

- Acesse a aplicação pelo navegador através do seguinte endereço:  
  [http://localhost:5049](http://localhost:5049)

## 🎨 **Design Responsivo**

O **Pizzas Hub MVC** foi projetado para ser totalmente responsivo, garantindo uma experiência de usuário agradável em dispositivos móveis, tablets e desktops. A interface usa **Bootstrap 5** para ajustar o layout automaticamente, tornando a navegação fácil e intuitiva em qualquer tela.

## 📚 **Estrutura do Projeto**

- **Controllers**: Contêm a lógica de controle da aplicação, como gerenciar o fluxo de dados entre a **View** e o **Model**. Exemplo: `PizzaController.cs`.
- **Models**: Definem as entidades que representam os dados no sistema. Exemplo: `PizzaModel.cs`.
- **DTOs (Data Transfer Objects)**: Usados para transferir dados entre as camadas da aplicação, geralmente com um subconjunto de propriedades ou modificações para um caso de uso específico. Exemplo: `PizzaDTO.cs`.
- **Migrations**: Utilizadas no Entity Framework para gerenciar alterações no esquema do banco de dados, como criação de tabelas ou adição de colunas. Exemplo: `Create-Migration`.
- **Views**: Arquivos baseados no Razor que definem o layout e o conteúdo da interface de usuário, permitindo uma renderização dinâmica. Exemplo: `Index.cshtml`.
- **Data**: Contém a lógica de acesso ao banco de dados, incluindo o contexto de dados (DbContext) e repositórios responsáveis pela persistência. Exemplo: `PizzaRepository.cs`.
- **Repositories**: Abstraem o acesso ao banco de dados e implementam métodos CRUD (Create, Read, Update, Delete). Exemplo: `PizzaRepository.cs`.
- **Services**: Contêm a lógica de negócios da aplicação, processando dados antes de serem enviados ao banco de dados ou exibidos na interface. Exemplo: `PizzaService.cs`.
- **wwwroot**: Contém arquivos estáticos, como **CSS**, **JavaScript**, e **imagens**, utilizados para estilizar e interagir com a aplicação.
  
## 🔄 **Fluxo de Trabalho**

1. O usuário acessa o **PizzaController** ao interagir com o sistema.
2. O controlador manipula os dados com o auxílio do **PizzaRepository** (camada de dados).
3. Os dados são passados para as **Views** via **Model Binding**.
4. As **Views** renderizam o HTML dinâmico com as informações do modelo.

## 📝 **Licença**

Este projeto é licenciado sob a **MIT License**. Veja o arquivo [LICENSE](LICENSE) para mais detalhes.

