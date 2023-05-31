using System;

public class BuscarValor {
  public static void Main(String[] args) {
    int userValue = 0, count = 0, lenght = 20;
    string lineColumn = "\n";
    do {
      Console.WriteLine("\nInsira um valor de 1 a 99: ");
      userValue = int.Parse(Console.ReadLine()!);
    } while(userValue < 1 || userValue > 99);
    Console.WriteLine("");

    Random random = new Random();
    int[,] matriz = new int[lenght, lenght];
    for(int i = 0; i< lenght; i++) {
      string printMatriz = "| ";
      for(int j = 0; j < lenght; j++) {
        matriz[i, j] = random.Next(1, 100);
        if(matriz[i, j] == userValue) {
          lineColumn += "Linha: " + (i + 1) + " | Coluna: " + (j + 1) + " = " + userValue + "\n";
          count++;
        }

        if (matriz[i, j] > 9) {
          printMatriz += matriz[i, j] + " | ";
        } else {
          printMatriz += " " + matriz[i, j] + " | ";
        }
      }
      Console.WriteLine(printMatriz);
    }
    if(count > 0) {
      Console.WriteLine(lineColumn);
    } else {
      Console.WriteLine("\nO valor {0} não foi encontrado", userValue);
    }
  }
}