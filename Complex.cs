namespace objetos_ejercicios_c_
{
    using System;
    class Complejo
    {
        static void Main(string[] args)
        {
            Complejo c1 = new Complejo(2, 3);
            Complejo c2 = new Complejo(1, 2);
            Console.WriteLine("c1: " + c1.ToString());
            Console.WriteLine("c2: " + c2.ToString());

            Complejo suma = c1.Sumar(c2);
            Console.WriteLine("\nSuma de c1 y c2: " + suma);

            Complejo multiplicacion = c1.Multiplicar();
            Console.WriteLine("\nMultiplicación de c1: " + multiplicacion);

            bool sonIguales = c1.EsIgualA(c2);
            Console.WriteLine("\n¿c1 es igual a c2? " + sonIguales);

            Console.WriteLine("\nPrint de c1: ");
            c1.Print();

            Console.WriteLine("\nToString de c1: " + c1.ToString());

            Complejo c3 = new Complejo(4, 4);
            Complejo c4 = new Complejo(4, 4);
            Console.WriteLine("\n\nc3: " + c3.ToString());
            Console.WriteLine("c4: " + c4.ToString());

            bool sonIguales2 = c3.EsIgualA(c4);
            Console.WriteLine("\n¿c3 es igual a c4? " + sonIguales2);
        }

        private float _parteReal { get; set; }
        private float _parteImaginaria { get; set; }

        private const float CONSTANTE_MULTIPLICACION = 4;

        public Complejo()
        {
            _parteReal = 0;
            _parteImaginaria = 0;
        }

        public Complejo(float _parteReal, float _parteImaginaria)
        {
            this._parteReal = _parteReal;
            this._parteImaginaria = _parteImaginaria;
        }

        Complejo Sumar(Complejo sumando)
        {
            float sumaReal = this._parteReal + sumando._parteReal;
            float sumaImaginaria = this._parteImaginaria + sumando._parteImaginaria;

            return new Complejo(sumaReal, sumaImaginaria);
        }


        Complejo Multiplicar()
        {

            float multiplicaReal = this._parteReal * CONSTANTE_MULTIPLICACION;
            float multiplicaImaginaria = this._parteImaginaria * CONSTANTE_MULTIPLICACION;

            return new Complejo(multiplicaReal, multiplicaImaginaria);
        }

        bool EsIgualA(Complejo igualando)
        {
            if (this._parteReal == igualando._parteReal && this._parteImaginaria == igualando._parteImaginaria)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        void Print()
        {
            Console.WriteLine($"{_parteReal} + {_parteImaginaria}i");
        }

        /*Por default es Ej1.Complejo, ahora con override: */

        public override string ToString()
        {
            return $" Complejo: {_parteReal} + {_parteImaginaria}i";
        }
    }
}