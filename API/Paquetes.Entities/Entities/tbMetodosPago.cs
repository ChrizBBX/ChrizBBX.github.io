﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace Paquetes.Entities.Entities
{
    public partial class tbMetodosPago
    {
        public tbMetodosPago()
        {
            tbPaquetes = new HashSet<tbPaquetes>();
        }

        public int meto_ID { get; set; }
        public string meto_Nombre { get; set; }
        public DateTime? meto_FechaCreacion { get; set; }
        public int meto_UserCreacion { get; set; }
        public DateTime? meto_FechaModificacion { get; set; }
        public int? meto_UserModificacion { get; set; }
        public bool? meto_Estado { get; set; }

        public virtual tbUsuarios meto_UserCreacionNavigation { get; set; }
        public virtual tbUsuarios meto_UserModificacionNavigation { get; set; }
        public virtual ICollection<tbPaquetes> tbPaquetes { get; set; }
    }
}