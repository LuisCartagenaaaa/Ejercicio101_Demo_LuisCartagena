namespace Ucu.Poo.Ejercicio101;

public class Prestamo
{
    public Estudiante Estudiante { get; private set; }
    public Equipo Equipo { get; private set; }
    public bool Activo { get; private set; }

    public Prestamo(Estudiante estudiante, Equipo equipo)
    {
        Estudiante = estudiante;
        Equipo = equipo;

        if (equipo.EstaDisponible())
        {
            equipo.Prestar();
            Activo = true;
        }
    }

    public void Finalizar()
    {
        if (Activo)
        {
            Equipo.Devolver();
            Activo = false;
        }
    }
}