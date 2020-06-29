using System;
using cw10.DTOs;
using cw4.DAL;
using cw4.Models;
using Microsoft.AspNetCore.Mvc;

namespace cw4.Controllers
{
    [ApiController]
    [Route("api/students")]
    public class StudentsController : ControllerBase
    {
        private readonly IDbService _dbService;

        public StudentsController(IDbService dbService)
        {
            _dbService = dbService;
        }

        [HttpGet]
        public IActionResult GetStudent(string studentId)
        {
            return Ok(_dbService.GetStudent(int.Parse(studentId)));
        }


        [HttpGet]
        public IActionResult GetStudents()
        {
            return Ok(_dbService.GetStudents();
        }

        [HttpDelete]
        public IActionResult DeleteStudent(string studentId)
        {
            return Ok(_dbService.RemoveStudent(int.Parse(studentId)));
        }

        [HttpPut]
        public IActionResult ModifyStudent(ModifyStudentRequest modifyStudentRequest)
        {
            return Ok(_dbService.ModifyStudent(modifyStudentRequest));
        }
    }
}
