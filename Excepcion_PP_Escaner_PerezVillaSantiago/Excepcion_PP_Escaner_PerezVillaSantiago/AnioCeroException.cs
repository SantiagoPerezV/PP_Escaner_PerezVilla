using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades;
public class AnioCeroException : Exception
{
    //Campos
    string lugarError;

    //Constructor de la excepción
    public AnioCeroException(string Message, string lugarError, Exception innerException)
        : base(Message, innerException)
    {
        this.lugarError = lugarError;
    }

    public string LugarError
    {
        get => this.lugarError;
    }
}
