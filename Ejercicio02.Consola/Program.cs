using System.Security.AccessControl;
using System.Timers;

namespace Ejercicio02.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("volumen y superficie de varios cilindros");
            int interaccion = 0;
            double mayorVolumen = 0;
            int i = 1; i++;

            while (true)
            {
                try
                {

                    Console.Write("Ingresar el radio del cilindro: ");
                    double radio = double.Parse(Console.ReadLine());
                    Console.Write("Ingresar la altura del ciclindro: ");
                    double altura = double.Parse(Console.ReadLine());
                    if (radio <= 0)
                    {
                        Console.WriteLine("Radio mal ingresado");
                        return;
                    }
                    if (altura <= 0)
                    {
                        Console.WriteLine("Altura mal ingresada");
                        return;
                    }
                    double volumen = Math.PI * Math.Pow(radio, 2) * altura;
                    double superficie = 2 * Math.PI * Math.Pow(radio, 2) + 2 * Math.PI * radio * altura;
                    Console.WriteLine($"Volumen del cilindro: {volumen}");
                    Console.WriteLine($"Superficie del cilindro: {superficie}");

                    if (volumen > mayorVolumen)
                    {
                        mayorVolumen = volumen;
                        interaccion = i;
                    }
                    Console.Write("¿Quiere ingresar un nuevo cilindro? (si/no): ");
                    string respuesta = Console.ReadLine().ToLower();
                   
                    if (respuesta != "si")
                    {
                        break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error, valores mal ingresados!!!");
                }  
            }
            if (interaccion > 0)
            {
                Console.WriteLine($"El cilindro de mayor volumen fue ingresado en la interaccion {interaccion} con un volumen de {mayorVolumen}.");
            }
        } 
    }
}


