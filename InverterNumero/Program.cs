using System;

public class InverterNumero
{
  public static void Main()
  {
    int auxVar1, auxVar2, auxVar3;
    string continueGame;
    do {
      Console.WriteLine("\nDigite um número entre 100 e 999: ");
      Console.WriteLine("Para sair, digite 0");
      int userNumber = int.Parse(Console.ReadLine());
      if(userNumber >= 100 && userNumber < 1000) {
        auxVar1 = (userNumber % 10) * 100;
        auxVar2 = ((userNumber % 100) / 10) * 10;
        auxVar3 = userNumber / 100;
        int reverseNumber = auxVar1 + auxVar2 + auxVar3;

        Console.WriteLine("\nNúmero digitado: " + userNumber);
        Console.WriteLine("Número inverso: " + reverseNumber);
      } else {
        if(userNumber != 0) {
          Console.WriteLine("\nNúmero inválido!");
        } else {
          Console.WriteLine("\nSaindo...\n");
          break;
        }
      }

      Console.WriteLine("\nDeseja mais uma rodada? (sim / nao)");
      continueGame = Console.ReadLine();
      while(continueGame != "sim" && continueGame != "nao") {
        Console.WriteLine("\nVocê precisa responder 'sim' ou 'nao':");
        continueGame = Console.ReadLine();
      }
    } while(continueGame == "sim");
  }
}