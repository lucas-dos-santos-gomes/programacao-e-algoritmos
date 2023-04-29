using System;
					
public class Fatorial
{
	public static void Main()
	{
		Console.WriteLine("Digite um número para fazer a contagem fatorial: ");
		int number = int.Parse(Console.ReadLine());
		int accumulate = 1;
		string print = ("\n" + number + "! = ");
		for(int i = 1; i <= number; i++) {
			accumulate *= i;
			if(i != number) {
				print += (i + " x ");
			} else {
				print += (i + " = " + accumulate);
			}
		}
		Console.WriteLine(print);
	}
}