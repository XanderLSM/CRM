using CRM.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CRM.Server.Configurations.Entities
{
    public class BlogcategorySeedConfiguration : IEntityTypeConfiguration<Blogcategory>
    {
        public void Configure(EntityTypeBuilder<Blogcategory> builder)
        {
            //throw new NotImplementedException();

            builder.HasData(
                new Blogcategory
                {
                    Id = 1,
                    Name = "Tips N Tricks",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Blogcategory
                {
                    Id = 2,
                    Name = "Finance",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
                );
        }
    }
}
