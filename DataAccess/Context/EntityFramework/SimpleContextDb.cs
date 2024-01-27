using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Context.EntityFramework
{
    public class SimpleContextDb : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-ABR5RK9\\SQLEXPRESS;Database=ClassStructuresDb;Integrated Security=true;TrustServerCertificate = True");
        }

        public DbSet<User> Users { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
        public DbSet<EmailParameter> EmailParameters { get; set; }
        public DbSet<Table> Tables { get; set; }
        public DbSet<Field> Fields { get; set; }

       
    }
}
