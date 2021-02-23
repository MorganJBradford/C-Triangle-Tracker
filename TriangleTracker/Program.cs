using System;
using TriangleTracker.Models;

namespace TriangleTracker
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("This program tests to see if 3 sides will make a triangle.");
      Console.WriteLine("------------------------------");
      Console.WriteLine("Please enter side 1:");
      int side1 = int.Parse(Console.ReadLine());
      Console.WriteLine("Please enter side 2:");
      int side2 = int.Parse(Console.ReadLine());
      Console.WriteLine("Please enter side 3:");
      int side3 = int.Parse(Console.ReadLine());

      Triangle UserTriangle = new Triangle(side1, side2, side3);
      Console.WriteLine(UserTriangle.IsATriangle());

    }
  }
}