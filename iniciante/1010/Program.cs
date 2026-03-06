using System;
class URI
{
    static void Main(string []args)
    {
       string[] produto1 = Console.ReadLine().Split(' ');
       string[] produto2 = Console.ReadLine().Split(' ');

       int codprod1 = int.Parse(produto1[0]);
       int qtdProd1 = int.Parse(produto1[1]);
       double priceProd1 =  double.Parse(produto1[2]);

       int codprod2 = int.Parse(produto2[0]);
       int qtdProd2 = int.Parse(produto2[1]);
       double priceProd2 =  double.Parse(produto2[2]);


       var result =((qtdProd1*priceProd1) + (qtdProd2*priceProd2)); 
        Console.WriteLine($"VALOR A PAGAR: R$ {result:F2}");
      

    }
}