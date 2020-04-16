using System;

class Program
{
    static void Main(string[] args)
    {
        Preguntas();
    }
    public static void Preguntas()
    {
        Aprendiz apSena = new Aprendiz();
        Console.Write("Ingresar su primer nombre: ");
        apSena.PrimerNombre = Console.ReadLine();
        Console.Write("Ingresar su segundo nombre: ");
        apSena.SegundoNombre = Console.ReadLine();
        Console.Write("Ingresar su primer apellido: ");
        apSena.PrimerApellido = Console.ReadLine();
        Console.Write("Ingresar su segundo apellido: ");
        apSena.Segundoapellido = Console.ReadLine();

        MostrarInformacion(apSena);
    }
    public static void MostraInformacion(Aprendiz apSena)
    {
        //GET
        Console.WriteLine("Primer Nombre....." + apSena.PrimerNombre);
        Console.WriteLine("SegundoNombre....." + apSena.SegundoNombre);
        Console.WriteLine("Primer Apellido....." + apSena.PrimerApellido);
        Console.WriteLine("Segundo Apellido....." + apSena.SegundoApellido);
        Console.ReadLine();
}

