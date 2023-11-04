using System;
using System.Collections.Generic;
using TurboAzProject.Model.Abstract;

namespace TurboAzProject.Model.Models;

public partial class March : BaseEntity
{
    public int Id { get; set; }

    public int CarMarch { get; set; }

    public virtual ICollection<Car> Cars { get; set; } = new List<Car>();
}
