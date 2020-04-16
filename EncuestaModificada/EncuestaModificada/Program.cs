using System;

class Program
{
    static void Main(string[] args)
    {
        string NombreUsuario = "";
        int EdadUsuario = 0;
        string HobbyUsuario = "";
        Console.WriteLine("Bienvenidos");
        Console.Write("Escriba su nombre: ");
        NombreUsuario = Console.ReadLine();
        Console.Write("Escriba su edad: ");
        EdadUsuario = Convert.ToInt32(Console.ReadLine());
        Console.Write("Escriba su hobbit: ");
        HobbyUsuario = Console.ReadLine();
        Console.WriteLine("Bienvenido(a), sr(a) " + NombreUsuario +
            ", Edad: " + EdadUsuario + " años, su hobby es: " + HobbyUsuario);
        Console.ReadLine();

    }
}

