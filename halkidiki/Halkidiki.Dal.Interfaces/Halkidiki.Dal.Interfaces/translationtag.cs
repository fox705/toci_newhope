//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Halkidiki.Dal.Interfaces
{
    using System;
    using System.Collections.Generic;
    
    public partial class translationtag
    {
        public int id { get; set; }
        public string tag { get; set; }
        public int idword { get; set; }
    
        public virtual word word { get; set; }
    }
}
