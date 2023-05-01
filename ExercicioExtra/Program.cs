using System;
					
public class ExercicioExtra
{
	public static void Main()
	{
		Console.WriteLine("Informe o valor da prestação do crédito imobiliário:");
		double prestacao = double.Parse(Console.ReadLine());
		Console.WriteLine("\nInforme seu salário bruto:");
		double salario = double.Parse(Console.ReadLine());
		double trintaPorCento = salario * 0.3;
		
		if(prestacao <= trintaPorCento) {
			Console.WriteLine("\nCrédito aprovado!");
		} else {
			Console.WriteLine("\nCrédito não foi aprovado!");
		}
	}
}