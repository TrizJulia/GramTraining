using Microsoft.EntityFrameworkCore;

namespace GramTrainingCoreAngular.Data
{
    public class GrDbContext : DbContext
    {
        public GrDbContext(DbContextOptions<GrDbContext> options)
        :base(options) 
        {
            
        }
        

    }
}