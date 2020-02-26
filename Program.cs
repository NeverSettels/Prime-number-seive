using System;
using System.Collections.Generic;
using Prime.Models;

namespace Prime
{
  public class Program
  {
   public static void Main()
    {
      Console.WriteLine("****************************************");
      Console.WriteLine("********PRIME NUMBER FINDER*************");
      Console.Write("Please enter a whole number: ");
      int number = int.Parse(Console.ReadLine());
      Numbers.PopulateList(number);
      Numbers.SieveList();
    }
  }
}