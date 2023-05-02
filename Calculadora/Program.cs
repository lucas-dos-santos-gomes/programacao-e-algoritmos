using System;

public class Calculadora
{
  public static void Main()
  {
    Console.WriteLine("Insira o primeiro número da operação: ");
		double n1 = double.Parse(Console.ReadLine());
		Console.WriteLine("\nInsira o segundo número da operação: ");
		double n2 = double.Parse(Console.ReadLine());

		Console.WriteLine("\nInsira a operação que deseja fazer: ");
		Console.WriteLine("1- adição/ 2- subtração/ 3- multiplicação/ 4- divisão/ 5- resto da divisão: ");
		int operacao = int.Parse(Console.ReadLine());
		while(operacao < 1 || operacao > 5) {
			Console.WriteLine("\nInsira apenas as operações mostradas: ");
			Console.WriteLine("1- adição/ 2- subtração/ 3- multiplicação/ 4- divisão/ 5- resto da divisão: ");
			operacao = int.Parse(Console.ReadLine());
		}
		double resultado;
		
		switch(operacao) {
			case 1:
				resultado = n1 + n2;
				Console.WriteLine("\n" + n1 + " + " + n2 + " = " + resultado);
				break;
			case 2:
				resultado = n1 - n2;
				Console.WriteLine("\n" + n1 + " - " + n2 + " = " + resultado);
				break;
			case 3:
				resultado = n1 * n2;
				Console.WriteLine("\n" + n1 + " x " + n2 + " = " + resultado);
				break;
			case 4:
				resultado = n1 / n2;
				Console.WriteLine("\n" + n1 + " / " + n2 + " = " + resultado);
				break;
			default:
				resultado = n1 % n2;
				Console.WriteLine("\n" + n1 + " % " + n2 + " = " + resultado);
				break;
		}
  }
}