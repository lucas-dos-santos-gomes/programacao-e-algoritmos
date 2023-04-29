using System;
					
public class Tabuada
{
	public static void Main()
	{
		Console.WriteLine("Digite um número para saber a tabuada: ");
		int number = int.Parse(Console.ReadLine());
		Console.WriteLine("\n");
		for(int i = 0; i <= 10; i++) {
			int multiplication = number * i;
			Console.WriteLine(number + " x " + i + " = " + multiplication);
		}
	}
}