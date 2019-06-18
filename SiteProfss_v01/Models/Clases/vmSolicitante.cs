using SiteProfss_v01.Models.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SiteProfss_v01.Models.Clases
{
    public class vmSolicitante
    {

        //Propiedades de Usuario
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Debes escribir un Correo Electronico")]
        [EmailAddress]
        [Display(Name = "Correo electrónico")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Debes escribir una Contraseña")]
        [StringLength(100, ErrorMessage = "El número de caracteres de {0} debe ser al menos {2}.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Contraseña")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Debes confirmar tu Contraseña")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirmar contraseña")]
        [System.ComponentModel.DataAnnotations.Compare("Password", ErrorMessage = "La contraseña y la contraseña de confirmación no coinciden.")]
        public string ConfirmPassword { get; set; }

        //Propiedades de Solicitante

        [Required(ErrorMessage = "Debes escribir tu Numero de Cedula")]
        [Display(Name = "N° Cedula")]
        public string NumeroCedula { get; set; }


        [Required(ErrorMessage = "Debes escribir al menos un Nombre")]
        [StringLength(50, ErrorMessage = "El número de caracteres de {0} debe ser al menos {2}.", MinimumLength = 3)]
        public string Nombres { get; set; }

        [Required(ErrorMessage = "Debes escribir al menos un Apellido")]
        [StringLength(50, ErrorMessage = "El número de caracteres de {0} debe ser al menos {2}.", MinimumLength = 3)]
        public string Apellidos { get; set; }


        [Required(ErrorMessage ="Debes seleccionar tu Fecha de Nacimiento")]
        [DataType(DataType.Date)]
        public DateTime FechaNacimiento { get; set; }


        [Required(ErrorMessage = "Debes seleccionar tu Sexo")]
        [Display(Name = "Sexo")]
        public int SexoId { get; set; }

        [Display(Name = "Sexo")]
        public virtual Sexo Sexo { get; set; }


        [Required(ErrorMessage = "Debes seleccionar tu Año Academico")]
        [Display(Name = "Año Academico")]
        public int AnioAcademicoId { get; set; }

        [Display(Name = "Año Academico")]
        public virtual AnioAcademico AnioAcademico { get; set; }
        
    }
}