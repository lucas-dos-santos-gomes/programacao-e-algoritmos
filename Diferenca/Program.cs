using System;
					
public class Diferenca
{
	public static void Main()
	{
		Console.WriteLine("Digite o primeiro número:");
		int number1 = int.Parse(Console.ReadLine());
		
		Console.WriteLine("\nDigite o segundo número");
		int number2 = int.Parse(Console.ReadLine());
		
		if(number1 > number2) {
			Console.WriteLine("\nMaior número: " + number1);
			Console.WriteLine("Menor número: " + number2);
			Console.WriteLine("Diferença: " + (number1 - number2));
		} else {
			Console.WriteLine("\nMaior número: " + number2);
			Console.WriteLine("Menor número: " + number1);
			Console.WriteLine("Diferença: " + (number2 - number1));
		}
	}
}