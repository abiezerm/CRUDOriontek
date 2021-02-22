using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGClaves.Modelos
{
   public class CondicionPruebaModel
    {
        public int IdCondicionPrueba { get; set; }
        public string Descripcion { get; set; }
        public byte Estatus { get; set; }
        public DateTime FechaCreacion { get; set; }

        public static CondicionPruebaModel Parse(CondicionPrueba entidad)
        {
            var item = new CondicionPruebaModel();
            item.Descripcion = entidad.Descripcion;
            item.Estatus = entidad.Estatus;
            item.FechaCreacion = entidad.FechaCreacion;
            item.IdCondicionPrueba = entidad.IdCondicionPrueba;

            return item;

        }
    }
}
