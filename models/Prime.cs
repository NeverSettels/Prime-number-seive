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
      foreach (int number in numbersList)
      {
        if ()
      }
    }
  }
}