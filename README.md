# CRUD Alunos-CursoDeArtes
![](https://uc7d5e53efdacb54c1bec707b516.previews.dropboxusercontent.com/p/thumb/ABUqpT88FBJHoIqNgbJZQdyWwzAmGNU0I8dupbJQgY85ZCDSVhyXBacnApVWe03rP17HIeutVfObj5owAC8b7PoUeIam8G-HR9H-lCNTWOrK9M-_oAgzvhJYmIKH1zRnhzfkwv3dgMlINIeWyyJWAiZ2Pr9Jjl3hyervPig3tq2B9OiHv0xI9rDazBq0s3OiQit5w-Z3cGR5Cet9cndA0uoQiqFaOm9TJlnBhkHA144QXxjtIEbzypomNc-ZLetctTPFEuPDR9Xm-2p-u-H67EnOffk28wo2cFOMsCxz05oRce6w1qr0ublR-ZkfjuVgD5YyZfLpU1FlkevOOUNTfjjt9P53GvspIIxrOvXXuEHb-Bkgbv_mfMqQQ3pLwBNQfrjuuOgZqUPYwlrNPJanWMBF/p.png?fv_content=true&size_mode=5)

![](https://uc7ce052b1fe0bb0a18c9d3187bf.previews.dropboxusercontent.com/p/thumb/ABVfyZiRdn4P3Ph-enY1bGoBzbMy6ZqBYaBh2aiafwAOqkA-ktuo0pEkFhA4J5fcqCQH20P5oI2HKW9HPWDrhd7IhV0ww0gs3_uBGx5dFQWiFPvPrrDvV6Waz0UzbUVUtoUIR4--69m1xRTXs5m3KO-bHec47EPeoCQ0x_ZsIuT6XTHK4zB3yPpmYQgIOWbHl2rPQJhyPr_j7PuI4DcX1zy88aP8EaR4MUGGSWN0LZzNY2Ke0q6bTBGAtwA-wHyVI3W3VwxZVEJX9umNTbFQJw9MENTierlscI__EpCLJOFTqjPJhwxEMYJYpICGTnounG06pm5aZS4HqowOYmRaRt8Hf7_IPLa5YxtbTfDl3XB0t_q_lkbSTGc2dOBYV5h-R8GUa7BQwppRmkj1HUjODJnM/p.png?fv_content=true&size_mode=5)


Para ver todos os *screenshots* clique [aqui](https://www.dropbox.com/sh/odl0gw23x9ll6ig/AAB6KVTyeI5lS109OpLChEZFa?dl=0).

## Sobre este projeto
Este projeto é parte do meu portfolio e aprendizado pessoal. Uma forma de experimentar e implementar um CRUD utilizando a arquitetura **MVC** no framework **ASP.NET Core**.
Faz parte do início da minha jornada para trabalhar com o ecossistema **.NET**

A estrutura de negócio do programa é um CRUD simples de uma listagem de alunos em um curso de artes, cada qual relacionado a uma turma.
Através do uso de um banco de dados **MySQL**, o programa possibilita além da exibição da listagem de alunos, a criação, edição, exibição de detalhes e exclusão de cada um.

Ao invés de montar um programa mais complexo apenas copiando e colando linhas de código de outras referências, me foquei no meu aprendizado, construindo algo simples que eu pudesse entender na íntegra. Por isso, nesse momento o programa ainda está bem básico e  vai servir de laboratório para eu dar continuidade no estudo e implementação de novos recursos. Citando apenas algumas possibilidades:
- criar relação "muitos para muitos" entre Aluno e Turma
- implementar pesquisa de Aluno e Turma
- listar alunos por Turma
- implementar CRUD para Turma
- criar a entidade Professor 
- etc.

Para mais detalhes sobre os recursos implementados confira as seções abaixo.

Para me contatar ou se conectar ao meu LinkedIn seguem os links:
* [fernando.ilustrar@gmail.com](mailto:fernando.ilustrar@gmail.com)
* [www.linkedin.com/in/fernando-r-lima](https://www.linkedin.com/in/fernando-r-lima/)

## Conceitos e recursos dominados através desse projeto

- Programação orientada a objetos
- Arquitetura Model View Controller
- Entity Framework Core
- Conexão a servidor MySQL
- Implementação Code First de bando de dados
- Injeção de dependência
- Tag-Helpers
- Data Annotations
- ViewModels
- Tipo Nullable
- Funções Lambda

## Desenvolvimento gradual 
Buscando dominar cada novo conceito e trecho de código implementado, comecei o projeto da forma mais simples possível e fui realizando pequenos commits a cada sucesso. Assim tenho as etapas de sua construção bem definidas, a fim de facilitar meu entendimento e minhas consultas futuras ao próprio código.

Segue aqui como se deu o crescimento do projeto e do meu aprendizado:
1. [commit](https://github.com/fernando-r-lima/portfolio-CRUD_ALUNOS/commit/cf58b2ea1a9f662aba69d75949523bb6b3f312f4) - Criação do projeto com *Visual Studio 2019*; Criação do *model* **Aluno.cs** 
2. [commit](https://github.com/fernando-r-lima/portfolio-CRUD_ALUNOS/commit/bee1410a2e253ffba6dbe3f1845b4e8f0f14bd3d) - Implementação do *EntityFramework* através do *scaffold* de **AlunosController.cs**
3. [commit](https://github.com/fernando-r-lima/portfolio-CRUD_ALUNOS/commit/7035e887688a2b1cddaf98fa08808dc584908089) - Edição do **AlunosController.cs** gerado e de **\_Layout.cshtml**
4.  [commit](https://github.com/fernando-r-lima/portfolio-CRUD_ALUNOS/commit/105f84c2a3890bfe9d38f40a957b6428d1a3655b) - Configuração do projeto para *MySQL*; Criação da tabela *Aluno* usando *migration* 
5. [commit](https://github.com/fernando-r-lima/portfolio-CRUD_ALUNOS/commit/e71a2e713714fbf78391a12acc5311cfb75d20b4) - Criação de **SeedingService.cs** para popular banco de dados no ambiente de desenvolvimento 
6.  [commit](https://github.com/fernando-r-lima/portfolio-CRUD_ALUNOS/commit/63f2234fcb26ef750bed3b8ca4e0f5b864fcc8c5) - Criação de **AlunosService.cs** com método de acesso ao banco; Exibição da lista em **Aluno/Index.cshtml** 
7. [commit](https://github.com/fernando-r-lima/portfolio-CRUD_ALUNOS/commit/74402c2d80009ffa5a0de7a46018185843265349) - Implementação do cadastro de um novo aluno 
8. [commit](https://github.com/fernando-r-lima/portfolio-CRUD_ALUNOS/commit/68fa34e46805415e0d79b20efaf08f6aefcba638) - Implementação da exclusão de um aluno 
9. [commit](https://github.com/fernando-r-lima/portfolio-CRUD_ALUNOS/commit/ff0283ef404fe948ef26ba02812dbd2b318497ea) - Criação do *model* **Turma.cs** e da tabela *Turma* com segunda *migration*; Atualização de **SeedingService.cs**
10. [commit](https://github.com/fernando-r-lima/portfolio-CRUD_ALUNOS/commit/55973898da449e80a63aa8fa1194e3973eeb875e) - Criação da propriedade *int TurmaId* em **Aluno.cs** para criar integridade referencial
11. [commit](https://github.com/fernando-r-lima/portfolio-CRUD_ALUNOS/commit/2b2e80df9fa0c45bccae91a4ec9b33685400a9a1) - Criação de **TurmasController.cs**, **TurmasService.cs** e **Turmas/Index.cshtml** para exibição da lista de turmas 
12. [commit](https://github.com/fernando-r-lima/portfolio-CRUD_ALUNOS/commit/f8b434842a7e3ba096c54e26157929ec3b4a1fd8) - Ajuste no model **Turma.cs** e vinculação a **Aluno.cs**; Implementação de um *ViewModel* no cadastro de aluno 
13. [commit](https://github.com/fernando-r-lima/portfolio-CRUD_ALUNOS/commit/91b480611d80b997258808a676600cf3c9d88dd0) - Implementação de exibição de detalhes de um aluno 
14. [commit](https://github.com/fernando-r-lima/portfolio-CRUD_ALUNOS/commit/0863adf8e0690e2330366573b852ddb810e3be86) - Atualização da lista em **Aluno/Index.cshtml** com exibição da turma de cada aluno 
15. [commit](https://github.com/fernando-r-lima/portfolio-CRUD_ALUNOS/commit/71b23747df8fb7d4910324583928c41c3dfe6705) - Implementação de edição de um aluno; Criação de página de erro personalizada para tratar método *GET* nas diferentes ações 

