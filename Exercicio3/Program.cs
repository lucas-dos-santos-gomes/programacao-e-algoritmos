using System;

public class Exercicio3
{
  public static void Main()
  {
    Console.WriteLine("Informe o primeiro número:");
		float n1 = float.Parse(Console.ReadLine());
		Console.WriteLine("\nInforme o segundo número:");
		float n2 = float.Parse(Console.ReadLine());
		
		if(n1 > n2) {
			float divisao = n1 / n2;
			Console.WriteLine("\nO resultado da divisão entre '" + n1 + "' e '" + n2 + "' é '" + divisao + "'");
		} else if(n1 < n2) {
			float divisao = n2 / n1;
			Console.WriteLine("\nO resultado da divisão entre '" + n2 + "' e '" + n1 + "' é '" + divisao + "'");
		} else {
			Console.WriteLine("\nO resultado da divisão é 1, pois os números são iguais");
		}
  }
}