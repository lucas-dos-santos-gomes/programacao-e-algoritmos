using System;

public class Gabarito {
  private static char Alternativa(int numero) {
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
      gabarito[i] = Alternativa(numero);
      Console.Write(gabarito[i] + "|");
    }
    Console.WriteLine("\n\n- Respostas -");
    int[,] respostasAlunos = new int[100, gabarito.Length];
    int[] resultados = new int[100];
    string imprimirResultados = "- Resultados -\n";
    for(int i = 0; i < respostasAlunos.GetLength(0); i++) {
      string imprimirRespostas = $"Aluno {i + 1}: |";
      int resultado = 0;
      for(int j = 0; j < gabarito.Length; j++) {
        respostasAlunos[i, j] = random.Next(1, 6);
        resultado += ((Alternativa(respostasAlunos[i, j]) == gabarito[j])? 1 : 0);
        imprimirRespostas += respostasAlunos[i, j] + "|";
      }
      resultados[i] = resultado;
      imprimirResultados += $"Aluno {i + 1}: {resultado}\n";
      Console.WriteLine(imprimirRespostas);
    }
    Console.Write($"\n\n{imprimirResultados}");
  }
}