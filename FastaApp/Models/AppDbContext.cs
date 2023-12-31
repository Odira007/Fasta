﻿using Microsoft.AspNetCore.Identity;
//using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore;
//using System;
//using System.Collections.Generic;
//using System.Globalization;
//using System.Linq;
//using System.Threading.Tasks;

//namespace FastaApp.Models
//{
//    public class AppDbContext : IdentityDbContext<IdentityUser>
//    {
//        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
//        {

//        }

//        public DbSet<Car> Cars { get; set; }

//        protected override void OnModelCreating(ModelBuilder modelBuilder)
//        {

//            base.OnModelCreating(modelBuilder);

//            modelBuilder.Entity<Car>().HasData(new Car
//            {
//                Id = Guid.NewGuid().ToString(),
//                Brand = "Toyota",
//                Model = "Corolla",
//                Year = 2022,
//                BodyStyle = "Sedan",
//                Color = "Silver",
//                Transmission = Transmission.Automatic,
//                Mileage = 10000.0d,
//                Features = "Air Conditioner,Bluetooth,Backup Camera",
//                Condition = Condition.Used,
//                PricePerDay = 15000.00m,
//                LicensePlate = "ABC123",
//                RentalLocation = "Downtown Branch",
//                Gps = Gps.Included,
//                ImageUrl = "https://i.pinimg.com/236x/74/61/4d/74614d884940788ce8d1a6ef46fcb8a9.jpg",
//                ThumbNailImageUrl = "https://i.pinimg.com/236x/25/e7/e4/25e7e47750265a7bdc3b6eb49785e5cb.jpg",
//                Description = "Embark on your next adventure in the 2022 Toyota Corolla, a reliable and well-maintained sedan in a classic silver finish. This vehicle offers a seamless blend of style, comfort, and technology, making it the perfect choice for both urban and highway driving. The Corolla is equipped with a fuel-efficient 1.8L engine, ensuring that your journeys are not only enjoyable but also eco-friendly. Inside, you'll find modern features, including Bluetooth connectivity for hands-free calling and music streaming, as well as a convenient backup camera to assist with parking and maneuvering in tight spaces. With seating for up to five passengers, it's an excellent choice for family trips or group outings. Despite being a used car, it feels like new, and you can enjoy all its perks for just $40 per day."
//            });

//            modelBuilder.Entity<Car>().HasData(new Car
//            {
//                Id = Guid.NewGuid().ToString(),
//                Brand = "Ford",
//                Model = "Mustang",
//                Year = 2023,
//                BodyStyle = "Coupe",
//                Color = "Red",
//                Transmission = Transmission.Manual,
//                Mileage = 5000.0d,
//                Features = "Air Conditioner,Leather Seats,Apple CarPlay",
//                Condition = Condition.New,
//                PricePerDay = 25080.00m,
//                LicensePlate = "DEF456",
//                RentalLocation = "Airport Branch",
//                Gps = Gps.Optional,
//                ImageUrl = "https://img.freepik.com/premium-vector/car_27088-93.jpg?w=826",
//                ThumbNailImageUrl = "https://i.pinimg.com/236x/25/e7/e4/25e7e47750265a7bdc3b6eb49785e5cb.jpg",
//                Description = "Unleash the power and sophistication of the 2023 Ford Mustang, a red-hot coupe designed for thrill-seekers and performance enthusiasts. This brand-new Mustang is the epitome of style, speed, and cutting-edge technology. Beneath the hood lies a potent 2.3L engine, offering a heart-pounding driving experience that's sure to ignite your passion for the road. The Mustang's manual transmission provides an intimate connection between driver and machine, making every gear shift a memorable experience. Whether you're planning a weekend getaway or simply want to make a statement, this Mustang is the perfect choice. For just $60 per day, you can commandeer this automotive marvel, available for rent starting from 09/02/2023 at our Airport Branch"
//            });

