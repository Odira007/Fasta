//using Microsoft.EntityFrameworkCore.Migrations;

//namespace FastaApp.Migrations
//{
//    public partial class AddedCarDescription : Migration
//    {
//        protected override void Up(MigrationBuilder migrationBuilder)
//        {
//            migrationBuilder.DeleteData(
//                table: "Cars",
//                keyColumn: "Id",
//                keyValue: "5fdb7407-9c9c-4f4c-a8b5-5f21a3852809");

//            migrationBuilder.DeleteData(
//                table: "Cars",
//                keyColumn: "Id",
//                keyValue: "79fb5057-69b9-4ec9-9282-730d13d86378");

//            migrationBuilder.DeleteData(
//                table: "Cars",
//                keyColumn: "Id",
//                keyValue: "9880c842-9bef-4fdb-90b0-26d070b91acb");

//            migrationBuilder.DeleteData(
//                table: "Cars",
//                keyColumn: "Id",
//                keyValue: "9e7f2fd7-5338-428a-af7c-a652ff8738e3");

//            migrationBuilder.DeleteData(
//                table: "Cars",
//                keyColumn: "Id",
//                keyValue: "a7775604-d52d-4761-9be8-5facba647222");

//            migrationBuilder.DeleteData(
//                table: "Cars",
//                keyColumn: "Id",
//                keyValue: "b47cb55e-1586-47d4-80d6-a305284b519d");

//            migrationBuilder.DeleteData(
//                table: "Cars",
//                keyColumn: "Id",
//                keyValue: "bc54f743-ccfb-4561-b50f-667415f785df");

//            migrationBuilder.DeleteData(
//                table: "Cars",
//                keyColumn: "Id",
//                keyValue: "cc94e49a-5fb3-4056-b499-00c878c99bb7");

//            migrationBuilder.DeleteData(
//                table: "Cars",
//                keyColumn: "Id",
//                keyValue: "fd45b881-3bfc-4ba8-8228-45c0a4a41779");

//            migrationBuilder.DeleteData(
//                table: "Cars",
//                keyColumn: "Id",
//                keyValue: "fd4ef50b-1191-4f54-b156-916e4dbb8b08");

//            migrationBuilder.AddColumn<string>(
//                name: "Description",
//                table: "Cars",
//                type: "nvarchar(max)",
//                nullable: true);


