using System;

public class Piramide {
  public static string PrintSpaces(char[,] matriz, int line, int columns, int spaces, int stars) {
    string printMatriz = "";
    for(int j = 0; j < columns; j++) {
      for (int k = 0; k < spaces; k++) {
        matriz[line, j] = ' ';
        printMatriz += matriz[line, j];
      }
      for (int k = 0; k < stars; k++) {
        matriz[line, j] = '*';
        printMatriz += matriz[line, j];
      }
      for (int k = 0; k < spaces; k++) {
        matriz[line, j] = ' ';
        printMatriz += matriz[line, j];
      }
      
      if(spaces > 0) {
        spaces--;
        stars += 2;
      }
      printMatriz += "\n";
    }
    return printMatriz += "\n";
  }
  public static void Main(String[] args) {
    int lines = 6;
    int columns = 11;
    int spaces = columns / 2;
    int stars = 1;
    char[,] pyramid = new char[lines, columns];
    for(int i = 0; i < lines; i++) {
      Console.WriteLine(PrintSpaces(pyramid, i, columns, spaces, stars));
      Console.WriteLine(pyramid[0, 0]);
    }
  }
}