//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Modelos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Cultos
    {
        public int Id { get; set; }
        public System.DateTime DataCulto { get; set; }
        public string HorarioCulto { get; set; }
        public string LocalCulto { get; set; }
        public string PastorCulto { get; set; }

        [ForeignKey("Pastores")]
        public int PastoresId { get; set; }

        [ForeignKey("Igrejas")]
        public int Igrejas_ID { get; set; }

        public virtual Igrejas Igrejas { get; set; }
        public virtual Pastores Pastores { get; set; }
    }
}
