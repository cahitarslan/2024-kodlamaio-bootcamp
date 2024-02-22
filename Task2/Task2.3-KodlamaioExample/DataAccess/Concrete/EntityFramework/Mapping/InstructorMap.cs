using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Concrete.EntityFramework.Mapping;

public class InstructorMap : IEntityTypeConfiguration<Instructor>
{
    public void Configure(EntityTypeBuilder<Instructor> builder)
    {
        builder.HasKey(I => I.Id);
        builder.Property(I => I.Id).UseIdentityColumn();

        builder.Property(I => I.FirstName).IsRequired(true);
        builder.Property(I => I.FirstName).HasMaxLength(50);
        builder.Property(I => I.LastName).IsRequired(true);
        builder.Property(I => I.LastName).HasMaxLength(50);
        builder.Property(I => I.Email).IsRequired(true);
        builder.Property(I => I.Email).HasMaxLength(50);
        builder.Property(I => I.Bio).IsRequired(true);
        builder.Property(I => I.Bio).HasMaxLength(500);
    }
}
