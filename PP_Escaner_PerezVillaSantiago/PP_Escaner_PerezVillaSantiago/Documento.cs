﻿using System.Text;

namespace PP_Escaner_PerezVillaSantiago;
public abstract class Documento
{
    public enum Paso
    {
        Inicio,
        Distribuido,
        EnEscaner,
        EnRevision,
        Terminado
    }

    //Atributos
    int anio;
    string autor;
    string barcode;
    string titulo;
    string numNormalizado;
    Paso estado;

    //Constructor
    public Documento(string titulo, string autor, int anio, string numNormalizado, string barcode)
    {
        this.anio = anio;
        this.autor = autor;
        this.barcode = barcode;
        this.titulo = titulo;
        this.numNormalizado = numNormalizado;
        this.estado = Paso.Inicio;
    }

    //Propiedades
    public int Anio
    {
        get => this.anio;
    }

    public string Autor
    {
        get => this.autor;
    }

    public string Barcode
    {
        get => this.barcode;
    }

    public Paso Estado
    {
        get => this.estado;
    }

    protected string NumNormalizado
    {
        get => this.numNormalizado;
    }

    public string Titulo
    {
        get => this.titulo;
    }

    //Método toString. Virtual ya que se sobreescribira en las clases hijas. Muestra los datos del documento menos su estado actual ni el numero normalizado
    public override string ToString()
    {
        StringBuilder text = new StringBuilder();
        text.AppendLine($"Titulo: {Titulo}\nAutor: {Autor}\nAño: {Anio}");
        return text.ToString();
    }

    //Método AvanzarEstado(): avanza el estado actual del documento si este no está terminado aún. Si está en el paso terminado retorna false, caso contrario true.
    public bool AvanzarEstado()
    {
        bool retorno = true;
        if (Estado == Paso.Terminado)
        {
            retorno = false;
        }
        else
        {
            this.estado++;
        }
        return retorno;
    }
}
