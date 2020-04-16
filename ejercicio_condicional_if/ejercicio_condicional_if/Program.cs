using System;

class Program
{
    static void Main(string[] args)
    {
        string PasswordBD = "GHE10";
        string PasswordUser = "";
          Console.WriteLine("Por Favor Ingrese Su Contraseña: ");
           PasswordUser = Console.ReadLine();

        if (PasswordUser == PasswordBD)

          Console.WriteLine("Acceso Autorizado.");

        else

          Console.WriteLine("Acceso Denegado!");

       
          Console.ReadLine();
    }
}

