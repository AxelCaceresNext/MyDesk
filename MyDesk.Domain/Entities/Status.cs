using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyDesk.Domain.Common;


namespace MyDesk.Domain.Entities;

public class Status : BaseEntity
{
    public required string Name { get; set; }
    public string? Description { get; set; }
}
