using System;
using System.ComponentModel.DataAnnotations;

namespace API.DTOs;

public class RegisterDto
{
    public required string Username { get; set; }
    public required string password { get; set; }
}
