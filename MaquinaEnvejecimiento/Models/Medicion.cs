using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
#pragma warning disable CS8632

namespace MaquinaEnvejecimiento.Models
{
    public class Medicion
    {
        public int ID { get; set; }
        public int MuestraID { get; set; }  
        public long TiempoEpoch { get; set; }
        public float Temperatura { get; set; }
        public float Humedad { get; set; }
        public bool Luminosidad { get; set; }

    }
}