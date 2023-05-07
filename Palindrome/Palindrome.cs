using System;

public class Palindrome {
  public static void Main() {
    string continueProgram = "nao";
    do {
      Console.WriteLine("\nDigite uma palavra para verificarmos se é um palíndromo: ");
      string word = Console.ReadLine();
      string reverseWord = "";
      for(int i = word.Length - 1; i >= 0; i--) {
        reverseWord += word[i];
      }

      if(word == reverseWord) {
        Console.WriteLine("\nEssa palavra é um palíndromo!");
      } else {
        Console.WriteLine("\nEssa palavra NÃO é um palíndromo!");
      }

      Console.WriteLine("\nDeseja inserir outra palavra? (sim / nao)");
      continueProgram = Console.ReadLine();
      while(continueProgram != "sim" && continueProgram != "nao") {
        Console.WriteLine("\nInsira apenas 'sim' ou 'nao': ");
        continueProgram = Console.ReadLine();
      }
    } while(continueProgram == "sim");
  }
}