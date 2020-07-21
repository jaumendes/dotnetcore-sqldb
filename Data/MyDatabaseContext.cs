using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DotNetCoreSqlDb.Models
{
    public class MyDatabaseContext : DbContext
    {
        public MyDatabaseContext (DbContextOptions<MyDatabaseContext> options)
            : base(options)
        {
        }

        public DbSet<DotNetCoreSqlDb.Models.Todo> Todo { get; set; }

        public DbSet<Product> Product { get; set; }


        public Product GetProductById(int id)
        {
            return this.Product.FirstOrDefault(product => product.Id == id);
        }

        public Product GetProductByName(string name)
        {
            return this.Product.FirstOrDefault(product => product.Name.ToLower().StartsWith(name.ToLower()));
        }
    }
}
