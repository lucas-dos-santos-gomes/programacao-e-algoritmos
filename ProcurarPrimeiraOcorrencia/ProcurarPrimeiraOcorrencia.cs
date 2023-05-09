using System;

public class ProcurarPrimeiraOcorrencia
{
  public static void Main()
  {
    Random random = new Random();
    int[] numberList = new int[20];
    for(int i = 0; i < numberList.Length; i++) {
      numberList[i] = random.Next(1, 51);
    }
    Console.WriteLine("Digite um número que será buscado no Array: ");
    
    int searchNumber = int.Parse(Console.ReadLine());
    int indexArray = Array.IndexOf(numberList, searchNumber);
    if(indexArray >= 0) {
     Console.WriteLine("\nO número " + searchNumber + " está na posição " + indexArray + " do array");
    } else {
      Console.WriteLine("\nO número " + searchNumber + " não está em nenhuma posição do array");
    }
    Console.WriteLine("\nItens do array:");
    for(int i = 0; i < numberList.Length; i++) {
      Console.WriteLine("{0}: {1}", i, numberList[i]);
    }
  }
}