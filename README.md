# design-patterns
Design Patterns C#

# Quando utilizar?
Muitos desenvolvedores tentam forçar ao máximo o uso de padrões nos códigos. O que você pensa sobre isso? Usar padrões 100% do tempo é o ideal? Quais são as vantagens e desvantagens?

Não. Padrões de projeto trazem grande flexibilidade ao seu código, mas isso tem um preço: complexidade. Naturalmente um código que faz uso de padrões de projeto é, do ponto de vista de implementação, mais complexo do que um código que não os utiliza. Afinal, como tudo está desacoplado, o desenvolvedor precisa entender melhor a solução para entender o que o código faz como um todo.

Um bom desenvolvedor sabe fazer essa avaliação e entender quais os ganhos e perdas da utilização de um padrão. Em um problema simples de resolver, talvez o uso de um padrão de projeto não faça sentido; o código vai apenas ficar mais complicado. Agora, em problemas que são por natureza complexos, ou que demandam flexibilidade, pois mudam o tempo todo, talvez a utilização de um padrão de projeto traga benefícios, já que todos os padrões sempre agregam flexibilidade ao código gerado.

Nunca se esqueça: a sua experiência é fundamental! Padrões de projeto são mais uma ferramenta. Eles devem ser um meio para se chegar à solução final, e não o "fim", ou seja, o seu objetivo principal.



#Ordem de Aprendizado
1. Strategy - permite encapsular tipos diferentes de acoes utilizando interfaces
O padrão Strategy é muito útil quando temos um conjunto de algoritmos similares, e precisamos alternar entre eles em diferentes pedaços da aplicação. No exemplo do vídeo, temos diferentes maneira de calcular o imposto, e precisamos alternar entre elas.
O Strategy nos oferece uma maneira flexível para escrever diversos algoritmos diferentes, e de passar esses algoritmos para classes clientes que precisam deles. Esses clientes desconhecem qual é o algoritmo "real" que está sendo executado, e apenas manda o algoritmo rodar. Isso faz com que o código da classe cliente fique bastante desacoplado das implementações concretas de algoritmos, possibilitando assim com que esse cliente consiga trabalhar com N diferentes algoritmos sem precisar alterar o seu código.

2. Chain of Responsibility - permite encapsular tipos diferentes de acoes utilizando interfaces e definir uma regra de sequencia de execucao.
O padrão Chain of Responsibility cai como uma luva quando temos uma lista de comandos a serem executados de acordo com algum cenário em específico, e sabemos também qual o próximo cenário que deve ser validado, caso o anterior não satisfaça a condição.
Nesses casos, o Chain of Responsibility nos possibilita a separação de responsabilidades em classes pequenas e enxutas, e ainda provê uma maneira flexível e desacoplada de juntar esses comportamentos novamente.

3. Template Method - permite definir um método padrão e classes que herdam esse metodo implementam o código que pode mudar utilizando classes abstratas.
Quando temos diferentes algoritmos que possuem estruturas parecidas, o Template Method é uma boa solução. Com ele, conseguimos definir, em um nível mais macro, a estrutura do algoritmo e deixar "buracos", que serão implementados de maneira diferente por cada uma das implementações específicas.
Dessa forma, reutilizamos ao invés de repetirmos código, e facilitamos possíveis evoluções, tanto do algoritmo em sua estrutura macro, quanto dos detalhes do algoritmo, já que cada classe tem sua responsabilidade bem separada.

4. Decorator - permite decorar "sequenciar" uma classe com outra classe. 
Sempre que percebemos que temos comportamentos que podem ser compostos por comportamentos de outras classes envolvidas em uma mesma hierarquia, como foi o caso dos impostos, que podem ser composto por outros impostos. O Decorator introduz a flexibilidade na composição desses comportamentos, bastando escolher no momento da instanciação, quais instancias serão utilizadas para realizar o trabalho.

5. State - Ações que são determinadas de acordo com o estado de um objeto e controle de transição entre estados.
A principal situação que faz emergir o Design Pattern State é a necessidade de implementação de uma máquina de estados. Geralmente, o controle das possíveis transições são vários e complexos, fazendo com que a implementação não seja simples. O State auxilia a manter o controle dos estados simples e organizados através da criação de classes que representem cada estado e saiba controlar as transições.

6. Builder - Auxiliar na construções de objetos complexos. Também conhecido como Fluent Interface e Method Chaining.
Sempre que tivermos um objeto complexo de ser criado, que possui diversos atributos, ou que possui uma lógica de criação complicada, podemos esconder tudo isso em um Builder.
Além de centralizar o código de criação e facilitar a manutenção, ainda facilitamos a vida das classes que precisam criar essa classe complexa, afinal a interface do Builder tende a ser mais clara e fácil de ser usada.

