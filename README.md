# Design Pattern Adapter

O repositório contém uma aplicação escrita em C#, a qual utiliza o padrão de projeto Adapter para facilitar a obtenção de informações de pessoas, possibilitando que uma nova fonte de leitura seja um arquivo .csv. Por fim, o conteúdo da lista obtida é exibido por meio do console em execução.

**Observação**: o repositório foi criado para a resolução da atividade avaliativa da disciplina de "Tópicos de Arquitetura de Software".

## Resolução

Para desenvolver a atividade, foram criados os seguintes itens:
- **Person** - É a classe que representa a entidade pessoa, com suas respectivas informações. Está localizada em `./AdapterPattern/Domain/Entities/Person.cs`
- **IPeopleRepository** - É uma interface que representa o contrato que uma classe que abstrai a extração de dados de pessoas deve implementar. Está localizada em `./AdapterPattern/Infrastructure/IPeopleRepository.cs`
- **PeopleCsvAdapter** - É uma classe que implementa a interface IPeopleRepository, e a partir do caminho de arquivo passado em seu construtor, realiza a leitura de um arquivo .csv retornando uma lista de pessoas instanciada. Está localizada em `./AdapterPattern/Infrastructure/PeopleCsvAdapter.cs`
