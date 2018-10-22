using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HappierLiving.Appointment.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HappierLiving.Appointment.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {       
        private readonly IStudentService _service;

        public StudentController(IStudentService service)
        {
            _service = service;
        }
        //// GET api/user/5
        //[HttpGet("{id}")]
        //public async Task<User> Get(int id)
        //{
        //    return await _userManager.GetUserById(id);

        //}
        //// GET api/user
        //[HttpGet]
        //public async Task<IEnumerable<User>> Get()
        //{
        //    return await _userManager.GetUsers();

        //}


        // GET api/user/5
        [HttpGet("{id}")]
        public int Get(int id)
        {            
            return _service.DeleteStudent(id);

        }
        
    }
}