## Sobre o Projeto
O projeto visava desenvolver um sistema para smartphones utilizando os princípios da Programação Orientada a Objetos (POO) em C#.

Classe abstrata "Smartphone": Uma classe abstrata central foi criada, denominada "Smartphone", para fornecer uma estrutura comum para as subclasses, que representam diferentes marcas de smartphones.
Subclasses "Iphone" e "Nokia": Classes específicas para "Iphone" e "Nokia" foram implementadas, herdando da classe abstrata "Smartphone". Isso permitiu que cada marca tivesse comportamentos distintos, enquanto compartilhava características genéricas.
Ambiente .NET: O desenvolvimento foi realizado no ambiente .NET, utilizando o console de gerenciamento.

## Proposta

![Diagrama classes](Imagens/diagrama.png)

## Regras e validações
1. A classe **Smartphone** deve ser abstrata, não permitindo instanciar e servindo apenas como modelo.
2. A classe **Nokia** e **Iphone** devem ser classes filhas de Smartphone.
3. O método **InstalarAplicativo** deve ser sobrescrito na classe Nokia e iPhone, pois ambos possuem diferentes maneiras de instalar um aplicativo.

## Tecnologias Utilizadas 

![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)
![Git](https://img.shields.io/badge/GIT-E44C30?style=for-the-badge&logo=git&logoColor=white)
