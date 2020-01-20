using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarparkApi.Models;
using CarparkApi.Services;
using CarparkApi.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarparkApi.Controllers
{
    [Route("api/vehicles")]
    [ApiController]
    public class VehiclesController : ControllerBase
    {
        private readonly IRepository _repo;

        public VehiclesController(IRepository repo)
        {
            _repo = repo;
        }
      
        [HttpGet("{id}")]
        public async Task<IActionResult>GetVehicleById(int id)
        {
            var vehicle = await _repo.GetVehicle(id);

            return Ok(vehicle);
        }

        [HttpGet()]
        public async Task<IActionResult> GetVehicles()
        {
            var vehicle = await _repo.ListVehicles();

            return Ok(vehicle);
        }

        [HttpPost()]
        public async Task<IActionResult> AddVehicles([FromBody] VehiclePostViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(model);
            }

            try
            {
                var vehicle = new Vehicle
                {
                    Make = model.Make,
                    Model = model.Model,
                    Mileage = model.Mileage,
                    ModelYear = model.ModelYear,
                    RegNo = model.RegNo,
                    VinNumber = model.VinNumber
                };

                var v = await _repo.AddVehicle(vehicle);

                return CreatedAtAction(nameof(GetVehicleById), new { id = v.VehicleId }, v);

            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}