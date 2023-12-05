using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace sistemasApp.Models
{
    public class ClienteModel
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

        [DisplayName("Cliente ID")]
        public int Id { get => id; set => id = value; }
        [DisplayName("Nombre Cliente")]
        [Required(ErrorMessage ="El nombre del cliente es requerido")]
        [StringLength(50, MinimumLength =3, ErrorMessage ="El nombre debe contener entre 3-50 caracteres")]
        public string Nombre { get => nombre; set => nombre = value; }
        [DisplayName("Apellido Cliente")]
        [Required(ErrorMessage = "El apellido del cliente es requerido")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El apellido debe contener entre 3-50 caracteres")]
        public string Apellido { get => apellido; set => apellido = value; }
        [DisplayName("Email Cliente")]
        [Required(ErrorMessage = "El email del cliente es requerido")]
       // [EmailAddress(ErrorMessage = "El formato del correo electrónico no es válido.")]
        public string Email { get => email; set => email = value; }

     /*   [DisplayName("Fecha de nacimiento Cliente")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "La fecha de nacimiento del cliente es requerida")]
        public string FechaNac { get => fechaNac; set => fechaNac = value; }*/
        [DisplayName("Telefono Cliente")]
        [Required(ErrorMessage = "El telefono del cliente es requerido")]
        [StringLength(50, MinimumLength = 10, ErrorMessage = "El telefono debe contener entre 10-50 caracteres")]
        public string Telefono { get => telefono; set => telefono = value; }
        [DisplayName("Direccion Cliente")]
        [Required(ErrorMessage = "La direccion del cliente es requerida")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "La direccion debe contener entre 5-50 caracteres")]
        public string Direccion { get => direccion; set => direccion = value; }
        [DisplayName("Latitud Cliente")]
        [Required(ErrorMessage = "La latitud del cliente es requerida")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "La latitud debe contener entre 3-50 caracteres")]
        public string Latitud { get => latitud; set => latitud = value; }
        [DisplayName("Longitud Cliente")]
        [Required(ErrorMessage = "La longitud del cliente es requerida")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "La longitud debe contener entre 3-50 caracteres")]
        public string Longitud { get => longitud; set => longitud = value; }
    }
}
