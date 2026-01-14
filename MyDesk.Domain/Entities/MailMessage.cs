using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyDesk.Domain.Common;

namespace MyDesk.Domain.Entities;

public class MailMessage : BaseEntity
{
    public required Ticket Ticket { get; set; }

    // Gmail messageId
    public string ExternalId { get; set; } = default!;
    public string? ThreadExternalId { get; set; }

    public User? From { get; set; }
    public User? To { get; set; }
    public List<MailCc> CcUsers { get; set; } = new();
    public string? Subject { get; set; }
    public List<MailTag> Tags { get; set; } = new();

    // JSON raw del mensaje
    public string PayloadJson { get; set; } = default!;
}
