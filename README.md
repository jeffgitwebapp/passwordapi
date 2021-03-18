# Passoword API - PA | Desenvolvido por Jefferson Santos
Projeto de teste verificação estrutural de senha.

# Passoword API - PA | Descrição da solução.
API foi desenvolvida em C# utilizando o framework .Net Core.

## Estruturalmente a solução foi organizada da seguinte forma:
 - Core	-> Componente que possui fluxos de processamento e define o comportamento do sistema em relação as regras de negocios envolvidas.
		- Domain -> Onde localizamos nosso dominio de negocio. Deve estar o mais desacoplado possível de toda a aplicação.
		- UseCase -> Define fluxos de processamento e execuação de regras de negocio, recebe as mensagens de entrada e processa a mesma retornando seu respectuivo resultado.
 
 - Infra - > Componente que implementa a utilização de recursos como acesso a dados, integrações, interfaces e qualquer outro recurso de infraestrurura para execução da aplicação.
	- Para este projeto implementamos apenas a injeção de dependência até o momento.
 
 - Api -> Ponto de entrada das requisições http.
	- Não utiliza chamadas diretas Core da aplicação, passa por abstrações enviando apenas a mensagem devida através do "Commad" as camadas mais internas.
 
 - Test -> Componente onde os testes pros cenários previstos estão implementados utilizando XUnit.
	- Implementado testes unitários
	- Teste de integração pendentes
 
 ## Técnicas e componentes
 
 - Foi utilizado UseCase pattern com o objetivo de chegar a uma arquitetura mais limpa possível para o problema em questão.
 - Desenvolvimento orietando a abstrações, utilizando interfaces, classes abstratas e incluíndo utilização do componentes com MediatR.
 - Como não há interação com fontes de dados não foi construindo nenhuma abstração de acesso ou manipulação de dados (Exemplo Repository Pattern)






