using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Web_API.Models;
using Web_API.Models.DataManager;
using Web_API.Models.DTO;
using Web_API.Models.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Web_API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class UsersController : ControllerBase
	{
		private readonly IDataRepository<Users, UsersDTO> _dataRepository;
		public UsersController(IDataRepository<Users, UsersDTO> dataRepository)
		{
			_dataRepository = dataRepository;
		}

		// POST api/<UsersController>
		[HttpPost("register")]
		public IActionResult PostRegister([FromBody] Users value)
		{
			if((_dataRepository as UsersDM).CheckUsername(value.Username))
			{
				return NotFound();
			}
			(_dataRepository as UsersDM).Add(value);
			return Ok();
		}

		[HttpPost("login")]
		public IActionResult PostLogin([FromBody] Users value)
		{
			if ((_dataRepository as UsersDM).CheckExist(value))
			{
				return Ok();
			}
			return NotFound();
		}
	}
}
