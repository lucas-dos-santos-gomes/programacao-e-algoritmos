<img alt="Ícone csharp" height="45" width="45" src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/csharp/csharp-original.svg" />
<h1 align="center">Projeto Array: Listas e Vetores</h1>

Resolução de 12 exercícios de estruturas de arrays com C#, onde treinei meu raciocínio lógico e meu conhecimento geral sobre essa linguagem e seus atributos.

## Features

Lição passada pela professora Cristiane Tuji da Silva na Etec Albert Einstein. O objetivo era praticar o conteúdo passado em sala de aula no dia 24/04, sobre arrays, listas e vetores.

As novas estruturas e funções que foram feitas nesses exercícios:
* Iniciar array:
  - char[] variable = variable.ToCharArray();
  - string[] variable = new string[number];
  - int[] variable = new int[number];
  - double[] variable = new double[number];
  - bool[] variable = new bool[number];
* Array.Sort(variable);
* int indexArray = Array.IndexOf(variable, x);
* int[] array = Array.FindAll(variable, x => condition);
* Random random = new Random();
  - random.Next(x, y);
* variable = (i == 0) ? (return if) : (return else);
* int[] filterArray = variable.Distinct().ToArray();
* int[] filterArray = variable.Where(n => n > 8).ToArray();
* break;

## Technologies

Todas as tecnologias utilizadas nesse projeto:
* C#
* .NET SDK
* Visual Studio Code
  - C#
  - C# Extensions
* Visual Studio
* dotnetfiddle.net
* ChatGPT

## Exercises

Criar os algoritmos que resolvam os problemas propostos, utilizando vetores.

### <a href="https://dotnetfiddle.net/kMlLMG">1. Classe: Media</a>

Faça um programa que receba 4 notas digitadas pelo usuário e calcule a média.

//Declare um array de doubles de 4 posições chamado notas.
> double[] notas = new double[4];

//Faça um for para receber as notas:
> for (int i = 0; i<notas.Length; i++) { <br>
>   Console.WriteLine("Informe a " + (i + 1) + "ª nota");<br>
>   notas[i] = double.Parse(Console.ReadLine());<br>
> }<br>

//Calcule a media

> double media = (notas[0] + notas[1] + notas[2] + notas[3])/4;

//Exiba a média

> Console.WriteLine("Sua média foi " + media); <br>
> Console.ReadKey();

### <a href="https://dotnetfiddle.net/MvSYw0">2. Classe: Fibonacci</a>

Crie um programa que receba por parâmetro um número inteiro de chamado índice e exiba o valor do número de Fibonacci correspondente. Os números de Fibonacci n1, n2, n3... são definidos da seguinte forma:

> N[0] = 0, n[1] = 1, n[i] = n[i – 1] + n[i – 2], sendo i>=2

Armazene os números em um vetor. Lembrando que o vetor começa no índice 0, a sequência de Fibonacci também começa com valor 0, mas ele já é o primeiro número da sequência. Assim se o usuário pedir o índice 10, no vetor ele será o n[9].

> 0, 1, 1, 2, 3, 5, 8, 13, 21, 44

### <a href="https://dotnetfiddle.net/ngWRrC">3. Classe: InverterPalavra</a>

Faça um programa que receba uma palavra e exiba a palavra digitada e a mesma palavra invertida. 

> Exemplo: Cristiane - enaitsirC

Converta a palavra recebida em um array de caracteres - <b>ToCharArray()</b> - e percorra este array de trás para frente, pegando as letras e concatenando em uma variável String.

### <a href="https://dotnetfiddle.net/iXGZm6">4. Classe: Palindrome</a>

Faça um programa que receba uma palavra digitada pelo usuário e verifique se essa palavra é palíndrome. Uma palavra palíndrome é aquela que pode ser lida tanto da direita para a esquerda quanto ao contrário. 

> Exemplo: arara, ovo.

### <a href="https://dotnetfiddle.net/kCLpk6">5. Classe: Impares</a>

Declare um array de inteiros de 10 posições numéricas, preencha com os 10 primeiros números impares, gerados aleatoriamente, e exiba o array obtido.

### <a href="https://dotnetfiddle.net/WKPPwL">6. Classe: OrdenarArray</a>

Faça um programa que gere e armazene em um array 10 valores gerados randomicamente e os apresente na ordem em que foram gerados. Ordene os valores e apresente os valores ordenados do menor para o maior.

### <a href="https://dotnetfiddle.net/GNyJ6n">7. Classe: TrocarPosicoes</a>

Declare um array de inteiros de 16 posições, preencha com números gerados aleatoriamente, troque os 8 primeiros valores pelos 8 últimos. Mostre o array original e o array final.

### <a href="https://dotnetfiddle.net/aQJEfS">8. Classe: ProcurarPrimeiraOcorrencia</a>

Declare um array de inteiros de 20 posições, preencha com números gerados aleatoriamente. Receba um valor digitado pelo usuário e exiba a primeira posição do array onde este valor foi encontrado ou se ele não foi encontrado e o array.

### <a href="https://dotnetfiddle.net/Inm3vo">9. Classe: ProcurarTodasOcorrencia</a>

Declare um array de inteiros de 100 posições, preencha com números gerados aleatoriamente. Receba um valor digitado pelo usuário e exiba todos os índices do array onde ocorre o valor digitado ou se ele não foi encontrado. Exiba também o array.

### <a href="https://dotnetfiddle.net/fG6jrH">10. Classe: Pares</a>

Declare um array de inteiros de 40 posições, preencha com números aleatórios. Contar e exibir quantos valores pares ele possui e exibir o array gerado.

### <a href="https://dotnetfiddle.net/AAtmsQ">11. Classe: Anagrama</a>

Crie um programa que receba duas palavras e verifique se uma palavra é anagrama da outra. Anagramas são palavras formadas pelas mesmas letras arranjadas de forma diferente.

> Ex.: amor-Roma, América-Iracema, rato-ator.

### <a href="https://dotnetfiddle.net/UxFhoE">12. Classe: Repetidos</a>

Declare um array de 100 posições, preencha e verifique se existem valores iguais. Escreva os valores que se repetem e quantas vezes ocorre a repetição.

## Authors

* Lucas dos Santos Gomes

> Me siga nas redes sociais e favorite esse projeto. <br>
> Obrigado pela sua visita!

. <br>
. <br>
. <br>

#etec #csharp #loops #logica #programacao #array #algoritmo #vetores #listas