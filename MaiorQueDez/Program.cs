using System;

public class MaiorQueDez {
  public static void Main() {
    Random random = new Random();
    int[,] matriz = new int[6, 6];
    int lenght = matriz.GetLength(0);
    int count = 0;
    for(int i = 0; i < lenght; i++) {
      string printMatriz = "|";
      for(int j = 0; j < lenght; j++) {
        matriz[i, j] = random.Next(1, 100);
        if(matriz[i, j] < 10) {
          printMatriz += ("0" + matriz[i, j] + "|");
        } else {
          printMatriz += (matriz[i, j] + "|");
          if(matriz[i, j] > 10) {
            count++;
          }
        }
      }
      Console.WriteLine(printMatriz);
    }
      Console.WriteLine("\nNúmeros maiores que dez: {0}", count);
  }
}