using System;

public class Validar
{
  public static void Main()
  {
    Console.WriteLine("Digite um número de 0 a 100:");
		int number = int.Parse(Console.ReadLine());
		
		if(number > 0 && number <= 100) {
			Console.WriteLine("\nO número " + number + " é um valor VÁLIDO.");
		} else {
			Console.WriteLine("\nO número " + number + " é um valor INVÁLIDO.");
		}
  }
}