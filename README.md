<img alt="Ícone csharp" height="45" width="45" src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/csharp/csharp-original.svg" />
<h1 align="center">Projeto Loop: Estruturas de Repetição</h1>

Resolução de 9 exercícios de estruturas de repetição com C#, onde treinei meu raciocínio lógico e meu conhecimento geral sobre essa liguagem e seus atributos.

## Features

Lição passada pela professora Cristiane Tuji da Silva na Etec Albert Einstein. O objetivo era praticar o conteúdo passado em sala de aula no dia 03/04, sobre estruturas de repetição / loops.

As novas estruturas que foram treinadas nesse exercício:
* While
* Do While
* For
  - Foreach (Projeto futuro)

## Technologies

Todas as tecnologias utilizadas nesse projeto:
* C#
* .NET SDK
* Visual Studio Code
  - C#
  - C# Extensions
* Visual Studio
* dotnetfiddle.net

## Exercises

Exercícios da letra 'a)' até a letra 'i)'.

### <a href="https://dotnetfiddle.net/XllVuh">a) Classe Tabuada</a>

Desenvolva um programa que receba um número inteiro digitado e apresente a tabuada deste número. Utilize o loop <b>for</b>. Sintaxe:

>  for (contador, limite, passo) { 
>   //codigo; 
> } 
> 
> for (int i = 0, i<=10, i++) { 
>   //criar aqui a mensagem a com o resultado da tabuada
> }

Ao final, exibir a mensagem:
<div align="center">
  <img src="https://user-images.githubusercontent.com/106649118/235416037-36b6ba73-e6c6-4ac0-8e82-201a6f815b1e.png" alt="Tabuada do 5" />
</div>

### b) Classe SomarValores

Desenvolver um programa que recebe um número inteiro digitado e soma todos os números de 1 ate o numero digitado e apresente o resultado abaixo. Utilize o loop <b>for</b>.

> 5! = 1 + 2 + 3 + 4 + 5 = 15

### c) CLasse Fatorial

Desenvolver um programa que recebe um número inteiro digitado e multiplique todos os números de 1 ate o numero digitado e apresente o resultado abaixo. Utilize o loop <b>for</b>.

> 5! = 1 * 2 * 3 * 4 * 5 = 120

### d) Classe TesteDeSoma

Desenvolva um programa que apresente um a expressão de soma de dois números obtidos randomicamente (de 1 a 10), caso o usuário digite a resposta errada, peça que ele tente novamente, se ele acertar, dê os parabéns. Conte quantas vezes ele acertou e apresente o percentual de acertos a cada jogada. Para sair, peça que ele digite 0. Utilize o loop <b>while</b>. Sintaxe:

> while (condição boleana) {
>   //código que será repetido enquanto a condição for verdadeira;
> }

Comando para gerar números aleatórios:

> Random gerador = new Random();
> int n1 = gerador.nextInt(10); // O 10 indica que o número gerado deve ser entre 1 e 10.
> int n2 = gerador.nextInt(10); // Se colocar 100 serão gerados números até 100.

<div align="center">
  <img src="https://user-images.githubusercontent.com/106649118/235416157-aff12275-b97f-4705-944d-08aaf6af297c.png" alt="Resultado soma" />

  <img src="https://user-images.githubusercontent.com/106649118/235416526-e6deb9b5-bed0-4ab0-bc97-21f56f7cd7a9.png" alt="Parabéns pelo acerto" />
</div>

### e) Classe ParOuImpar

Faça um programa que o usuário escolha entre as opções “1- Par 2- Impar 0- Sair”. Exiba um número obtido randomicamente. Se ele acertar, conte o ponto para o usuário, senão, ponto para o computador. Exiba o placar a cada jogada. Utilize o loop <b>while</b>.

<div align="center">
  <img src="https://user-images.githubusercontent.com/106649118/235417179-f2874aee-6436-454d-8b68-975cd7388c4c.png" alt="Escolha ímpar, par ou saída" />

  <img src="https://user-images.githubusercontent.com/106649118/235417363-e22ed698-a1af-4ab2-92f1-64cb1a330015.png" alt="Parabéns, é realmente ímpar!" />
