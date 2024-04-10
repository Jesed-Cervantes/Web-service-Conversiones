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
        [ActionName("Metro")]
        [HttpGet]
        public String Metro(float cantidad)
        {
            return "La convercion de "+ cantidad + " Metro es igual a: " + (cantidad * 100) + " Centimetros";
        }

        [ActionName("Centimetros")]
        [HttpGet]

        public String Centimetros(float cantidad) 
        { 
            return "La conversion de "+ cantidad + " Centimetros es igual a: " + (cantidad / 100) + " Metros";
        } 
    }
}
