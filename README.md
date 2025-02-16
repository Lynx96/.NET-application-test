# .NET-application-test
Application test using .NET AspNET CORE with PostgreSQL and VueJS


# Instruções Docker (Comandos devem ser executados no CLI no nível da pasta em que se encontra os arquivos docker, neste caso, em Server/TestApplication)

- execução dos containers/serviços: docker-compose up -d
- parar e remover execução de container: docker-compose down
- rebuild e execução dos containers/serviços: docker-compose up -d --build
- listagem de containers docker em execução: docker ps
- listagem de imagens docker: docker images
- remover imagem docker: docker rmi <containerId>
- remover todas as imagens docker não associadas a um container: docker image prune
- remover todas as imagens docker: docker rmi $(docker images -q)
- executar instância de serviço docker pelo bash: docker exec -it <containerId> sh


# Instruções .NET
- Build/compilação da aplicação: dotnet build
- Criar migration para banco de dados: dotnet ef migrations add <NomeDaMigration>
- Aplicar a migration no banco de dados: dotnet ef database update
- Reverter uma migration: dotnet ef database update <NomeDaMigrationAnterior>
