using System;

public class InverterPalavra
{
  public static void Main()
  {
    string continueProgram;
    do {
      string finalWord = "";
      Console.WriteLine("\nEscreva uma palavra para invertermos: ");
      string word = Console.ReadLine();
      char[] wordList = word.ToCharArray();

      // Array.reverse()
      for(int i = wordList.Length - 1; i >= 0; i--) {
        finalWord += wordList[i];
      }
      Console.WriteLine("\nPalavra inserida: {0}", word);
      Console.WriteLine("Palavra invertida: " + finalWord);

      Console.WriteLine("\nDeseja inserir outra palavra? (sim / nao)");
      continueProgram = Console.ReadLine();
      while(continueProgram != "sim" && continueProgram != "nao") {
        Console.WriteLine("\nInsira apenas 'sim' ou 'nao': ");
        continueProgram = Console.ReadLine();
      }
    } while(continueProgram == "sim");
  }
}