using CarparkApi.Data;
using CarparkApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarparkApi.Services
{
    public class Repository : IRepository
    {
        private readonly CarparkContext _context;

        public Repository(CarparkContext context)
        {
            _context = context;
        }

        public async Task<Vehicle> AddVehicle(Vehicle vehicle)
        {
            try
            {
                _context.Vehicles.Add(vehicle);
                await _context.SaveChangesAsync();
                return vehicle;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<Vehicle> GetVehicle(int id)
        {
            return await _context.Vehicles.Where(c => c.VehicleId == id).FirstOrDefaultAsync();
        }

        public async Task<IList<Vehicle>> ListVehicles()
        {
            return await _context.Vehicles.ToListAsync();
        }
    }
}
