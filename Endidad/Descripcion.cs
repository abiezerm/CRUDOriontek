using Edeeste.IRepository.Attribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
   public class Descripcion
    {
        [Ignore, Identity]
        public int IdDescripcion { get; set; }
        public string descripcion { get; set; }
        public byte Estatus { get; set; }
        public DateTime FechaCreaion { get; set; }
    }
}
