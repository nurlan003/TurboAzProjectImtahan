using System;
using System.Collections.Generic;
using TurboAzProject.Model.Abstract;

namespace TurboAzProject.Model.Models;

public partial class Marka : BaseEntity
{
    public int Id { get; set; }

    public string MarkaName { get; set; } = null!;

    public virtual ICollection<Car> Cars { get; set; } = new List<Car>();

    public virtual ICollection<Model> Models { get; set; } = new List<Model>();
}
