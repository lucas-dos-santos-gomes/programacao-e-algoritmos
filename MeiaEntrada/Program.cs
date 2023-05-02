using System;

public class MeiaEntrada
{
  public static void Main()
  {
    Console.WriteLine("Digite seu nome:");
		string name = Console.ReadLine();

		Console.WriteLine("\nDigite sua idade:");
		int age = int.Parse(Console.ReadLine());
		
    Console.WriteLine("\nVocê é estudante? (sim/nao)");
		string yesOrNo = Console.ReadLine();
		
		while(yesOrNo != "sim" && yesOrNo != "nao") {
			Console.WriteLine("\nVocê digitou um valor inválido!");
			Console.WriteLine("Você é estudante? (sim/nao)");
			yesOrNo = Console.ReadLine();
		}
		
		bool student;
		if(yesOrNo == "sim") {
			student = true;
		} else {
			student = false;
		}
		
		if(student || age < 12 || age > 65) {
			Console.WriteLine("\nEntrada: meia");
			Console.WriteLine("Valor: R$10,00");
		} else {
			Console.WriteLine("\nEntrada: inteira");
			Console.WriteLine("Valor: R$20,00");
		}
  }
}