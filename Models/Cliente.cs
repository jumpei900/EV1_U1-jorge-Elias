﻿using System;
using System.Collections.Generic;

namespace Apex.Models;

public partial class Cliente
{
    public int Id { get; set; }

    public string? Rut { get; set; }

    public string? Nombre { get; set; }

    public string? Apellido { get; set; }

    public string? Correo { get; set; }

    public string? Direccion { get; set; }

    public string? Telefono { get; set; }
}
