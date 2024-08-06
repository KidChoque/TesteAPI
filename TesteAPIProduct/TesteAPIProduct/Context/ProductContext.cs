using Microsoft.EntityFrameworkCore;
using TesteAPIProduct.Domains;

namespace TesteAPIProduct.Context
{
    public class ProductContext : DbContext
    {
        public DbSet<Products> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=NOTE11-SALA21; Database=Product;User Id=sa; Pwd=Senai@134; TrustServerCertificate=true;");
                base.OnConfiguring(optionsBuilder);
            }


        }
    }
}
