# 🍕 Pizzas Hub MVC 

Bem-vindo ao **Pizzas Hub MVC**! Este projeto é uma aplicação web feita utilizando o padrão de arquitetura MVC (Model-View-Controller), desenvolvida em **ASP.NET Core**. Ele permite que os usuários visualizem, adicionem e gerenciem diferentes tipos de pizzas de maneira simples e intuitiva.

## 🚀 Tecnologias Utilizadas

- **ASP.NET Core MVC** 🖥️
- **C#** 💻
- **Entity Framework Core** 🛠️
- **SQL Oracle** (Banco de dados) 🗄️
- **Bootstrap 5** (Design Responsivo) 🎨
- **Razor Views** (Views Dinâmicas) ⚡
- **JavaScript** (Interatividade) 🧩

## 📸 Demonstração

![Pizzas Hub MVC](https://github.com/user-attachments/assets/5bfebb09-102a-49dc-af68-ad37e61ba5d6)

## ✨ Funcionalidades

- 📋 **Cadastro de Pizzas**: Adicione pizzas com nome, descrição, imagem e preços.
- 🧑‍🍳 **Gerenciamento de Pizzas**: Visualize, edite ou exclua pizzas no sistema.
- 💰 **Visualização de Preços**: Exiba os preços das pizzas por tamanho (Pequena, Média, Grande).
- 🔍 **Pesquisa de Pizzas**: Busque por pizzas específicas usando filtros.
- 📦 **Visualização de Imagem**: As imagens das pizzas são exibidas de forma responsiva e intuitiva.

## 🔧 Como Rodar o Projeto

### 1. Clonar o repositório
Clone o repositório para sua máquina local usando o comando abaixo:

```bash
git clone https://github.com/laiscrz/pizzas-dotnet-mvc.git
```

### 2. Instalar Dependências

- **Instalar Pacotes NuGet**: 
  Navegue até o diretório do projeto e execute o comando para restaurar os pacotes:

```bash
dotnet restore
```

### 3. Configurar Banco de Dados

- Configure o banco de dados no **appsettings.json** com as suas credenciais.

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=localhost;Database=PizzasHub;User Id=sa;Password=senha"
}
```

- Execute as migrações para criar as tabelas no banco de dados:

```bash
dotnet ef database update
```

### 4. Rodar o Projeto

- Após configurar o banco de dados, execute o projeto com o comando:

```bash
dotnet run
```

- Acesse o aplicativo através de [http://localhost:5049](http://localhost:5049).

## 🎨 Design Responsivo

O **Pizzas Hub MVC** foi desenvolvido para ser totalmente responsivo, garantindo que a aplicação funcione bem em dispositivos móveis, tablets e desktops.

## 📚 Estrutura do Projeto

- **Controllers**: Contém a lógica de controle de acesso às vistas e manipulação dos dados (ex.: `PizzaController.cs`).
- **Models**: Define as entidades do sistema, como a classe `PizzaModel` para representar uma pizza.
- **Views**: Define o layout e o conteúdo da interface do usuário com o Razor (ex.: `Index.cshtml`).
- **Data**: Contém a lógica de acesso a dados, incluindo o contexto do banco de dados e repositórios.
