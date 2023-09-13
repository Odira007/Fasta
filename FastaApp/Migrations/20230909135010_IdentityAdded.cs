//using System;
//using Microsoft.EntityFrameworkCore.Migrations;

//namespace FastaApp.Migrations
//{
//    public partial class IdentityAdded : Migration
//    {
//        protected override void Up(MigrationBuilder migrationBuilder)
//        {
//            migrationBuilder.CreateTable(
//                name: "AspNetRoles",
//                columns: table => new
//                {
//                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
//                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
//                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
//                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
//                },
//                constraints: table =>
//                {
//                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
//                });

//            migrationBuilder.CreateTable(
//                name: "AspNetUsers",
//                columns: table => new
//                {
//                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
//                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
//                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
//                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
//                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
//                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
//                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
//                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
//                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
//                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
//                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
//                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
//                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
//                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
//                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
//                },
//                constraints: table =>
//                {
//                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
//                });

//            migrationBuilder.CreateTable(
//                name: "Cars",
//                columns: table => new
//                {
//                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
//                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: true),
//                    Model = table.Column<string>(type: "nvarchar(max)", nullable: true),
//                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
//                    Mileage = table.Column<double>(type: "float", nullable: false),
//                    Transmission = table.Column<int>(type: "int", nullable: false),
//                    Condition = table.Column<int>(type: "int", nullable: false),
//                    RentalLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
//                    Gps = table.Column<int>(type: "int", nullable: false),
//                    PricePerDay = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
//                    BodyStyle = table.Column<string>(type: "nvarchar(max)", nullable: true),
//                    Year = table.Column<int>(type: "int", nullable: false),
//                    LicensePlate = table.Column<string>(type: "nvarchar(max)", nullable: true),
//                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
//                    ThumbNailImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
//                    Features = table.Column<string>(type: "nvarchar(max)", nullable: true)
//                },
//                constraints: table =>
//                {
//                    table.PrimaryKey("PK_Cars", x => x.Id);
//                });

//            migrationBuilder.CreateTable(
//                name: "AspNetRoleClaims",
//                columns: table => new
//                {
//                    Id = table.Column<int>(type: "int", nullable: false)
//                        .Annotation("SqlServer:Identity", "1, 1"),
//                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
//                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
//                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
//                },
//                constraints: table =>
//                {
//                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
//                    table.ForeignKey(
//                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
//                        column: x => x.RoleId,
//                        principalTable: "AspNetRoles",
//                        principalColumn: "Id",
//                        onDelete: ReferentialAction.Cascade);
//                });

//            migrationBuilder.CreateTable(
//                name: "AspNetUserClaims",
//                columns: table => new
//                {
//                    Id = table.Column<int>(type: "int", nullable: false)
//                        .Annotation("SqlServer:Identity", "1, 1"),
//                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
//                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
//                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
//                },
//                constraints: table =>
//                {
//                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
//                    table.ForeignKey(
//                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
//                        column: x => x.UserId,
//                        principalTable: "AspNetUsers",
//                        principalColumn: "Id",
//                        onDelete: ReferentialAction.Cascade);
//                });

//            migrationBuilder.CreateTable(
//                name: "AspNetUserLogins",
//                columns: table => new
//                {
//                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
//                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
//                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
//                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
//                },
//                constraints: table =>
//                {
//                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
//                    table.ForeignKey(
//                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
//                        column: x => x.UserId,
//                        principalTable: "AspNetUsers",
//                        principalColumn: "Id",
//                        onDelete: ReferentialAction.Cascade);
//                });

//            migrationBuilder.CreateTable(
//                name: "AspNetUserRoles",
//                columns: table => new
//                {
//                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
//                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
//                },
//                constraints: table =>
//                {
//                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
//                    table.ForeignKey(
//                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
//                        column: x => x.RoleId,
//                        principalTable: "AspNetRoles",
//                        principalColumn: "Id",
//                        onDelete: ReferentialAction.Cascade);
//                    table.ForeignKey(
//                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
//                        column: x => x.UserId,
//                        principalTable: "AspNetUsers",
//                        principalColumn: "Id",
//                        onDelete: ReferentialAction.Cascade);
//                });

//            migrationBuilder.CreateTable(
//                name: "AspNetUserTokens",
//                columns: table => new
//                {
//                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
//                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
//                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
//                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
//                },
//                constraints: table =>
//                {
//                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
//                    table.ForeignKey(
//                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
//                        column: x => x.UserId,
//                        principalTable: "AspNetUsers",
//                        principalColumn: "Id",
//                        onDelete: ReferentialAction.Cascade);
//                });

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

//            migrationBuilder.CreateIndex(
//                name: "IX_AspNetRoleClaims_RoleId",
//                table: "AspNetRoleClaims",
//                column: "RoleId");

//            migrationBuilder.CreateIndex(
//                name: "RoleNameIndex",
//                table: "AspNetRoles",
//                column: "NormalizedName",
//                unique: true,
//                filter: "[NormalizedName] IS NOT NULL");

//            migrationBuilder.CreateIndex(
//                name: "IX_AspNetUserClaims_UserId",
//                table: "AspNetUserClaims",
//                column: "UserId");

//            migrationBuilder.CreateIndex(
//                name: "IX_AspNetUserLogins_UserId",
//                table: "AspNetUserLogins",
//                column: "UserId");

//            migrationBuilder.CreateIndex(
//                name: "IX_AspNetUserRoles_RoleId",
//                table: "AspNetUserRoles",
//                column: "RoleId");

//            migrationBuilder.CreateIndex(
//                name: "EmailIndex",
//                table: "AspNetUsers",
//                column: "NormalizedEmail");

//            migrationBuilder.CreateIndex(
//                name: "UserNameIndex",
//                table: "AspNetUsers",
//                column: "NormalizedUserName",
//                unique: true,
//                filter: "[NormalizedUserName] IS NOT NULL");
//        }

//        protected override void Down(MigrationBuilder migrationBuilder)
//        {
//            migrationBuilder.DropTable(
//                name: "AspNetRoleClaims");

//            migrationBuilder.DropTable(
//                name: "AspNetUserClaims");

//            migrationBuilder.DropTable(
//                name: "AspNetUserLogins");

//            migrationBuilder.DropTable(
//                name: "AspNetUserRoles");

//            migrationBuilder.DropTable(
//                name: "AspNetUserTokens");

//            migrationBuilder.DropTable(
//                name: "Cars");

//            migrationBuilder.DropTable(
//                name: "AspNetRoles");

//            migrationBuilder.DropTable(
//                name: "AspNetUsers");
//        }
//    }
//}
