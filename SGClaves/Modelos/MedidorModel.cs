using Entidad;
using SGClaves.Annotation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGClaves.Modelos
{
   public class MedidorModel
    {
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

    public class TipoMedidorModel
    {
        [FieldName(Caption ="Id")]
        public int IdTipoMedidor { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        [FieldName(Caption = "Tamaño Clave")]
        public int Tamaño_Clave { get; set; }
        public byte UltimaClave { get; set; }
        public string Estatus { get; set; }


        public static TipoMedidorModel Parse(TipoMedidor value)
        {
            var iten =new  TipoMedidorModel();
            iten.Nombre = value.Nombre;
            iten.Descripcion = value.Descripcion;
            iten.Tamaño_Clave = value.tamano_clave;
            iten.Estatus = value.Estatus;
            iten.IdTipoMedidor = value.IDtipomedidor;
            return iten;
        }
    }
}
