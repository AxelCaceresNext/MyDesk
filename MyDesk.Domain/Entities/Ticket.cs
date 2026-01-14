using MyDesk.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace MyDesk.Domain.Entities;

public class Ticket : BaseEntity
{
    public string? Subjet { get; set; }
    public required Status Status { get; set; }
    public required User Requester { get; set; }
    public Agent? AssignedAgent { get; set; }

    // Merge/Fusion (self-reference)
    public Ticket? ParentTicket { get; set; }

    public List<InternalNote> InternalNotes { get; set; } = new();
    public List<MailMessage> Mails { get; set; } = new();
    public List<TicketEvent> Events { get; set; } = new();

    public List<TicketCc> CcUsers { get; set; } = new();
}
