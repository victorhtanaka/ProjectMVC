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


## Funcionalidades

![image](https://github.com/victorhtanaka/ProjectMVC/assets/131787507/5569607e-2289-40ea-b5f8-8d50b7fb36ef)

![image](https://github.com/victorhtanaka/ProjectMVC/assets/131787507/afb28cbd-fb36-47cc-bf6a-1122bacb3a54)

![image](https://github.com/victorhtanaka/ProjectMVC/assets/131787507/f31a7466-9557-4878-a662-bb2d340e571f)
