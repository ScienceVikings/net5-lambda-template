dotnet build .\net5-lambda-template.sln
docker-compose build
docker-compose run -p 9000:8080 lambda