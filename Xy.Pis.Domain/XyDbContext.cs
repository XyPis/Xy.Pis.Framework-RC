using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Reflection;
using Xy.Pis.Domain;
using Xy.Pis.Domain.Mapping;

namespace Xy.Pis
{
    public partial class XyDbContext : DbContext
    {
        static XyDbContext()
        {
            Database.SetInitializer<XyDbContext>(null);
        }

        public XyDbContext(string connectionString)
            : base(string.Format("Name={0}", connectionString))
        { 
        }

        public DbSet<AdditionalMealDetails> AdditionalMealDetails { get; set; }
        
        public DbSet<AdditionalMeal> AdditionalMeals { get; set; }
        
        public DbSet<BsLocation> BsLocations { get; set; }
        
        public DbSet<BsUser> BsUsers { get; set; }        
        
        public DbSet<InHosInfo> InHosInfoes { get; set; }
        
        public DbSet<LmFood> LmFoodMaps { get; set; }
        
        public DbSet<LmWeekFood> LmWeekFoods { get; set; }
        
        public DbSet<BsItem> BsItems { get; set; }
        
        public DbSet<LmWorkRepair> LmWorkRepairs { get; set; }
        
        public DbSet<InStopMealRegister> InStopMealRegisters { get; set; }
        
        public DbSet<LocationEquipment> LocationEquipments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.AddFromAssembly(Assembly.GetExecutingAssembly());

            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
    }
}
