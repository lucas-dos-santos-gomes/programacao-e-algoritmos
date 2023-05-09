using System;

public class TrocarPosicoes
{
  public static void Main()
  {
    Random random = new Random();
    int[] firstArray = new int[16], finalArray = new int[16];
    string printFirstArray = "\nArray principal:", printFinalArray = "Array inverso (8 / 8):";
    for(int i = 0; i < firstArray.Length; i++) {
      firstArray[i] = random.Next(1, 100);
      if(i == 0) {
        printFirstArray += (" " + firstArray[i]);
      } else {
        printFirstArray += (", " + firstArray[i]);
      }
    }
    for(int i = 0; i < finalArray.Length; i++) {
      if(i < 8) {
        finalArray[i] = firstArray[i + 8];
      } else {
        finalArray[i] = firstArray[i - 8];
      }
      if(i == 0) {
        printFinalArray += (" " + finalArray[i]);
      } else {
        printFinalArray += (", " + finalArray[i]);
      }
    }
    Console.WriteLine(printFirstArray + "\n" + printFinalArray + "\n");
  }
}