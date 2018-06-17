using DemFramework.Nortwind.Entities.Concrete;
using System.Data.Entity.ModelConfiguration;

namespace DemFramework.Nortwind.DataAccess.Concrete.EntityFramework.Mapping
{
    public class CategoryMap : EntityTypeConfiguration<Category>
    {
        public CategoryMap()
        {
            ToTable(@"Categories", @"dbo");
            HasKey(x => x.CategoryId);
            Property(x => x.CategoryId).HasColumnName("CategoryId");
            Property(x => x.CategoryName).HasColumnName("CategoryName");
        }
    }
}
