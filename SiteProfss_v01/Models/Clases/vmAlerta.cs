using SiteProfss_v01.Models.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SiteProfss_v01.Models.Clases
{
    public class vmAlerta
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage="Debe escribir un Parametro" )]
        [Display (Name= "Palabras Claves")]
        public string Parametro { get; set; }

        public DateTime FechaCreacion { get; set; }

        public bool Activa { get; set; }


        public int SolicitanteId { get; set; }

        public virtual Solicitante Solicitante { get; set; }


        [Required(ErrorMessage = "Debe seleccionar una Categoria")]
        [Display(Name = "Categoria")]
        public int CategoriaId { get; set; }

        public virtual Categoria Categoria { get; set; }

        [Required(ErrorMessage = "Debe Seleccionar un Departamento")]
        [Display(Name = "Departamento")]
        public int DepartamentoId { get; set; }

        public virtual Departamento Departamento { get; set; }

    }
}