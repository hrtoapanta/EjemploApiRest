using EjemploApiRest.Aplication;
using EjemploApiRest.Entities;
using EjemploApiRest.WebApi.DTO;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EjemploApiRest.WebApi.Controllers
{
    [Authorize(AuthenticationSchemes =JwtBearerDefaults.AuthenticationScheme)]
    [Route("api/[controller]")]
    [ApiController]
    public class FootballTeamController : ControllerBase
    {
        private readonly IAplication<FootballTeam> _football;
        public FootballTeamController(IAplication<FootballTeam> football) 
        { 
            _football = football;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok( _football.GetAll());
        }
        [HttpPost]
        public IActionResult Save(FootballTeamDTO dto)
        {
            var f = new FootballTeam
            {
                Name = dto.Name,
                Score = dto.Score,
                Manager = dto.Manager,
            };
            return Ok(_football.Save(f));
        }
    }
}
