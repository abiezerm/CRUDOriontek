using Edeeste.IRepository.Attribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Medidor
    {
        [Ignore, Identity]
        public int IdMedidor { get; set; }
        public string Serie { get; set; }
        public int IdDepartamento { get; set; }
        public int IdCondicion { get; set; }
        public int IdMarca { get; set; }
        public int IdModelo { get; set; }
        public int IdTiposdeComunicacion { get; set; }
        public int IdTipoMedidor { get; set; }
        public DateTime FechaCreacion { get; set; } 
        public int IdDescripcion { get; set; }
        public byte Estatus { get; set; }
        public string DireccComunicacion { get; set; }
    }
    [TableName("[dbo].[Tipo_Medidor]")]
    public class TipoMedidor
    {
        [Ignore, Identity]
        public int IDtipomedidor { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int tamano_clave { get; set; }
        public byte utiliza_clave { get; set; }
        public string Estatus { get; set; }

    }
}
