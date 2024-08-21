
using admisionesuteco.web.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace admisionesuteco.web.Servicios
{
    public interface IUtecoServices
    {
        Task<List<Estudiante>> GetAllStudentsAsync();
        Task<Estudiante> GetStudentByIdAsync(int id);
        Task<Estudiante> AddStudentAsync(Estudiante student);
        Task<Estudiante> UpdateStudentAsync(Estudiante student);
        Task<bool> DeleteStudentAsync(int id);
    }
}