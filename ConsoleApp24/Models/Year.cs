using System;
using System.Collections.Generic;
using TurboAzProject.Model.Abstract;

namespace TurboAzProject.Model.Models;

public partial class Year : BaseEntity
{
    public int Id { get; set; }

    public DateTime Year1 { get; set; }

    public virtual ICollection<Car> Cars { get; set; } = new List<Car>();
}
