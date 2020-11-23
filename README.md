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

### Como autenticar

POST /v1/banco/login HTTP/1.1
Host: localhost:5001
Content-Type: application/json
Content-Length: 45

{"username":"Joao Maria","password":"123456"}

### Como consumir action restrita
GET /v1/banco/authenticated HTTP/1.1
Host: localhost:5001
Authorization: Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IkpvYW8gTWFyaWEiLCJyb2xlIjoiQ2FpeGEiLCJuYmYiOjE2MDYwOTEzODYsImV4cCI6MTYwNjA5ODU4NiwiaWF0IjoxNjA2MDkxMzg2fQ.ZT2v-y5lur_w1eZ_zUngoEVzwO3PvFOyo9rcUXu7jBU



