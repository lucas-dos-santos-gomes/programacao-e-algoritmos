using System;

public class Pares
{
  public static void Main()
  {
    Random random = new Random();
    int[] numberArray = new int[40];
    int evenCount = 0;
    string printArray = "\nItens do array:";
    for(int i = 0; i < numberArray.Length; i++) {
      numberArray[i] = random.Next(1, 100);
      if(numberArray[i] % 2 == 0) {
        evenCount++;
      }
      string ternary = (i == 0) ? (" " + numberArray[i]) : (", " + numberArray[i]);
      printArray += ternary;
    }
    Console.WriteLine(printArray);
    Console.WriteLine("Quantidade de valores pares: {0}\n", evenCount);
  }
}