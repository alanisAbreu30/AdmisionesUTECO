using admisionesuteco.web.Domain.Entities;
using admisionesuteco.web.Infraestructure.Context;
using admisionesuteco.web.Servicios;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace admisionesuteco.web.Services
{
    public class UtecoServices : IUtecoServices
    {
        private readonly AdmisionDbContext _context;

        public UtecoServices(AdmisionDbContext context)
        {
            _context = context;
        }

        public async Task<List<Estudiante>> GetAllStudentsAsync()
        {
            return await _context.Estudiante.ToListAsync();
        }

        public async Task<Estudiante> GetStudentByIdAsync(int id)
        {
            return await _context.Estudiante.FindAsync(id);
        }

        public async Task<Estudiante> AddStudentAsync(Estudiante student)
        {
            _context.Estudiante.Add(student);
            await _context.SaveChangesAsync();
            return student;
        }

        public async Task<Estudiante> UpdateStudentAsync(Estudiante student)
        {
            _context.Estudiante.Update(student);
            await _context.SaveChangesAsync();
            return student;
        }

        public async Task<bool> DeleteStudentAsync(int id)
        {
            var student = await _context.Estudiante.FindAsync(id);
            if (student != null)
            {
                _context.Estudiante.Remove(student);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }
    }
}


