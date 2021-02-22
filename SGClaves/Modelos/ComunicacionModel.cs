using Entidad;
using SGClaves.Annotation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGClaves.Modelos
{
   public  class ComunicacionModel
    {
        [FieldName(EnableCount = true)]
        public bool Marcar { get; set; }
        [FieldName(Caption ="ID")]
        public int IdComunicacion { get; set; }
        [FieldName]
        public string Nombre { get; set; }
        [FieldName]
        public byte Estatus { get; set; }
        [FieldName]
        public DateTime FechaCreacion { get; set; }

        public static ComunicacionModel Parse(Comunicacion value)
        {
            var itemModel = new ComunicacionModel();
            itemModel.IdComunicacion= value.IdComunicacion;
            itemModel.Nombre = value.Nombre;
            itemModel.Estatus= value.Estatus;
            itemModel.FechaCreacion = value.FechaCreacion;
            return itemModel;
        }
    }

}
