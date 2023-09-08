using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pista.UI.Data;

namespace Pista.UI.Domain;

public class test
{
}


public class Employee
{
    public string EmployeeId { get; set; } = null!;
    public string Name { get; set; } = null!;
    public string UserId { get; set; } = null!;
    public ApplicationUser User { get; set; } = null!;
}

public class EmployeeConfig : IEntityTypeConfiguration<Employee>
{
    public void Configure(EntityTypeBuilder<Employee> builder)
    {
        builder.ToTable("Employees");
        builder.Property(x => x.EmployeeId).HasColumnType("varchar(50)");
        builder.HasKey(x => x.EmployeeId);
        builder.Property(x => x.Name).IsRequired().HasColumnType("varchar(250)");
        builder.Property(x => x.UserId).IsRequired().HasColumnType("nvarchar(450)");
        builder.HasOne(x => x.User).WithMany(x => x.Employees).HasForeignKey(x => x.UserId).OnDelete(DeleteBehavior.Cascade);
        //builder.Property(x => x.Email).IsRequired();
        //builder.Property(x => x.Mobile).IsRequired();
    }
}