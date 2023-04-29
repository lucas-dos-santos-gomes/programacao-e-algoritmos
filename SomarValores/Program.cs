using System;
					
public class SomarValores
{
	public static void Main()
	{
		Console.WriteLine("Digite um número maior que 0: ");
		int number = int.Parse(Console.ReadLine());
		int accumulate = 0;
		string print = ("\n" + number + "! = ");
		for(int i = 1; i <= number; i++) {
			accumulate += i;
			if(i != number) {
				print += (i + " + ");
			} else {
				print += (i + " = " + accumulate);
			}
		}
		Console.WriteLine(print);
	}
}