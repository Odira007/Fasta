using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using FastaApp.Persistence.Interfaces;
using FastaApp.Entities;
using System.Data.SqlClient;
using System.Data;
using FastaApp.Common;

namespace FastaApp.Persistence.Repositories
{
    public class CarRepository : ICarRepository
    {
        private readonly IConfiguration _configuration;
        private readonly string _conStr;

        public CarRepository(IConfiguration configuration)
        {
            _configuration = configuration;
            _conStr = _configuration.GetConnectionString("DefaultConnection");
        }

        public async Task<int> AddCarAsync(Car car)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_conStr))
                {
                    SqlCommand command = new SqlCommand("AddNewCar", connection) { CommandType = CommandType.StoredProcedure };

                    command.Parameters.Add("@Id", SqlDbType.UniqueIdentifier).Value = car.Id;
                    command.Parameters.AddWithValue("@BodyStyle", car.BodyStyle);
                    command.Parameters.AddWithValue("@Brand", car.Brand);
                    command.Parameters.AddWithValue("@Model", car.Model);
                    command.Parameters.AddWithValue("@Color", car.Color);
                    command.Parameters.AddWithValue("@Gps", car.Gps);
                    command.Parameters.AddWithValue("@RentalLocation", car.RentalLocation);
                    command.Parameters.AddWithValue("@Transmission", car.Transmission);
                    command.Parameters.AddWithValue("@PricePerDay", car.PricePerDay);
                    command.Parameters.AddWithValue("@AvailableFrom", car.AvailableFrom);
                    command.Parameters.AddWithValue("@ImageUrl", car.ImageUrl);
                    command.Parameters.AddWithValue("@BodyStyle", car.BodyStyle);
                    command.Parameters.AddWithValue("@ThumbnailImageUrl", car.ThumbNailImageUrl);
                    command.Parameters.AddWithValue("@RealImage", car.RealImage);
                    command.Parameters.AddWithValue("@LicensePlate", car.LicensePlate);
                    command.Parameters.AddWithValue("@HorsePowerHP", car.HorsepowerHP);
                    command.Parameters.AddWithValue("@HorsePowerKW", car.HorsePowerKW);
                    command.Parameters.AddWithValue("@EngineType", car.EngineType);
                    command.Parameters.AddWithValue("@Mileage", car.Mileage);
                    command.Parameters.AddWithValue("@Year", car.Year);
                    command.Parameters.AddWithValue("@Features", car.Features);
                    command.Parameters.AddWithValue("@Condition", car.Condition);
                    command.Parameters.AddWithValue("@LongDescription", car.Description);

                    connection.Open();
                    return await command.ExecuteNonQueryAsync();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }


        public async Task<Car> GetSingleCarAsync(string carId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_conStr))
                {
                    SqlCommand command = new SqlCommand("GetCarDetails", connection) { CommandType = CommandType.StoredProcedure };
                    command.Parameters.Add("@Id", SqlDbType.UniqueIdentifier).Value = carId;

                    connection.Open();

                    SqlDataReader reader = await command.ExecuteReaderAsync();

                    Car car = new Car();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            car.Id = reader["Id"].ToString();
                            car.Brand = reader["Brand"].ToString();
                            car.Model = reader["Model"].ToString();
                            car.Mileage = double.Parse(reader["Mileage"].ToString());
                            car.PricePerDay = decimal.Parse(reader["PricePerDay"].ToString());
                            car.RentalLocation = reader["RentalLocation"].ToString();
                            car.Transmission = (Transmission)Enum.Parse(typeof(Transmission), reader["Transmission"].ToString());
                            car.Condition = (Condition)Enum.Parse(typeof(Condition), reader["Condition"].ToString());
                            car.Color = reader["Color"].ToString();
                            car.Year = reader["Year"].ToString();
                            car.RealImage = reader["RealImage"].ToString();
                            car.BodyStyle = reader["BodyStyle"].ToString();
                            car.Gps = (Gps)Enum.Parse(typeof(Gps), reader["Gps"].ToString());
                            car.Description = reader["Description"].ToString();
                            car.HorsePowerKW = reader["HorsePowerKW"].ToString();
                            car.HorsepowerHP = reader["HorsePowerHP"].ToString();
                            car.Features = reader["Features"].ToString();
                            car.EngineType = reader["EngineType"].ToString();
                            car.AvailableFrom = reader["AvailableFrom"].ToString();
                            car.ThumbNailImageUrl = reader["ThumbnailImaheUrl"].ToString();
                            car.ImageUrl = reader["ImageUrl"].ToString();
                            car.LicensePlate = reader["LicensePlate"].ToString();
                        }
                    }
                    return car;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<List<Car>> GetAllCarsAsync()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_conStr))
                {
                    SqlCommand command = new SqlCommand("GetAllCarsDetails", connection) { CommandType = CommandType.StoredProcedure };
                    connection.Open();

                    SqlDataReader reader = await command.ExecuteReaderAsync();

                    List<Car> cars = new List<Car>();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            var car = new Car();
                            car.Id = reader["Id"].ToString();
                            car.Brand = reader["Brand"].ToString();
                            car.Model = reader["Model"].ToString();
                            car.Mileage = double.Parse(reader["Mileage"].ToString());
                            car.PricePerDay = decimal.Parse(reader["PricePerDay"].ToString());
                            car.RentalLocation = reader["RentalLocation"].ToString();
                            car.Transmission = (Transmission)Enum.Parse(typeof(Transmission), reader["Transmission"].ToString());
                            car.Condition = (Condition)Enum.Parse(typeof(Condition), reader["Condition"].ToString());
                            car.Color = reader["Color"].ToString();
                            car.Year = reader["Year"].ToString();
                            car.RealImage = reader["RealImage"].ToString();
                            car.BodyStyle = reader["BodyStyle"].ToString();
                            car.Gps = (Gps)Enum.Parse(typeof(Gps), reader["Gps"].ToString());
                            car.Description = reader["Description"].ToString();
                            car.HorsePowerKW = reader["HorsePowerKW"].ToString();
                            car.HorsepowerHP = reader["HorsePowerHP"].ToString();
                            car.Features = reader["Features"].ToString();
                            car.EngineType = reader["EngineType"].ToString();
                            car.AvailableFrom = reader["AvailableFrom"].ToString();
                            car.ThumbNailImageUrl = reader["ThumbnailImaheUrl"].ToString();
                            car.ImageUrl = reader["ImageUrl"].ToString();
                            car.LicensePlate = reader["LicensePlate"].ToString();

                            cars.Add(car);
                        }
                    }
                    return cars;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<int> DeleteCarAsync(string carId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_conStr))
                {
                    using (SqlCommand command = new SqlCommand("DeleteCar", connection) { CommandType = CommandType.StoredProcedure})
                    {
                        command.Parameters.Add("@Id", SqlDbType.UniqueIdentifier).Value = carId;

                        connection.Open();
                        return await command.ExecuteNonQueryAsync();
                    }

                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
