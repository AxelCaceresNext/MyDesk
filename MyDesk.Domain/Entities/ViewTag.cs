using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MyDesk.Domain.Entities;

public class ViewTag
{
    public required View View { get; set; }

    public required Tag Tag { get; set; }
}