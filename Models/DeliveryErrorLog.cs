using System.ComponentModel.DataAnnotations;

namespace Duck_Mail.Models;

public class DeliveryErrorLog
{
    [Key]
    public int Id { get; set; }
    public string Message { get; set; }
    public string Code { get; set; }
    public DateTime Date { get; set; }
    public virtual Recipient Recipient { get; set; }
}