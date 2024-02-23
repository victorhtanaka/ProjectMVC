<h1>Projeto MVC - Volvo</h1>
<p>Um gestor logístico para redes de concessionárias.</p>

<h2>> Instalação</h2>
<p>1 - Trocar conexão com o sql no arquivo context</p>

<p>2 - Executar comando para criar o banco de dados a partir da migration</p>
```cs
protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=YOURSERVER;Database=ProjectMVC;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True;");
        }
```
<p></p>
<p></p>
<p></p>

3 - Adicionar um registro na tabela adminInfo
4 - dotnet run
5 - Colocar as informações do registro de admin nos campos do login
