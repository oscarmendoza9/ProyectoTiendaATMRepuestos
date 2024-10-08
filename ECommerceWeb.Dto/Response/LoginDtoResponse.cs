﻿namespace ECommerceWeb.Dto.Response;

public class LoginDtoResponse : BaseResponse
{
    public string Token { get; set; } = default!;
    public string NombreCompleto { get; set; } = default!;
    public IList<string> Roles { get; set; } = new List<string>();
}