//            modelBuilder.Entity<Car>().HasData(new Car
//            {
//                Id = Guid.NewGuid().ToString(),
//                Brand = "Honda",
//                Model = "CR-V",
//                Year = 2021,
//                BodyStyle = "SUV",
//                Color = "Blue",
//                Transmission = Transmission.Automatic,
//                Mileage = 15000.0d,
//                Features = "All-Wheel Drive,Air Conditioner,Sunroof",
//                Condition = Condition.Used,
//                PricePerDay = 13789.00m,
//                LicensePlate = "XYZ789",
//                RentalLocation = "Suburb Branch",
//                Gps = Gps.Included,
//                ImageUrl = "https://img.freepik.com/premium-vector/realistic-vector-blue-city-car-coupe-sport-transportation-isolated-background_33869-3203.jpg?w=826",
//                ThumbNailImageUrl = "https://i.pinimg.com/236x/25/e7/e4/25e7e47750265a7bdc3b6eb49785e5cb.jpg",
//                Description = "Experience the environmentally conscious driving pleasure of the 2021 Honda CR-V in a mesmerizing shade of blue. This well-maintained SUV is equipped with all-wheel drive, ensuring exceptional stability and control on diverse terrains. The spacious interior accommodates up to five passengers comfortably, making it ideal for family outings or group adventures. You'll find a sunroof that adds an extra touch of luxury and the opportunity to soak in the natural surroundings during your journey. Plus, with comprehensive insurance coverage, you can embark on your travels with confidence. Rent the 2021 Honda CR-V today for just $55 per day from our conveniently located suburb branch."
//            });

//            modelBuilder.Entity<Car>().HasData(new Car
//            {
//                Id = Guid.NewGuid().ToString(),
//                Brand = "Chevrolet",
//                Model = "Tahoe",
//                Year = 2022,
//                BodyStyle = "SUV",
//                Color = "Black",
//                Transmission = Transmission.Automatic,
//                Mileage = 8000.0d,
//                Features = "Air Conditioner,Third-Row Seating,Rear Entertainment System",
//                Condition = Condition.New,
//                PricePerDay = 30090.00m,
//                LicensePlate = "MNO102",
//                RentalLocation = "City Center Branch",
//                Gps = Gps.Included,
//                ImageUrl = "https://img.freepik.com/premium-vector/car-illustration_74218-174.jpg?w=826",
//                ThumbNailImageUrl = "https://i.pinimg.com/236x/25/e7/e4/25e7e47750265a7bdc3b6eb49785e5cb.jpg",
//                Description = "Elevate your travel experiences with the 2022 Chevrolet Tahoe, a commanding presence in sleek black. This full-size SUV is engineered for versatility, making it a perfect choice for family vacations and group getaways. Equipped with a robust 5.3L engine, the Tahoe offers ample power to tackle various terrains with ease. Inside, you'll discover the luxury of third-row seating, ensuring ample space for everyone on board. And to keep passengers entertained during long journeys, there's a rear entertainment system that's sure to keep the kids (and adults) engaged. For your peace of mind, the Tahoe comes with collision insurance coverage, so you can relax and enjoy your adventures. Rent this spacious and stylish SUV today for $85 per day from our city center branch."
//            });

//            modelBuilder.Entity<Car>().HasData(new Car
//            {
//                Id = Guid.NewGuid().ToString(),
//                Brand = "Nissan",
//                Model = "Altima",
//                Year = 2023,
//                BodyStyle = "Sedan",
//                Color = "White",
//                Transmission = Transmission.CVT,
//                Mileage = 3500.0d,
//                Features = "Air Conditioner,Keyless Entry,Lane Departure Warning",
//                Condition = Condition.New,
//                PricePerDay = 12000.00m,
//                LicensePlate = "PQR345",
//                RentalLocation = "Residential Branch",
//                Gps = Gps.Optional,
//                ImageUrl = "https://img.freepik.com/free-vector/white-sedan-car-isolated-white-vector_53876-67413.jpg?w=740&t=st=1693468993~exp=1693469593~hmac=85da748d4aaa3d7e6b355f713443f4d83c1b7657c921d615f0700aa0b2a91c24",
//                ThumbNailImageUrl = "https://i.pinimg.com/236x/25/e7/e4/25e7e47750265a7bdc3b6eb49785e5cb.jpg",
//                Description = "Step into the future of driving with the 2023 Nissan Altima, a contemporary and efficient sedan in classic white. This new model is equipped with a fuel-efficient 2.5L engine and seamless Apple CarPlay integration, allowing you to stay connected and entertained on the road. Whether you're commuting to work or embarking on a weekend road trip, the Altima offers the perfect blend of comfort and convenience. With a spacious interior and a medium-sized luggage capacity, it's well-suited for urban explorations and beyond. Priced at just $45 per day, this stylish sedan is available for rent from our residential branch, making it an ideal choice for your next adventure."

