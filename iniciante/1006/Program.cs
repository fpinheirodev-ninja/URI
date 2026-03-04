using System;
class URI
{
    static void Main(string [] args)
    {  

        double a =   double.Parse(Console.ReadLine()); 
        double b =   double.Parse(Console.ReadLine());
        double c =   double.Parse(Console.ReadLine());
        double p1 = 2;
        double p2 = 3;
        double p3 = 5;
        
        double result = (((a  * p1)+ (b * p2)  + (c * p3))/ (p1+p2+p3)) ;
        Console.WriteLine($"MEDIA = {result:f1}");
    }
}