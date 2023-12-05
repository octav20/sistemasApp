using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemasApp.Models
{
    public class ProveedorModel
    {

        private int id;
        private string nombre;
        private string apellido;
        private string email;
        private string fechaNac;
        private string telefono;
        private string direccion;
        private string latitud;
        private string longitud;

        [DisplayName("Proveedor ID")]
        public int Id { get => id; set => id = value; }
        [DisplayName("Nombre Proveedor")]
        [Required(ErrorMessage = "El nombre del Proveedor es requerido")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El nombre debe contener entre 3-50 caracteres")]
        public string Nombre { get => nombre; set => nombre = value; }
        [DisplayName("Apellido Proveedor")]
        [Required(ErrorMessage = "El apellido del Proveedor es requerido")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El apellido debe contener entre 3-50 caracteres")]
        public string Apellido { get => apellido; set => apellido = value; }
        [DisplayName("Email Proveedor")]
        [Required(ErrorMessage = "El email del Proveedor es requerido")]
        // [EmailAddress(ErrorMessage = "El formato del correo electrónico no es válido.")]
        public string Email { get => email; set => email = value; }

        /*   [DisplayName("Fecha de nacimiento Proveedor")]
           [DataType(DataType.Date)]
           [Required(ErrorMessage = "La fecha de nacimiento del Proveedor es requerida")]
           public string FechaNac { get => fechaNac; set => fechaNac = value; }*/
        [DisplayName("Telefono Proveedor")]
        [Required(ErrorMessage = "El telefono del Proveedor es requerido")]
        [StringLength(50, MinimumLength = 10, ErrorMessage = "El telefono debe contener entre 10-50 caracteres")]
        public string Telefono { get => telefono; set => telefono = value; }
        [DisplayName("Direccion Proveedor")]
        [Required(ErrorMessage = "La direccion del Proveedor es requerida")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "La direccion debe contener entre 5-50 caracteres")]
        public string Direccion { get => direccion; set => direccion = value; }
        [DisplayName("Latitud Proveedor")]
        [Required(ErrorMessage = "La latitud del Proveedor es requerida")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "La latitud debe contener entre 3-50 caracteres")]
        public string Latitud { get => latitud; set => latitud = value; }
        [DisplayName("Longitud Proveedor")]
        [Required(ErrorMessage = "La longitud del Proveedor es requerida")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "La longitud debe contener entre 3-50 caracteres")]
        public string Longitud { get => longitud; set => longitud = value; }
    }
}
