using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Repositories.Entities;

public partial class Detail
{
    [Key]
    public string Idenentity { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public DateTime BornDate { get; set; }

    public string Gender { get; set; } = null!;

    public string Hmo { get; set; } = null!;

    public virtual ICollection<Child> Children { get; } = new List<Child>();
}
