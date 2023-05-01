using System;

public class Exercicio2
{
  public static void Main()
  {
    Console.WriteLine("Digite um número inteiro: ");
		int number = int.Parse(Console.ReadLine());
		if(number % 2 == 0) {
			Console.WriteLine("\nO número " + number + " é par!");
		} else {
			Console.WriteLine("\nO número " + number + " é impar!");
		}
  }
}