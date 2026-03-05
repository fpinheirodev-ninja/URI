using System;
class URI
{
    static void Main(string[] args)
    {
        string name = Console.ReadLine();
        double salary =  double.Parse(Console.ReadLine());
        double soldProd =  double.Parse(Console.ReadLine());
        double tax = 0.15;
        
        double result = salary + (soldProd * tax);
        Console.WriteLine($"TOTAL = R$ {result:F2}");    
    }
}
