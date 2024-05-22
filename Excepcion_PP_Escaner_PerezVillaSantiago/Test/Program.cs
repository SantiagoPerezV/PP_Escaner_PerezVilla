using Entidades;
namespace Test;

internal class Program
{
    static void Main(string[] args)
    {
        //Pruebo la excepción, que intente crearme un libro el cual tenga como año un numero negativo.
        //Si encuentra AnioCeroException que me escriba por consola el mensaje y el nombre de la excepción.
        try
        {
            Libro libro1 = new Libro("Rayuela", "Cortazar", -21, "752", "65", 20);
        }
        catch (AnioCeroException ac)
        {
            Console.WriteLine($"ERROR: {ac.Message} Producido en {ac.NombreMetodo}");
        }
    }
}
