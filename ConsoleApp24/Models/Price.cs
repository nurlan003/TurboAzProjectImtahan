using System;
using System.Collections.Generic;
using TurboAzProject.Model.Abstract;

namespace TurboAzProject.Model.Models;

public partial class Price : BaseEntity
{
    public int Id { get; set; }

    public int CarPrice { get; set; }

    public virtual ICollection<Car> Cars { get; set; } = new List<Car>();
}
