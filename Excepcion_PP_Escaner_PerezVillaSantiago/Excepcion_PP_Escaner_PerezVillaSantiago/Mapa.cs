using Excepcion_PP_Escaner_PerezVillaSantiago;
using System;
using System.Text;

namespace Entidades;
public class Mapa : Documento
{
    //Atributos agregados
    int ancho;
    int alto;

    //Constructor
    public Mapa(string titulo, string autor, int anio, string numNormalizado, string barcode, int ancho, int alto)
        : base(titulo, autor, anio, numNormalizado, barcode)
    {
        this.ancho = ancho;
        this.alto = alto;
    }

    //Propiedades
    public int Ancho
    {
        get => this.ancho;
    }

    public int Alto
    {
        get => this.alto;
    }

    public int Superficie
    {
        get => Ancho * Alto;
    }

    //Sobrecarga de operador igual que nos indicará cuando un mapa es igual a otro
    public static bool operator ==(Mapa m1, Mapa m2)
    {
        return (m1.Barcode == m2.Barcode) || (m1.Titulo == m2.Titulo && m1.Autor == m2.Autor && m1.Anio == m2.Anio && m1.Superficie == m2.Superficie);
    }

    public static bool operator !=(Mapa m1, Mapa m2)
    {
        return !(m1 == m2);
    }

    //Mismo método ToString() que el padre, pero se le agrega la Superficie la cual es exclusivo de la clase derivada Mapa
    public override string ToString()
    {
        StringBuilder text = new StringBuilder();
        text.Append(base.ToString());
        text.AppendLine($"Cód. de barras: {Barcode}\nSuperficie: {Ancho} * {Alto} = {Superficie} cm2");
        return text.ToString();
    }

}
