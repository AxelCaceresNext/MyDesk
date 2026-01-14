using MyDesk.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MyDesk.Domain.Entities;

public class View : BaseEntity
{
    public string Name { get; set; } = default!;
    public string? Description { get; set; }

    public string? FilterJson { get; set; }

    public bool IsActive { get; set; } = true;

    public List<ViewTag> Tags { get; set; } = new();
    public List<ViewAgent> Agents { get; set; } = new();
}