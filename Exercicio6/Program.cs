using System;

public class Exercicio6
{
  public static void Main()
  {
    Console.WriteLine("Informe um número qualquer:");
		float number = float.Parse(Console.ReadLine());
		
		if(number < 100) {
			Console.WriteLine("\nO número informado é menor do que 100!");
		} else if(number > 100) {
			Console.WriteLine("\nO número informado é maior do que 100!");
		} else {
			Console.WriteLine("\nO número informado é igual a 100!");
		}
  }
}