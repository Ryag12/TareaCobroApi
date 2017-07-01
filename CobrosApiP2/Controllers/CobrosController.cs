using CobrosApiP2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CobrosApiP2.Controllers
{
    public class CobrosController : ApiController
    {
        Cobros[] cobro = new Cobros[]{

       new Cobros{IdCobro=1,Fecha="30/06/17",Referencia ="Rob-541222",IdRemoto=1,IdRuta=3,Mora=500,Monto=2000,Latitud=3502,Longitud=500,EsNulo=true },
       new Cobros{IdCobro=2,Fecha="28/04/17",Referencia ="Rob-541558",IdRemoto=1,IdRuta=1,Mora=500,Monto=5000,Latitud=3502,Longitud=500,EsNulo=true },
       new Cobros{IdCobro=3,Fecha="30/05/17",Referencia ="Rob-5811225",IdRemoto=1,IdRuta=4,Mora=500,Monto=6000,Latitud=3502,Longitud=500,EsNulo=true },
       new Cobros{IdCobro=4,Fecha="15/06/17",Referencia ="Rob-5851412",IdRemoto=1,IdRuta=5,Mora=500,Monto=7000,Latitud=3502,Longitud=500,EsNulo=true },
       new Cobros{IdCobro=5,Fecha="01/06/16",Referencia ="Rob-5411452",IdRemoto=1,IdRuta=6,Mora=500,Monto=6500,Latitud=3502,Longitud=500,EsNulo=true }

       };


        public IEnumerable<Cobros> GetAllCobros()
        {
            return cobro;
        }


        public IHttpActionResult GetCobros(int id)
        {
            var cobros = cobro.FirstOrDefault((c) => c.IdCobro == id);
            if (cobros != null)
            {
                return Ok(cobros);
            }
            else
            {
                return NotFound();
            }
        }
    }
}
