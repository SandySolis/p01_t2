using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==============================================");
            Console.Write("Ingresa el número de pesos a analizar (máximo 300): ");
            int numPersonas = Convert.ToInt32(Console.ReadLine());

            if (numPersonas > 300)
            {
                Console.WriteLine("El número de personas no puede ser mayor a 300.");
                return;
            }

            Random rand = new Random();
            int[] pesos = new int[numPersonas];
            int sumaPesos = 0;
            int menos60kg = 0, mas100kg = 0;

            for (int i = 0; i < numPersonas; i++)
            {
                pesos[i] = rand.Next(150); // Genera un peso aleatorio entre 0 y 150
                sumaPesos += pesos[i];

                if (pesos[i] < 60)
                    menos60kg++;
                else if (pesos[i] > 100)
                    mas100kg++;
            }

            double promedioPesos = Math.Round((double)sumaPesos / numPersonas, 2);

            Console.WriteLine("==============================================");
            Console.WriteLine("Procesando...");
            Console.WriteLine("==============================================");
            Console.WriteLine($"La suma de todos los pesos es: {sumaPesos}");
            Console.WriteLine($"El promedio de todos los pesos es: {promedioPesos}Kg");
            Console.WriteLine("==============================================");
            Console.WriteLine($"Menos de 60Kg: {menos60kg}");
            Console.WriteLine($"Más de 100Kg: {mas100kg}");
            Console.ReadKey();
        }
    }
}
