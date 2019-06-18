using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SiteProfss_V01.Models.Clases
{
    public class vmEmpresa
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

        //Propiedades de Empresa

        [Required(ErrorMessage ="Debes escribir el Nomnbre de la Empresa")]
        [Display(Name ="Nombre de la Empresa")]
        public string NombreEmpresa { get; set; }




    }
}