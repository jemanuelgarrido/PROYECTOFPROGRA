
using NombreProyecto.Vehiculos;

namespace NombreProyecto
{
    internal class Program
    {
        private static void Main()
        {
            // Crear objetos de diferentes clases
            PickUp miPickUp = new PickUp("Ford", "Ranger", "Rojo", 2022, "P456FRG", 1000, true);
            Sedan miSedan = new Sedan("Toyota", "Camry", "Negro", 2021, "P456GTR", 4, false);
            SUV miSUV = new SUV("Honda", "CR-V", "Blanco", 2023, "PRTF54GTY", true);
            CuatroPorCuatro miCuatroPorCuatro = new CuatroPorCuatro("Jeep", "Wrangler", "Verde", 2020, "PHI012", 2, true);

            // Asignar valores a las propiedades
            miPickUp.CargaMaxima = 500;
            miSedan.EsDeportivo = true;
            miSUV.TieneTechoSolar = true;
            miCuatroPorCuatro.NumeroEjes = 4;

            // Llamar a los métodos
            miPickUp.Acelerar(50);
            miSedan.AbrirMaletero ();
            miSUV.Encender();
            miCuatroPorCuatro.ActivarTraccion4x4();

            // Mostrar información de los vehículos
            Console.WriteLine("Información del PickUp:");
            Console.WriteLine($"Marca: {miPickUp.Marca}");
            Console.WriteLine($"Modelo: {miPickUp.Modelo}");
            Console.WriteLine($"Color: {miPickUp.Color}");
            Console.WriteLine($"Año: {miPickUp.Año }");
            Console.WriteLine($"Placa: {miPickUp.Placa}");
            Console.WriteLine($"Tipo: {miPickUp.Tipo}");
            Console.WriteLine($"Velocidad Máxima: {miPickUp.VelocidadMaxima}");
            Console.WriteLine($"Velocidad Actual: {miPickUp.VelocidadActual}");
            Console.WriteLine($"Carga Máxima: {miPickUp.CargaMaxima}");

            Console.WriteLine("Información del SEDAN:");
            Console.WriteLine($"Marca: {miSedan .Marca}");
            Console.WriteLine($"Modelo: {miSedan.Modelo}");
            Console.WriteLine($"Color: {miSedan.Color}");
            Console.WriteLine($"Año: {miSedan.Año}");
            Console.WriteLine($"Placa: {miSedan.Placa}");
            Console.WriteLine($"Tipo: {miSedan.Tipo}");
            Console.WriteLine($"Velocidad Máxima: {miSedan.VelocidadMaxima}");
            Console.WriteLine($"Velocidad Actual: {miSedan.VelocidadActual}");

            Console.WriteLine("Información del SUV:");
            Console.WriteLine($"Marca: {miSUV.Marca}");
            Console.WriteLine($"Modelo: {miSUV.Modelo}");
            Console.WriteLine($"Color: {miSUV.Color}");
            Console.WriteLine($"Año: {miSUV.Año}");
            Console.WriteLine($"Placa: {miSUV.Placa}");
            Console.WriteLine($"Tipo: {miSUV.Tipo}");
            Console.WriteLine($"Velocidad Máxima: {miSUV.VelocidadMaxima}");
            Console.WriteLine($"Velocidad Actual: {miSUV.VelocidadActual}");

            Console.WriteLine("Información del CUATRO:");
            Console.WriteLine($"Marca: {miCuatroPorCuatro.Marca}");
            Console.WriteLine($"Modelo: {miCuatroPorCuatro.Modelo}");
            Console.WriteLine($"Color: {miCuatroPorCuatro.Color}");
            Console.WriteLine($"Año: {miCuatroPorCuatro.Año}");
            Console.WriteLine($"Placa: {miCuatroPorCuatro.Placa}");
            Console.WriteLine($"Tipo: {miCuatroPorCuatro.Tipo}");
            Console.WriteLine($"Velocidad Máxima: {miCuatroPorCuatro.VelocidadMaxima}");
            Console.WriteLine($"Velocidad Actual: {miCuatroPorCuatro.VelocidadActual}");
            



           



            Console.ReadLine();
        }
    }
}

