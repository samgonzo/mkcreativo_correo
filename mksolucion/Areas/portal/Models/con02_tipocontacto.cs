﻿namespace mksolucion.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class con02_tipocontacto
    {
        [ScaffoldColumn(false)]
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal con02_id { get; set; }

        [Display(Name = "Tipo Soporte")]
        [Required(ErrorMessage = "Debe ingresar un valor para {0}")]
        [StringLength(500, ErrorMessage = "El registro {0} debe estar entre {2} y {1} caracteres", MinimumLength = 3)]
        public string con02_nombre { get; set; }

        [Display(Name = "Descripción")]
        public string con02_descripcion { get; set; }

        [Display(Name = "credencial")]
        public string con02_usuariocredencial { get; set; }

        [Display(Name = "credencial clave")]
        public string con02_usuariocredencialclave { get; set; }

        [Display(Name = "credencial host")]
        public string con02_host { get; set; }

        [Display(Name = "credencial port")]
        public string con02_port { get; set; }

        [Display(Name = "credencial ssl")]
        public int? con02_ssl { get; set; }

        [ScaffoldColumn(false)]
        [Display(Name = "Estado")]
        public int? con02_estado { get; set; }

        [ScaffoldColumn(false)]
        [Display(Name = "Fecha creación")]
        [DisplayFormat(DataFormatString = "{0:dd-mm-yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime? con02_fechacreacion { get; set; }

        [Display(Name = "Fecha Actualización")]
        [DisplayFormat(DataFormatString = "{0:dd-mm-yyyy}", ApplyFormatInEditMode = true)]
        [ScaffoldColumn(false)]
        [DataType(DataType.Date)]
        public DateTime? con02_ultimaactualizacion { get; set; }

        public virtual gen01_estados gen01_estados { get; set; }

    }
}