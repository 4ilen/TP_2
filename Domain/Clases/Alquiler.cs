//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Alquiler
    {
        public int ID_ALQUILER { get; set; }
        public Nullable<System.DateTime> FECHA_INICIO { get; set; }
        public Nullable<System.DateTime> FECHA_DEVOLUCION { get; set; }
        public Nullable<int> CODIGO { get; set; }
        public Nullable<int> ID_DETALLE_ALQUILER { get; set; }
    
        public virtual DETALLE_ALQUILER DETALLE_ALQUILER { get; set; }
    }
}