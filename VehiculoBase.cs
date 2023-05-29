using System;
using VehicleApp;

namespace proyectofinal
{
    internal class VehiculoBase : IVehiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public int Año { get; set; }
        public string Placa { get; set; }
        public string Tipo { get; set; }
        public int VelocidadMaxima { get; }
        public int VelocidadActual { get; private set; }
        private bool encendido;

        public VehiculoBase(string marca)
        {
            VelocidadMaxima = 200; // Velocidad máxima predeterminada
        }

        public VehiculoBase(string marca, string modelo, string color, int año, string placa, string tipo, int velocidadMaxima) : this(marca)
        {
        }

        public void Bocina()
        {
            Console.WriteLine("¡Beep beep!");
        }

        public void Acelerar(int cuanto)
        {
            if (encendido)
            {
                VelocidadActual += cuanto;
                if (VelocidadActual > VelocidadMaxima)
                {
                    VelocidadActual = VelocidadMaxima;
                }
                Console.WriteLine($"Acelerando. Velocidad actual: {VelocidadActual} km/h");
            }
            else
            {
                Console.WriteLine("El vehículo está apagado. No se puede acelerar.");
            }
        }

        public void Encender()
        {
            if (!encendido)
            {
                encendido = true;
                Console.WriteLine("El vehículo ha sido encendido.");
            }
            else
            {
                Console.WriteLine("El vehículo ya está encendido.");
            }
        }

        public void Apagar()
        {
            if (encendido)
            {
                encendido = false;
                VelocidadActual = 0;
                Console.WriteLine("El vehículo ha sido apagado.");
            }
            else
            {
                Console.WriteLine("El vehículo ya está apagado.");
            }
        }

        public void Frenar(int cuanto)
        {
            if (encendido)
            {
                VelocidadActual -= cuanto;
                if (VelocidadActual < 0)
                {
                    VelocidadActual = 0;
                }
                Console.WriteLine($"Frenando. Velocidad actual: {VelocidadActual} km/h");
            }
            else
            {
                Console.WriteLine("El vehículo está apagado. No se puede frenar.");
            }
        }
    }

}