//            migrationBuilder.InsertData(
//                table: "Cars",
//                columns: new[] { "Id", "BodyStyle", "Brand", "Color", "Condition", "Description", "Features", "Gps", "ImageUrl", "LicensePlate", "Mileage", "Model", "PricePerDay", "RentalLocation", "ThumbNailImageUrl", "Transmission", "Year" },
//                values: new object[,]
//                {
//                    { "12ee631b-e38d-4cba-b6d3-b01e9fe72973", "Sedan", "Toyota", "Silver", 1, "Embark on your next adventure in the 2022 Toyota Corolla, a reliable and well-maintained sedan in a classic silver finish. This vehicle offers a seamless blend of style, comfort, and technology, making it the perfect choice for both urban and highway driving. The Corolla is equipped with a fuel-efficient 1.8L engine, ensuring that your journeys are not only enjoyable but also eco-friendly. Inside, you'll find modern features, including Bluetooth connectivity for hands-free calling and music streaming, as well as a convenient backup camera to assist with parking and maneuvering in tight spaces. With seating for up to five passengers, it's an excellent choice for family trips or group outings. Despite being a used car, it feels like new, and you can enjoy all its perks for just $40 per day.", "Air Conditioner,Bluetooth,Backup Camera", 0, "https://i.pinimg.com/236x/74/61/4d/74614d884940788ce8d1a6ef46fcb8a9.jpg", "ABC123", 10000.0, "Corolla", 15000.00m, "Downtown Branch", "https://i.pinimg.com/236x/25/e7/e4/25e7e47750265a7bdc3b6eb49785e5cb.jpg", 1, 2022 },
//                    { "627c621c-fa4f-4942-9969-8982ea4d2c07", "Coupe", "Ford", "Red", 0, "Unleash the power and sophistication of the 2023 Ford Mustang, a red-hot coupe designed for thrill-seekers and performance enthusiasts. This brand-new Mustang is the epitome of style, speed, and cutting-edge technology. Beneath the hood lies a potent 2.3L engine, offering a heart-pounding driving experience that's sure to ignite your passion for the road. The Mustang's manual transmission provides an intimate connection between driver and machine, making every gear shift a memorable experience. Whether you're planning a weekend getaway or simply want to make a statement, this Mustang is the perfect choice. For just $60 per day, you can commandeer this automotive marvel, available for rent starting from 09/02/2023 at our Airport Branch", "Air Conditioner,Leather Seats,Apple CarPlay", 1, "https://img.freepik.com/premium-vector/car_27088-93.jpg?w=826", "DEF456", 5000.0, "Mustang", 25080.00m, "Airport Branch", "https://i.pinimg.com/236x/25/e7/e4/25e7e47750265a7bdc3b6eb49785e5cb.jpg", 0, 2023 },
//                    { "2c2c07a2-54f2-4c48-aa2d-e142e4be7673", "SUV", "Honda", "Blue", 1, "Experience the environmentally conscious driving pleasure of the 2021 Honda CR-V in a mesmerizing shade of blue. This well-maintained SUV is equipped with all-wheel drive, ensuring exceptional stability and control on diverse terrains. The spacious interior accommodates up to five passengers comfortably, making it ideal for family outings or group adventures. You'll find a sunroof that adds an extra touch of luxury and the opportunity to soak in the natural surroundings during your journey. Plus, with comprehensive insurance coverage, you can embark on your travels with confidence. Rent the 2021 Honda CR-V today for just $55 per day from our conveniently located suburb branch.", "All-Wheel Drive,Air Conditioner,Sunroof", 0, "https://img.freepik.com/premium-vector/realistic-vector-blue-city-car-coupe-sport-transportation-isolated-background_33869-3203.jpg?w=826", "XYZ789", 15000.0, "CR-V", 13789.00m, "Suburb Branch", "https://i.pinimg.com/236x/25/e7/e4/25e7e47750265a7bdc3b6eb49785e5cb.jpg", 1, 2021 },
//                    { "b2ca4f4e-b457-4ba4-a4e2-46b0b1957677", "SUV", "Chevrolet", "Black", 0, "Elevate your travel experiences with the 2022 Chevrolet Tahoe, a commanding presence in sleek black. This full-size SUV is engineered for versatility, making it a perfect choice for family vacations and group getaways. Equipped with a robust 5.3L engine, the Tahoe offers ample power to tackle various terrains with ease. Inside, you'll discover the luxury of third-row seating, ensuring ample space for everyone on board. And to keep passengers entertained during long journeys, there's a rear entertainment system that's sure to keep the kids (and adults) engaged. For your peace of mind, the Tahoe comes with collision insurance coverage, so you can relax and enjoy your adventures. Rent this spacious and stylish SUV today for $85 per day from our city center branch.", "Air Conditioner,Third-Row Seating,Rear Entertainment System", 0, "https://img.freepik.com/premium-vector/car-illustration_74218-174.jpg?w=826", "MNO102", 8000.0, "Tahoe", 30090.00m, "City Center Branch", "https://i.pinimg.com/236x/25/e7/e4/25e7e47750265a7bdc3b6eb49785e5cb.jpg", 1, 2022 },
//                    { "8736f6ad-c695-4f5b-986c-8708d2f9dc60", "Sedan", "Nissan", "White", 0, "Step into the future of driving with the 2023 Nissan Altima, a contemporary and efficient sedan in classic white. This new model is equipped with a fuel-efficient 2.5L engine and seamless Apple CarPlay integration, allowing you to stay connected and entertained on the road. Whether you're commuting to work or embarking on a weekend road trip, the Altima offers the perfect blend of comfort and convenience. With a spacious interior and a medium-sized luggage capacity, it's well-suited for urban explorations and beyond. Priced at just $45 per day, this stylish sedan is available for rent from our residential branch, making it an ideal choice for your next adventure.", "Air Conditioner,Keyless Entry,Lane Departure Warning", 1, "https://img.freepik.com/free-vector/white-sedan-car-isolated-white-vector_53876-67413.jpg?w=740&t=st=1693468993~exp=1693469593~hmac=85da748d4aaa3d7e6b355f713443f4d83c1b7657c921d615f0700aa0b2a91c24", "PQR345", 3500.0, "Altima", 12000.00m, "Residential Branch", "https://i.pinimg.com/236x/25/e7/e4/25e7e47750265a7bdc3b6eb49785e5cb.jpg", 2, 2023 },
//                    { "c19d0350-1ead-4d3c-a039-c8aa5eed1813", "SUV", "BMW", "Dark Grey", 1, "Experience the epitome of luxury and performance with the 2022 BMW X5, a sophisticated SUV in a striking shade of dark gray. This vehicle is designed to impress, boasting a powerful 3.0L engine that delivers an exhilarating driving experience. Inside, you'll find a panoramic roof that bathes the cabin in natural light, creating an open and airy atmosphere. Whether you're planning a weekend getaway or a special occasion, the BMW X5 is ready to elevate your journey. It's like-new, meticulously maintained, and available for rent at $75 per day from our luxury branch. Treat yourself to the elegance and power of the BMW X5 today", "Air Conditioner,Virtual Cockpit,Adaptive Cruise Control", 0, "https://img.freepik.com/free-vector/black-sedan-car-isolated-white-vector_53876-64403.jpg?w=740&t=st=1693469071~exp=1693469671~hmac=e9294ad93de6cf4e47d7fcee1d010df6fd0c1c41b64dc6508bb1e91bcad4ea8b", "STU678", 12000.0, "X5", 27790.00m, "Luxury Branch", "https://i.pinimg.com/236x/25/e7/e4/25e7e47750265a7bdc3b6eb49785e5cb.jpg", 1, 2022 },
//                    { "ebdc2804-eac6-4704-8961-07dfadd5f3c9", "Crossover", "Hyundai", "Silver", 0, "Navigate the city in style with the 2023 Hyundai Tucson, a versatile and feature-packed crossover in timeless silver. Designed to make your daily commute or urban exploration a breeze, this Hyundai offers seamless Apple CarPlay integration and advanced lane-keeping assist for added safety. With its medium luggage capacity and spacious interior, it's perfectly suited for both daily routines and spontaneous getaways. Priced at just $50 per day, it's an affordable choice for those seeking comfort, convenience, and modern technology. Rent the 2023 Hyundai Tucson today from our conveniently located urban branch and experience the best in contemporary driving.", "Air Conditioner,Panoramic Roof,Advanced Driver Assistance", 1, "https://img.freepik.com/free-vector/white-hatchback-car-isolated-white-vector_53876-67619.jpg?w=740&t=st=1693469151~exp=1693469751~hmac=42020cd6b47cea4989913352d633ee1f077224ae04331702d18a80b9978f4160", "VWX901", 4000.0, "Tuscon", 12900.00m, "Urban Branch", "https://i.pinimg.com/236x/25/e7/e4/25e7e47750265a7bdc3b6eb49785e5cb.jpg", 1, 2023 },
//                    { "8d228ee2-e685-4361-b9e3-60d71101632f", "Sedan", "Mercedes Benz", "Black", 1, "Indulge in a world of sophistication and comfort with the 2021 Mercedes-Benz C-Class, an elegant black sedan that exudes luxury. This vehicle is designed for those who appreciate the finer things in life, with plush leather seats and a premium sound system that transforms your journeys into auditory delights. Its like-new condition ensures a smooth and worry-free driving experience. Whether you're planning a night out in the city or an important business meeting, the C-Class is the perfect choice to make a lasting impression. Available for rent at $65 per day from our downtown branch, it's your ticket to arriving in style and comfort", "Air Conditioner,Apple CarPlay,Lane Keeping Assistance", 0, "https://img.freepik.com/free-vector/black-sedan-car-isolated-white-vector_53876-64403.jpg?w=740&t=st=1693469250~exp=1693469850~hmac=f3510a48665977358efbfbbb4feda40e4219fbb151376d0201abff0be083f5e0", "XYZ234", 9000.0, "C-Class", 18000.00m, "Downtown Branch", "https://i.pinimg.com/236x/25/e7/e4/25e7e47750265a7bdc3b6eb49785e5cb.jpg", 1, 2021 },
//                    { "57c4c993-b063-43c9-b7ce-0763da78f227", "Wagon", "Subaru", "Green", 0, "Embrace the spirit of adventure with the 2023 Subaru Outback, a vibrant green wagon that's ready to tackle any terrain. With its all-wheel-drive capability and roof rack, this Subaru is your go-to companion for outdoor escapades. Whether you're planning a camping trip, a scenic road journey, or simply need extra cargo space, the Outback has got you covered. This like-new wagon is priced at an affordable $55 per day and is available for rent from our convenient suburb branch. Don't miss the opportunity to explore the great outdoors in style and comfort with the 2023 Subaru Outback", "Air Conditioner,Leather Seats,Premium Sound System", 0, "https://img.freepik.com/premium-vector/realistic-green-sport-two-tone-luxury-car-set-grey-metallic-background-vector_33869-3705.jpg?w=826", "ABC567", 2500.0, "Outback", 13000.00m, "Suburb Branch", "https://i.pinimg.com/236x/25/e7/e4/25e7e47750265a7bdc3b6eb49785e5cb.jpg", 2, 2023 },
//                    { "7d25bc24-ba01-4a9b-9548-810a919b2a62", "Sedan", "Audi", "Blue", 1, "Elevate your airport arrival experience with the 2022 Audi A4, a sleek and stylish blue sedan that blends performance with sophistication. The Audi A4 boasts an advanced Virtual Cockpit and adaptive cruise control, ensuring that your journey is both technologically advanced and comfortable. Whether you're arriving in town for a business meeting or embarking on a leisurely vacation, this Audi offers the perfect blend of luxury and practicality. It's like-new, meticulously maintained, and available for rent at $70 per day from our airport branch. Treat yourself to the Audi experience and make your arrival memorable", "Air Conditioner,All-Wheel Drive,Roof Rack", 1, "https://img.freepik.com/free-vector/blue-hatchback-car-isolated-white-vector_53876-67408.jpg?w=740&t=st=1693469399~exp=1693469999~hmac=32c8b4fcec147544bfb4919c72de1bc1229d202c4bd18741bdcb065f908b2be3", "DEF678", 7500.0, "A4", 28470.00m, "Airport Branch", "https://i.pinimg.com/236x/25/e7/e4/25e7e47750265a7bdc3b6eb49785e5cb.jpg", 1, 2022 }
//                });
//        }

