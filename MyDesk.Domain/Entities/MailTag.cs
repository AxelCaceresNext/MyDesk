using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MyDesk.Domain.Entities;

public class MailTag
{
    public required MailMessage MailMessage { get; set; }

    public required Tag Tag { get; set; }
}