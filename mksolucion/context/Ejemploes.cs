namespace mksolucion.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Ejemploes
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string description { get; set; }

        public decimal price { get; set; }

        public DateTime Dateupdate { get; set; }
    }
}
