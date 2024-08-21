using Microsoft.AspNetCore.Components.Forms;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace admisionesuteco.web.Domain.Entities
{


    public class Estudiante
    {
       

        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "El apellido es obligatorio.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "El email es obligatorio.")]
        [EmailAddress(ErrorMessage = "Formato de email inválido.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "La fecha de nacimiento es obligatoria.")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "Seleccionar una carrera es obligatorio.")]
        public string SelectedCareer { get; set; }

        public string DocumentPath { get; set; }

        public bool IsVerified { get; set; } = false; // Estado de verificación
    }




}







