using Microsoft.EntityFrameworkCore;
using MLA.Portal.Domain.Entities;

namespace MLA.Portal.Infrastructure.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Role> Roles { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<District> Districts { get; set; }
    public DbSet<Assembly> Assemblies { get; set; }
    public DbSet<GramPanchayat> GramPanchayats { get; set; }
    public DbSet<Village> Villages { get; set; }
    public DbSet<Survey> Surveys { get; set; }
    public DbSet<QuestionMaster> QuestionMasters { get; set; }
    public DbSet<SurveyAnswer> SurveyAnswers { get; set; }
    public DbSet<ReportCard> ReportCards { get; set; }

    public DbSet<Msr_District> Msr_Districts { get; set; }
    public DbSet<Msr_LocalBody> Msr_LocalBodies { get; set; }
    public DbSet<Msr_Village> Msr_Villages { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Configure relationships to prevent cascade delete issues
        modelBuilder.Entity<Survey>()
            .HasOne(s => s.District)
            .WithMany()
            .HasForeignKey(s => s.DistrictId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Survey>()
            .HasOne(s => s.LocalBody)
            .WithMany()
            .HasForeignKey(s => s.LocalBodyId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Survey>()
            .HasOne(s => s.Village)
            .WithMany()
            .HasForeignKey(s => s.VillageId)
            .OnDelete(DeleteBehavior.Restrict);


            
        modelBuilder.Entity<User>()
            .HasOne(u => u.District)
            .WithMany()
            .HasForeignKey(u => u.DistrictId)
            .OnDelete(DeleteBehavior.SetNull);
            
        modelBuilder.Entity<User>()
            .HasOne(u => u.Assembly)
            .WithMany()
            .HasForeignKey(u => u.AssemblyId)
            .OnDelete(DeleteBehavior.SetNull);

        modelBuilder.Entity<Survey>().ToTable("Surveys");
        modelBuilder.Entity<Msr_District>().ToTable("Msr_District");
        modelBuilder.Entity<Msr_LocalBody>().ToTable("Msr_LocalBody");
        modelBuilder.Entity<Msr_Village>().ToTable("Msr_Village");
    }
}
