using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Concrete.EntityFramework.Mapping;

public class CategoryMap : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.HasKey(I => I.Id);
        builder.Property(I => I.Id).UseIdentityColumn();

        builder.Property(I => I.Name).IsRequired(true);
        builder.Property(I => I.Name).HasMaxLength(50);
        builder.Property(I => I.Description).HasMaxLength(100);
    }
}
