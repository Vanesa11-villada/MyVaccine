﻿namespace MyVaccine.WebApi.Dtos;

public class RegisterRequetDto
{
    public string Username { get; set; }
    //public string Email { get; set; }
    public string Password { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime? Birthdate { get; set; }
    public string? Photo { get; set; }
}
