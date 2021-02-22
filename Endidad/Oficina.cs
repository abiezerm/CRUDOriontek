using Edeeste.IRepository.Attribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidad
{
    public class Oficina
    {
        [Ignore, Identity]
        public int Id { get; set; }
        public string IdOficina { get; set; }
        public string NbrOficina { get; set; }
        public int Status { get; set; }
    }
}
