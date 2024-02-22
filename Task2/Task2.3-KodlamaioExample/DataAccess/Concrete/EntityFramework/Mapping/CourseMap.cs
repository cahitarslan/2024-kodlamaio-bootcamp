using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Concrete.EntityFramework.Mapping;

public class CourseMap : IEntityTypeConfiguration<Course>
{
    public void Configure(EntityTypeBuilder<Course> builder)
    {
        builder.HasKey(I => I.Id);
        builder.Property(I => I.Id).UseIdentityColumn();

        builder.Property(I => I.Title).IsRequired(true);
        builder.Property(I => I.Title).HasMaxLength(50);
        builder.Property(I => I.Description).IsRequired(true);
        builder.Property(I => I.Description).HasMaxLength(1000);

        builder.HasOne(I => I.Category).WithMany(I => I.Courses).HasForeignKey(I => I.CategoryId);
        builder.HasOne(I => I.Instructor).WithMany(I => I.Courses).HasForeignKey(I => I.InstructorId);
    }
}
