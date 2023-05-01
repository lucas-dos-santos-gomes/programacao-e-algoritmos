using System;

public class Exercicio4
{
  public static void Main()
  {
    Console.WriteLine("Informe a receita da empresa:");
		float receita = int.Parse(Console.ReadLine());
		Console.WriteLine("\nInforme o prejuízo da empresa:");
		float prejuizo = int.Parse(Console.ReadLine());
		
		if(receita > prejuizo) {
			Console.WriteLine("\nA empresa teve LUCRO!");
		} else if(receita < prejuizo) {
			Console.WriteLine("\nA empresa teve PREJUIZO!");
		} else {
			Console.WriteLine("\nA empresa não teve LUCRO e nem PREJUÍZO!");
		}
  }
}