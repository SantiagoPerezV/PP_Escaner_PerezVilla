using PP_Escaner_PerezVillaSantiago;
using System;
using System.Text;

namespace Entidades;
public class Libro : Documento
{
    //Atributo agregado
    int numPaginas;

    //Constructor
    public Libro(string titulo, string autor, int anio, string numNormalizado, string barcode, int numPaginas)
        : base(titulo, autor, anio, numNormalizado, barcode)
    {
        this.numPaginas = numPaginas;
    }

    //Propiedades
    public int NumPaginas
    {
        get => this.numPaginas;
    }

    public string ISBN
    {
        get => this.NumNormalizado;
    }

    //Operador de sobrecarga, que nos indicara cuando un libro es igual a otro
    public static bool operator ==(Libro l1, Libro l2)
    {
        return (l1.Barcode == l2.Barcode) || (l1.ISBN == l2.ISBN) || (l1.Titulo == l2.Titulo && l1.Autor == l2.Autor);
    }

    public static bool operator !=(Libro l1, Libro l2)
    {
        return !(l1 == l2);
    }

    //Mismo metodo ToString() que en el padre pero se le agrega dos atributos cargados en Libro
    public override string ToString()
    {
        StringBuilder text = new StringBuilder();
        text.Append(base.ToString());
        text.AppendLine($"ISBN: {ISBN}\nCód. de barras: {Barcode}\nNúmero de páginas: {NumPaginas}");
        return text.ToString();
    }

}
