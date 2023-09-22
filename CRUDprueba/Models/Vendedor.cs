using System;
using System.Collections.Generic;

namespace CRUDprueba.Models;

public partial class Vendedor
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public string? Apellido { get; set; }

    public string? Correo { get; set; }
}

