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
	public class PhieuNhapSachController : ControllerBase
	{

		private readonly IDataRepository<PhieuNhapSach, PhieuNhapSachDTO> _dataRepository;
		public PhieuNhapSachController(IDataRepository<PhieuNhapSach, PhieuNhapSachDTO> dataRepository)
		{
			_dataRepository = dataRepository;
		}

		// GET: api/<PhieuNhapSachController>
		[HttpGet]
		public IEnumerable<string> Get()
		{
			return new string[] { "value1", "value2" };
		}

		// GET api/<PhieuNhapSachController>/5
		[HttpGet("{id}")]
		public string Get(int id)
		{
			return "value";
		}

		// POST api/<PhieuNhapSachController>
		[HttpPost]
		public IActionResult Post([FromBody] PhieuNhapSachDTO value)
		{
			if ((_dataRepository as PhieuNhapSachDM).CheckExist(value.MaPn))
			{
				return Conflict();
			}
			(_dataRepository as PhieuNhapSachDM).Add(value);
			return Ok();
		}

		// PUT api/<PhieuNhapSachController>/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] string value)
		{
		}

		// DELETE api/<PhieuNhapSachController>/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
		}
	}
}
