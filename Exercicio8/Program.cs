using System;
					
public class Exercicio8
{
	public static void Main()
	{
		Console.WriteLine("Digite o número de vitórias do Corinthians:");
		int vitorias = int.Parse(Console.ReadLine());
		Console.WriteLine("\nDigite o número de derrotas do Corinthians:");
		int derrotas = int.Parse(Console.ReadLine());
		
		if(vitorias > derrotas) {
			Console.WriteLine("\nBOM!");
		} else if(vitorias < derrotas) {
			Console.WriteLine("\nRUIM!");
		} else {
			Console.WriteLine("\nMAIS OU MENOS!");
		}
	}
}