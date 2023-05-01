using System;

public class ChuteCerto
{
  public static void Main()
  {
    int userNumber, randomNumber, userPoints = 0, computerPoints = 0;
    string continueGame;
    Random random = new Random();
    do {
      randomNumber = random.Next(1, 11);
      Console.WriteLine("\nDigite um número de 1 a 10: \nPara sair, digite 0");
      userNumber = int.Parse(Console.ReadLine());
      while(userNumber < 0 || userNumber > 10) {
        Console.WriteLine("\nVocê precisa digitar um número entre 1 e 10 (0 se quiser sair):");
        userNumber = int.Parse(Console.ReadLine());
      }

      if(userNumber == 0) {
        break;
      }

      if(userNumber == randomNumber) {
        Console.WriteLine("\nParabéns! Você acertou!");
        userPoints++;
      } else {
        Console.WriteLine("\nPutz... você errou...");
        computerPoints++;
      }
      Console.WriteLine("O número gerado foi " + randomNumber);
      Console.WriteLine("\nComputador: " + computerPoints + " pts.");
      Console.WriteLine("Jogador: " + userPoints + " pts.");

      Console.WriteLine("\nDeseja jogar mais uma? (sim / nao)");
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