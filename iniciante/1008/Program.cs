using System;
class URI
{
    static void Main(string[] args)
    {
        int employeerNumber = int.Parse(Console.ReadLine());
        double salary =     double.Parse(Console.ReadLine());
        double payHour =    double.Parse(Console.ReadLine());

        double  result  = payHour * salary;

        Console.WriteLine($"NUMBER = {employeerNumber}\nSALARY = U$ {result:f2}");
    }
}