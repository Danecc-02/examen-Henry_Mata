using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace examenHenryMata.Models
{
    public class Identificacion
    {
        [Key]
        public int IdentificacionId { get; set; }

        [Display(Name = "Codigo")]
        [Required(ErrorMessage = "El codigo es obligatorio")]
        
       
       
        public string IdentificacionCodigo { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")] ///
        [StringLength(20, ErrorMessage ="Muchos Caracteres")]
        [MinLength(2, ErrorMessage ="Pocos Caracteres")]
        [Display(Name = "Apellido")]

        public string IdentificacionApellido { get; set; }
        [Display(Name = "Nombres")]
        [StringLength(20, ErrorMessage = "Muchos Caracteres")] ///
        [MinLength(2, ErrorMessage = "Pocos Caracteres")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
      




        public string IdentificacionNombres { get; set; }
        [Display(Name = "Apodo")]
        [StringLength(20, ErrorMessage = "Muchos Caracteres")]  //
        [MinLength(2, ErrorMessage = "Pocos Caracteres")]



        public string IdentificacionApodo { get; set; }
        [Display(Name = "Direccion")]
        [StringLength(50, ErrorMessage = "Muchos Caracteres")]  
        [MinLength(2, ErrorMessage = "Pocos Caracteres")]
        



        public string IdentificacionDireccion { get; set; }
        [Display(Name = "Codigo Postal")]
       




        public int IdentificacionCodigoPostal { get; set; }
        [Display(Name = "Telefono")]
        
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public int IdentificacionTelefono { get; set; }
        [Display(Name = "Celular")]
       


        [Required(ErrorMessage = "Este campo es obligatorio")]
        public int IdentificacionCelular { get; set; }
        [Display(Name = "Fax")]
      
        [Required(ErrorMessage = "Este campo es obligatorio")]



        public string IdentificacionFax { get; set; }
        [Display(Name = "Email")]
        
        [Required(ErrorMessage = "Este campo es obligatorio")]

        public string IdentificacionEmail { get; set; }
        [Display(Name = "Observaciones")]
      


        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string observaciones { get; set; }
    }
}
