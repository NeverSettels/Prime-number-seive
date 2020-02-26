using System;
using System.Collections.Generic;

namespace Prime.Models
{
  public class Numbers
  {
    public static List<int> numbersList = new List<int>(){};

    public static void PopulateList(int number)
    {
      for (int i=2; i<=number; i++)
      {
        numbersList.Add(i);
      }
    }

    public static void SieveList()
    {
      int counter = numbersList.Count;
      for (int j = 0; j<numbersList.Count; j++)
      {
        for(int i = numbersList[j]; i<=counter+1; i++)
        {
          if(i/numbersList[j] != 1 && i%numbersList[j] == 0)
          {
            numbersList.Remove(i);
          }
        }
      }
      foreach (int number in numbersList)
      {
      Console.WriteLine(number);
      }
    }
  }
}