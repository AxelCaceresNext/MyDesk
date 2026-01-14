using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyDesk.Domain.Common;

namespace MyDesk.Domain.Entities;

public class Agent : BaseEntity
{
    public required User User { get; set; }
    public required string Password { get; set; }
    public bool IsActive { get; set; } = true;
    public List<Ticket> Tickets { get; set; } = new();
}
