namespace objetos_ejercicios_c_.Car-parts
{
    class Ventana
    {
        private bool _abierta;

        public Ventana()
        {
            _abierta = false;
        }

        public void Abrir()
        {
            _abierta = true;
        }

        public void Cerrar()
        {
            _abierta = false;
        }

        public bool EstaAbierta()
        {
            return _abierta;
        }
    }
}