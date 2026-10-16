namespace Ucu.Poo.Ejercicio101;

public class Estudiante
{
    public string Nombre { get; private set; }
    public string Documento { get; private set; }

    public Estudiante(string nombre, string documento)
    {
        Nombre = nombre;
        Documento = documento;
    }

    public string ObtenerDescripcion()
    {
        return $"{Nombre} - {Documento}";
    }
}