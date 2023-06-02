using System;

public class Piramide {
  public static void Main(String[] args) {
    int lines = 6, columns = 11;
    int stars = 1, spaces = columns / 2;
    char[,] pyramid = new char[lines, columns];
    for(int i = 0; i < lines; i++) {
      int[] array = AddChar(pyramid, i, columns, spaces, stars);
      spaces = array[0];
      stars = array[1];
      for (int j = 0; j < columns; j++) {
        Console.Write(pyramid[i, j]);
        if(j == columns - 1) {
          Console.Write('\n');
        }
      }
    }
  }
  public static int[] AddChar(char[,] matriz, int line, int columns, int spaces, int stars) {
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
    }
    spaces--;
    stars += 2;
    int[] array = {spaces, stars};
    return array;
  }
}