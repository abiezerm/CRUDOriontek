using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGClaves.Modelos
{
 public   class CondicionModel
    {
        public int IdCondicion { get; set; }
        public string Nombre { get; set; }
        public byte Estatus { get; set; }
        public DateTime FechaCreacion { get; set; }

        public static CondicionModel Parse(Condicion entidad)
        {
            var item = new CondicionModel();
            item.Nombre = entidad.Nombre;
            item.Estatus = entidad.Estatus;
            item.FechaCreacion = entidad.FechaCreacion;
            item.IdCondicion = entidad.IdCondicion;

            return item;
        }
    }
}
