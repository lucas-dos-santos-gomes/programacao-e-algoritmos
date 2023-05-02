using System;
                   
public class OrdenarNumeros
{
  public static void Main()
  {
    Console.WriteLine("Digite o primeiro valor: ");
    int numA = int.Parse(Console.ReadLine());

    Console.WriteLine("\nDigite o segundo valor: ");
    int numB = int.Parse(Console.ReadLine());
    
    Console.WriteLine("\nDigite o terceiro valor: ");
    int numC = int.Parse(Console.ReadLine());
    
    if(numA > numB) {
      int aux = numA;
      numA = numB;
      numB = aux;
    }
    if(numA > numC) {
      int aux = numA;
      numA = numC;
      numC = aux;
    }
    if(numB > numC) {
      int aux = numB;
      numB = numC;
      numC = aux;
    }
    Console.WriteLine("\nOrdem crescente: " + numA + " , " + numB + " , " + numC);
  }
}