//            });

//            modelBuilder.Entity<Car>().HasData(new Car
//            {
//                Id = Guid.NewGuid().ToString(),
//                Brand = "BMW",
//                Model = "X5",
//                Year = 2022,
//                BodyStyle = "SUV",
//                Color = "Dark Grey",
//                Transmission = Transmission.Automatic,
//                Mileage = 12000.0d,
//                Features = "Air Conditioner,Virtual Cockpit,Adaptive Cruise Control",
//                Condition = Condition.Used,
//                PricePerDay = 27790.00m,
//                LicensePlate = "STU678",
//                RentalLocation = "Luxury Branch",
//                Gps = Gps.Included,
//                ImageUrl = "https://img.freepik.com/free-vector/black-sedan-car-isolated-white-vector_53876-64403.jpg?w=740&t=st=1693469071~exp=1693469671~hmac=e9294ad93de6cf4e47d7fcee1d010df6fd0c1c41b64dc6508bb1e91bcad4ea8b",
//                ThumbNailImageUrl = "https://i.pinimg.com/236x/25/e7/e4/25e7e47750265a7bdc3b6eb49785e5cb.jpg",
//                Description = "Experience the epitome of luxury and performance with the 2022 BMW X5, a sophisticated SUV in a striking shade of dark gray. This vehicle is designed to impress, boasting a powerful 3.0L engine that delivers an exhilarating driving experience. Inside, you'll find a panoramic roof that bathes the cabin in natural light, creating an open and airy atmosphere. Whether you're planning a weekend getaway or a special occasion, the BMW X5 is ready to elevate your journey. It's like-new, meticulously maintained, and available for rent at $75 per day from our luxury branch. Treat yourself to the elegance and power of the BMW X5 today"

//            });

//            modelBuilder.Entity<Car>().HasData(new Car
//            {
//                Id = Guid.NewGuid().ToString(),
//                Brand = "Hyundai",
//                Model = "Tuscon",
//                Year = 2023,
//                BodyStyle = "Crossover",
//                Color = "Silver",
//                Transmission = Transmission.Automatic,
//                Mileage = 4000.0d,
//                Features = "Air Conditioner,Panoramic Roof,Advanced Driver Assistance",
//                Condition = Condition.New,
//                PricePerDay = 12900.00m,
//                LicensePlate = "VWX901",
//                RentalLocation = "Urban Branch",
//                Gps = Gps.Optional,
//                ImageUrl = "https://img.freepik.com/free-vector/white-hatchback-car-isolated-white-vector_53876-67619.jpg?w=740&t=st=1693469151~exp=1693469751~hmac=42020cd6b47cea4989913352d633ee1f077224ae04331702d18a80b9978f4160",
//                ThumbNailImageUrl = "https://i.pinimg.com/236x/25/e7/e4/25e7e47750265a7bdc3b6eb49785e5cb.jpg",
//                Description = "Navigate the city in style with the 2023 Hyundai Tucson, a versatile and feature-packed crossover in timeless silver. Designed to make your daily commute or urban exploration a breeze, this Hyundai offers seamless Apple CarPlay integration and advanced lane-keeping assist for added safety. With its medium luggage capacity and spacious interior, it's perfectly suited for both daily routines and spontaneous getaways. Priced at just $50 per day, it's an affordable choice for those seeking comfort, convenience, and modern technology. Rent the 2023 Hyundai Tucson today from our conveniently located urban branch and experience the best in contemporary driving."

//            });

