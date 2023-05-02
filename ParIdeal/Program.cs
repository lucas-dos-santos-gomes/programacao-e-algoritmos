using System;

public class ParIdeal
{
  public static void Main()
  {
    int index_estacoes, index_viagem, index_nomes;
		string estacao, viagem, continuar = "sim";
		char genero;
		string[] estacoes = {"inverno", "outono", "primavera", "verao"};
		string[] opcao_viagem = {"campo", "cidade", "cruzeiro", "praia", "radical", "resort"};
		string[] nomes_femininos = {"Ana", "Beatriz", "Carolina", "Daniella", "Evelyn", "Fernanda", "Geovanna", "Luana", "Mariana", "Nathalia"};
		string[] nomes_masculinos = {"Albert", "Jonas", "Lucas", "Danilo", "Ruan", "Willian", "Kayque", "Gabriel", "Marcos", "Pedro"};
		
		while(continuar == "sim") {
			Console.WriteLine("\n===== PAR IDEAL =====");
			Console.WriteLine("Escolha uma das quatro estações (primavera/verao/outono/inverno): ");
			estacao = Console.ReadLine();
			index_estacoes = Array.BinarySearch(estacoes, estacao);
			while(index_estacoes < 0) {
				Console.WriteLine("\nVocê não digitou uma opção válida!");
				Console.WriteLine("Por favor, escolha uma das quatro estações (primavera/verao/outono/inverno): ");
				estacao = Console.ReadLine();
				index_estacoes = Array.BinarySearch(estacoes, estacao);
			}

			Console.WriteLine("\nAgora, escolha uma opção de viagem (cidade/campo/praia/radical/cruzeiro/resort): ");
			viagem = Console.ReadLine();
			index_viagem = Array.BinarySearch(opcao_viagem, viagem);
			while(index_viagem < 0) {
				Console.WriteLine(viagem);
				Console.WriteLine(index_viagem);
				Console.WriteLine(opcao_viagem[2]);
				Console.WriteLine("\nVocê não digitou uma opção válida!");
				Console.WriteLine("Por favor, escolha uma opção de viagem (cidade/campo/praia/radical/cruzeiro/resort): ");
				viagem = Console.ReadLine();
				index_viagem = Array.BinarySearch(opcao_viagem, viagem);
			}

			Console.WriteLine("\nQual o gênero do seu par ideal? (M/F): ");
			genero = char.Parse(Console.ReadLine());
			while(genero != 'M' && genero != 'F' && genero != 'm' && genero != 'f') {
				Console.WriteLine("\nVocê não digitou uma opção válida!");
				Console.WriteLine("Por favor, informe o gênero do seu par ideal (M/F): ");
				genero = char.Parse(Console.ReadLine());
			}

			index_nomes = index_estacoes + index_viagem;
			if(genero == 'M' || genero == 'm') {
				Console.WriteLine("\nSeu parceiro ideal é: " + nomes_masculinos[index_nomes]);
			} else {
				Console.WriteLine("\nSua parceira ideal é: " + nomes_femininos[index_nomes]);
			}
			
			Console.WriteLine("\nDeseja ver outro par ideal? (sim/nao): ");
			continuar = Console.ReadLine();
			while(continuar != "sim" && continuar != "nao") {
				Console.WriteLine("\nVocê não digitou uma opção válida!");
				Console.WriteLine("Informe se você deseja ver outro par ideal (sim/nao): ");
				continuar = Console.ReadLine();
			}
		}
		Console.WriteLine("\nPrograma finalizado");
  }
}