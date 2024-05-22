using Entidades;
using Microsoft.Win32.SafeHandles;
using PP_Escaner_PerezVillaSantiago;
namespace Test;
internal class Program
{
    static void Main(string[] args)
    {
        //Instancias de clases / Creacion de objetos

        Libro libro1 = new Libro("Harry Potter", "JK Rowling", 2024, "123", "123", 24);
        Libro libro2 = new Libro("Diario de un naufragio", "Gabriel Garcia Marquez", 2007, "256", "123", 106);
        Libro libro3 = new Libro("Harry Potter", "JK Rowling", 2007, "223", "125", 369);
        Libro libro4 = new Libro("Divina Comedia", "Dante Alighieri", 2007, "215", "127", 780);
        Libro libro5 = new Libro("Sherlock Holmes", "Connan Doyle", 2007, "652", "129", 240);
        Libro libro6 = new Libro("El Mastín de los Baskerville", "Connan Doyle", 2007, "652", "1232", 201);

        Mapa mapa1 = new Mapa("Francia", "Alberto", 1891, "9090", "789", 50, 40);
        Mapa mapa2 = new Mapa("America", "Americo", 1492, "569", "456", 30, 100);
        Mapa mapa3 = new Mapa("Francia", "Alberto", 1891, "741", "698", 50, 40);
        Mapa mapa4 = new Mapa("Argentina", "Mario", 1910, "905", "789", 100, 46);


        Escaner escanerlibro = new Escaner("Philips", Escaner.TipoDoc.libro);
        Escaner escanermapa = new Escaner("Samsung", Escaner.TipoDoc.mapa);

                                                //*********************     PRUEBAS   *********************
                                                    ////*******   DOCUMENTO: AvanzarEstado()   *******
        //Console.WriteLine(libro1.AvanzarEstado());
        //Console.WriteLine(libro1.Estado);
        //libro1.AvanzarEstado();
        //libro1.AvanzarEstado();
        //libro1.AvanzarEstado();
        ////Ya está terminado
        //Console.WriteLine(libro1.AvanzarEstado());
        //Console.WriteLine(libro1.Estado);


                                                    ////*******  LIBRO: ToString(), sb==  *******
        //Console.WriteLine(libro2.ToString());
        ////sb== true
        //Console.WriteLine(libro1 == libro2);
        //Console.WriteLine(libro5 == libro6);
        //Console.WriteLine(libro1 == libro3);
        ////sb== false
        //Console.WriteLine(libro1 == libro4);


                                                    ////*******  MAPA: ToString(), sb==  *******
        //Console.WriteLine(mapa2.ToString());
        ////sb== true
        //Console.WriteLine(mapa1 == mapa3);
        //Console.WriteLine(mapa1 == mapa4);
        ////sb== false
        //Console.WriteLine(mapa1 == mapa2);


                                                ////*******  ESCANER:CambiarEstadoDocumento() sb== y +  *******
        ////Agrega a la lista
        Console.WriteLine(escanerlibro + libro1);
        Console.WriteLine(escanerlibro + libro3);
        Console.WriteLine(escanerlibro + libro4);
        Console.WriteLine(escanerlibro + libro5);
        Console.WriteLine(escanerlibro + libro6);
        Console.WriteLine(escanermapa + mapa1);
        Console.WriteLine(escanermapa + mapa2);
        Console.WriteLine(escanermapa + mapa3);
        Console.WriteLine(escanermapa + mapa4);

        ////Validaciones erroneas
        //libro2.AvanzarEstado();
        //Console.WriteLine(escanerlibro + libro2); //libro2 no esta en Estado Inicio
        //Console.WriteLine(escanermapa + libro3); //escaner y documento de distinto tipo
        //Console.WriteLine(escanerlibro + libro1); //ya fue agregado

        escanerlibro.CambiarEstadoDocumento(libro1);
        //Console.WriteLine(libro1.Estado);
        //Console.WriteLine(mapa3.Estado);
        escanermapa.CambiarEstadoDocumento(mapa3);
        //Console.WriteLine(mapa3.Estado);
        escanermapa.CambiarEstadoDocumento(mapa3);
        escanermapa.CambiarEstadoDocumento(mapa3);
        //Console.WriteLine(escanermapa.CambiarEstadoDocumento(mapa3));
        //Console.WriteLine(mapa3.Estado);

        ////Validacion erronea
        //Console.WriteLine(escanerlibro.CambiarEstadoDocumento(mapa2)); //Distintos tipos
        //Console.WriteLine(escanermapa.CambiarEstadoDocumento(libro3)); //Distintos tipos
        //Console.WriteLine(escanerlibro.CambiarEstadoDocumento(libro2)); //No está dentro de la lista


                                                    ////*******  INFORMES: MostrarDocumentosPorEstado()  *******
        //escanermapa.CambiarEstadoDocumento(mapa4);
        //escanermapa.CambiarEstadoDocumento(mapa4);

        //escanerlibro.CambiarEstadoDocumento(libro4);
        //escanerlibro.CambiarEstadoDocumento(libro4);
        //escanerlibro.CambiarEstadoDocumento(libro4);
        //escanerlibro.CambiarEstadoDocumento(libro5);
        //escanerlibro.CambiarEstadoDocumento(libro6);
        //escanerlibro.CambiarEstadoDocumento(libro6);

        //Informes.MostrarDistribuidos(escanerlibro, out int extDis, out int cantDis, out string resumenDis);
        //Console.WriteLine($"Extensión de distribuidos: {extDis}\nCantidad de distribuidos: {cantDis}\nResumen de distribuidos: {resumenDis}\n");
        //Informes.MostrarEnEscaner(escanerlibro, out int extEsc, out int cantEsc, out string resumenEsc);
        //Console.WriteLine($"Extensión de EnEscaner: {extEsc}\nCantidad de EnEscaner: {cantEsc}\nResumen de EnEscaner: {resumenEsc}\n");
        //Informes.MostrarEnRevision(escanerlibro, out int extRev, out int cantRev, out string resumenRev);
        //Console.WriteLine($"Extensión de EnRevision: {extRev}\nCantidad de EnRevision: {cantRev}\nResumen de EnRevision: {resumenRev}\n");
        //Informes.MostrarTerminado(escanerlibro, out int extTer, out int cantTer, out string resumenTer);
        //Console.WriteLine($"Extensión de Terminados: {extTer}\nCantidad de Terminados: {cantTer}\nResumen de Terminados: {resumenTer}\n");

        //Informes.MostrarDistribuidos(escanermapa, out int extDis, out int cantDis, out string resumenDis);
        //Console.WriteLine($"Extensión de distribuidos: {extDis}\nCantidad de distribuidos: {cantDis}\nResumen de distribuidos: {resumenDis}\n");
        //Informes.MostrarEnEscaner(escanermapa, out int extEsc, out int cantEsc, out string resumenEsc);
        //Console.WriteLine($"Extensión de EnEscaner: {extEsc}\nCantidad de EnEscaner: {cantEsc}\nResumen de EnEscaner: {resumenEsc}\n");
        //Informes.MostrarEnRevision(escanermapa, out int extRev, out int cantRev, out string resumenRev);
        //Console.WriteLine($"Extensión de EnRevision: {extRev}\nCantidad de EnRevision: {cantRev}\nResumen de EnRevision: {resumenRev}\n");
        //Informes.MostrarTerminado(escanermapa, out int extTer, out int cantTer, out string resumenTer);
        //Console.WriteLine($"Extensión de Terminados: {extTer}\nCantidad de Terminados: {cantTer}\nResumen de Terminados: {resumenTer}\n");

    }
}