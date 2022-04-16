using Astronaut.user.repository.Entity;
using Microsoft.EntityFrameworkCore;

namespace Astronaut.user.repository
{
    internal class SqlDbContext : DbContext
    {
        public SqlDbContext(DbContextOptions<SqlDbContext> options)
            : base(options) { }

        public DbSet<EmployeeInfo> EmployeeInfo { get; set; } = null!;
    }
}
