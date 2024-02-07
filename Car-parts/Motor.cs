namespace objetos_ejercicios_c_.Car-parts
{
    class Motor
    {
        private bool _encendido;

        public Motor()
        {
            this._encendido = false;
        }

        public void Encender()
        {
            this._encendido = true;
        }
        public void Apagar()
        {
            this._encendido = false;
        }

        public bool EstaEncendido()
        {
            return _encendido;
        }
    }
}
