using System;
using System.Collections.Generic;
using NetTopologySuite.Geometries;

namespace InterActive.ABMEntities;

public partial class User
{
    public int UserId { get; set; }

    public string Firstname { get; set; } = null!;

    public string Lastname { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Address { get; set; } = null!;

    public byte[] Password { get; set; } = null!;

    public byte[] Salt { get; set; } = null!;

    public Geometry Coord { get; set; } = null!;
}
