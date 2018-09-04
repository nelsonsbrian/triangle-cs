using System;
using System.Collections.Generic;


class Triangle
{
  public int Side1;
  public int Side2;
  public int Side3;

  public Triangle(int side1, int side2, int side3)
  {
    Side1 = side1;
    Side2 = side2;
    Side3 = side3;
  }

  public string WhatTriangle()
  {
    if (Side1 > Side2 + Side3 || Side2 > Side1 + Side3 || Side3 > Side1 + Side2)
    {
      return "Those lengths of sides are not a triangle";
    }
    else if (Side1 == Side2 && Side2 == Side3)
    {
      return "Equilateral Triangle";
    }
    else if (Side1 == Side2 || Side2 == Side3 || Side1 == Side3)
    {
      return "Isosceles Triangle";
    }
    else if (Side1 != Side2 && Side2 != Side3 && Side1 != Side3)
    {
      return "Scalene Triangle";
    }
    else
    {
      return "Input Sides are not numbers";
    }
  }
}

public class Program
{
  public static void Main()
  {
    Console.WriteLine("To see what type of triangle you have, enter in the 3 sides of the triange:");
    Console.WriteLine("-----------------------------------------------------");

    Console.WriteLine("Enter in Side 1:");
    string inputNum1 = Console.ReadLine();
    int num1 = int.Parse(inputNum1);
    Console.WriteLine("Enter in Side 2:");
    string inputNum2 = Console.ReadLine();
    int num2 = int.Parse(inputNum2);
    Console.WriteLine("Enter in Side 3:");
    string inputNum3 = Console.ReadLine();
    int num3 = int.Parse(inputNum3);

    Triangle newTri = new Triangle(num1, num2, num3);

    Console.WriteLine("After computing, the triangle you entered is:");
    Console.WriteLine(newTri.WhatTriangle());


  }
}
