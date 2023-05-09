using System;

public class ProcurarTodasOcorrencias
{
  public static void Main()
  {
    Random random = new Random();
    int[] numberArray = new int[100];
    string printArray = "Itens do array:";
    for(int i = 0; i < numberArray.Length; i++) {
      numberArray[i] = random.Next(1, 51);
      string ternary = (i == 0) ? (" " + numberArray[i]) : (", " + numberArray[i]);
      printArray += ternary;
    }
    Console.WriteLine("Digite um número de 1 a 50 que será buscado no Array: "); 
    int searchNumber = int.Parse(Console.ReadLine());

    Console.WriteLine("\nNúmero inserido: {0}", searchNumber);
    int qttItems = Array.FindAll(numberArray, x => x == searchNumber).Length;
    if(qttItems == 0) {
      Console.WriteLine("O número {0} não foi encontrado", searchNumber);
    } else {
      string printPositionItems = "Posição dos itens encontrados:";
      int[] positionItems = new int[qttItems];
      int count = 0;
      for(int i = 0; i < positionItems.Length; i++) {
        for(int j = count; j < numberArray.Length; j++) {
          if(searchNumber == numberArray[j]) {
            positionItems[i] = j;
            count = (j + 1);
            break;
          }
        }
        string ternary = (i == 0) ? (" " + positionItems[i]) : (", " + positionItems[i]);
        printPositionItems += ternary;
      }
      Console.WriteLine("Quantidade de itens: " + qttItems);
      Console.WriteLine(printPositionItems);
    }
    Console.WriteLine(printArray);
  }
}