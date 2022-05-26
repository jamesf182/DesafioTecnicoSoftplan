# Desafio Técnico Softplan

Projeto desenvolvido seguindo a descrição do documento <b>Desafio Técnico .Net Core</b> da <b>Softplan</b> para se tornar um <b><i>Softplayer</b></i>. 😊

## 🚀 Começando

Foram desenvolvidas duas API's, uma com dois endpoints e uma com um endpoint: 

## 📌 API 1

1 - Retorna taxa de juros
* Retorna a taxa de juros fixa de ```1%``` ou ```0,01```
* Responde pelo path "<i>/taxaJuros</i>"
* Exemplo: ```/taxaJuros``` Resultado esperado: ```0,01```

## 📌 API 2

1 - Calcula juros
* Realiza o cálculo de juros compostos, conforme a seguinte fórmula: ```Valor Final = Valor Inicial * (1 + Juros) ^ Tempo```
* O ```Valor Inicial``` é um decimal recebido por parâmetro
* O Valor dos ```Juros``` deve ser consultado na ```API 1```
* O ```Tempo``` é um inteiro, que representa os meses, também recebido por parâmetro
* O ```Valor Final``` retornado é truncado em duas casas decimais e sem arredondamento
* Responde pelo path <i>"/calculajuros"</i>
* Exemplo: ```/calculajuros?valorinicial=100&meses=2``` Resultado esperado: ```102,01```

2 - Show me the code
* Retorna a url onde encontra-se o código fonte do projeto no GitHub

### 📋 Pré-requisitos

```
Microsoft.NET SDK 6.0.300
```
## 📦 Acesso ao projeto

Você pode [acessar o código fonte do projeto](https://github.com/jamesf182/DesafioTecnicoSoftplan) ou [baixá-lo](https://github.com/jamesf182/DesafioTecnicoSoftplan/archive/refs/heads/master.zip).

## ⚙️ Executando os testes

Após baixar o projeto, você pode abrir com o ```Visual Studio 2022```.
* Primeiro acesse a pasta ```API1```, abra o arquivo ```API1.sln``` e execute o projeto
* Depois acesse a pasta ```API2```, abra o arquivo ```API2.sln``` e execute o projeto
* Ambos estão sendo executados utilizando o ```Swagger```, onde é possível testar as funcionalidades das API's

## 🛠️ Construído com

As ferramentas e tipos de projetos utilizados foram:

* IDE <b>Visual Studio 2022</b>
* As API's foram desenvolvidas utlizando o modelo de projeto <b>API Web do ASP.NET Core 6.0</b>
* Os testes unitários e testes de integração foram desenvolvidos utilizando o modelo de projeto <b>Projeto de Teste do xUnit</b>


---
⌨️ com ❤️ por [James Freitas](https://github.com/jamesf182) 😊

