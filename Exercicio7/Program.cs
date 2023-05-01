using System;
					
public class Exercicio7
{
	public static void Main()
	{
		Console.WriteLine("Digite 1 (sinal vermelho) ou 2 (sinal verde):");
		int sinal = int.Parse(Console.ReadLine());
		while(sinal != 1 && sinal != 2) {
			Console.WriteLine("\nIncorreto!");
			Console.WriteLine("Digite 1 (sinal vermelho) ou 2 (sinal verde):");
			sinal = int.Parse(Console.ReadLine());
		}
		if(sinal == 1) {
			Console.WriteLine("\nESPERE!");
		} else {
			Console.WriteLine("\nSIGA!");
		}
	}
}