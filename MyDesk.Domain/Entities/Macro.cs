using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyDesk.Domain.Common;

namespace MyDesk.Domain.Entities;

public class Macro : BaseEntity
{
    public required string Name { get; set; }

    public string? Message { get; set; }

    // CC opcional (lista de usuarios)
    public List<MacroCc> CcUsers { get; set; } = new();

    // Cambio de estado opcional
    public Status? ChangeStatus { get; set; }

    // Reasignar agente opcional
    public Agent? AssignAgent { get; set; }

    public bool IsActive { get; set; } = true;
}