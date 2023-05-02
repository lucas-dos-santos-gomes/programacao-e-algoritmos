using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Digite um número:");
		int number = int.Parse(Console.ReadLine());
		
		if(number % 2 == 0) {
			Console.WriteLine("\nO número " + number + " é par");
		} else {
			Console.WriteLine("\nO número " + number + " é ímpar");
		}
	}
}