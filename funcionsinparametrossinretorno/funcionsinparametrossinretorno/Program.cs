using System;

class Program
{
    static void Main(string[] args)
    {
        string Respuesta = "";
        Console.Write("¿Desea realizar una suma?:(S/N)");
        Respuesta = Console.ReadLine();
        while (Respuesta == "S")
        {
            Suma();
            Console.Write("¿Desea realizar otra suma?:(S/N)");
            Respuesta = Console.ReadLine();
        }
        Console.WriteLine("fin del ejercicio.");
        Console.ReadLine();
    }

    private static void Suma()
    {
        int Num1 = 0;
        int Num2 = 0;
        Console.WriteLine("Ingrese el primer numero:");
        Int32.TryParse(Console.ReadLine(), out Num1);
        Console.WriteLine("Ingrese el segundo numero:");
        Int32.TryParse(Console.ReadLine(), out Num2);
        Console.WriteLine("El resultado es: {0, 1}", Num1 + Num2);
    }

}

