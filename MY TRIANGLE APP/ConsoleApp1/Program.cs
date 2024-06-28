using System;
using System.Transactions;

class TriangleTypeIdentifier
{
    static void Main()
    {
        Console.WriteLine("Enter the length of the first side: ");
        int side1 = int.Parse(Console.ReadLine());

        Console.Write("Enter the length of the second side: ");
        int side2 = int.Parse(Console.ReadLine());

        Console.Write("Enter the length of the third side: ");
        int side3 = int.Parse(Console.ReadLine());

        string triangleType;

        if (side1 == side2 && side2 == side3);
        {
            triangleType = "Equilateral";
        }
        else if (side1 == side2 || side2 == side3 || side1 == side3)
        {
            triangleType = "Isosceles"; 
        }
        else
        {
            triangleType = "Scalene";
        }

        Console.WriteLine($"The type of the triangle is: {triangleType}");
    }
}

