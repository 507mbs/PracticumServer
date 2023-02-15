using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Repositories.Entities;

public partial class Child
{
   [Key]
    public string Identity { get; set; } = null!;

    public string ParentId { get; set; } = null!;

    public DateTime BornDate { get; set; }

    public string Name { get; set; } = null!;

    public virtual Detail Parent { get; set; } = null!;
}
