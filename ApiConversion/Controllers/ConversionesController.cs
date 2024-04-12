using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiConversion.Controllers
{
    public class ConversionesController : ApiController
    {
        [ActionName("MetroCM")]
        [HttpGet]
        public String MetroCM(float cantidad)
        {
            return "La convercion de "+ cantidad + " Metros es igual a: " + (cantidad * 100) + " Centimetros";
        }

        [ActionName("MetroP")]
        [HttpGet]
        public String MetroP(float cantidad)
        {
            return "La conversion de " + cantidad + "Metros es igual a: " + (cantidad * 39.3701) + " Pulgadas";
        }

        [ActionName("CentimetrosM")]
        [HttpGet]

        public String CentimetrosM(float cantidad) 
        { 
            return "La conversion de "+ cantidad + " Centimetros es igual a: " + (cantidad / 100) + " Metros";
        }

        [ActionName("CentimetrosP")]
        [HttpGet]
        public String CentimetrosP (float cantidad)
        {
            return "La conversion de "+ cantidad + "Centimetros es igual a: " + (cantidad * 0.393701) + " Pulgadas" ;
        }

        [ActionName("PulgadaCM")]
        [HttpGet]
        public String PulgadaCM(float cantidad) 
        {
            return "La conversion de " + cantidad + "pulgadas es igual a: " + (cantidad * 2.54) + " Centimetros";
        }

        [ActionName("PulgadaM")]
        [HttpGet]

        public String PulgadaM(float cantidad)
        {
            return "La conversion de " + cantidad + "Pulgadas es igual a: " + (cantidad * 0.0254) + "Metros";
        }
    }   
}
