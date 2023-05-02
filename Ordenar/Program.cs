using System;

public class Ordenar
{
  public static void Main()
  {
    Console.WriteLine("Digite o primeiro valor:");
		int numA = int.Parse(Console.ReadLine());
		
    Console.WriteLine("\nDigite o segundo número:");
		int numB = int.Parse(Console.ReadLine());
		
    Console.WriteLine("\nDigite o terceiro valor:");
		int numC = int.Parse(Console.ReadLine());
		
		if(numA <= numB && numB <= numC) {
			Console.WriteLine("\nOrdem crescente: " + numA + " -> " + numB + " -> " + numC);
		} else if(numA <= numC && numC <= numB) {
			Console.WriteLine("\nOrdem crescente: " + numA + " -> " + numC + " -> " + numB);
		} else if(numB <= numA && numA <= numC) {
			Console.WriteLine("\nOrdem crescente: " + numB + " -> " + numA + " -> " + numC);
		} else if(numB <= numC && numC <= numA) {
			Console.WriteLine("\nOrdem crescente: " + numB + " -> " + numC + " -> " + numA);
		} else if(numC <= numA && numA <= numB) {
			Console.WriteLine("\nOrdem crescente: " + numC + " -> " + numA + " -> " + numB);
		} else {
			Console.WriteLine("\nOrdem crescente: " + numC + " -> " + numB + " -> " + numA);
		}
  }
}