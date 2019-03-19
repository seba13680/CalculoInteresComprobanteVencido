using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoInteresComprobanteVencido
{
    class calculaOperacion
    {
        public double MostrarCantidadMeses(double pagoImporte, DateTime pagoFechaEmision, DateTime pagoFecha)
        {

            double[,] porcentajeInteres = new double[,] { { 15, 1.5 }, { 30, 3 }, { 60, 4 }, { 99999999, 5 } };

            var cantidadDias = pagoFecha.Subtract(pagoFechaEmision).Days;
           
            if (pagoFecha <= pagoFechaEmision)
            {
                return pagoImporte;
            }

            if (cantidadDias <= 15)
            {
                return pagoImporte + (porcentajeInteres[0, 1] * pagoImporte / 100);
            }

            if (cantidadDias <= 30) {
                return pagoImporte + (porcentajeInteres[1, 1] * pagoImporte / 100);
            }
            
            if (cantidadDias <= 60)
            {
                return pagoImporte + (porcentajeInteres[2, 1] * pagoImporte / 100);
            }

            if (cantidadDias > 60)
            {
                return pagoImporte + (porcentajeInteres[3, 1] * pagoImporte / 100);
            }
            return pagoImporte;
        }
       
    }
   
}
