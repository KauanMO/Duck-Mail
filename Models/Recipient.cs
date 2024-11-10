using Duck_Mail.Enums;
using System.ComponentModel.DataAnnotations;

namespace Duck_Mail.Models;

public class Recipient
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public RecipientStatus Status { get; set; }
    public DateTime SentDate { get; set; }
    public DateTime CreatedDate { get; set; } = DateTime.Now;
    public virtual CampaignEmailTemplate CampaignEmailTemplate { get; set; }
}