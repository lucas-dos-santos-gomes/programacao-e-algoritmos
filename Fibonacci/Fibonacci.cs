using System;

public class Fibonacci
{
  public static void Main()
  {
    string continuar;
    do {
      Console.WriteLine("\nDigite um número para fazer a sequência de Fibonacci:");
      int index = int.Parse(Console.ReadLine());
      int[] fibonacci = new int[index];
      for(int i = 0; i < index; i++) {
        if(i >= 2) {
          fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
        } else {
          fibonacci[i] = i;
        }
      }
      string printFibonacci = "\nSequência de Fibonacci:";
      foreach (int i in fibonacci) {
        if(i == 0) {
          printFibonacci += (" " + i);
        } else {
          printFibonacci += (", " + i);
        }
      }
      Console.WriteLine(printFibonacci);
      Console.WriteLine("\nDeseja fazer o Fibonacci novamente? (sim / nao)");
      continuar = Console.ReadLine();
      while(continuar != "sim" && continuar != "nao") {
        Console.WriteLine("Digite apenas 'sim' ou 'nao': ");
        continuar = Console.ReadLine();
      }
    } while(continuar == "sim");
  }
}