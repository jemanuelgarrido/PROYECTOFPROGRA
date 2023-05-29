using System;
using proyectofinal;

namespace NombreProyecto.Vehiculos
{
    internal  class SUV : VehiculoBase
    {
        internal bool TieneTechoSolar;
        private string v1;
        private string v2;
        private int v3;
        private string v4;
        private bool v5;

        public SUV(string marca) : base(marca)
        {
        }

        public SUV(string marca, string v1, string v2, int v3, string v4, bool v5) : this(marca)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.v4 = v4;
            this.v5 = v5;
        }

        public SUV(string marca, string modelo, string color, int año, string placa, string tipo, int velocidadMaxima) : base(marca, modelo, color, año, placa, tipo, velocidadMaxima)
        {
        }

        public int CapacidadPasajeros { get; set; }
        public bool TerceraFilaAsientos { get; set; }

        public void ActivarModoOffRoad()
        {
            Console.WriteLine("Modo off-road activado.");
        }
    }
}


