using System;
					
public class TesteDeSoma
{
	public static void Main()
	{
		Random gerador = new Random();
		int n1 = gerador.Next(1, 10);
		int n2 = gerador.Next(1, 10);
		int resultado = n1 + n2;
		
		Console.WriteLine("Qual o resultado da soma de " + n1 + " + " + n2 + "?");
		Console.WriteLine("\nPara sair digite 0");
		int resposta = int.Parse(Console.ReadLine());
		int erros = 0;
		while(resposta != resultado && resposta != 0) {
			erros++;
			Console.WriteLine("\nTente novamente: " + n1 + " + " + n2 + " ?");
			resposta = int.Parse(Console.ReadLine());
		}

		int porcentagemErros = 100 / (erros + 1);
		if(resposta == 0) {
			Console.WriteLine("\nVocê desistiu da conta");
		} else {
			Console.WriteLine("\nParabéns! Você acertou!");
			Console.WriteLine(n1 + " + " + n2 +  " = " + resultado);
			Console.WriteLine("Percentual de acertos: " + porcentagemErros + "%");
		}
	}
}