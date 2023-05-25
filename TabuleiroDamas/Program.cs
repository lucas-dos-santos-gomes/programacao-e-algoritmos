using System;

public class TabuleiroDamas {
  public static void Main() {
    string columns = "";
    for(int i = 0; i < 8; i++) {
      columns += $"  {i} ";
    }
    Console.WriteLine(columns);
    char[,] board = new char[8, 8];
    for(int i = 0; i < 8; i++) {
      string printBoard = "| ";
      for(int j = 0; j < 8; j++) {
        if(i < 3) {
          if(i % 2 == 0) {
            if(j % 2 == 0) {
              board[i, j] = ' ';
            } else {
              board[i, j] = '0';
            }
          } else {
            if(j % 2 == 0) {
              board[i, j] = '0';
            } else {
              board[i, j] = ' ';
            }
          }
        } else if(i > 4) {
          if(i % 2 == 0) {
            if(j % 2 == 0) {
              board[i, j] = ' ';
            } else {
              board[i, j] = '*';
            }
          } else {
            if(j % 2 == 0) {
              board[i, j] = '*';
            } else {
              board[i, j] = ' ';
            }
          }
        } else {
          board[i, j] = ' ';
        }
        printBoard += board[i, j] + " | ";
      }
      Console.WriteLine(printBoard + i);
    }
  }
}