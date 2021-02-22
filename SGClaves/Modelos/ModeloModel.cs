using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGClaves.Modelos
{
   public class ModeloModel
    {
        public int IdModelo { get; set; }
        public string Nombre { get; set; }
        public byte Estatus { get; set; }
        public DateTime FechaCreacion { get; set; }

        public static ModeloModel Parse(Modelo value)
        {
            var item = new ModeloModel();
            item.Estatus = value.Estatus;
            item.FechaCreacion = value.FechaCreacion;
            item.Nombre = value.Nombre;
            item.IdModelo = value.IdModelo;
            return item;

        }
    }
}
