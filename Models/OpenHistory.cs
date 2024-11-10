using System.ComponentModel.DataAnnotations;

namespace Duck_Mail.Models;

public class OpenHistory
{
    [Key]
    public int Id { get; set; }
    public DateTime OpenedDate { get; set; }
    public virtual Recipient Recipient { get; set; }
}