using System;
using System.Collections.Generic;
using TurboAzProject.Model.Abstract;

namespace TurboAzProject.Model.Models;

public partial class Car : BaseEntity
{
    public int Id { get; set; }

    public int MarkaId { get; set; }

    public int ModelId { get; set; }

    public int CityId { get; set; }

    public int PriceId { get; set; }

    public int YearId { get; set; }

    public int ColorId { get; set; }

    public int EngineId { get; set; }

    public int MarchId { get; set; }

    public int TransmitterId { get; set; }

    public int AcceleratingBoxId { get; set; }

    public int FuelTypeId { get; set; }

    public int ImageId { get; set; }

    public int RegistrationPlateId { get; set; }

    public virtual AcceleratingBox AcceleratingBox { get; set; } = null!;

    public virtual City City { get; set; } = null!;

    public virtual Color Color { get; set; } = null!;

    public virtual Engine Engine { get; set; } = null!;

    public virtual FuelType FuelType { get; set; } = null!;

    public virtual Image Image { get; set; } = null!;

    public virtual March March { get; set; } = null!;

    public virtual Marka Marka { get; set; } = null!;

    public virtual Model Model { get; set; } = null!;

    public virtual Price Price { get; set; } = null!;

    public virtual RegistrationPlate RegistrationPlate { get; set; } = null!;

    public virtual Transmitter Transmitter { get; set; } = null!;

    public virtual Year Year { get; set; } = null!;
}
