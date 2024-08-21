namespace admisionesuteco.web.Domain.Entities
{
    public class DocumentoDto
    {
        public int Id { get; set; }

        public string Title { get; set; } 

        public Estudiante Estudiante { get; set; }
    }
}
