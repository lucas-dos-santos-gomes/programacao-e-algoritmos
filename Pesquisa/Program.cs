using System;

public class Pesquisa
{
  public static void Main()
  {
    Console.WriteLine("Digite o nome do cliente: ");
		string nome = Console.ReadLine();
		
    Console.WriteLine("\nInsira o sexo de " + nome + " (masculino/feminino): ");
		string sexo = Console.ReadLine().ToLower();
		
    while(sexo != "masculino" && sexo != "feminino") {
			Console.WriteLine("\nInsira 'masculino' ou 'feminino': ");
			sexo = Console.ReadLine().ToLower();
		}
		if(sexo == "masculino") {
			Console.WriteLine("\nInsira a idade de " + nome + ": ");
			int idade = int.Parse(Console.ReadLine());
			if(idade >= 20 && idade <= 25) {
				Console.WriteLine("\nInsira a classe de " + nome + " (A/B/C/D/E): ");
				char classe = char.Parse(Console.ReadLine().ToUpper());
				while(classe != 'A' && classe != 'B' && classe != 'C' && classe != 'D' && classe != 'E') {
					Console.WriteLine("\nInsira uma classe válida (A/B/C/D/E): ");
					classe = char.Parse(Console.ReadLine().ToUpper());
				}
				if(classe == 'A' || classe == 'B'){
					Console.WriteLine("\nInsira a escolaridade de " + nome + " (superior/tecnico/medio/fundamental): ");
					string escolaridade = Console.ReadLine().ToLower();
					if(escolaridade == "superior") {
						Console.WriteLine("\nHá quantos meses " + nome + " comprou o produto? ");
						int meses = int.Parse(Console.ReadLine());
						if(meses > 6 && meses < 12) {
							Console.Write("\n" + nome + " está apto para participar da pesquisa");
						} else {
							Console.Write("\n" + nome + " está fora da faixa de pesquisa");
						}
					} else {
						Console.Write("\n" + nome + " está fora da faixa de pesquisa");
					}
				} else {
					Console.Write("\n" + nome + " está fora da faixa de pesquisa");
				}
			} else {
				Console.Write("\n" + nome + " está fora da faixa de pesquisa");
			}
		} else {
			Console.Write("\n" + nome + " está fora da faixa de pesquisa");
		}
  }
}