</div>

### f) Classe MaiorGanha

Faça um programa que exiba um número de 1 a 100 obtido randomicamente para o usuário e pergunte se ele quer apostar. Se sim, gere outro número obtido randomicamente. Se o número recebido pelo usuário for maior, pontue o usuário, se o número apresentado para o computador for maior, pontue o computador, se os números forem iguais, não pontue ninguém. Exiba o placar a cada jogada. Utilize o loop <b>do while</b>.

> do{
>   //código que será repetido enquanto a condição for verdadeira;
> } while (condição booleana);
> 
> //Caixa de mensagem com opção de sim e não:
> JOptionPane.showConfirmDialog(null, “Seu número é” + n + “ Apostar?”,”Confirmação”, 0);

<div align="center">
  <img align="center" src="https://user-images.githubusercontent.com/106649118/235417843-fe309d6e-c15d-43cf-8eff-bab81c1affdd.png" alt="Aposta contra computador" />
</div>

### g) Classe ChuteCerto

Faça um programa que receba um número (de 1 a 10) digitado pelo usuário. Gere um número randomicamente. Se número gerado for igual ao número informado pelo usuário, dê os parabéns e some 1 ponto. Senão, some 1 ponto para o computador. Exiba o placar a cada jogada. Para sair peça que ele digite 0.

<div align="center">
  <img align="center" src="https://user-images.githubusercontent.com/106649118/235418241-3e9a7ed0-c432-43fa-bfcc-369a93c3c8bf.png" alt="Digite um número de 1 a 10" />

  <img align="center" src="https://user-images.githubusercontent.com/106649118/235418395-16f2d1da-0cb1-4a18-a3dc-1cb18753c421.png" alt="Parabéns! Você acertou o número!" />
</div>

### h) Classe InverterNumero

Faça um programa que receba um número entre 100 e 999. Se o número estiver fora desta faixa, exiba uma mensagem ao usuário de número inválido. Caso o número seja válido, exiba o número digitado e o inverso do número digitado. Não converta o número em String para inverter. Utilize variáveis auxiliares do tipo int. Se a pessoa digitar 0, saia do programa. Utilize o loop <b>do while</b> para repetir até que o usuário queira parar. Você vai precisar de pelo menos <b>3 variáveis auxiliares</b>.

<div align="center">
  <img align="center" src="https://user-images.githubusercontent.com/106649118/235418759-c91b0b55-f091-479a-b62b-c7a0974c73ce.png" alt="Digite um número de entre 100 e 999" />

  <img align="center" src="https://user-images.githubusercontent.com/106649118/235421581-c477b3d6-5dd8-47b2-8c16-8cef8cb77650.png" alt="Número digitado e o inverso dele" />
</div>

### i) Classe ProgressaoAritmetica

Crie um programa que receba um número digitado pelo usuário, uma razão e o limite. Calcule os termos de  uma P.A (Progressão Aritmética), armazenando esses valores em uma String. Exiba os números obtidos. Progressão aritmética é uma sequência de números somados a um valor constante. Fórmula:

<div align="center">
  <img align="center" src="https://user-images.githubusercontent.com/106649118/235421984-9e31ba05-1d87-4837-a433-2e6b5458f5ae.png" alt="Fórmula da progressão aritmética" />
</div>

, em que:
* a¹ é o primeiro termo;
* r é a razão;
* O segundo número da progressão é obtido pela fórmula: a2 = a1 + (2 - 1) * r;
* Exemplo = número recebido 2, razão 2, limite 10: 2, 4, 6, 8, 10, 12, 14, 16, 18, 20.

<div align="center">
  <img align="center" src="https://user-images.githubusercontent.com/106649118/235422490-a7420ca8-b599-4669-8e2e-127aa0fd439e.png" alt="Exemplo do programa" />
</div>

## Authors

* Lucas dos Santos Gomes

> Me siga nas redes sociais e favorite esse projeto. <br>
> Obrigado pela sua visita!

. <br>
. <br>
. <br>

#etec #csharp #loops #logica #programacao #projetoloop #algoritmo