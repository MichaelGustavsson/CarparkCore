using CarparkApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarparkApi.Services
{
    public interface IRepository
    {
        Task<Vehicle> GetVehicle(int id);
        Task<IList<Vehicle>> ListVehicles();
        Task<Vehicle> AddVehicle(Vehicle vehicle);
    }
}
