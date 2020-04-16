using System;

class Program
{
    static void Main(string[] args)
    {
        Aprendiz apSena = new Aprendiz();
        Console.Write("Ingrese su primer nombre: ");
        apSena.PrimerNombre = Console.ReadLine();
        Console.Write("Ingrese su segundo nombre: ");
        apSena.SegundoNombre = Console.ReadLine();
        Console.Write("Ingrese su primer apellido: ");
        apSena.PrimerApellido = Console.ReadLine();
        Console.Write("Ingrese su segundo apellido: ");
        apSena.SegundoApellido = Console.ReadLine();
        Console.Write("Bienvenido(a) " + apSena.PrimerNombre + " " + apSena.SegundoNombre + " " + apSena.PrimerApellido + " " + apSena.SegundoApellido);
        Console.ReadLine();


    }
}

