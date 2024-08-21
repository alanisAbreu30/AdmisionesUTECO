using admisionesuteco.web.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace admisionesuteco.web.Infraestructure.Context
{
    public interface IAdmisionDbContext
    {
        DbSet<Estudiante> Estudiante { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);

    }
}