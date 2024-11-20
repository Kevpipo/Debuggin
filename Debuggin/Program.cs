using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debugging
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Lista de números del 1 al 15
                List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

                int suma = SumaNumeros(list);
                int sumaPares = SumaPares(list);
                int sumaImpares = SumaImpares(list);
                int sumaRandom = SumaRandoms();

                // Resultados
                Console.WriteLine("La suma es: " + suma);
                Console.WriteLine("La suma de PARES es: " + sumaPares);
                Console.WriteLine("La suma de IMPARES es: " + sumaImpares);
                Console.WriteLine("La suma de 10 números aleatorios entre 1 y 10 es: " + sumaRandom);

                Console.ReadKey(); 
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.ToString()}");
            }
        }

        static int SumaNumeros(List<int> lista)
        {
            int suma = 0;
            foreach (int i in lista)
            {
                // Cada valor de 'i' se va sumando al total de 'suma'
                // En la primera iteración suma = 0 + 1 = 1
                // En la segunda iteración suma = 1 + 2 = 3
                // En la tercera iteración suma = 3 + 3 = 6
                // Este proceso continúa hasta que todos los números se han sumado
                suma += i; // Incrementa 'suma' con el valor de 'i'
            }
            return suma; 
        }

        static int SumaPares(List<int> lista)
        {
            int sumaPares = 0;
            foreach (var n in lista)
            {
                if (n % 2 == 0) // Verificar si el número es par
                    // Si es par, se suma a SumaPares
                    // Por ejemplo, cuando n = 2, SumaPares = 0 + 2 = 2
                    // Luego cuando n = 4, SumaPares = 2 + 4 = 6
                    // Así continúa con todos los números pares de la lista
                    sumaPares += n; // Si es par, se suma a sumaPares
            }
            return sumaPares;
        }

        static int SumaImpares(List<int> lista)
        {
            int sumaImpares = 0;
            foreach (var n in lista)
            {
                if (n % 2 != 0) // Verificar si el número es impar
                    // Si es impar, se suma a SumaImpares
                    // Por ejemplo, cuando n = 1, SumaImpares = 0 + 1 = 1
                    // Luego cuando n = 3, SumaImpares = 1 + 3 = 4
                    // Así continúa con todos los números impares de la lista
                    sumaImpares += n; // Si es impar, se suma a sumaImpares
            }
            return sumaImpares; 
        }

        static int SumaRandoms()
        {
            Random random = new Random();
            int suma = 0;

            for (int i = 0; i < 10; i++)
            {
                int numeroAleatorio = random.Next(1, 11); // Genera un número entre 1 y 10
                suma += numeroAleatorio; // Agrega el número aleatorio a 'suma'
            }

            return suma; 
        }
    }
}
