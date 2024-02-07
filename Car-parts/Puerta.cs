namespace objetos_ejercicios_c_.Car-parts
{
    class Puerta
    {
        public Ventana ventana { get; }
        private bool _abierta { get; set; }

        public Puerta()
        {
            this.ventana = new Ventana();
            this._abierta = false;
        }

        public void Abrir()
        {
            this._abierta = true;
        }

        public void Cerrar()
        {
            this._abierta = false;
        }

        public bool EstaAbierta()
        {
            return _abierta;
        }
    }
}
