using System;

public class Piramide {
  public static void Main(String[] args) {
    int lines = 6;
    int columns = 11;
    int spaces = columns / 2;
    int stars = 1;
    char[,] pyramid = new char[lines, columns];
    for(int i = 0; i < lines; i++) {
      int[] array = AddChar(pyramid, i, columns, spaces, stars);
      spaces = array[0];
      stars = array[1];
    }
  }
  public static int[] AddChar(char[,] matriz, int line, int columns, int spaces, int stars) {
    string printMatriz = "\n";
    int countSpaces = spaces, countStars = stars;
    for(int j = 0; j < columns; j++) {
      if(countSpaces > 0) {
        matriz[line, j] = ' ';
        countSpaces--;
      } else {
        if(countStars > 0) {
          matriz[line, j] = '*';
          countStars--;
        } else {
          countSpaces = spaces;
        }
      }
      printMatriz += matriz[line, j];
    }
    Console.Write(printMatriz);
    spaces--;
    stars += 2;
    int[] array = {spaces, stars};
    return array;
  }
}