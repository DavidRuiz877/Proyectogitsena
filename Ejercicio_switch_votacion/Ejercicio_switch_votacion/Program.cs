using System;

class Program
{
    static void Main(string[] args)
    {
        int VotoUsuario = 0;
        int VotoNulo = 0;
        int VotoMaria = 0;
        int VotoDavid = 0;
        int VotoDuver = 0;
        int VotoJohan = 0;
        int VotoBlanco = 0;
        int VotoTarjetaNoMarcada = 0;
        string RespuestaUsuario = "";

        // Por favor, ingrese el nombre del candidato de su escogencia:
        // ===Candidatos=== 
        ////0. Nulo
        //1. Maria Losada 
        //2. David Ruiz
        //3. Duver Uni
        //4. Johan Bravo 
        //5. En Blanco 
        //6.Tarjeta No Marcada
        Console.WriteLine("Desea ingresar un nuevo voto? (SI/NO) ");
        RespuestaUsuario = Console.ReadLine();

         while (RespuestaUsuario == "SI")
         
        {
            Console.WriteLine(" Lista de candidatos: ");
            Console.WriteLine("1. Maria losada");
            Console.WriteLine("2. David Ruiz");
            Console.WriteLine("3. Duver Uni");
            Console.WriteLine("4. Johan Bravo");
            Console.WriteLine("5. En blanco");
            Console.WriteLine("6. Tarjeta no marcada");
            Console.Write("Por favor,ingrese el numero " + " del candidado de su preferencia: ");
            Int32.TryParse(Console.ReadLine(), out VotoUsuario);

            switch (VotoUsuario)
            {
                case 0:
                    Console.WriteLine("Su voto ha sido marcado como nulo");
                    VotoNulo++;
                    break;
                case 1:
                    Console.WriteLine("Su voto es para Maria Losada");
                    VotoMaria++;
                    break;
                case 2:
                    Console.WriteLine("Su voto es para David Ruiz");
                    VotoDavid++;
                    break;
                case 3:
                    Console.WriteLine("Su voto es para Duver Uni");
                    VotoDuver++;
                    break;
                case 4:
                    Console.WriteLine("Su voto es para Johan Bravo");
                    VotoJohan++;
                    break;
                case 5:
                    Console.WriteLine("Su voto es en blanco");
                    VotoBlanco++;
                    break;
                case 6:
                    Console.WriteLine("Su tarjeta no ha sido marcada");
                    VotoTarjetaNoMarcada++;
                    break;
                default:
                    Console.WriteLine("su voto ha sido marcado como nulo");
                    VotoNulo++;
                    break;
            }
                Console.WriteLine("Desea ingresar un nuevo voto? (SI/NO)");
                RespuestaUsuario = Console.ReadLine();
        }
            
       
                Console.WriteLine("===RESULTADOS===");
                Console.WriteLine("1.Maria Losada........ "+ VotoMaria + "voto(s) " );
                Console.WriteLine("2.David Ruiz.........." + VotoDavid + "voto(s) ");
                Console.WriteLine("3.Duver Uni..........." + VotoDuver + "voto(s) ");
                Console.WriteLine("4.Johan Bravo........." + VotoJohan + "voto(s) ");
                Console.WriteLine("5.En Blanco..........." + VotoBlanco + " voto(s) ");
                Console.WriteLine("6.Tarjeta No Marcada.." + VotoTarjetaNoMarcada + " voto(s) ");
    
    Console.ReadLine();
        
    }
}

