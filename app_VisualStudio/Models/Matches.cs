//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace app_VisualStudio.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Matches
    {
        public int ID { get; set; }
        public Nullable<int> Like_Local_ID { get; set; }
        public Nullable<int> Like_Musico_ID { get; set; }
        public Nullable<bool> Estado { get; set; }
    
        public virtual Locales Locales { get; set; }
        public virtual Musicos Musicos { get; set; }
    }
}
