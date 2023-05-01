using System;

public class Exercicio5
{
  public static void Main()
  {
    Console.WriteLine("Informe o primeiro número:");
		int n1 = int.Parse(Console.ReadLine());
		while(n1 == 0) {
			Console.WriteLine("\nErrado! Informe um número diferente de '0':");
			n1 = int.Parse(Console.ReadLine());
		}
		
		Console.WriteLine("\nInforme o segundo número:");
		int n2 = int.Parse(Console.ReadLine());
		while(n2 == 0) {
			Console.WriteLine("\nErrado! Informe um número diferente de '0':");
			n2 = int.Parse(Console.ReadLine());
		}
		
		int produto = n1 * n2;
		Console.WriteLine("\nO produto entre '" + n1 + "' e '" + n2 + "' é = " + produto);
  }
}