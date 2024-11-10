using Duck_Mail.Models;
using Microsoft.EntityFrameworkCore;

namespace Duck_Mail.Data;

public class DatabaseContext : DbContext
{
    public DatabaseContext(DbContextOptions<DatabaseContext> opts) : base(opts) { }

    public DbSet<EmailTemplate> EmailTemplates { get; set; }
    public DbSet<Campaign> Campaigns { get; set; }
    public DbSet<CampaignEmailTemplate> CampaignEmailTemplates { get; set; }
    public DbSet<Recipient> Recipients { get; set; }
    public DbSet<ClickHistory> ClickHistories { get; set; }
    public DbSet<DeliveryErrorLog> DeliveryErrorLogs { get; set; }
    public DbSet<OpenHistory> OpenHistories { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ClickHistory>()
            .HasOne(ch => ch.Recipient)
            .WithMany(r => r.ClickHistories)
            .HasForeignKey(ch => ch.RecipientId)
            .OnDelete(DeleteBehavior.NoAction);

        base.OnModelCreating(modelBuilder);
    }
}