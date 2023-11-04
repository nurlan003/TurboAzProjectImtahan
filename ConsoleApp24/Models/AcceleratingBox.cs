using System;
using System.Collections.Generic;
using TurboAzProject.Model.Abstract;

namespace TurboAzProject.Model.Models;

public partial class AcceleratingBox : BaseEntity
{
    public int Id { get; set; }

    public string AcceleratingBox1 { get; set; } = null!;

    public virtual ICollection<Car> Cars { get; set; } = new List<Car>();
}
