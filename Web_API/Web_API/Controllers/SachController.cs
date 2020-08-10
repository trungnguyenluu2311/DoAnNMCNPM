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

		[HttpGet("id={id};ten={ten};theloai={tl};tacgia={tg}")]
		public IEnumerable<Sach> Get(string id, string ten, string tl, string tg)
		{
			return (_dataRepository as SachDM).GetBy(id, ten, tl, tg);
		}

		[HttpGet("getallmasach")]
		public IEnumerable<string> GetMKH(string id)
		{
			return (_dataRepository as SachDM).GetAllMaSach();
		}

		// POST api/<SachController>
		[HttpPost]
		public IActionResult Post([FromBody] Sach value)
		{
			if ((_dataRepository as SachDM).CheckExist(value.MaSach))
			{
				return Conflict();
			}
			_dataRepository.Add(value);
			return Ok();
		}

		// PUT api/<SachController>/5
		[HttpPut("{id}")]
		public IActionResult Put(string id, [FromBody] Sach value)
		{
			if (!(_dataRepository as SachDM).CheckExist(id))
			{
				return BadRequest();
			}
			_dataRepository.Update(id, value);
			return Ok();
		}

		// DELETE api/<SachController>/5
		[HttpDelete("{id}")]
		public IActionResult Delete(string id)
		{
			if (!(_dataRepository as SachDM).CheckExist(id))
			{
				return BadRequest();
			}
			_dataRepository.Delete(id);
			return Ok();
		}
	}
}
