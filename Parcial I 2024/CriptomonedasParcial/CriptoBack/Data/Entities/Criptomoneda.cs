﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace CriptoBack.Data.Entities;

public partial class Criptomoneda
{
    public int Id { get; set; }

    public string Nombre { get; set; }

    public string Simbolo { get; set; }

    public double ValorActual { get; set; }

    public DateTime UltimaActualizacion { get; set; }

    public int Categoria { get; set; }

    public string Estado { get; set; }

    public virtual Categoria CategoriaNavigation { get; set; }
}