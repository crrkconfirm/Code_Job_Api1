using Microsoft.AspNetCore.Mvc;
using Code_Job_Api1.Repository.GenericRepository;
using Code_Job_Api1.Models;
using System.Collections;
using Code_Job_Api1.Repository;

namespace Code_Job_Api1.Controllers;

[ApiController]
[Route("[controller]")]
public class StudentController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<StudentController> _logger;
    private readonly IStudentRepository _studentRepository;

    public StudentController(ILogger<StudentController> logger,
        IStudentRepository studentRepository)
    {
        _logger = logger;
        _studentRepository = studentRepository;
    }

    [HttpGet(Name = "GetStudents")]
    public IEnumerable<Student> Get()
    {
        IEnumerable<Student>  students = _studentRepository.GetAll();
        return students;
    }
}