namespace objetos_ejercicios_c_.Car-parts
{
    using System;
    class Main
    {
        static void Main(string[] args)
        {
            Coche miCoche = new Coche();
            miCoche.Print();
            Console.WriteLine("\n\nAhora inflando ruedas,encendiendo motor, abriendo puertas y ventanas: \n\n");
            foreach (Rueda rueda in miCoche.ruedas)
            {
                rueda.Inflar();
            }
            foreach (Puerta puerta in miCoche.puertas)
            {
                puerta.Abrir();
            }
            foreach (Puerta puerta in miCoche.puertas)
            {
                puerta.ventana.Abrir();
            }
            miCoche.motor.Encender();
            miCoche.Print();
        }
    }
}