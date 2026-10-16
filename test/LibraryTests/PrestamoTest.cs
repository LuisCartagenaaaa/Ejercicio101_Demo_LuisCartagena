using NUnit.Framework;
using Ucu.Poo.Ejercicio101;

namespace Ucu.Poo.Ejercicio101.Tests;

public class PrestamoTests
{
    [Test]
    public void Prestamo_WhenEquipoDisponible_MarcaEquipoNoDisponible()
    {
        Estudiante estudiante = new Estudiante("Ana", "11111111");
        Equipo equipo = new Equipo("NB001", "Notebook");

        Prestamo prestamo = new Prestamo(estudiante, equipo);

        Assert.That(prestamo.Activo, Is.True);
        Assert.That(equipo.EstaDisponible(), Is.False);
    }
}