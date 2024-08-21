using System.ComponentModel.DataAnnotations;

namespace admisionesuteco.web.Domain.Entities
{
    public class Documento
    {
        [Key]
        public int Id { get; set; }

        public string Title { get; set; } = null!;

        public Estudiante Estudiante { get; set; } = null!;


        public bool Actualizar(DocumentoDto dto)
        {
            var changes = false;

            if (Id != dto.Id)
            {
                Id = dto.Id;
                changes = true;
            }

           
            {
                Estudiante = dto.Estudiante;
                changes = true;

                return changes;
            }
            return changes;
        }

       
    }
}