//        protected override void Down(MigrationBuilder migrationBuilder)
//        {
//            migrationBuilder.DeleteData(
//                table: "Cars",
//                keyColumn: "Id",
//                keyValue: "12ee631b-e38d-4cba-b6d3-b01e9fe72973");

//            migrationBuilder.DeleteData(
//                table: "Cars",
//                keyColumn: "Id",
//                keyValue: "2c2c07a2-54f2-4c48-aa2d-e142e4be7673");

//            migrationBuilder.DeleteData(
//                table: "Cars",
//                keyColumn: "Id",
//                keyValue: "57c4c993-b063-43c9-b7ce-0763da78f227");

//            migrationBuilder.DeleteData(
//                table: "Cars",
//                keyColumn: "Id",
//                keyValue: "627c621c-fa4f-4942-9969-8982ea4d2c07");

//            migrationBuilder.DeleteData(
//                table: "Cars",
//                keyColumn: "Id",
//                keyValue: "7d25bc24-ba01-4a9b-9548-810a919b2a62");

//            migrationBuilder.DeleteData(
//                table: "Cars",
//                keyColumn: "Id",
//                keyValue: "8736f6ad-c695-4f5b-986c-8708d2f9dc60");

//            migrationBuilder.DeleteData(
//                table: "Cars",
//                keyColumn: "Id",
//                keyValue: "8d228ee2-e685-4361-b9e3-60d71101632f");

