using System;
using System.Collections.Generic;
using TurboAzProject.Model.Abstract;

namespace TurboAzProject.Model.Models;

public partial class Model : BaseEntity
{
    public int Id { get; set; }

    public string ModelName { get; set; } = null!;

    public int MarkaId { get; set; }

    public virtual ICollection<Car> Cars { get; set; } = new List<Car>();

    public virtual Marka Marka { get; set; } = null!;
}
