using System;

public class XdeUm {
  public static void Main(String[] args) {
    int[,] matriz = new int[5, 5];
    Console.WriteLine("\n");
    for(int i = 0; i < matriz.GetLength(0); i++) {
      string printMatriz = "| ";
      for(int j = 0; j < matriz.GetLength(1); j++) {
        if(i == j || i + j == (matriz.GetLength(0) - 1)) {
          matriz[i, j] = 1;
        } else {
          matriz[i, j] = 0;
        }
        printMatriz += matriz[i, j] + " | ";
      }
      Console.WriteLine(printMatriz);
    }
    Console.WriteLine("\n");
  }
}