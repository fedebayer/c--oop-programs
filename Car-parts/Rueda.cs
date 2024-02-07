namespace objetos_ejercicios_c_.Car-parts
{
    class Rueda
    {

        private bool _inflada;

        public Rueda()
        {
            this._inflada = false;
        }

        public void Inflar()
        {
            this._inflada = true;
        }

        public void Desinflar()
        {
            this._inflada = false;
        }

        public bool EstaInflada()
        {
            return _inflada;
        }
    }
}
