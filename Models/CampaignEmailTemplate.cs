﻿using System.ComponentModel.DataAnnotations;

namespace Duck_Mail.Models;

public class CampaignEmailTemplate
{
    [Key]
    public int Id { get; set; }
    public string Url { get; set; }
    public DateTime CreatedDate { get; set; }
    public virtual Campaign Campaign { get; set; }
    public virtual EmailTemplate EmailTemplate { get; set; }
}