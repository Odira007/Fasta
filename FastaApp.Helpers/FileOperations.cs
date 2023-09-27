//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Threading.Tasks;
//using Newtonsoft.Json;
//using FastaApp.Persistence;
//using FastaApp.Entities;

//namespace FastaApp.Helpers
//{
//    public class FileOperations
//    {
//        private static string dir = Environment.CurrentDirectory;
//        public static string path = Path.Combine(dir, "cars.json");
//        public static string userPath = Path.Combine(dir, "user.json");

//        public static async Task SaveUserAsync<T>(T user)
//        {
//            if (!File.Exists(userPath)) File.Create(userPath);

//            string parsedJson = JsonConvert.SerializeObject(user);

//            await File.WriteAllTextAsync(path, parsedJson);
//        }

//        public static async Task<List<T>> ReadUsers<T>(string path)
//        {
//            var lines = await File.ReadAllTextAsync(path);

//            return JsonConvert.DeserializeObject<List<T>>(lines);
//        }

//        public static async Task<bool> SaveToFileDatabaseAync()
//        {
//            if (!Directory.Exists(dir)) Directory.CreateDirectory(dir);
//            try
//            {
//                await SaveUserAsync(DataStore.Users);
//                return true;
//            }
//            catch(Exception)
//            {
//                return false;
//            }
//        }

//        public static async Task SeedCarData<T>(List<T> ts)
//        {
//            if (!File.Exists(path)) File.Create(path);

//            string parsedJson = JsonConvert.SerializeObject(ts);

//            await File.WriteAllTextAsync(path, parsedJson);
//        }

//        public static List<T> ReadCarData<T>()
//        {
//            var cars = new List<T>();

//            try
//            {
//                string lines = File.ReadAllText(path);
//                cars = JsonConvert.DeserializeObject<List<T>>(lines);
//            }
//            catch { }

//            return cars;
//        }

//        public static async Task LoadCarDataAsync()
//        {
//            await SeedCarData(DataStore.Cars);

//            ReadCarData<Car>();
//        }

//        public static Task SeedCarData(object cars)
//        {
//            throw new NotImplementedException();
//        }
//    }
//}