//            modelBuilder.Entity<Car>().HasData(new Car
//            {
//                Id = Guid.NewGuid().ToString(),
//                Brand = "Mercedes Benz",
//                Model = "C-Class",
//                Year = 2021,
//                BodyStyle = "Sedan",
//                Color = "Black",
//                Transmission = Transmission.Automatic,
//                Mileage = 9000.0d,
//                Features = "Air Conditioner,Apple CarPlay,Lane Keeping Assistance",
//                Condition = Condition.Used,
//                PricePerDay = 18000.00m,
//                LicensePlate = "XYZ234",
//                RentalLocation = "Downtown Branch",
//                Gps = Gps.Included,
//                ImageUrl = "https://img.freepik.com/free-vector/black-sedan-car-isolated-white-vector_53876-64403.jpg?w=740&t=st=1693469250~exp=1693469850~hmac=f3510a48665977358efbfbbb4feda40e4219fbb151376d0201abff0be083f5e0",
//                ThumbNailImageUrl = "https://i.pinimg.com/236x/25/e7/e4/25e7e47750265a7bdc3b6eb49785e5cb.jpg",
//                Description = $"Indulge in a world of sophistication and comfort with the 2021 Mercedes-Benz C-Class, an elegant black sedan that exudes luxury. This vehicle is designed for those who appreciate the finer things in life, with plush leather seats and a premium sound system that transforms your journeys into auditory delights. Its like-new condition ensures a smooth and worry-free driving experience. Whether you're planning a night out in the city or an important business meeting, the C-Class is the perfect choice to make a lasting impression. Available for rent at $65 per day from our downtown branch, it's your ticket to arriving in style and comfort"

//            });

//            modelBuilder.Entity<Car>().HasData(new Car
//            {
//                Id = Guid.NewGuid().ToString(),
//                Brand = "Subaru",
//                Model = "Outback",
//                Year = 2023,
//                BodyStyle = "Wagon",
//                Color = "Green",
//                Transmission = Transmission.CVT,
//                Mileage = 2500.0d,
//                Features = "Air Conditioner,Leather Seats,Premium Sound System",
//                Condition = Condition.New,
//                PricePerDay = 13000.00m,
//                LicensePlate = "ABC567",
//                RentalLocation = "Suburb Branch",
//                Gps = Gps.Included,
//                ImageUrl = "https://img.freepik.com/premium-vector/realistic-green-sport-two-tone-luxury-car-set-grey-metallic-background-vector_33869-3705.jpg?w=826",
//                ThumbNailImageUrl = "https://i.pinimg.com/236x/25/e7/e4/25e7e47750265a7bdc3b6eb49785e5cb.jpg",
//                Description = "Embrace the spirit of adventure with the 2023 Subaru Outback, a vibrant green wagon that's ready to tackle any terrain. With its all-wheel-drive capability and roof rack, this Subaru is your go-to companion for outdoor escapades. Whether you're planning a camping trip, a scenic road journey, or simply need extra cargo space, the Outback has got you covered. This like-new wagon is priced at an affordable $55 per day and is available for rent from our convenient suburb branch. Don't miss the opportunity to explore the great outdoors in style and comfort with the 2023 Subaru Outback"

//            });

//            modelBuilder.Entity<Car>().HasData(new Car
//            {
//                Id = Guid.NewGuid().ToString(),
//                Brand = "Audi",
//                Model = "A4",
//                Year = 2022,
//                BodyStyle = "Sedan",
//                Color = "Blue",
//                Transmission = Transmission.Automatic,
//                Mileage = 7500.0d,
//                Features = "Air Conditioner,All-Wheel Drive,Roof Rack",
//                Condition = Condition.Used,
//                PricePerDay = 28470.00m,
//                LicensePlate = "DEF678",
//                RentalLocation = "Airport Branch",
//                Gps = Gps.Optional,
//                ImageUrl = "https://img.freepik.com/free-vector/blue-hatchback-car-isolated-white-vector_53876-67408.jpg?w=740&t=st=1693469399~exp=1693469999~hmac=32c8b4fcec147544bfb4919c72de1bc1229d202c4bd18741bdcb065f908b2be3",
//                ThumbNailImageUrl = "https://i.pinimg.com/236x/25/e7/e4/25e7e47750265a7bdc3b6eb49785e5cb.jpg",
//                Description = "Elevate your airport arrival experience with the 2022 Audi A4, a sleek and stylish blue sedan that blends performance with sophistication. The Audi A4 boasts an advanced Virtual Cockpit and adaptive cruise control, ensuring that your journey is both technologically advanced and comfortable. Whether you're arriving in town for a business meeting or embarking on a leisurely vacation, this Audi offers the perfect blend of luxury and practicality. It's like-new, meticulously maintained, and available for rent at $70 per day from our airport branch. Treat yourself to the Audi experience and make your arrival memorable"

//            });
//        }
//    }
//}
