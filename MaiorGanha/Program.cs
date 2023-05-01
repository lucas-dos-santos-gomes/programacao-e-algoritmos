using System;

public class MaiorGanha
{
  public static void Main()
  {
    string continueGame = "sim";
    int userNumber, computerNumber, plays = 0, userPoints = 0, computerPoints = 0;
    Random random = new Random();
    do {
      userNumber = random.Next(1, 101);
      computerNumber = random.Next(1, 101);
      
      Console.WriteLine("\nSeu número é " + userNumber + ". Quer apostar se seu número é maior?");
      Console.WriteLine("(sim / nao)");
      string bet = Console.ReadLine();
      while(bet != "sim" && bet != "nao") {
        Console.WriteLine("\nVocê precisa responder 'sim' ou 'nao':");
        bet = Console.ReadLine();
      }

      plays++;
      if(bet == "sim") {
        if(userNumber > computerNumber) {
          Console.WriteLine("\nParabens!");
          userPoints++;
        } else if(userNumber < computerNumber) {
          Console.WriteLine("\nVixe... Você perdeu!");
          computerPoints++;
        } else {
          Console.WriteLine("\nEmpate!");
        }
      } else {
        Console.WriteLine("\n");
      }

      Console.WriteLine("O número do computador é " + computerNumber);
      Console.WriteLine("\nJogadas: " + plays);
      Console.WriteLine("Computador: " + computerPoints + " pts.");
      Console.WriteLine("Jogador: " + userPoints + " pts.");

      Console.WriteLine("\nDeseja jogar de novo? (sim / nao)");
      continueGame = Console.ReadLine();
      while(continueGame != "sim" && continueGame != "nao") {
        Console.WriteLine("\nVocê precisa responder 'sim' ou 'nao':");
        continueGame = Console.ReadLine();
      }
    } while(continueGame == "sim");

    if(userPoints > computerPoints) {
      Console.WriteLine("\nParabens! Você ganhou o jogo!");
    } else if(userPoints < computerPoints) {
      Console.WriteLine("\ninfelizmente você perdeu...");
    } else {
      Console.WriteLine("\nO placar deu empate!");
    }
    Console.WriteLine("Jogador: " + userPoints + " x Computador: " + computerPoints);
  }
}