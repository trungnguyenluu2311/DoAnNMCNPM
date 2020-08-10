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
	public class PhieuThuTienController : ControllerBase
	{
		private readonly IDataRepository<PhieuThuTien, PhieuThuTienDTO> _dataRepository;
		public PhieuThuTienController(IDataRepository<PhieuThuTien, PhieuThuTienDTO> dataRepository)
		{
			_dataRepository = dataRepository;
		}
		// GET: api/<PhieuThuTienController>
		[HttpGet]
		public IEnumerable<PhieuThuTien> Get()
		{
			return _dataRepository.GetAll();
		}

		// GET api/<PhieuThuTienController>/5
		[HttpGet("{id}")]
		public PhieuThuTien Get(string id)
		{
			return _dataRepository.Get(id);
		}

		// POST api/<PhieuThuTienController>
		[HttpPost]
		public IActionResult Post([FromBody] PhieuThuTien value)
		{
			if ((_dataRepository as PhieuThuTienDM).CheckExist(value.MaKh))
			{
				return Conflict();
			}
			_dataRepository.Add(value);
			return Ok();
		}

		// PUT api/<PhieuThuTienController>/5
		[HttpPut("{id}")]
		public IActionResult Put(string id, [FromBody] PhieuThuTien value)
		{
			if (!(_dataRepository as PhieuThuTienDM).CheckExist(id))
			{
				return BadRequest();
			}
			_dataRepository.Update(id, value);
			return Ok();
		}

		// DELETE api/<PhieuThuTienController>/5
		[HttpDelete("{id}")]
		public IActionResult Delete(string id)
		{
			if (!(_dataRepository as PhieuThuTienDM).CheckExist(id))
			{
				return BadRequest();
			}
			_dataRepository.Delete(id);
			return Ok();
		}
	}
}
