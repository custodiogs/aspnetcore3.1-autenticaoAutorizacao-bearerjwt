# ASP.NET Core 3.1 - Autenticação e Autorização - JWT / Bearer

## Criar o projeto
dotnet new webapi -o aspnetcore3.1-autenticaoAutorizacao-bearerjwt

## Excluir arquivos desnecessários
Exclua os arquivos WeatherForecast.cs e WeatherForecastController.cs

## Criação da chave privada

### Instalar o pacote Microsoft.AspNetCore.Authentication
-- dotnet add package Microsoft.AspNetCore.Authentication

### Instalar o pacote Microsoft.AspNetCore.Authentication.JwtBearer
-- dotnet add package Microsoft.AspNetCore.Authentication.JwtBearer
