using CarparkClient.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace CarparkClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var vehicles = await GetVehicles();

            foreach(var vehicle in vehicles)
            {
                Console.WriteLine($"Id: {vehicle.VehicleId} - RegNo: {vehicle.RegNo} - Make: {vehicle.Make} - Model: {vehicle.Model}");
            }
        }
       
        static async Task<List<VehicleModel>> GetVehicles() {
            var vehicles = new List<VehicleModel>();

            using(HttpClient client = new HttpClient())
            {
                var url = "https://localhost:44359/api/vehicle";
                var response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode){
                    var content = await response.Content.ReadAsStringAsync();
                    vehicles = JsonConvert.DeserializeObject<List<VehicleModel>>(content);
                    return vehicles;
                }else{
                    return vehicles;
                }
            }            
        }
    }
}
