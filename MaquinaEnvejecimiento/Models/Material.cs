using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
#pragma warning disable CS8632


namespace MaquinaEnvejecimiento.Models
{
    public class Material
    {
        public int ID { get; set; }
        public int CategoriaID  { get; set; }
        public String Nombre { get; set; }
    }
}