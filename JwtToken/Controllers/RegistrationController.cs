using JwtToken.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace JwtToken.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistrationController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public RegistrationController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpPost]
        [Route("registration")]
        public string Registration(Registration registration)
        {
            SqlConnection con = new SqlConnection(_configuration.GetConnectionString("DefaultConnection").ToString());
            SqlCommand cmd = new SqlCommand("Insert into Registration(Username,Password,Email,Isactive)values('"+registration.Username + "','"+registration.Password+"','"+registration.Email+"','"+registration.Isactive+"')",con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if(i>0)
            {
                return "Data Inserted";
            }
            else
            {
                return "Error";
            }

           
        }
    }
}
