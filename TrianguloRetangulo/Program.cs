using System;

public class TrianguloRetangulo {
  public static void Main() {
    int length = 6, stars = 1, countStars = 0;
    char[,] triangle = new char[length, length];
    for (int i = 0; i < length; i++) {
      Console.Write("|");
      for (int j = 0; j < length; j++) {
        if(j == 0) {
          countStars = stars;
        }

        if(countStars > 0) {
          triangle[i, j] = '*';
          countStars--;
        } else {
          triangle[i, j] = ' ';
        }
        Console.Write(triangle[i, j] + "|");
      }
      stars++;
      Console.Write("\n");
    }
  }
}