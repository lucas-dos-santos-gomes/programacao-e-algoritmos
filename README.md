<img alt="Ícone csharp" height="45" width="45" src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/csharp/csharp-original.svg" />
<h1 align="center">Desvios Condicionais Parte 2</h1>

Resolução de 11 exercícios de estruturas condicionais, onde continuei do desvios condicionais simples e treinei mais meu raciocínio lógico e meu conhecimento geral sobre essa linguagem e seus atributos.

## Features

Lição passada pela professora Cristiane Tuji da Silva na Etec Albert Einstein. O objetivo era reforçar o conteúdo passado em sala de aula até o momento, sobre estruturas condicionais.

As estruturas que foram treinadas nesse exercício:
* if
* else
* else if
* Switch

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

Desenvolva programas que atendam as solicitações:

### <a href="https://dotnetfiddle.net/RLFdzb">Exercício 1 - Validar</a>

<p>Desenvolver um programa que receba valores numéricos entre 0 (zero) e 100 (cem), digitados pelo usuário. Se o valor estiver dentro da faixa, deverá apresentar a mensagem "Valor Válido" e o valor digitado. Caso o valor esteja fora da faixa, apresentar a mensagem "Valor Inválido" e o valor digitado.</p>

### <a href="https://dotnetfiddle.net/3wP7kZ">Exercício 2 - Média</a>

<p>Desenvolva um programa que leia 4 notas escolares de um aluno e calcule a média aritmética das notas. Caso a média seja maior ou igual a 5, exibir a mensagem "Aluno aprovado". Se o aluno ficou entre 3 e 5, exibir a mensagem “Recuperação”, se não atingiu a média mínima (menos do que 3), exibir a mensagem "Aluno reprovado". Apresente junto à mensagem a média do aluno.</p>

### <a href="https://dotnetfiddle.net/ReTtzu">Exercício 3 - Diferença</a>

<p>Desenvolva um programa que leia dois valores inteiros digitados pelo usuário, e apresente a diferença do maior pelo menor.</p>

### <a href="https://dotnetfiddle.net/SWIA27">Exercício 4 - Par ou Ímpar</a>

<p>Elabore um programa que verifique se o número digitado e par ou ímpar. Use o comando % que retorna o resto de uma divisão.</p>

### <a href="https://dotnetfiddle.net/3U8w0h">Exercício 5 - Ordenar Números</a>

<p>Elaborar um programa que leia 3 valores inteiros digitados (representados pelas variáveis numA, numB e numC). O programa deverá apresentar os valores digitados em ordem crescente. Não esqueça que você precisará de uma variável auxiliar, para não perder os valores digitados pelo usuário.</p>

### <a href="https://dotnetfiddle.net/IBLZCv">Exercício 6 - Meia Entrada</a>

<p>Desenvolva um programa que calcule meia entrada para menores de 12 anos, maiores de 65 anos ou estudantes. Receba os parâmetros do usuário: idade (inteiro), estudante (lógico). Faça um único separa testar todas as condições de uma única vez. O valor da entrada é R$ 20,00. Exibir o valor da entrada a ser pago pelo cliente.</p>

### <a href="https://dotnetfiddle.net/PAmkR4">Exercício 7 - Ordenar</a>

<p>Utilize o conceito de propriedade distributiva para ordenar os valores. Não use variável auxiliar desta vez. Utilize ifs independentes. Baseie-se no algoritmo:</p>

> Se (numA > numB) Entao <br>
>   numB ← numA –numB <br>
>   numA ← numA –numB <br>
>   numB ← numA + numB <br>
> FimSe <br>
> Se (numA > numC) Entao <br>
>   numC ← numA –numC <br>
>   numA ← numA –numC <br>
>   numC ← numA + numC <br>
> FimSe <br>
> Se (numB > numC) Entao <br>
>   numC ← numB –numC <br>
>   numB ← numB –numC <br>
>   numC ← numB + numC <br>
> FimSe <br>
> Exibir numA, numB, numC

### <a href="https://dotnetfiddle.net/r2CJpP">Exercício 8 - Aumento</a>

<p>Uma empresa decidiu dar reajuste a seus funcionários de acordo com os seguintes critérios:</p>

* 10% para os funcionários que recebam um salário inferior a 1000 reais (<1000)
* 8% para os funcionários que recebam até 2000 reais (<=2000)
* 6% para os funcionários que recebam até 3500 reais (<=3500)
* 4% para os funcionários que recebam até 5000 reais (<=5000)
* 2% para os demais.

<p>Desenvolva um programa que efetue esse cálculo e apresente o resultado:</p>

* Salário anterior = --salário--
* Aumento = --valor_do_aumento--
* Salário atual = --salário atual--

### <a href="https://dotnetfiddle.net/fqkrBY">Exercício 9 - Pesquisa</a>

<p>Desenvolva um programa que teste responda se a pessoa está apta para participar da pesquisa. Uma empresa quer testar a satisfação dos clientes com um produto lançado recentemente no mercado. Os consumidores entrevistados deverão ser do sexo masculino, idade entre 20 e 25 anos, da classe A ou B, nível superior, que tenham adquirido o produto há mais de 6 meses e menos de 1 ano. Teste as informações e exiba “Apto” ou “Fora da faixa pesquisada”. Crie SE's encadeados e passe para a próxima pergunta somente se ele continuar apto.</p>

### <a href="https://dotnetfiddle.net/9GVxg0">Exercício 10 - Calculadora</a>

<p>Desenvolva um programa que receba 2 números digitados pelo usuário, e armazene  em duas variáveis do tipo real. Após receber os 2 números, apresente o seguinte menu:</p>

<ol>
  <li>adição</li>
  <li>subtração</li>
  <li>multiplicação</li>
  <li>divisão</li>
  <li>resto da divisão</li>
</ol>

<p>Depois que o usuário escolher a opção, efetue a operação escolhida pelo usuário, sempre o primeiro pelo segundo, por exemplo: Se o usuário digitar 10 e 5 e escolher subtração, subtraia 10 – 5. Exiba ao final o cálculo, da seguinte forma:</p>

* 10 - 5 = 5

### <a href="https://dotnetfiddle.net/HYWMwe">Exercício 11 - Par Ideal</a>

<p>Desenvolva um programa que sugira uma pessoa como sendo o par ideal (Tipo o BuzzFeed). Para descobrir, faça alguns testes. Peça que o usuário selecione uma das opções:</p>

* Apresente as 4 estações do ano
  - primavera, verão, outono, inverno
* Apresente 6 opções de viagem
  - cidade, campo, praia, radical, cruzeiro e resort
* Apresente os gêneros e pergunte qual o gênero do par ideal dela
  - F, M

<p>Ao final, apresente como sugestão de par ideal o nome de uma pessoa qualquer. O programa deve apresentar nomes diferentes caso a pessoa mude as escolhas. Vá pontuando conforme as escolhas. Cada opção possui um valor, por exemplo, primavera vale 1, verão vale 2 e assim por diante. O menor valor que a pessoa vai obter, escolhendo sempre as opções 1 será 3 pontos. O gênero não conta ponto. Ao mostrar o par ideal, veja se o gênero é F ou M e apresente um nome do gênero selecionado. Você vai precisar de 10 nomes para cada gênero.</p>

## Authors

* Lucas dos Santos Gomes

> Me siga nas redes sociais e favorite esse projeto. <br>
> Obrigado pela sua visita!

. <br>
. <br>
. <br>

#etec #csharp #if-else #switch #logica #programacao #estruturas-condicionais