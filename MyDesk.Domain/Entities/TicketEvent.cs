using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyDesk.Domain.Common;

namespace MyDesk.Domain.Entities;

public class TicketEvent : BaseEntity
{
    public required Ticket Ticket { get; set; }

    public required string Name { get; set; }
    public string? Description { get; set; }

    public Agent? Agent { get; set; }

}