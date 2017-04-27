namespace mksolucion.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class lis02_clasificacion
    {
        [ScaffoldColumn(false)]
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal? lis02_id { get; set; }

        [Display(Name = "Tipo Lista")]
        [StringLength(500, ErrorMessage = "El registro {0} debe estar entre {2} y {1} caracteres", MinimumLength = 3)]
        [Required(ErrorMessage = "Debe ingresar un valor para {0}")]
        
        public string lis02_nombre { get; set; }

        [Display(Name = "Descripción")]
        public string lis02_descripcion { get; set; }

        [ScaffoldColumn(false)]
        [Display(Name = "Estado")]
        public int? lis02_estado { get; set; }

        [ScaffoldColumn(false)]
        [Display(Name = "Fecha creación")]
        [DisplayFormat(DataFormatString = "{0:dd-mm-yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime? lis02_fechacreacion { get; set; }

        [Display(Name = "Fecha Actualización")]
        [DisplayFormat(DataFormatString = "{0:dd-mm-yyyy}", ApplyFormatInEditMode = true)]
        [ScaffoldColumn(false)]
        [DataType(DataType.Date)]
        public DateTime? lis02_ultimaactualizacion { get; set; }

        public virtual gen01_estados gen01_estados { get; set; }
    }
}
