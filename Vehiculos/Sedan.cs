using System;
using proyectofinal;

namespace NombreProyecto.Vehiculos
{
    internal  class Sedan : VehiculoBase
    {
        public Sedan(string marca, string v, string v1) : base(marca)
        {
        }

        public Sedan(string marca, string modelo, string color, int año, string placa, string tipo, int velocidadMaxima) : base(marca, modelo, color, año, placa, tipo, velocidadMaxima)
        {
        }

        public Sedan(string marca, string v, string v1, int v2, string v3, int v4, bool v5) : this(marca, v, v1)
        {
        }

        public int NumeroPuertas { get; set; }
        public bool Automatico { get; set; }
        public bool EsDeportivo { get; internal set; }

        public void AbrirMaletero()
        {
            Console.WriteLine("Maletero abierto.");
        }
    }
}

