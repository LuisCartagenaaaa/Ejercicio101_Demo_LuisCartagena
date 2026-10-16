namespace Ucu.Poo.Ejercicio101;

public class Equipo
{
    public string Codigo { get; private set; }
    public string Nombre { get; private set; }
    public bool Disponible { get; private set; }

    public Equipo(string codigo, string nombre)
    {
        Codigo = codigo;
        Nombre = nombre;
        Disponible = true;
    }

    public bool EstaDisponible() => Disponible;

    public void Prestar()
    {
        Disponible = false;
    }

    public void Devolver()
    {
        Disponible = true;
    }
}