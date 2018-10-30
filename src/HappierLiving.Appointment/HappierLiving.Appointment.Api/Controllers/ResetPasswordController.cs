using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using HappierLiving.Appointment.Model;
using Microsoft.AspNetCore.Http;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace HappierLiving.Appointment.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResetPasswordController : ControllerBase
    {
        public IConfiguration Configuration { get; }
        public ResetPasswordController(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public async Task<IActionResult> Post([FromBody]ResetPasswordModel resetPasswordModel)
        {
            resetPasswordModel.ClientId = Configuration["OpenId:ClientId"];
            var client = new HttpClient();
           
          var response = await client.PostAsJsonAsync(
              $"{Configuration["OpenId:Authority"]}dbconnections/change_password", resetPasswordModel);

            string Result = await response.Content.ReadAsStringAsync();

            return Ok(new { result=Result });
        } 
    }
}