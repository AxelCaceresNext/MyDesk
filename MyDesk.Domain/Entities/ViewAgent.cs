using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MyDesk.Domain.Entities;

public class ViewAgent
{
    public required View View { get; set; }

    public required Agent Agent { get; set; }
}