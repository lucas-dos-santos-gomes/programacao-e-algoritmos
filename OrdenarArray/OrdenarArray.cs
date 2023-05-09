using System;

public class OrdenarArray
{
  public static void Main()
  {
    Random random = new Random();
    int[] values = new int[10];
    int[] orderedValues = new int[10];
    string initialArray = "\nValores do array:";
    string orderedArray = "Array ordenado:";
    for(int i = 0; i < values.Length; i++) {
      bool repeatedNumber;
      int randomNumber;
      if(i == 0) {
        randomNumber = random.Next(1, 101);
        initialArray += (" " + randomNumber);
      } else {
        do {
          repeatedNumber = false;
          randomNumber = random.Next(1, 101);
          for(int j = 0; j < i; j++) {
            if (randomNumber == values[j]) {
              repeatedNumber = true;
              break;
            }
          }
        } while(repeatedNumber);
        initialArray += (", " + randomNumber);
      }
      values[i] = randomNumber;
    }
    Console.WriteLine(initialArray);
    Array.Sort(values);
    foreach (int n in values) {
      if(n == values[0]) {
        orderedArray += (" " + n);
      } else {
        orderedArray += (", " + n);
      }
    }
    Console.WriteLine(orderedArray + "\n");
  }
}