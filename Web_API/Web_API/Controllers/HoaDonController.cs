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
	public class HoaDonController : ControllerBase
	{

		private readonly IDataRepository<HoaDon, HoaDonDTO> _dataRepository;
		public HoaDonController(IDataRepository<HoaDon, HoaDonDTO> dataRepository)
		{
			_dataRepository = dataRepository;
		}

		// GET: api/<HoaDonController>
		[HttpGet]
		public IEnumerable<string> Get()
		{
			return new string[] { "value1", "value2" };
		}

		// GET api/<HoaDonController>/5
		[HttpGet("{id}")]
		public string Get(int id)
		{
			return "value";
		}

		// POST api/<HoaDonController>
		[HttpPost]
		public IActionResult Post([FromBody] HoaDonDTO value)
		{
			if ((_dataRepository as HoaDonDM).CheckExist(value.MaHd))
			{
				return Conflict();
			}
			(_dataRepository as HoaDonDM).Add(value);
			return Ok();
		}

		// PUT api/<HoaDonController>/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] string value)
		{
		}

		// DELETE api/<HoaDonController>/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
		}
	}
}