7. Observer - Utilizado no exemplo em conjunto com o builder. Uma forma de notificar outras classes que um objeto foi criado e uma nova ação de ser executada.
Quando o acoplamento da nossa classe está crescendo, ou quando temos diversas ações diferentes a serem executadas após um determinado processo, podemos implementar o Observer.
Ele permite que diversas ações sejam executadas de forma transparente à classe principal, reduzindo o acoplamento entre essas ações, facilitando a manutenção e evolução do código.


8. Factory - Para auxiliar na criação de objetos. Por exemplo, auxiliar na criação de uma conexão com banco de dados. Semelhante ao builder mas sem as opções para receber informações adicionais.

Temos o costume de usar o sufixo Factory nas nossas classes que são fábricas. Muitas vezes vale a pena seguir a convenção, já que, dessa forma, outros desenvolvedores entenderão mais facilmente o código.

9. FlyWeight - Tratar e reaproveitar multiplos objetos instanciando uma unica vez.
10. Memento - Uma solução para preservar o historico de estados de uma classe.


11. Singleton - O Singleton nos ajuda a ter uma única instância do objeto ao longo do sistema.
Considerado obsoleto, ou anti-pattern atualmente, considerar utilizar o padrão monostate. 

12. Façade - Uma façade serve como uma frente única para os serviços disponibilizados por um ou mais sub-sistemas, provendo uma maneira mais simples para consumo do mesmo.


13. Interpreter 
O padrão Interpreter é geralmente útil para interpretar DSLs. É comum que, ao ler a string (como por exemplo 2+3/4), o programa transforme-a em uma estrutura de dados melhor (como as nossas classes Expressao) e aí interprete essa árvore.
É realmente um padrão de projeto bem peculiar, e com utilização bem específica.

14. Visitor 


15. Bridges

16. Command 


--- 

Semelhanças / Diferenças entre Façade a Adapter
O Façade cria uma interface amigável para que clientes consigam consumir sub-sistemas (ou serviços).
Já o Adapter tem um propósito diferente. Ele visa adaptar um conjunto de classes que já existem, para uma outra interface, que é a requerida pelo outro sistema.


Qual a diferença entre Factory e Builder?
Ambos são padrões de projeto que visam resolver problemas de criação de objetos. O que muda de um pro outro é basicamente a semântica.
Geralmente usamos um builder quando precisamos passar diversas informações para a lógica que monta o objeto. No caso da Nota Fiscal, passamos nome, ítens, etc.
Usamos uma fábrica quando temos que isolar o processo de criação de um objeto em um único lugar. Essa fábrica pode descobrir como criar o objeto dentro dela própria, mas geralmente ela não precisa de muitas informações para criar o objeto.

Qual a diferença entre Factory e Flyweight?
Uma Factory instancia uma classe que é importante/complexa, e seu processo de criação deve ser isolado.
Um Flyweight serve para quando temos muitas instâncias do mesmo objeto andando pelo sistema, e precisamos economizar. Para tal, o Flyweight faz uso de uma fábrica modificada, que guarda essas instâncias.

Singleton vs FlyWeight
A ideia de ambos é garantir que existam apenas uma única referência para o objeto ao longo do programa.
A diferença é que o Flyweight garante que existam apenas uma única instância de vários elementos. É um "singleton maior".

Bridge vs Strategy
Na implementação do bridge podemos ver que o bridge pode utilizar o strategy em sua implementação: a mensagem em seu método Envia utiliza o strategy para decidir qual é a estratégia de envio que será utilizada pela aplicação.

Qual a diferença entre Command e Strategy?
Novamente, em termos de implementação, eles são bem parecidos, pois dependem de interfaces.
A ideia do Command é abstrair um comando que deve ser executado, pois não é possível executá-lo naquele momento (pois precisamos por em uma fila ou coisa do tipo).
Já no Strategy, a ideia é que você tenha uma estratégia (um algoritmo) para resolver um problema.

Você consegue ver o Command trabalhando junto com algum outro padrão?
Podemos ser criativos e usar outros padrões de projeto de acordo com o problema que temos em mãos.
Podemos usar Memento para restaurar estados de objetos que foram alterados por um Command.

Quais são as diferenças que existem entre os padrões Adapter e Strategy?
A diferença que existe entre os padrões é o propósito. No Adapter estamos adaptando a interface de um sistema antigo para que ela possa se encaixar em um sistema novo. Já no Strategy a ideia é utilizar diferentes estratégias para resolver um dado problema no sistema.

Quais são as diferenças entre os padrões Adapter e Command?
O Adapter serve para adaptar o código de um sistema legado ou biblioteca para que ele possa ser utilizado no novo sistema. Já o command serve para guardarmos um trecho de código que precisa ser executado posteriormente.
