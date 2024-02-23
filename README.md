# Projeto MVC - Volvo

Um gestor logístico para redes de concessionárias de automóveis.

## > Instalação
1 - Trocar conexão com o servidor no arquivo context para a conexão do seu servidor SQL.
```c#
protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=YOURSERVER;Database=ProjectMVC;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True;");
        }
```


2 - Executar comando para criar o banco de dados a partir da migration.
```bash
dotnet ef database update
```


3 - Adicionar um registro na tabela AdminInfos, esse será seu login.

![image](https://github.com/victorhtanaka/ProjectMVC/assets/131787507/fa0cc24a-4e86-4e34-aab7-a9fa49411a14)


4 - Executar o comando para rodar o programa.
```bash
dotnet run
```

5 - Acessar o url do sistema.
"http://localhost:5222"
