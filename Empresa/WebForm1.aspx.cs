using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Empresa;

namespace Empresa
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Factura obj_factura = new Factura();
            Remisión obj_remito = new Remisión();
            ReciboSueldo obj_recibo = new ReciboSueldo();
            FacturaLuz obj_facturaLuz = new FacturaLuz();
            Impuesto obj_impuesto = new Impuesto();
            Impresora obj_impresora = new Impresora();

            obj_factura.Importe = 1500;
            obj_remito.CantBultos = 10;
            obj_recibo.Legajo = 2211;
            obj_facturaLuz.CodigoPago = "1245544589";
            obj_impuesto.Partida = "Cód. 30, 33.";

            Response.Write(obj_impresora.Imprimir(obj_factura) + "</br>");
            Response.Write(obj_impresora.Imprimir(obj_remito) + "</br>");
            Response.Write(obj_impresora.Imprimir(obj_recibo) + "</br>");
            Response.Write(obj_impresora.Imprimir(obj_facturaLuz) + "</br>");
            Response.Write(obj_impresora.Imprimir(obj_impuesto) + "</br>");

        }
    }
}