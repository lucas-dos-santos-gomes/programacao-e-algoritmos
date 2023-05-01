<img alt="Ícone csharp" height="45" width="45" src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/csharp/csharp-original.svg" />
<h1 align="center">Algoritmos e Fluxograma: Troca de Pneus</h1>

Resolução do exercício de algoritmo, criando o fluxograma dos algoritmos solicitados feitos para troca de pneu. Nesta atividade, treinei meu raciocínio lógico e algorítmico, pensando no passo a passo para resolver o problema proposto.

## Features

Lição passada pela professora Cristiane Tuji da Silva na Etec Albert Einstein. O objetivo era praticar o conteúdo passado em sala de aula até o dia 27/02, sobre lógica, algoritmos e fluxogramas.

Instruções para realizar a tarefa:

* Crie 3 algoritmos para as trocas de pneus propostas 
* Crie os fluxogramas para cada um dos algoritmos
* O fluxograma pode ser feito no site https://app.diagrams.net/

## Exercises

Tendo como exemplo os algoritmos anteriores, elabore 3 algoritmos que mostrem os passos necessários para trocar um pneu furado. Considere o seguinte conjunto de situações:

1. Trocar o pneu traseiro esquerdo;
2. Trocar o pneu traseiro esquerdo e, antes, verificar se o pneu reserva está em condições de uso;
3. Verificar se existe algum pneu furado; se houver, verificar o pneu reserva e, então, trocar o pneu correto.

Para cada algoritmo faça um refinamento do anterior, introduzindo novas ações e alterando o fluxo de execução de forma compatível com as situações apresentadas.

### Exercise 1 - Algoritmo Sequencial

Trocar o pneu traseiro esquerdo
* Abrir o porta-malas;
* Pegar o pneu reserva e o macaco;
* Fechar o porta-malas;
* Colocar o macaco na posição;
* Subir o macaco;
* Retirar os parafusos;
* Retirar o pneu;
* Colocar o pneu reserva;
* Apertar os parafusos;
* Baixar o macaco;
* Retirar o macaco;
* Abrir o porta-malas;
* Guardar o pneu e o macaco;
* Fechar o porta-malas.

<img align="center" src="https://user-images.githubusercontent.com/106649118/235532563-5cf9752b-b24c-4cbd-a13e-fd44074ea6a1.png" alt="Fluxograma do algoritmo sequencial" />

### Exercise 2 - Algoritmo de Decisão 1

Trocar o pneu traseiro esquerdo e, antes, verificar se o pneu reserva está em condições de uso;

<b>Versão da professora:</b>
* Abrir o porta-malas;
* Se o pneu reserva estiver em condições de uso, então:
  - Pegar o pneu reserva e o macaco;
  - Fechar o porta-malas;
  - Colocar o macaco na posição;
  - Subir o macaco;
  - Retirar os parafusos;
  - Retirar o pneu;
  - Colocar o pneu reserva;
  - Apertar os parafusos;
  - Baixar o macaco;
  - Retirar o macaco;
  - Abrir o porta-malas.

<b>Minha versão:</b>
* Abrir o porta-malas; 
* Se o pneu reserva estiver em condições de uso, então: 
  - Pegar o pneu reserva e o macaco;
  - Fechar o porta-malas;
  - Colocar o macaco na posição; 
  - Subir o macaco; 
  - Retirar os parafusos; 
  - Retirar o pneu; 
  - Colocar o pneu reserva; 
  - Apertar os parafusos; 
  - Baixar o macaco; 
  - Retirar o macaco; 
  - Abrir o porta-malas; 
  - Guardar o pneu e o macaco; 
  - Fechar o porta-malas. 
