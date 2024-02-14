namespace objetos_ejercicios_c_
{
    using System;
    class CatalogoLibros
    {
        static void Main(string[] args)
        {

            CatalogoLibros catalogo = new CatalogoLibros();

            Libro cienAnios = new Libro("Cien años de soledad", 1967);
            catalogo.AgregarLibro(cienAnios);
            Libro romaSoyYo = new Libro("Roma soy yo", 2022);
            catalogo.AgregarLibro(romaSoyYo);
            Libro elReinoDeLasTinieblas = new Libro("El reino de las tinieblas", 2021);
            catalogo.AgregarLibro(elReinoDeLasTinieblas);
            Libro quijote = new Libro("Don Quijote de la Mancha", 1605);
            catalogo.AgregarLibro(quijote);


            Console.WriteLine($"Número de libros en el catálogo: {catalogo.ObtenerNumeroLibros()}");


            Console.WriteLine("\nBuscar libro por nombre -roma-:");
            catalogo.ObtenerLibroPorNombre("roma");

            Console.WriteLine("\nBuscar libro por parte del título -quijote-:");
            catalogo.BuscarLibroPorParteDelTitulo("quijote");

            Console.WriteLine("\nBuscar libro por parte del título -a-:");
            catalogo.BuscarLibroPorParteDelTitulo("a");

            Console.WriteLine("\nBuscar libro por cantidad de caracteres en el título -23-:");
            catalogo.BuscarLibroPorCantidadCaracteres(23);

            Console.WriteLine("\nBuscar libro por cantidad de caracteres en el título -20-:");
            catalogo.BuscarLibroPorCantidadCaracteres(20);

            Console.WriteLine("\nBuscar libro por año de publicación -2021-:");
            catalogo.BuscarLibroPorAnio(2021);

            Console.WriteLine("\nEliminar libro por nombre:");
            catalogo.EliminarLibroPorNombre("Roma soy yo");

            Console.WriteLine($"\nNúmero de libros en el catálogo después de eliminar: {catalogo.ObtenerNumeroLibros()}");

        }

        private List<Libro> catalogo;

        public CatalogoLibros()
        {
            catalogo = new List<Libro>();
        }

        private void AgregarLibro(Libro libro)
        {
            catalogo.Add(libro);
        }

        public int ObtenerNumeroLibros()
        {
            return catalogo.Count;
        }

        public void EliminarLibroPorNombre(string nombre)
        {
            var librosAEliminar = catalogo.Where(libro => libro.nombre.Contains(nombre, StringComparison.OrdinalIgnoreCase)).ToList();

            if (librosAEliminar.Count > 0)
            {
                foreach (var libro in librosAEliminar)
                {
                    catalogo.Remove(libro);
                }
                Console.WriteLine($"\tSe han eliminado {librosAEliminar.Count} libro(s).");
            }
            else
            {
                Console.WriteLine("\tNo se encontraron libros para eliminar.");
            }
        }

        public void ObtenerLibroPorNombre(string nombre)
        {
            var librosEncontrados = catalogo.Where(libro => libro.nombre.Contains(nombre, StringComparison.OrdinalIgnoreCase)).ToList();

            if (librosEncontrados.Count > 0)
            {
                foreach (var libro in librosEncontrados)
                {
                    Console.WriteLine("\t" + libro);
                }
            }
            else
            {
                Console.WriteLine("\tNo se encontraron libros con ese nombre.");
            }
        }

        public void BuscarLibroPorParteDelTitulo(string parteTitulo)
        {
            var librosEncontrados = catalogo.Where(libro => libro.nombre.IndexOf(parteTitulo, StringComparison.OrdinalIgnoreCase) >= 0).ToList();

            if (librosEncontrados.Count > 0)
            {
                foreach (var libro in librosEncontrados)
                {
                    Console.WriteLine("\t" + libro);
                }
            }
            else
            {
                Console.WriteLine("\tNo se encontraron libros con esa parte del título.");
            }
        }

        public void BuscarLibroPorCantidadCaracteres(int cantidadCaracteres)
        {
            var librosEncontrados = catalogo.Where(libro => libro.nombre.Length == cantidadCaracteres).ToList();

            if (librosEncontrados.Count > 0)
            {
                foreach (var libro in librosEncontrados)
                {
                    Console.WriteLine("\t" + libro);
                }
            }
            else
            {
                Console.WriteLine("\tNo se encontraron libros con esa cantidad de caracteres en el título.");
            }
        }

        public void BuscarLibroPorAnio(int anio)
        {
            var librosEncontrados = catalogo.Where(libro => libro.anioPublicacion == anio).ToList();

            if (librosEncontrados.Count > 0)
            {
                foreach (var libro in librosEncontrados)
                {
                    Console.WriteLine("\t" + libro);
                }
            }
            else
            {
                Console.WriteLine("\tNo se encontraron libros con ese año de publicación.");
            }
        }

        // Para crear metodos similares para buscar segun criterios diferentes, se puede pasar el criterio como parametro y utilizarlo en el Where.
        //ejemplo
        //tambien se podria usar el patron strategy para crear una clase que herede de clase "CriterioLibro" por cada criterio de busqueda y pasarla como parametro.
        /*
        public void BuscarLibroPorCriterio(String criterio)
        {
            var librosEncontrados = catalogo.Where(libro => libro.criterio == criterio).ToList();

            if (librosEncontrados.Count > 0)
            {
                foreach (var libro in librosEncontrados)
                {
                    Console.WriteLine("\t" + libro);
                }
            }
            else
            {
                Console.WriteLine($"No se encontraron libros con ese {criterio}.");
            }
        }*/


        private class Libro
        {
            public string nombre { get; set; }
            public int anioPublicacion { get; set; }

            public Libro(string nombre, int anioPublicacion)
            {
                this.nombre = nombre;
                this.anioPublicacion = anioPublicacion;
            }

            public override string ToString()
            {
                return $"Libro: Nombre: {this.nombre}, Año de Publicación: {this.anioPublicacion}";
            }
        }
    }
}