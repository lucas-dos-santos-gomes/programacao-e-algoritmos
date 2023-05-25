using System;

public class MaiorValor {
  public static void Main() {
    Random random = new Random();
    int[,] matriz = new int[10, 10];
    int[] biggerNumber = {0, 0, 0};
    int[] smallerNumber = {1000, 0, 0};
    for(int i = 0; i < 10; i++) {
      string printMatriz = "| ";
      for(int j = 0; j < 10; j++) {
        matriz[i, j] = random.Next(100, 1000);
        printMatriz += matriz[i, j] + " | ";
        if(matriz[i, j] > biggerNumber[0]) {
          biggerNumber[0] = matriz[i, j];
          biggerNumber[1] = i;
          biggerNumber[2] = j;
        }
        if(matriz[i, j] < smallerNumber[0]) {
          smallerNumber[0] = matriz[i, j];
          smallerNumber[1] = i;
          smallerNumber[2] = j;
        }
      }
      Console.WriteLine(printMatriz);
    }
    Console.WriteLine($"\nMaior número: {biggerNumber[0]} \nLinha: {biggerNumber[1]} \nColuna: {biggerNumber[2]}");
    Console.WriteLine($"\nMenor número: {smallerNumber[0]} \nLinha: {smallerNumber[1]} \nColuna: {smallerNumber[2]}");
  }
}