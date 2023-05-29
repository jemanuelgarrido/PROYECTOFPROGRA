using System;
using proyectofinal;

namespace NombreProyecto
{
    internal class CuatroPorCuatro : VehiculoBase
    {
        public int NumeroEjes { get; set; }
        public bool EsTodoTerreno { get; set; }

        public CuatroPorCuatro(string marca, string modelo, string color, int anio, string placa, int numeroEjes, bool esTodoTerreno)
            : base(marca, modelo, color, anio, placa, "4x4", 250)
        {
            NumeroEjes = numeroEjes;
            EsTodoTerreno = esTodoTerreno;
        }

        public void ActivarTraccion4x4()
        {
            Console.WriteLine("Tracción 4x4");
        }
    }
}

