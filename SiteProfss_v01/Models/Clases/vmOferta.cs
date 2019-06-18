using SiteProfss_v01.Models.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SiteProfss_v01.Models.Clases
{
    public class vmOferta
    {
        [Key]
        public int Id { get; set; }


        [Required(ErrorMessage = "Debe escribir un titulo")]
        //[StringLength(100, ErrorMessage = "El número de caracteres de {0} debe ser al menos {2}.", MinimumLength = 1)]
        public string Titulo { get; set; }


        [Required(ErrorMessage = "Debe escribir una descripción")]
        //[StringLength(250, ErrorMessage = "El número de caracteres de {0} debe ser al menos {2}.", MinimumLength = 1)]
        [DataType(DataType.MultilineText)]
        public string Descripcion { get; set; }



        [Display(Name ="Fecha de publicación")]
        public DateTime FechaPublicacion { get; set; }



        [Required(ErrorMessage = "Debe escribir el area laboral")]
        //[StringLength(30, ErrorMessage = "El número de caracteres de {0} debe ser al menos {2}.", MinimumLength = 1)]
        [Display(Name = "Area laboral")]
        public string AreaLaboral { get; set; }


        [Required(ErrorMessage = "Debe especificar si al menos habra una vacante")]
        [Display(Name = "Cantidad de vacantes")]
        public int CantidadVacantes { get; set; }


        [Required(ErrorMessage = "Esta campo no puede estar vacio")]
        [Display(Name = "Habiliades requeridas")]
        //[StringLength(200, ErrorMessage = "El número de caracteres de {0} debe ser al menos {2}.", MinimumLength = 1)]
        public string HabilidadesRequeridas { get; set; }


        [Required(ErrorMessage = "Debe escribir desde que edad pueden aplicar")]
        [Display(Name = "Edad desde")]
        public int EdadDesde { get; set; }


        [Required(ErrorMessage = "Debe escribir hasta que edad pueden aplicar")]
        [Display(Name = "Edad hasta")]
        public int EdadHasta { get; set; }


        [Display]
        public bool Remuneracion { get; set; }


        [Display(Name = "Transporte")]
        public bool TransporteRecorrido { get; set; }


        [Required(ErrorMessage = "Debe seleccionar una fecha limite de solicitud")]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha limite")]
        public DateTime FechaLimiteSolicitud { get; set; }



        [Required(ErrorMessage = "Debe seleccionar una Categoria")]
        [Display(Name = "Categoria")]
        public int CategoriaId { get; set; }


        public virtual Categoria Categoria { get; set; }


        [Required(ErrorMessage = "Debe seleccionar un Departamento")]
        [Display(Name = "Departamento/Ubicación")]
        public int DepartamentoId { get; set; }


        public virtual Departamento Departamento { get; set; }


        [Required(ErrorMessage = "Debe seleccionar un Tiempo de contratación")]
        [Display(Name = "Tiempo de contratación")]
        public int TiempoContratacionId { get; set; }

        [Display(Name = "Tiempo de contratación")]
        public TiempoContratacion TiempoContratacion { get; set; }

    }
}