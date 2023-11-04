using System;
using System.Collections.Generic;
using TurboAzProject.Model.Abstract;

namespace TurboAzProject.Model.Models;

public partial class Image : BaseEntity
{
    public int Id { get; set; }

    public string ImagePath { get; set; } = null!;

    public virtual ICollection<Car> Cars { get; set; } = new List<Car>();
}
