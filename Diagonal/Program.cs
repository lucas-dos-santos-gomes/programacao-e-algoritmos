using System;

public class Diagonal {
  public static void Main() {
    Random random = new Random();
    int lenght = 8;
    int[,] matriz = new int[lenght, lenght];
    int diagonal1 = 0, diagonal2 = 0;
    for(int i = 0; i < lenght; i++) {
      string printMatriz = "|";
      for(int j = 0; j < lenght; j++) {
        matriz[i, j] = random.Next(0, 10);
        if(i == j) {
          diagonal1 += matriz[i, j];
          printMatriz += "+ "+ matriz[i, j] + " +|";
        } else if(i + j == 7) {
          diagonal2 += matriz[i, j];
          printMatriz += "- "+ matriz[i, j] + " -|";
        } else {
          printMatriz += "  "+ matriz[i, j] + "  |";
        }
      }
      Console.WriteLine(printMatriz);
    }
    Console.WriteLine("\nPrimeira diagonal (+): {0}", diagonal1);
    Console.WriteLine("Segunda diagonal (-): {0}", diagonal2);
  }
}