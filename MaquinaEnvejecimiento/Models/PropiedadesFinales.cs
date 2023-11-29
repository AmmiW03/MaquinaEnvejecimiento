#pragma warning disable CS8632

namespace MaquinaEnvejecimiento.Models
{
    public class PropiedadesFinales
    {
        public int ID { get; set; }
        public int MuestraID { get; set; }
        public float Tension { get; set; }
        public float Compresion { get; set; }
        public float Corte { get; set; }
        public float Torsion { get; set; }
        public float Flexion { get; set; }
    }
}
