using System;

namespace StudentsBlazor.Models;

public class Student
{
    public int StudentId { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? School { get; set; }
    public string? Gender { get; set; }
    public DateOnly DateOfBirth { get; set; }
}
