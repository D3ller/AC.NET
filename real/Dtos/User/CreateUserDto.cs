﻿namespace real.Dtos.User;

public class CreateUserDto
{
    public string Username { get; set; } = null!;
    public string Password { get; set; } = null!;
    public string ConfirmPassword { get; set; } = null!;
    public string Email { get; set; } = null!;
}