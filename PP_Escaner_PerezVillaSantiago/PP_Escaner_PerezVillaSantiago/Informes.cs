using System;
using System.Text;
using PP_Escaner_PerezVillaSantiago;

namespace Entidades;
public static class Informes
{
    //Dado el escáner y el estado que le des por parámetro, deben encontrar los elementos encontrados en la lista de documentos con esas características.
    //Primero inicializo los out, luego pregunto si el escaner es de tipo libro o mapa (lo cual cambiará en la extension más tarde)
    //Luego recorro la lista de documentos, y si el estado que pidio por parámetro, es el mismo que el elemento que esta siendo recorrido ahora, le doy valor a los out
    //A la extension le sumo, ya sea la superficie o el numero de páginas depende qué sea, a la cantidad lo incremento, y al resumen le agrego el método ToString().
    private static void MostrarDocumentosPorEstado(Escaner e, Documento.Paso estado, out int extension, out int cantidad, out string resumen)
    {
        cantidad = 0;
        StringBuilder mensajeResumen = new StringBuilder();
        extension = 0;
        foreach (Documento d in e.ListaDocumentos)
            {
                if ((int)estado == (int)d.Estado)
                {
                    if(d.GetType() == typeof(Libro))
                    {
                        Libro l = (Libro)d;
                        extension += l.NumPaginas;
                    }
                    else
                    {
                        Mapa m = (Mapa)d;
                        extension += m.Superficie;
                    }
                    cantidad++;
                    mensajeResumen.Append(d.ToString());
                }
            }
            resumen = mensajeResumen.ToString();
    }

    public static void MostrarDistribuidos(Escaner e, out int extension, out int cantidad, out string resumen)
    {
        MostrarDocumentosPorEstado(e, Documento.Paso.Distribuido, out extension, out cantidad, out resumen);
    }

    public static void MostrarEnEscaner(Escaner e, out int extension, out int cantidad, out string resumen)
    {
        MostrarDocumentosPorEstado(e, Documento.Paso.EnEscaner, out extension, out cantidad, out resumen);
    }

    public static void MostrarEnRevision(Escaner e, out int extension, out int cantidad, out string resumen)
    {
        MostrarDocumentosPorEstado(e, Documento.Paso.EnRevision, out extension, out cantidad, out resumen);
    }

    public static void MostrarTerminado(Escaner e, out int extension, out int cantidad, out string resumen)
    {
        MostrarDocumentosPorEstado(e, Documento.Paso.Terminado, out extension, out cantidad, out resumen);
    }

}
