using System.Threading.Tasks;
using CQRS.WebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CQRS.WebApi.Infrastructure.Context
{
    public interface IApplicationContext
    {
        DbSet<Product> Products { get; set; }

        Task<int> SaveChangesAsync();
    }
}