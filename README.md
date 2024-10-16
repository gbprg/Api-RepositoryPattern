<h1>📚 Projeto Livro e Autor - Repository Pattern</h1>

<p>
    Este projeto tem como foco a implementação do <strong>Design Pattern Repository</strong>, com o objetivo de melhorar a organização e o desacoplamento da lógica de acesso aos dados. Ele simula um sistema de gerenciamento de livros e autores, fornecendo uma API para operações de CRUD (criação, leitura, atualização e exclusão) de forma clara e eficiente.
</p>

<h2>🚀 Tecnologias Utilizadas</h2>
<ul>
    <li><strong>C#</strong> com <strong>ASP.NET Core</strong> para construção da API</li>
    <li><strong>Repository Pattern</strong> para separar a lógica de persistência de dados</li>
    <li><strong>Entity Framework Core</strong> como ORM (Object-Relational Mapping)</li>
    <li><strong>SQL Server</strong> como banco de dados relacional</li>
</ul>

<h2>🏗️ Estrutura do Projeto</h2>
<p>
    O projeto é organizado em camadas para promover a separação de responsabilidades e facilitar a manutenção. As principais camadas são:
</p>
<ul>
    <li><strong>Controllers</strong>: Gerenciam as requisições HTTP e encaminham para os serviços adequados.</li>
    <li><strong>Services</strong>: Contêm a lógica de negócios e coordenam as operações entre os controllers e repositórios.</li>
    <li><strong>Repositories</strong>: São responsáveis por realizar as operações de CRUD no banco de dados, mantendo a lógica de persistência isolada.</li>
    <li><strong>DTOs (Data Transfer Objects)</strong>: Utilizados para transferir dados entre as camadas, garantindo que as entidades corretas sejam expostas ao usuário da API.</li>
</ul>

<h2>✨ Funcionalidades</h2>
<h3>📖 Livros:</h3>
<ul>
    <li>Listar todos os livros</li>
    <li>Buscar livro por ID</li>
    <li>Buscar livros por autor</li>
    <li>Criar, editar e excluir livros</li>
</ul>

<h3>👤 Autores:</h3>
<ul>
    <li>Listar todos os autores</li>
    <li>Buscar autor por ID</li>
    <li>Buscar autor por livro</li>
    <li>Criar, editar e excluir autores</li>
</ul>

<h2>🎯 Motivação</h2>
<p>
    Este projeto foi criado como parte dos meus estudos sobre o <strong>Repository Pattern</strong>. A implementação desse padrão permite uma maior flexibilidade e facilidade de manutenção, além de promover o princípio da separação de responsabilidades.
</p>

<h2>⚙️ Como Executar</h2>
<ol>
    <li>Clone este repositório.</li>
    <li>Configure sua conexão com o banco de dados no arquivo <code>appsettings.json</code>.</li>
    <li>Execute as migrações para configurar o banco de dados.</li>
    <li>Inicie o projeto via Visual Studio ou <code>dotnet run</code>.</li>
</ol>
