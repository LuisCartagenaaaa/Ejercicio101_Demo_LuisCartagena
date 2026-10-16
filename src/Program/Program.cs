using System;
using Ucu.Poo.Ejercicio101;

namespace Project
{
    /// <summary>
    /// Programa principal.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Punto de entrada al programa principal.
        /// </summary>
        public static void Main()
        {
            Estudiante estudiante =
                new Estudiante("Ana Pérez", "4.567.890-1");

            Equipo notebook =
                new Equipo("NB001", "Notebook Dell");

            Console.WriteLine("=== ESTADO INICIAL ===");
            Console.WriteLine($"Disponible: {notebook.EstaDisponible()}");

            Prestamo prestamo = new Prestamo(estudiante, notebook);

            Console.WriteLine("\n=== PRÉSTAMO ===");
            Console.WriteLine($"Estudiante: {estudiante.ObtenerDescripcion()}");
            Console.WriteLine($"Préstamo activo: {prestamo.Activo}");
            Console.WriteLine($"Disponible: {notebook.EstaDisponible()}");

            prestamo.Finalizar();

            Console.WriteLine("\n=== DEVOLUCIÓN ===");
            Console.WriteLine($"Préstamo activo: {prestamo.Activo}");
            Console.WriteLine($"Disponible: {notebook.EstaDisponible()}");
        }
    }
}