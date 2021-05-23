# CAMBMONEY


### Esse projeto é um sistema de conversão de moedas simples, onde o usuário poderá casdastrar a moeda e o valor dela em reais(existem muitas regras de conversão para cada tipo de ### moeda, uma forma de simplificar isso foi informar o valor em reais de cada moeda e usar isso como base para o calculo, isso dificulta casjo haja uma mudança nas cotações, mas ### é um sistema simples então os valores podem ser fixos).

## O projeto

### Foi feito em C# usando o dotnet 5.0 e a IDE visual studeo community 2019 e utilizando sql server
### Para executar o projeto primeiro faça o download e localize o arquivo com a extensão .sln e o execute(o visual studio precisa estar instalado)
### Caso de algum erro, abra primeiro o visual studio e no lado direito selecione a opção "abrir projeto e solução" após selecione esse arquivo .sln
### Basta cliclar na seta verde localizada no centro da barra superior.
### O banco de dados é para se criar sozinho, mas caso de algum erro, vá no menu superior em Ferramentas -> Gerenciador de pacotes do nuget -> Console do gerenciador de pacotes.
### Digite o comando
### update-database


## O Formulário:
### Você encontrará duas abas assim que abrir o aplicativo, a primeira é para adicionar a operação e a segunda para adicinar as moedas, va ná segunda aba e adicione as moedas que ### desejar e os valores em reais de cada uma.

### Após volte para a primeira aba e faça uma operação, basta adicionar o nome do cliente, a moeda de origem, a moeda de destino e o valor, o resto dos campos irão se preencher ### sozinhos ao clicar no botão Calcular, basta salvar e a operação aparecerá na lista ao lado direito, ao cliclar um mini relatório aparecerá.

### Você conseguirá usar filtros de data e por nome do cliente, caso queira restar os filtros basta clicar no botão de resetar.