* Se o pneu reserva não estiver em condições de uso, então: 
  - Retirar o pneu para o descarte; 
  - Fechar o porta-malas; 
  - Descartar pneu em local apropriado; 
  - Ir até uma loja ou site que venda pneu; 
  - Comprar o pneu; 
  - Pegar o pneu; 
  - Ir até o carro; 
  - Abrir porta-malas; 
  - Pegar o macaco; 
  - Fechar o porta-malas; 
  - Colocar o macaco na posição; 
  - Subir o macaco; 
  - Retirar os parafusos; 
  - Retirar o pneu; 
  - Colocar o pneu reserva; 
  - Apertar os parafusos; 
  - Baixar o macaco; 
  - Retirar o macaco; 
  - Abrir o porta-malas; 
  - Guardar o pneu e o macaco; 
  - Fechar o porta-malas. 

<img align="center" src="https://user-images.githubusercontent.com/106649118/235534954-10ca7e4a-b111-411b-b75e-53a8c9e5ed99.png" alt="Fluxograma do primeiro algoritmo de decisão" />

### Exercise 3 - Algoritmo de Decisão 2

Verificar se existe algum pneu furado; se houver, verificar o pneu reserva e, então, trocar o pneu correto.

<b>Versão da professora:</b>
* Verificar o estado dos pneus
* Se existir um pneu furado, então:
  - Abrir o porta-malas;
  - Verificar o estado do pneu reserva;
  - Se o pneu reserva estiver em condições de uso, então:
    - Pegar o pneu reserva e o macaco;
    - Fechar o porta-malas;
    - Colocar o macaco na posição;
    - Subir o macaco;
    - Retirar os parafusos;
    - Retirar o pneu;
    - Colocar o pneu reserva;
    - Apertar os parafusos;
    - Baixar o macaco;
    - Retirar o macaco;
    - Abrir o porta-malas;
    - Guardar o pneu e o macaco;
    - Fechar o porta-malas

<b>Minha versão:</b>
* Verificar o estado dos pneus; 
* Se existir um pneu furado, então: 
  - Abrir o porta-malas; 
  - Verificar o estado do pneu reserva; 
  - Se o pneu reserva estiver em condições de uso, então: 
    - Pegar o pneu reserva e o macaco; 
    - Fechar o porta-malas; 
    - Colocar o macaco na posição; 
    - Subir o macaco; 
    - Retirar os parafusos; 
    - Retirar o pneu; 
    - Colocar o pneu reserva; 
    - Apertar os parafusos; 
    - Baixar o macaco; 
    - Retirar o macaco; 
    - Abrir o porta-malas; 
    - Guardar o pneu e o macaco; 
    - Fechar o porta-malas; 
  - Se o pneu reserva não estiver em condições de uso, então: 
    - Retire o pneu para o descarte; 
    - Feche o porta-malas; 
    - Descarte o pneu em um local apropriado; 
    - Vá até uma loja ou site que venda pneu; 
    - Compre o pneu; 
    - Assim que chegar, pegar o pneu; 
    - Ir até o porta-malas; 
    - Abrir porta-malas; 
    - Pegar o macaco; 
    - Fechar o porta-malas; 
    - Colocar o macaco na posição; 
    - Subir o macaco; 
    - Retirar os parafusos; 
    - Retirar o pneu; 
    - Colocar o pneu reserva; 
    - Apertar os parafusos; 
    - Baixar o macaco; 
    - Retirar o macaco; 
    - Abrir o porta-malas; 
    - Guardar o pneu e o macaco; 
    - Fechar o porta-malas. 
* Se não existir um pneu furado, então: 
  - O carro está em condições de uso. 

<img align="center" src="https://user-images.githubusercontent.com/106649118/235537708-5a34fd6e-1c4c-4619-b418-8e2f2349b17f.png" alt="Fluxograma do segundo algoritmo de decisão" />

## Authors

* Lucas dos Santos Gomes

> Me siga nas redes sociais e favorite esse projeto. <br>
> Obrigado pela sua visita!

. <br>
. <br>
. <br><br>

#etec #csharp #logica #algoritmos #fluxograma #programacao #dev