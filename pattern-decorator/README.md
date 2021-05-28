# Pattern Decorator

O Decorator é um padrão estrutural que permite adicionar novos comportamentos aos objetos dinamicamente, colocando-os dentro de objetos wrapper especiais.

Usando decoradores, você pode agrupar objetos inúmeras vezes, pois os objetos de destino e os decoradores seguem a mesma interface. O objeto resultante terá um comportamento de empilhamento de todos os wrappers.

## Prós
- Você pode estender o comportamento de um objeto sem fazer um nova subclasse.

- Você pode adicionar ou remover responsabilidades de um objeto no momento da execução.

- Você pode combinar diversos comportamentos ao envolver o objeto com múltiplos decoradores.

- Princípio de responsabilidade única. 

- Você pode dividir uma classe monolítica que implementa muitas possíveis variantes de um comportamento em diversas classes menores.