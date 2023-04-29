using System;

public class ParOuImpar
{
  public static void Main()
  {
    int answer = 1, pc = 0, user = 0;
    string parOuImpar;
    string[] parAndImpar = {"par", "ímpar"};
    Random random = new Random();
    while(answer != 0) {
      Console.WriteLine("\nEscolha: \n2- Par \n1- Ímpar \n0- Sair");
      answer = int.Parse(Console.ReadLine());
      if(answer == 2) {
        parOuImpar = parAndImpar[0];
      } else if(answer == 1) {
        parOuImpar = parAndImpar[1];
      } else {
        break;
      }
      int randomNumber = random.Next(1, 21);
      bool isPar = randomNumber % 2 == 0;

      if((isPar && answer == 2) || (!isPar && answer == 1)) {
        user++;
        Console.WriteLine("\nParabéns! Você acertou!");
        Console.WriteLine("O número " + randomNumber + " é realmente um número " + parOuImpar + "!\n");
        Console.WriteLine("Usuário - " + user + " x PC - " + pc);
      } else {
        pc++;
        Console.WriteLine("\nPutz, você errou...\n");
        Console.WriteLine("O número " + randomNumber + " não é um número " + parOuImpar + "...\n");
        Console.WriteLine("Usuário - " + user + " x PC - " + pc);
      }
    }
    Console.WriteLine("\nO placar final ficou: \nUsuário - " + user + " x PC - " + pc);
    if(user > pc) {
      Console.WriteLine("Parabéns! Você humilhou o computador!");
    } else if(pc > user) {
      Console.WriteLine("Que pena, você foi completamente derrotado...");
    } else {
      Console.WriteLine("Quase! Mas terminou dando empate...");
    }
  }
}