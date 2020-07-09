using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Web_API.Models;
using Web_API.Models.DTO;
using Web_API.Models.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Web_API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class SachController : ControllerBase
	{
		private readonly IDataRepository<Sach, SachDTO> _dataRepository;
		public SachController(IDataRepository<Sach, SachDTO> dataRepository)
		{
			_dataRepository = dataRepository;
		}

		// GET: api/<SachController>
		[HttpGet]
		public IEnumerable<Sach> Get()
		{
			return _dataRepository.GetAll();
		}

		// GET api/<SachController>/5
		[HttpGet("{id}")]
		public IActionResult Get(string id)
		{
			var sach = _dataRepository.Get(id);
			if(sach==null)
			{
				return NotFound("Not found");
			}
			return Ok(sach);
		}

		// POST api/<SachController>
		[HttpPost]
		public void Post([FromBody] Sach value)
		{
			_dataRepository.Add(value);
		}

		// PUT api/<SachController>/5
		[HttpPut("{id}")]
		public void Put(string id, [FromBody] Sach value)
		{
			_dataRepository.Update(id, value);
		}

		// DELETE api/<SachController>/5
		[HttpDelete("{id}")]
		public void Delete(string id)
		{
			_dataRepository.Delete(id);
		}
	}
}
