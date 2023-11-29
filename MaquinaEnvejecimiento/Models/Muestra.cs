using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
#pragma warning disable CS8618
#pragma warning disable CS8632

namespace MaquinaEnvejecimiento.Models
{
    public class Muestra
    {
        public int ID { get; set; }
        public int MateialID { get; set; }
        public int UsuarioID { get; set; }
        public String Nombre { get; set; } 

    }
}