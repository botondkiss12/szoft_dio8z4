using System;
using System.Collections.Generic;

namespace ZH3.Models;

public partial class Category
{
    public int CategoryId { get; set; }

    public string CategoryName { get; set; } = null!;

    public virtual ICollection<Riddle> Riddles { get; set; } = new List<Riddle>();
}
