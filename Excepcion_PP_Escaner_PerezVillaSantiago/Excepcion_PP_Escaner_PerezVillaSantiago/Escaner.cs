using System;
using System.Text;
using Excepcion_PP_Escaner_PerezVillaSantiago;
namespace Entidades;

public class Escaner
{
    //Enums
    public enum Departamento
    {
        nulo,
        mapoteca,
        procesosTecnicos
    }

    public enum TipoDoc
    {
        libro,
        mapa
    }

    //Atributos
    List<Documento> listaDocumentos;
    Departamento locacion;
    string marca;
    TipoDoc tipo;

    //Constructor. se inicializa la lista de tipos Documento y la locacion dependerá de que tipo de documento sea. Si es libro va a procesos tecnicos y casos contrario va a la mapoteca.
    public Escaner(string marca, TipoDoc tipo)
    {
        this.marca = marca;
        this.tipo = tipo;
        this.listaDocumentos = new List<Documento>();
        this.locacion = tipo == TipoDoc.libro ? Departamento.procesosTecnicos : Departamento.mapoteca;
    }

    //Propiedades
    public List<Documento> ListaDocumentos
    {
        get => this.listaDocumentos;
    }

    public Departamento Locacion
    {
        get => this.locacion;
    }

    public string Marca
    {
        get => this.marca;
    }

    public TipoDoc Tipo
    {
        get => this.tipo;
    }

    //Sobrecarga de operadores
    //Sobrecarga de igualdad: un escaner es igual al documento cuando existe ya uno igual dentro de la lista de documentos.
    public static bool operator ==(Escaner e, Documento d)
    {
        bool retorno = false;

        foreach (Documento doc in e.ListaDocumentos)
        {
            if (doc == d)
            {
                retorno = true;
            }
        }

        return retorno;

    }

    //Sobrecarga de desigualdad: contrario al de igualdad
    public static bool operator !=(Escaner e, Documento d)
    {
        return !(e == d);
    }

    //Sobrecarga de suma: Si el documento pasado no se encuentra ya en la lista de documentos y se encuentra en el estado de Inicio, entra a la otra validación que es si el documento y el escaner son del mismo tipo. Si pasa las validaciones, se agrega a esta lista, se avanza al estado Distribuido y retorna true. Si no pasa las validaciones, retorna false
    public static bool operator +(Escaner e, Documento d)
    {
        bool retorno = false;
        if (e != d && d.Estado == Documento.Paso.Inicio)
        {
            //Validar si es un escaner de mapas y si el documento es un mapa, o si tipo de escaner es igual a libro y si el tipo de documento es un libro
            if ((e.Tipo == Escaner.TipoDoc.mapa && d.GetType() == typeof(Mapa)) || (e.Tipo == Escaner.TipoDoc.libro && d.GetType() == typeof(Libro)))
            {
                d.AvanzarEstado();
                e.listaDocumentos.Add(d);
                retorno = true;
            }
        }
        return retorno;
    }

    //CambiarEstadoDocumento() avanza el estado de un documento si este está dentro de la listaDocumentos. Sino devuelve false.
    public bool CambiarEstadoDocumento(Documento d)
    {
        bool retorno = false;
        if (this.ListaDocumentos.Contains(d)) //.Contains determina si un elemento se encuentra en la lista. True si está, false si no.
        {
            d.AvanzarEstado();
            retorno = true;
        }
        return retorno;
    }

}
