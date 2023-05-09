using System;

public class Impares
{
  public static void Main()
  {
    Random random = new Random();
    int[] oddNumbers = new int[10];
    string printConsole = "Primeiros 10 números ímpares embaralhados:";
    for(int i = 0; i < oddNumbers.Length; i++) {
      bool repeatedNumber;
      int randomNumber;
      if(i == 0) {
        do {
          randomNumber = random.Next(1, 20);
        } while(randomNumber % 2 == 0);
        printConsole += (" " + randomNumber);
      } else {
        do {
          repeatedNumber = false;
          do {
            randomNumber = random.Next(1, 20);
          } while(randomNumber % 2 == 0);
          for(int j = 0; j < i; j++) {
            if (randomNumber == oddNumbers[j]) {
              repeatedNumber = true;
              break;
            }
          }
        } while(repeatedNumber);
        printConsole += (", " + randomNumber);
      }
      oddNumbers[i] = randomNumber;
    }
    Console.WriteLine(printConsole);
  }
}