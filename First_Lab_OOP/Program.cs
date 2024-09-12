using System;
using System.IO.Compression;
using System.Text;
using Triangle;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("Введіть три сторони трикутника");
        Console.Write("Введіть сторону а:");
        double a = Double.Parse(Console.ReadLine());
        Console.Write("Введіть сторону b:");
        double b = Double.Parse(Console.ReadLine());
        Console.Write("Введіть сторону c:");
        double c = Double.Parse(Console.ReadLine());
        ClassTriangle triangle= new ClassTriangle(a,b,c);
        double area = triangle.AreaOfTriangle();
        Console.WriteLine($"Площа трикутника: {area}");
        
    }
}
