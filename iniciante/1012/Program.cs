using System;
class URI
{
    static void Main(string [] args)
    {
        /*
            Crie um programa que leia três valores de ponto flutuante: A, B e C. 
            Em seguida, calcule e mostre: 
            a) a área do triângulo retângulo com base A e altura C; 
            b)a área da circunferência de raio C (π = 3,14159); 
            c) a área do trapézio com bases A e B e altura C; 
            d) a área do quadrado com lado B; 
            e) a área do retângulo com lados A e B.
        */
        string []  input = Console.ReadLine().Split(" ");    

        double  a = double.Parse(input[0]);
        double  b = double.Parse(input[1]);
        double  c = double.Parse(input[2]);
        double pi = 3.14159;

        double triangulo_retangulo = (a*c)/2;
        double circulo = (pi * (c*c));
        double trapézio= ((a+b) *c)/2; 
        double quadrado = (b*b);
        double retangulo = (b*a);
        
        Console.WriteLine($"triangulo_retangulo:");
        Console.WriteLine($"circulo:");
        Console.WriteLine($"trapézio");
        Console.WriteLine($"quadrado");
        Console.WriteLine($"retangulo");
        

    }
}