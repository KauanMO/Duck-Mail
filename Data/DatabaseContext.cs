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
}