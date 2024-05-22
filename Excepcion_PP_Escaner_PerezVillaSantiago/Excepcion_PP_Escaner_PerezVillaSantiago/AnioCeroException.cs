using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades;
public class AnioCeroException : Exception
{
    //Campos
    string nombreMetodo;

    //Constructor de la excepción
    public AnioCeroException(string Message, string nombreMetodo, Exception innerException)
        : base(Message, innerException)
    {
        this.nombreMetodo = nombreMetodo;
    }

    public string NombreMetodo
    {
        get => this.nombreMetodo;
    }
}
