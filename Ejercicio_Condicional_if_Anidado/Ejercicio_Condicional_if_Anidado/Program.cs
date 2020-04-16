using System;

class Program
{
    static void Main(string[] args)
    {
        Decimal NotaUsuario = 0;

        Console.WriteLine(" Por Favor, Ingrese La Nota: ");
        NotaUsuario = Convert.ToDecimal(Console.ReadLine());

        if (NotaUsuario == 10)
            Console.Write(" El Resultado Es Excelente");

        else if (NotaUsuario >= 9)
            Console.WriteLine("El Resultado Es: Muy Bueno");

        else if (NotaUsuario >= 7)
            Console.WriteLine("El Resultado Es. Regular");

        else if (NotaUsuario >= 5)
            Console.WriteLine("El Resultado Es Malo");
                
                Console.ReadLine();
    }
}

