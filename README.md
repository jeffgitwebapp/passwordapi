# Password API - PA | Desenvolvido por Jefferson Santos
Projeto de teste verificação estrutural de senha.

# Password API - PA | Descrição da solução.
API foi desenvolvida em C# utilizando o framework .Net Core.

## Estruturalmente a solução foi organizada da seguinte forma:
 - Core	-> Componente que possui fluxos de processamento e define o comportamento do sistema em relação as regras de negocios envolvidas.
	- Domain -> Onde localizamos nosso dominio de negocio. Deve estar o mais desacoplado possível de toda a aplicação.
	- UseCase -> Define fluxos de processamento e execuação de regras de negocio, recebe as mensagens de entrada e processa a mesma retornando seu respectuivo resultado.
		- Os UseCase estão divididos em versões para preservar sua estrutura de mudanças em que a versão anterior deva coexistir com a nova versão.
 
 - Infra - > Componente que implementa a utilização de recursos como acesso a dados, integrações, interfaces e qualquer outro recurso de infraestrurura para execução da aplicação.
	- Para este projeto implementamos apenas a injeção de dependência até o momento.
 
 - Api -> Ponto de entrada das requisições http.
	- Não utiliza chamadas diretas Core da aplicação, passa por abstrações enviando apenas a mensagem devida através do "Commad" as camadas mais internas.
 
 - Test -> Componente onde os testes pros cenários previstos estão implementados utilizando XUnit.
	- Implementado testes unitários
	- Teste de integração pendente
 
 ## Técnicas e componentes
 
 - Foi utilizado UseCase pattern com o objetivo de chegar a uma arquitetura mais limpa possível para o problema em questão.
 - Desenvolvimento orietando a abstrações, utilizando interfaces, classes abstratas e incluíndo utilização de componentes como MediatR.
 - Como não há interação com fontes de dados não foi construindo nenhuma abstração de acesso ou manipulação de dados (Exemplo Repository Pattern)
  
 
  ## Itens de melhoria ou não implementados
 
 - Implentar estrutura de notificação de erros ou validações ao invés de lançar exceções na aplicação e tratar exceções.
 - Implementar health check api
 - Constuir logs para acompanhar comportamento da aplicação no servidor.
 - Utilização de Automapper para mapear objetos uma vez que objetos de dados (expostos ou não na API) e dominio podem seguir estruturas diferentes.
 - Swagger da API


  ## Execução do projeto
  - Utilizando o Visual Studio Code (ou similiar) acesse a pasta \..\PA.Api> e execute o comando dotnet run .\PA.Api.csproj
  - Através do método post chame o endpoint api/pa/validations/v1/password
  - A senha deve ser postada como o json abaixo:
    {
	"password": "!123456Qasdfg@"
	}
  - A Api sempre retornará http response OK(200) se não houver erro de execução, será retornado "true" se a senha for válida e "false" se não for.
  - Caso haja erro na execução ou algum parametro de entrada for inválido será retornado BadRequest(400)





