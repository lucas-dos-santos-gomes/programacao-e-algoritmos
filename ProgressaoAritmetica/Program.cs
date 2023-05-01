using System;

public class ProgressaoAritmetica
{
  public static int Formula(int a1, int r, int n) {
    int progressaoAritmetica = a1 + (n - 1) * r;
    return progressaoAritmetica;
  }
  public static void Main()
  {
    int firstNumber, rate, limit, progressionNumber = 0, index;
    string continueGame;
    do {
      string arithmeticProgression = "PA: ";
      Console.WriteLine("\nAn = A¹ + (n - 1) * r");
      Console.WriteLine("\n= A¹ é o primeiro termo;");
      Console.WriteLine("= r é a razão;");
      Console.WriteLine("= n é termo (posição) que você quer descobrir;");
      Console.WriteLine("= O limite é a quantidade de vezes que a progressão vai aumentar.");

      Console.WriteLine("\nInforme o primeiro termo: ");
      firstNumber = int.Parse(Console.ReadLine());
      
      Console.WriteLine("\nInforme a razão: ");
      rate = int.Parse(Console.ReadLine());
      
      Console.WriteLine("\nInforme o limite: ");
      limit = int.Parse(Console.ReadLine());

      for(int i = 0; i < limit; i++) {
        if(i == 0) {
          progressionNumber = firstNumber;
          arithmeticProgression += firstNumber;
        } else {
          progressionNumber = Formula(progressionNumber, rate, 2);
          arithmeticProgression += ", " + progressionNumber;
        }
      }
      Console.WriteLine("\n" + arithmeticProgression);

      Console.WriteLine("\nInforme o termo (n) que você quer descobrir dessa progressão aritmética: ");
      index = int.Parse(Console.ReadLine());
      Console.WriteLine("\nO " + index + "° termo dessa progressão é o " + Formula(firstNumber, rate, index));

      Console.WriteLine("\nDeseja fazer outra progressão aritmética? (sim / nao)");
      continueGame = Console.ReadLine();
      while(continueGame != "sim" && continueGame != "nao") {
        Console.WriteLine("\nVocê precisa responder 'sim' ou 'nao':");
        continueGame = Console.ReadLine();
      }
    } while(continueGame == "sim");
  }
}