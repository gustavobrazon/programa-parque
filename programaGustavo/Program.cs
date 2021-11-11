using System;

namespace programaGustavo
{
    class Program
    {
        static void Main(string[] args)
        {
            int edadMinima = 15;
            double estaturaMinima = 1.65; 

            Console.WriteLine("Ingresar tu edad: ");
            int edad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingresar tu estatura en metros: ");
            double estatura = Convert.ToDouble(Console.ReadLine());

            bool edadPermitida = (edad >= edadMinima);
            bool estaturaPermitida = (estatura >= estaturaMinima);

            if(edadPermitida == true) {
                if(estaturaPermitida == true) {
                    Console.WriteLine("Puedes entrar al parque");
                } else {
                    Console.WriteLine("Tu estatura no es suficiente para entrar al parque");
                }
            } else {
                Console.WriteLine("Tu edad no es suficiente para entrar al parque");
            }
        }
    }
}
