using System;
using proyectofinal;

namespace NombreProyecto.Vehiculos
{
    internal class PickUp : VehiculoBase
    {
        public PickUp(string marca, string v) : base(marca)
        {
        }

        public PickUp(string marca, string modelo, string color, int año, string placa, string tipo, int velocidadMaxima) : base(marca, modelo, color, año, placa, tipo, velocidadMaxima)
        {
        }

        public PickUp(string marca, string v, string v1, int v2, string v3, int v4, bool v5) : this(marca, v)
        {
        }

        public int CapacidadCarga { get; set; }
        public bool DobleCabina { get; set; }
        public int CargaMaxima { get; internal set; }

        public void ActivarTraccion4x4()
        {
            Console.WriteLine("Tracción 4x4 activada.");
        }
    }
}

