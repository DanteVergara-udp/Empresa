using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Empresa
{
    public class Impresora
    {
        public string Imprimir (Factura obj_factura)
        {
            return "Imprimiendo una factura de $" + obj_factura.Importe;
        }

        public string Imprimir (Remisión obj_remito)
        {
            return "Imprimiendo Comprobante de Remisión con " + obj_remito.CantBultos + " bultos";
        }

        public string Imprimir (ReciboSueldo obj_recibo)
        {
            return "Imprimiendo recibo de sueldo del legajo " + obj_recibo.Legajo;
        }

        public string Imprimir (Impuesto obj_impuesto)
        {
            return "Imprimiendo total de la partida " + obj_impuesto.Partida;
        }

        public string Imprimir (FacturaLuz obj_facturaLuz)
        {
            return "Imprimiendo la factura de luz de codigo de pago electrónico " + obj_facturaLuz.CodigoPago;
        }

    }
}