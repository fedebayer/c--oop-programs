namespace objetos_ejercicios_c_
{
    using System;
    class ArtefactosElectricos
    {
        static void Main(string[] args)
        {
            Lampara lampara1 = new Lampara("Lámpara de escritorio");
            Linterna linterna1 = new Linterna("Linterna de camping");
            Enchufe enchufe1 = new Enchufe();
            CargadorPortatil cargador1 = new CargadorPortatil();

            // Conectar la lámpara al enchufe
            enchufe1.Conectar(lampara1);

            // Cargar la linterna con el cargador portátil
            cargador1.Cargar(linterna1);

            //PUNTO 2
            FarolLed farol1 = new FarolLed("Farol Led");
            farol1.ConectarAlEnchufe(enchufe1);
            farol1.CargarConCargadorPortatil(cargador1);
        }

        public abstract class ArtefactoElectrico
        {
            public string Nombre { get; set; }

            public ArtefactoElectrico(string nombre)
            {
                Nombre = nombre;
            }
        }

        public interface IRecargablePorEnchufe
        {
            string Nombre { get; }
            void ConectarAlEnchufe(Enchufe enchufe);
        }

        public interface IRecargablePorCargadorPortatil
        {
            string Nombre { get; }
            void CargarConCargadorPortatil(CargadorPortatil cargadorPortatil);
        }


        public class Lampara : ArtefactoElectrico, IRecargablePorEnchufe
        {
            public Lampara(string nombre) : base(nombre)
            {
            }

            public void ConectarAlEnchufe(Enchufe enchufe)
            {
                enchufe.Conectar(this);
            }
        }

        public class Linterna : ArtefactoElectrico, IRecargablePorCargadorPortatil
        {
            public Linterna(string nombre) : base(nombre)
            {
            }

            public void CargarConCargadorPortatil(CargadorPortatil cargadorPortatil)
            {
                cargadorPortatil.Cargar(this);
            }
        }

        public class Enchufe
        {
            public void Conectar(IRecargablePorEnchufe recargableEnchufe)
            {
                Console.WriteLine($"Se ha conectado {recargableEnchufe.Nombre} al enchufe.");
            }
        }

        public class CargadorPortatil
        {
            public void Cargar(IRecargablePorCargadorPortatil recargablePortatil)
            {
                Console.WriteLine($"Se está cargando {recargablePortatil.Nombre} con el cargador portátil.");
            }
        }

        //PUNTO 2 Para que el farol led pueda poseer ambas funcionalidades, se implementan ambas interfaces. Esto facilita la reutilización de código y creacion de
        //mas artefactos electricos (ya sean por enchufe/cargador portatil) que puedan implementar estas interfaces.
        public class FarolLed : ArtefactoElectrico, IRecargablePorEnchufe, IRecargablePorCargadorPortatil
        {
            public FarolLed(string nombre) : base(nombre)
            {
            }

            public void ConectarAlEnchufe(Enchufe enchufe)
            {
                enchufe.Conectar(this);
            }

            public void CargarConCargadorPortatil(CargadorPortatil cargadorPortatil)
            {
                cargadorPortatil.Cargar(this);
            }
        }
    }
}
