using System;
class URI
{
    static void Main(string []args)
    {
        //formula da area A= pi*R*R
        double pi = 3.14159;
        double r =0;
        r =double.Parse(Console.ReadLine());
        double result = pi * (r*r);
        Console.WriteLine("A={0:F4}",result);
    } 
}