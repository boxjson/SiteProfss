using SiteProfss_v01.Models.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
namespace SiteProfss_v01.Models.Clases
{
    public class vmSolicitud
    {
        //Propiedades de Usuario
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Debe escribir un Comentario")]
        [Display(Name = "Comentarios del Solicitante")]
        public string ComentariosSolicitante { get; set; }


        [Required(ErrorMessage = "Debe escribir un Comentario")]
        [Display(Name = "Comentarios de la Empresa")]
        public string ComentariosEmpresa { get; set; }



        [Display(Name = "Visto por la Empresa")]
        public bool VistaEmpresa { get; set; }
        

        [DataType(DataType.Date)]
        [Display(Name = "fecha de la Vista")]
        public DateTime FechaVista { get; set; }


        
        public int SolicitanteId { get; set; }

        public virtual Solicitante Solicitante { get; set; }


       
        public int OfertaId { get; set; }
        public virtual Oferta Oferta { get; set; }


    }
}