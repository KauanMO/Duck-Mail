using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Duck_Mail.Models;

public class ClickHistory
{
    [Key]
    public int Id { get; set; }
    public string BrowserType { get; set; }
    public string DeviceType { get; set; }
    public int ClickCount { get; set; }
    public DateTime FirstOpenedDate { get; set; }
    public DateTime LastOpenedDate { get; set; }
    public virtual CampaignEmailTemplate CampaignEmailTemplate { get; set; }
    public virtual Recipient Recipient { get; set; }
}