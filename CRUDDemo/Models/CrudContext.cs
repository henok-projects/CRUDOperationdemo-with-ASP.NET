using System.Data.Entity;

namespace CRUDDemo.Models
{
    public class CrudContext : DbContext
    {
        public CrudContext() : base("CrudContextDemo")
        {
            
        }

        public DbSet<Employee> Employees { get; set; }
    }
}