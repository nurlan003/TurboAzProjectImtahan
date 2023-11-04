using System;
using System.Collections.Generic;
using TurboAzProject.Model.Abstract;

namespace TurboAzProject.Model.Models;

public partial class Transmitter : BaseEntity
{
    public int Id { get; set; }

    public string CarTransmitter { get; set; } = null!;

    public virtual ICollection<Car> Cars { get; set; } = new List<Car>();
}
