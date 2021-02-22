using Edeeste.IRepository.Attribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    [TableName("[dbo].[Condicion_Prueba]")]
    public   class CondicionPrueba
    {
        [Ignore, Identity]
        public int IdCondicionPrueba { get; set; }
        public string Descripcion { get; set; }
        public byte Estatus { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
