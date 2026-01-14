using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyDesk.Domain.Common;

namespace MyDesk.Domain.Entities;

public class Tag : BaseEntity
{
    public required string Name { get; set; };
    public string? Description { get; set; }
    public bool IsActive { get; set; } = true;

    public List<MailTag> MailTags { get; set; } = new();
    public List<ViewTag> ViewTags { get; set; } = new();
}