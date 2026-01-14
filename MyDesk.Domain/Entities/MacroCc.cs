using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MyDesk.Domain.Entities;

public class MacroCc
{
    public required Macro Macro { get; set; }

    public required User User { get; set; }
}