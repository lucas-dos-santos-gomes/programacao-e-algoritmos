using System;

public class Media
{
  public static void Main()
  {
    int contador = 0;
    double[] notas = new double[4];
    foreach(double i in notas) {
      contador++;
      Console.WriteLine("\nInforme a " + contador + "ª nota");
      notas[contador-1] = double.Parse(Console.ReadLine());
    }
    double media = (notas[0] + notas[1] + notas[2] + notas[3]) / 4;
    Console.WriteLine("\nSua média foi " + media);
  }
}