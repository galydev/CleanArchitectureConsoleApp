using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class WaterConfiguration : IEntityTypeConfiguration<Weater>
{
    public void Configure(EntityTypeBuilder<Weater> builder)
    {
        builder.ToTable("Weater");

        builder.HasKey(o => o.Id);

        builder.Property(t => t.Date)
                .HasColumnName("Date")
                .IsRequired()
                .HasColumnType("Date")
                .HasDefaultValueSql("GetDate())");

        builder.Property(t => t.TemperatureC)
                .HasColumnName("TemperatureC")
                .IsRequired()
                .HasColumnType("decimal(10.2)");  

        builder.Property(t => t.TemperatureF)
                .HasColumnName("TemperatureF")
                .IsRequired()
                .HasColumnType("decimal(10.2)"); 
        
        builder.Property(t => t.Summary)
                .HasColumnName("Summary")
                .IsRequired()
                .HasColumnType("nvarchar");   
    }
}
}