using System;
namespace APIRETO4.Models
{
    public class Empleado
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public int Restaurante_id {get; set;}
        public string imagen {get; set;}

    }
}
