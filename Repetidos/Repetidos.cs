using System;

public class Repetidos
{
  public static void Main()
  {
    Random random = new Random();
    int[] numberList = new int[100];
    string printNumberList = "\nItens do array:";
    int hasRepeat = 1;
    int countRepeatNumbers = 0;
    for(int i = 0; i < numberList.Length; i++) {
      numberList[i] = random.Next(1, 51);
      string ternario = (i == 0) ? (" " + numberList[i]) : (", " + numberList[i]);
      printNumberList += ternario;
    }
    for(int i = 0; i < numberList.Length; i++) {
      int qttItems = Array.FindAll(numberList, x => x == numberList[i]).Length;
      hasRepeat *= qttItems;
      countRepeatNumbers += (qttItems > 1) ? 1 : 0;
    }
    if(hasRepeat == 1) {
      Console.WriteLine("\nEssa lista não tem nenhuma repetição");
    } else {
      int[] testFilterList = numberList.Distinct().ToArray();
      int[] filterList = testFilterList.Where(n => {
        return Array.FindAll(numberList, x => x == n).Length > 1;
      }).ToArray();

      Console.WriteLine("\nQuantidade de números que se repetem: {0} números", filterList.Length);
      foreach(int n in filterList) {      
        Console.WriteLine("\nNúmero que repete: {0}", n);
        Console.WriteLine("Quantidade de vezes que ele se repete: {0}", Array.FindAll(numberList, x => x == n).Length);
      }
      Console.WriteLine("\n{0}\n", printNumberList);
    }
  }
}