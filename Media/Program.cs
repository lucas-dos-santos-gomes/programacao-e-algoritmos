using System;

public class Media
{
  public static void Main()
  {
    Console.WriteLine("Digite o nome do aluno:");
		string name = Console.ReadLine();
		
		int nota;
		Console.WriteLine("\nDigite a nota de participação de " + name + ":");
		nota = int.Parse(Console.ReadLine());
		
		Console.WriteLine("\nDigite a nota da pesquisa de " + name + ":");
		nota += int.Parse(Console.ReadLine());
		
		Console.WriteLine("\nDigite a nota da prova de " + name + ":");
		nota += int.Parse(Console.ReadLine());
		
		Console.WriteLine("\nDigite a nota do TCC de " + name + ":");
		nota += int.Parse(Console.ReadLine());
		double media = nota / 4;
		
		Console.WriteLine("\nMédia: " + media);
		if(media >= 6 && media <= 10) {
			Console.WriteLine("Status: APROVADO");
		} else if(media >= 4 && media < 6) {
			Console.WriteLine("Status: RECUPERAÇÃO");
		} else {
			Console.WriteLine("Status: REPROVADO");
		}
  }
}