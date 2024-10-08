﻿using System.ComponentModel.DataAnnotations;

namespace ECommerceWeb.Dto.Request;

public class TarjetaDto
{
    [Required(ErrorMessage = "Ingrese Titular")]
    public string? Titular { get; set; }

    [Required(ErrorMessage = "Ingrese una tarjeta valida")]
    public string? Numero { get; set; }

    [Required(ErrorMessage = "Ingrese Vigencia")]
    [MaxLength(5)]
    public string? Vigencia { get; set; }

    [Required(ErrorMessage = "Ingrese CVV")]
    [MaxLength(3)]
    public string? Cvv { get; set; }
}