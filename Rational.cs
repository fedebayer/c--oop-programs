namespace objetos_ejercicios_c_
{
    class Racional
    {
        static void Main(string[] args)
        {
            Racional fraccion1 = new Racional(3, 4);
            Racional fraccion2 = new Racional(1, 2);
            Console.WriteLine("Fracción 1: " + fraccion1);
            Console.WriteLine("Fracción 2: " + fraccion2);

            Racional suma = fraccion1.Sumar(fraccion2);
            Console.WriteLine("\nSuma: " + suma);

            Racional producto = fraccion1.Multiplicar(fraccion2);
            Console.WriteLine("\nMultiplicación: " + producto);

            //ejemplo de excepción con denominador 0
            Racional fraccionError = new Racional(4, 0);
            Console.WriteLine(fraccionError);

        }
        private int _numerador { get; set; }
        private int _denominador { get; set; }

        public Racional(int numerador, int denominador)
        {
            try
            {
                _numerador = numerador;

                if (denominador == 0) throw new ArgumentException("El denominador no puede ser cero.");

                else _denominador = denominador;
            }
            catch (ArgumentException) //Se podria dejar sin el try-catch y dejar que tire un error que pare la ejecucion del programa
            {
                Console.WriteLine("El denominador no puede ser cero, se cambia por 1.");
                _denominador = 1;
            }
        }


        public Racional Sumar(Racional otroRacional)
        {
            int nuevoNumerador = (_numerador * otroRacional._denominador) + (otroRacional._numerador * _denominador);
            int nuevoDenominador = _denominador * otroRacional._denominador;
            return new Racional(nuevoNumerador, nuevoDenominador);
        }


        public Racional Multiplicar(Racional otroRacional)
        {
            int nuevoNumerador = _numerador * otroRacional._numerador;
            int nuevoDenominador = _denominador * otroRacional._denominador;
            return new Racional(nuevoNumerador, nuevoDenominador);
        }

        public override string ToString()
        {
            return $" Fracción: {this._numerador} / {this._denominador}";
        }
    }
}