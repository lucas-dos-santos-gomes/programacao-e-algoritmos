using System;

public class Exercicio1
{
  public static void Main()
  {
    Console.WriteLine("Informe o primeiro número: ");
		int n1 = int.Parse(Console.ReadLine());
		Console.WriteLine("\nInforme o segundo número: ");
		int n2 = int.Parse(Console.ReadLine());
		
		if(n1 > n2) {
			Console.WriteLine("\nO maior número entre '" + n1 + "' e '" + n2 + "' é o '" + n1 + "'");
		} else if(n2 > n1) {
			Console.WriteLine("\nO maior número entre '" + n1 + "' e '" + n2 + "' é o '" + n2 + "'");
		} else {
			Console.WriteLine("\nOs números são iguais");
		}
  }
}