using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoInteresComprobanteVencido
{
    class Program
    {
        static void Main(string[] args)
        {
    
        var comprobante = new Comprobante();
        double diferenciaDias = comprobante.pagoFecha.Subtract(comprobante.pagoFechaEmision).Days;
        
        var calcula = new calculaOperacion();
        double cantidadMeses = calcula.MostrarCantidadMeses(comprobante.pagoImporte, comprobante.pagoFechaEmision, comprobante.pagoFecha);

        Console.WriteLine("Calcular los intereses de un comprobante vencido");
        Console.WriteLine("------------------------------------------------");
        Console.WriteLine("");
        Console.WriteLine("Fecha emision comprobante : " + comprobante.pagoFechaEmision);
        Console.WriteLine("Fecha vencimiento comprobante : " + comprobante.pagoFecha  );
        Console.WriteLine("Cantidad de dias de diferencia : " + diferenciaDias);
        Console.WriteLine("Importe comprobante : " + comprobante.pagoImporte);
        Console.WriteLine("Importe aplicando interes : " + calcula.MostrarCantidadMeses(comprobante.pagoImporte, comprobante.pagoFechaEmision, comprobante.pagoFecha));
        
        Console.ReadKey();
        }
    }
}
