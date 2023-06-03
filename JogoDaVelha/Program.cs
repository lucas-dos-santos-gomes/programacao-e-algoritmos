using System;

namespace JogoDaVelha {
  public class Program {
    private static bool ValidGame(char[,] board, int lenght, char piece) {
      int diagonal = 0;
      for (int i = 0; i < lenght; i++) {
        int horizontal = 0, vertical = 0;
        for (int j = 0; j < lenght; j++) {
          if(board[i, j] == piece) {
            horizontal++;
          }
          if(board[j, i] == piece) {
            vertical++;
          }
          if((i == j || i + j == lenght - 1) && board[i, j] == piece) {
            diagonal++;
          }
        }

        if(horizontal >= lenght || vertical >= lenght || diagonal >= lenght) {
          return true;
        }
      }
      return false;
    }

    private static int ValidNumber(int initialNumber, int lastNumber, string position) {
      Console.WriteLine($"{position}: ");
      int number = int.Parse(Console.ReadLine()!) - 1;
      while (number < initialNumber || number >= lastNumber) {
        Console.WriteLine("\nInsira um local válido (1, 2, 3): ");
        number = int.Parse(Console.ReadLine()!) - 1;
      }
      return number;
    }

    private static char[,] SetBoard(char[,] board, int line, int column, char piece, bool confirmPrint) {
      string print = "";
      for (int i = 0; i < board.GetLength(0); i++) {
        print += "|";
        for (int j = 0; j < board.GetLength(1); j++) {
          if(board[i, j] == '0' || board[i, j] == 'X') {
            board[i, j] = board[i, j];
          } else {
            if(i == line && j == column) {
              board[i, j] = piece;
            } else {
              board[i, j] = ' ';
            }
          }
          print += (board[i, j] + "|");
        }
        print += "\n";
      }
      if(confirmPrint) Console.Write(print);
      return board;
    }

    public static void Main(String[] args) {
      string winner = "";
      Console.WriteLine("\nInsira o nome do Jogador 1: ");
      string player1 = Console.ReadLine()!;
      Console.WriteLine("\nInsira o nome do Jogador 2: ");
      string player2 = Console.ReadLine()!;

      bool changePlayer = true, changePiece = true, gameOver = false;
      int round = 1, line = -1, column = -1;
      char[,] gameBoard = new char[3, 3];
      char piece = ' ';
      while(!gameOver) {
        Console.WriteLine($"\n - - - - - \n\n- Rodada {round} -\n");
        gameBoard = SetBoard(gameBoard, line, column, piece, true);
        if(changePiece) {
          piece = '0';
        } else {
          piece = 'X';
        }
        changePiece = !changePiece;

        string player = (changePlayer)? player1 : player2;
        Console.WriteLine($"\n{player}, insira a linha que você quer colocar a peça (1, 2, 3)");
        line = ValidNumber(0, gameBoard.GetLength(0), "Linha");
        
        Console.WriteLine("\nAgora, insira a coluna que você quer colocar a peça (1, 2, 3)");
        column = ValidNumber(0, gameBoard.GetLength(1), "Coluna");
        while (gameBoard[line, column] == '0' || gameBoard[line, column] == 'X') {
          Console.WriteLine("\nInsira um local que ainda não possui uma peça");
          line = ValidNumber(0, gameBoard.GetLength(0), "Linha");
          column = ValidNumber(0, gameBoard.GetLength(1), "\nColuna");
        }

        gameOver = ValidGame(SetBoard(gameBoard, line, column, piece, false), gameBoard.GetLength(0), piece);
        if(gameOver) {
          winner = player;
          break;
        }

        round++;
        changePlayer = !changePlayer;
      }
      Console.WriteLine("\n - - - - - \n");
      SetBoard(gameBoard, line, column, piece, true);
      Console.WriteLine($"\n{winner} ganhou!");
    }
  }
}