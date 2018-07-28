using System.Data.Entity;

namespace MoneyTemplate.Models
{
    public class ModelContext : DbContext
    {
        public ModelContext() : base("name=SkillTreeHomeworkEntities")
        {
        }
        public virtual DbSet<AccountBook> AccountBook { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

        public System.Data.Entity.DbSet<MoneyTemplate.Models.ViewModels.SpendingTrackerViewModel> SpendingTrackerViewModels { get; set; }
    }
}