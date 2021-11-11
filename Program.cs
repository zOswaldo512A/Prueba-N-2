using System;

namespace Parcial_N_2_Programación
{
    class Program
    {
        static void Main(string[] args)
        {
            int Edad = 1;
            double Altura = 0.1;
            string Cadena = "";

            Console.WriteLine("¿Comó esta joven?, ingrese tu edad:");
            Cadena = Console.ReadLine();
            Edad = Convert.ToInt32(Cadena);
            
            if( Edad >= 20)
            {
                Console.WriteLine("Superaste la edad requerida para el parque.");
                Console.ReadLine();
            }
            {
            if( Edad <= 0)
                Console.WriteLine("Tu edad, no te permite ingresar a este parque.");
                }

            else
            {
                Console.WriteLine("!!!Bienvenido, mi estimad@!!!");
                Console.WriteLine("¿Cuál es tu Altura? Expresado en metros");
                if(Edad < 5.0)
                {
                Console.WriteLine("lo siento... Pero todavia eres muy bajo para estos juegos, vuelve cuando crescas un poco.");
                
                Cadena = Console.ReadLine();

                Altura = Convert.ToDouble(Cadena);

                if(Altura <= 1.72);
            }
            {
                Console.WriteLine("Listo, felicidades puedes subir a los carritos chocones, casa embrujada y el carrusel");    
              
              Cadena = Console.ReadLine();

              Altura = Convert.ToDouble(Cadena);
            }

             else

             {
                    Console.WriteLine("Listo, felicidades puedes ir subir a los carritos chocones, casa embrujada, el carrusel y a la montaña rusa");
             }       


        }
        Console.ReadKey();
    }
