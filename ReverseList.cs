namespace objetos_ejercicios_c_
{
    using System;
    class PalabrasInversas
    {
        static void Main(string[] args)
        {

            List<string> palabras = new List<string>();

            Console.WriteLine("Ingresa diez palabras:");

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Palabra {i + 1}: ");
                string palabra = Console.ReadLine();
                palabras.Add(palabra);
            }

            Console.WriteLine("Palabras en orden inverso:");

            for (int i = palabras.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(palabras[i]);
            }

            /*Version con Stack
             *
             Stack<string> palabras = new Stack<string>();

            Console.WriteLine("Ingresa diez palabras:");

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Palabra {i + 1}: ");
                string palabra = Console.ReadLine();
                palabras.Push(palabra);
            }

            Console.WriteLine("Palabras en orden inverso:");

            // Mostrar las palabras en orden inverso utilizando el Stack.
            while (palabras.Count > 0)
            {
                string palabra = palabras.Pop();
                Console.WriteLine(palabra);
            }
             */

        }

    }

}