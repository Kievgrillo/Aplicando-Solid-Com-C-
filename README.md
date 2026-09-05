POO e SOLID com C#

Repositório de estudos do curso de Programação Orientada a Objetos e princípios SOLID em C#, com José Carlos Macoratti.

O objetivo é escrever código limpo e que resista a mudanças. A ênfase está no SOLID — a parte de POO serve de base para chegar até lá.

Stack

.NET (Console App) · C# · Visual Studio 2026

Parte 1 — Fundamentos de POO

Classes e objetos · construtores e sobrecarga · propriedades · métodos e métodos estáticos · métodos de extensão · nomenclatura · modelo anêmico · herança · upcast e downcast · operadores is e as.

Parte 2 — Relacionamentos e Abstração

Diagrama de classes e UML · herança vs composição vs agregação · interfaces · classes abstratas · sealed · interface vs classe abstrata · polimorfismo · default interface members.

Regra prática: prefira composição a herança. Herança acopla à implementação; composição acopla só ao contrato.

Parte 3 — SOLID

Os cinco princípios formulados por Robert C. Martin. Cada um ataca um sintoma específico de código difícil de manter — o segredo é identificar o sintoma antes de aplicar a solução.

S — Single Responsibility Principle

Uma classe deve ter apenas um motivo para mudar.

Não é "fazer só uma coisa", é sobre atores: se financeiro e RH pedem mudanças na mesma classe, ela tem duas responsabilidades.

Sintoma: classes enormes, nomes tipo Manager/Helper, métodos que misturam regra de negócio, acesso a dados e formatação. Correção: extrair classes por responsabilidade.

O — Open/Closed Principle

Aberto para extensão, fechado para modificação.

Sintoma: switch ou cadeia de if/else sobre um tipo/enum que cresce a cada requisito novo. Correção: abstrair a variação atrás de uma interface e usar polimorfismo — o caso novo vira uma classe nova, não uma linha nova no switch.

L — Liskov Substitution Principle

Uma subclasse deve poder substituir a classe base sem quebrar o programa.

Herança é promessa de comportamento, não só de estrutura. Exemplo clássico: Quadrado herdando de Retangulo.

Sintoma: override que lança exceção ou ignora o parâmetro; código cliente com if (obj is TipoX) para tratar exceções à regra. Correção: rever a hierarquia — se não cumpre o contrato, não é subtipo.

I — Interface Segregation Principle

Nenhum cliente deve depender de métodos que não usa.

Sintoma: throw new NotImplementedException() ou métodos vazios nas implementações; interfaces com dezenas de membros. Correção: quebrar em interfaces pequenas e coesas, por papel.

D — Dependency Inversion Principle

Módulos de alto nível não dependem dos de baixo nível — ambos dependem de abstrações.

Sintoma: new de classe concreta dentro da regra de negócio; impossível testar sem banco ou API externa. Correção: depender de interfaces e receber as dependências pelo construtor.

DIP ≠ DI: Dependency Inversion é o princípio, Dependency Injection é a técnica.

Code Smells e DRY

Sinais na superfície do código que indicam problema mais profundo: Long Method, Large Class, Duplicated Code, Long Parameter List, Feature Envy, Data Class, Switch Statements, Shotgun Surgery.

DRY: cada conhecimento do sistema deve ter uma representação única. Cuidado — é sobre conhecimento duplicado, não sobre linhas parecidas.

📚 Estudos pessoais