//            migrationBuilder.DeleteData(
//                table: "Cars",
//                keyColumn: "Id",
//                keyValue: "b2ca4f4e-b457-4ba4-a4e2-46b0b1957677");

//            migrationBuilder.DeleteData(
//                table: "Cars",
//                keyColumn: "Id",
//                keyValue: "c19d0350-1ead-4d3c-a039-c8aa5eed1813");

//            migrationBuilder.DeleteData(
//                table: "Cars",
//                keyColumn: "Id",
//                keyValue: "ebdc2804-eac6-4704-8961-07dfadd5f3c9");

//            migrationBuilder.DropColumn(
//                name: "Description",
//                table: "Cars");

//            migrationBuilder.InsertData(
//                table: "Cars",
//                columns: new[] { "Id", "BodyStyle", "Brand", "Color", "Condition", "Features", "Gps", "ImageUrl", "LicensePlate", "Mileage", "Model", "PricePerDay", "RentalLocation", "ThumbNailImageUrl", "Transmission", "Year" },
//                values: new object[,]
//                {
//                    { "fd4ef50b-1191-4f54-b156-916e4dbb8b08", "Sedan", "Toyota", "Silver", 1, "Air Conditioner,Bluetooth,Backup Camera", 0, "https://i.pinimg.com/236x/74/61/4d/74614d884940788ce8d1a6ef46fcb8a9.jpg", "ABC123", 10000.0, "Corolla", 15000.00m, "Downtown Branch", "https://i.pinimg.com/236x/25/e7/e4/25e7e47750265a7bdc3b6eb49785e5cb.jpg", 1, 2022 },
//                    { "79fb5057-69b9-4ec9-9282-730d13d86378", "Coupe", "Ford", "Red", 0, "Air Conditioner,Leather Seats,Apple CarPlay", 1, "https://img.freepik.com/premium-vector/car_27088-93.jpg?w=826", "DEF456", 5000.0, "Mustang", 25080.00m, "Airport Branch", "https://i.pinimg.com/236x/25/e7/e4/25e7e47750265a7bdc3b6eb49785e5cb.jpg", 0, 2023 },
//                    { "5fdb7407-9c9c-4f4c-a8b5-5f21a3852809", "SUV", "Honda", "Blue", 1, "All-Wheel Drive,Air Conditioner,Sunroof", 0, "https://img.freepik.com/premium-vector/realistic-vector-blue-city-car-coupe-sport-transportation-isolated-background_33869-3203.jpg?w=826", "XYZ789", 15000.0, "CR-V", 13789.00m, "Suburb Branch", "https://i.pinimg.com/236x/25/e7/e4/25e7e47750265a7bdc3b6eb49785e5cb.jpg", 1, 2021 },
//                    { "b47cb55e-1586-47d4-80d6-a305284b519d", "SUV", "Chevrolet", "Black", 0, "Air Conditioner,Third-Row Seating,Rear Entertainment System", 0, "https://img.freepik.com/premium-vector/car-illustration_74218-174.jpg?w=826", "MNO102", 8000.0, "Tahoe", 30090.00m, "City Center Branch", "https://i.pinimg.com/236x/25/e7/e4/25e7e47750265a7bdc3b6eb49785e5cb.jpg", 1, 2022 },
//                    { "9e7f2fd7-5338-428a-af7c-a652ff8738e3", "Sedan", "Nissan", "White", 0, "Air Conditioner,Keyless Entry,Lane Departure Warning", 1, "https://img.freepik.com/free-vector/white-sedan-car-isolated-white-vector_53876-67413.jpg?w=740&t=st=1693468993~exp=1693469593~hmac=85da748d4aaa3d7e6b355f713443f4d83c1b7657c921d615f0700aa0b2a91c24", "PQR345", 3500.0, "Altima", 12000.00m, "Residential Branch", "https://i.pinimg.com/236x/25/e7/e4/25e7e47750265a7bdc3b6eb49785e5cb.jpg", 2, 2023 },
//                    { "cc94e49a-5fb3-4056-b499-00c878c99bb7", "SUV", "BMW", "Dark Grey", 1, "Air Conditioner,Virtual Cockpit,Adaptive Cruise Control", 0, "https://img.freepik.com/free-vector/black-sedan-car-isolated-white-vector_53876-64403.jpg?w=740&t=st=1693469071~exp=1693469671~hmac=e9294ad93de6cf4e47d7fcee1d010df6fd0c1c41b64dc6508bb1e91bcad4ea8b", "STU678", 12000.0, "X5", 27790.00m, "Luxury Branch", "https://i.pinimg.com/236x/25/e7/e4/25e7e47750265a7bdc3b6eb49785e5cb.jpg", 1, 2022 },
//                    { "fd45b881-3bfc-4ba8-8228-45c0a4a41779", "Crossover", "Hyundai", "Silver", 0, "Air Conditioner,Panoramic Roof,Advanced Driver Assistance", 1, "https://img.freepik.com/free-vector/white-hatchback-car-isolated-white-vector_53876-67619.jpg?w=740&t=st=1693469151~exp=1693469751~hmac=42020cd6b47cea4989913352d633ee1f077224ae04331702d18a80b9978f4160", "VWX901", 4000.0, "Tuscon", 12900.00m, "Urban Branch", "https://i.pinimg.com/236x/25/e7/e4/25e7e47750265a7bdc3b6eb49785e5cb.jpg", 1, 2023 },
//                    { "a7775604-d52d-4761-9be8-5facba647222", "Sedan", "Mercedes Benz", "Black", 1, "Air Conditioner,Apple CarPlay,Lane Keeping Assistance", 0, "https://img.freepik.com/free-vector/black-sedan-car-isolated-white-vector_53876-64403.jpg?w=740&t=st=1693469250~exp=1693469850~hmac=f3510a48665977358efbfbbb4feda40e4219fbb151376d0201abff0be083f5e0", "XYZ234", 9000.0, "C-Class", 18000.00m, "Downtown Branch", "https://i.pinimg.com/236x/25/e7/e4/25e7e47750265a7bdc3b6eb49785e5cb.jpg", 1, 2021 },
//                    { "9880c842-9bef-4fdb-90b0-26d070b91acb", "Wagon", "Subaru", "Green", 0, "Air Conditioner,Leather Seats,Premium Sound System", 0, "https://img.freepik.com/premium-vector/realistic-green-sport-two-tone-luxury-car-set-grey-metallic-background-vector_33869-3705.jpg?w=826", "ABC567", 2500.0, "Outback", 13000.00m, "Suburb Branch", "https://i.pinimg.com/236x/25/e7/e4/25e7e47750265a7bdc3b6eb49785e5cb.jpg", 2, 2023 },
//                    { "bc54f743-ccfb-4561-b50f-667415f785df", "Sedan", "Audi", "Blue", 1, "Air Conditioner,All-Wheel Drive,Roof Rack", 1, "https://img.freepik.com/free-vector/blue-hatchback-car-isolated-white-vector_53876-67408.jpg?w=740&t=st=1693469399~exp=1693469999~hmac=32c8b4fcec147544bfb4919c72de1bc1229d202c4bd18741bdcb065f908b2be3", "DEF678", 7500.0, "A4", 28470.00m, "Airport Branch", "https://i.pinimg.com/236x/25/e7/e4/25e7e47750265a7bdc3b6eb49785e5cb.jpg", 1, 2022 }
//                });
//        }
//    }
//}
