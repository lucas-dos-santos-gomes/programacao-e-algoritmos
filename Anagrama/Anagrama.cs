using System;

public class Anagrama
{
  public static void Main()
  {
    bool isAnagram = false;
    Console.WriteLine("Digite uma palavra:");
    string firstWord = Console.ReadLine();
    char[] arrayFirstWord = firstWord.ToCharArray();
  
    Console.WriteLine("\nDigite outra palavra para verificarmos se é um anagrama da outra:");
    string secondWord = Console.ReadLine();
    char[] arraySecondWord = secondWord.ToCharArray();

    if(firstWord.Length == secondWord.Length) {
      for(int i = 0; i < secondWord.Length; i++) {
        isAnagram = false;
        for(int j = 0; j < firstWord.Length; j++) {
          if(secondWord[i] == firstWord[j]) {
            isAnagram = true;
          }
        }
        if(!isAnagram) {
          Console.WriteLine("\nEssas palavras não são anagramas");
          break;
        }
      }
    } else {
      Console.WriteLine("\nEssas palavras não são anagramas");
    }
    if (isAnagram) {
      Console.WriteLine("\nAs palavras {0} e {1} são anagramas", firstWord, secondWord);
    }
  }
}