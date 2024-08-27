namespace Ejercicio01.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("volumen y superficie de un cilindro"); 

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
            }
            catch (FormatException)
            {
                Console.WriteLine("Error, valores mal ingresados!!!");
            }
        }
    }
}




