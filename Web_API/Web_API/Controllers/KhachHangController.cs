﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
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
	public class KhachHangController : ControllerBase
	{
		private readonly IDataRepository<KhachHang, KhachHangDTO> _dataRepository;
		public KhachHangController(IDataRepository<KhachHang, KhachHangDTO> dataRepository)
		{
			_dataRepository = dataRepository;
		}

		// GET: api/<KhachHangController>
		[HttpGet]
		public IEnumerable<KhachHang> Get()
		{
			return _dataRepository.GetAll();
		}

		// GET api/<KhachHangController>/5
		[HttpGet("{id}")]
		public KhachHang Get(string id)
		{
			return _dataRepository.Get(id);
		}

		[HttpGet("getallmakhachhang")]
		public IEnumerable<string> GetMKH(string id)
		{
			return (_dataRepository as KhachHangDM).GetAllMaKH();
		}

		// POST api/<KhachHangController>
		[HttpPost]
		public IActionResult Post([FromBody] KhachHang value)
		{
			if((_dataRepository as KhachHangDM).CheckExist(value.MaKh))
			{
				return Conflict();
			}
			_dataRepository.Add(value);
			return Ok();
		}

		// PUT api/<KhachHangController>/5
		[HttpPut("{id}")]
		public IActionResult Put(string id, [FromBody] KhachHang value)
		{
			if (!(_dataRepository as KhachHangDM).CheckExist(id))
			{
				return BadRequest();
			}
			_dataRepository.Update(id, value);
			return Ok();
		}

		// DELETE api/<KhachHangController>/5
		[HttpDelete("{id}")]
		public IActionResult Delete(string id)
		{
			if (!(_dataRepository as KhachHangDM).CheckExist(id))
			{
				return BadRequest();
			}
			_dataRepository.Delete(id);
			return Ok();
		}
	}
}
