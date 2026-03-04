using System;
using System.ComponentModel;

class URI
{
    static void Main(string [] args)
    {
        double a  = double.Parse(Console.ReadLine());   
        double b = double.Parse(Console.ReadLine());
        double p1 = 3.5;
        double p2 = 7.5;
        double media = ((((a * p1) + (b * p2))) /(p1+p2));

        Console.WriteLine($"MEDIA = {media.ToString("F5")}");
        
    }
}