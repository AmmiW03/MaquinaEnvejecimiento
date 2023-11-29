using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
#pragma warning disable CS8618

namespace MaquinaEnvejecimiento.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public String Nombre { get; set; }
        public String Correo {  get; set; }
        public String Clave  { get; set; }
        public String Contraseña { get; set; }
    }
}