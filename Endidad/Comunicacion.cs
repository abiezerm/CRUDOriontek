using Edeeste.IRepository.Attribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    [TableName("Comunicacion")]
    public  class Comunicacion
    {
        [Ignore, Identity]
        public int IdComunicacion { get; set; }
        public string Nombre { get; set; }
        public byte Estatus { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
