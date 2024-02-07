namespace objetos_ejercicios_c_.Car-parts
{
    using System;
    class Coche
    {
        public Motor motor { get; }
        public Rueda[] ruedas { get; }
        public Puerta[] puertas { get; }

        public Coche()
        {
            this.motor = new Motor();
            ruedas = new Rueda[4];
            for (int i = 0; i < 4; i++)
            {
                ruedas[i] = new Rueda();
            }
            puertas = new Puerta[2];
            for (int i = 0; i < 2; i++)
            {
                puertas[i] = new Puerta();
            }
        }

        public void Print()
        {
            Console.WriteLine("Ruedas: ");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"\tRueda{i + 1}: {(ruedas[i].EstaInflada() ? "Inflada" : "Desinflada")}");
            }
            Console.WriteLine("\nPuertas: ");
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"\tPuerta{i + 1}: {(puertas[i].EstaAbierta() ? "Abierta" : "Cerrada")}");
            }
            Console.WriteLine($"\nMotor: {(motor.EstaEncendido() ? "Encendido" : "Apagado")}");
        }
    }
}
