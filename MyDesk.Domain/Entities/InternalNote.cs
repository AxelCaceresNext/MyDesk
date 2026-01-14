using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyDesk.Domain.Common;

namespace MyDesk.Domain.Entities;

public class InternalNote : BaseEntity
{
    public required Ticket Ticket { get; set; }

    public required Agent AuthorAgent { get; set; }

    public required string Message { get; set; }
}
