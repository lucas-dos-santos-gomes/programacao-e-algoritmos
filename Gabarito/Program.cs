using System;

public class Gabarito {
  private static char Letra(int numero) {
    switch(numero) {
      case 1:
        return 'a';
      case 2:
        return 'b';
      case 3:
        return 'c';
      case 4:
        return 'd';
      default:
        return 'e';
    }
  }
  public static void Main(String[] args) {
    Random random = new Random();
    char[] gabarito = new char[10];
    Console.Write("\nGabarito: |");
    for(int i = 0; i < gabarito.Length; i++) {
      int numero = random.Next(1, 6);
      gabarito[i] = Letra(numero);
      Console.Write(gabarito[i] + "|");
    }
    Console.WriteLine("\n\n- Respostas -");
    int[,] respostasAlunos = new int[100, gabarito.Length];
    int[] resultados = new int[100];
    for(int i = 0; i < respostasAlunos.GetLength(0); i++) {
      int resultado = 0;
      for(int j = 0; j < gabarito.Length; j++) {
        respostasAlunos[i, j] = random.Next(1, 6);
        resultado += (Letra(respostasAlunos[i, j]) == gabarito[j])? 1 : 0;
      }
      resultados[i] = resultado;
    }
  }
}