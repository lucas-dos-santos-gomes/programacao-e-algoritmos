using System;

public class Aumento
{
  public static void Main()
  {
    string nome, continuar = "sim";
		double salario, porcentagem, aumento;
		
		while(continuar == "sim") {
			Console.WriteLine("\nInsira o nome do funcionário: ");
			nome = Console.ReadLine();
			
			Console.WriteLine("\nInsira o valor do salário de " + nome + ": ");
			salario = double.Parse(Console.ReadLine());
			
			Console.WriteLine("\nSalário anterior: " + salario);
			if(salario < 1000) {
				porcentagem = 10;
			} else {
				if(salario <= 2000) {
					porcentagem = 8;
				} else {
					if(salario <= 3500) {
						porcentagem = 6;
					} else {
						if(salario <= 5000) {
							porcentagem = 4;
						} else {
							porcentagem = 2;
						}
					}
				}
			}
			aumento = salario * (porcentagem / 100);
			Console.WriteLine("Aumento: " + porcentagem + "% (" + aumento + ")");
			Console.WriteLine("Salário atual: " + (salario + aumento));
			
			Console.WriteLine("\nDeseja ver o aumento de outro funcionário? (sim/nao): ");
			continuar = Console.ReadLine();
			while(continuar != "sim" && continuar != "nao") {
				Console.WriteLine("Digite apenas 'sim' ou 'nao': ");
				continuar = Console.ReadLine();
			}
		}
  }
}