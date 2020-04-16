using System;

class Program
{
    static void Main(string[] args)
    {
        int Edad = 0;
        Console.WriteLine("Por Favor, Ingrese Su Edad: ");
        Edad = Convert.ToInt32(Console.ReadLine());

        if (Edad >= 18)

            Console.WriteLine("Bienvenido!");

        Console.ReadLine();
    }
}

