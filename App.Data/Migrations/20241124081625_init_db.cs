using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace App.Data.Migrations
{
    /// <inheritdoc />
    public partial class init_db : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppEquipmentType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppEquipmentType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppHotel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Slug = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PhoneNumber1 = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    PhoneNumber2 = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    ImgBanner = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppHotel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppNewsCategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Slug = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Content = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CoverImgPath = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppNewsCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppRole",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Desc = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CanDelete = table.Column<bool>(type: "bit", nullable: true),
                    DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppRole", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppRoomType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoomTypeName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PeopleStay = table.Column<int>(type: "int", maxLength: 2, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    BringPet = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppRoomType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MstPermission",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Table = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    GroupName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Desc = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MstPermission", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppEquipment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    TypeEquipmentId = table.Column<int>(type: "int", nullable: true),
                    DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppEquipment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppEquipment_AppEquipmentType_TypeEquipmentId",
                        column: x => x.TypeEquipmentId,
                        principalTable: "AppEquipmentType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppBranchHotel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Slug = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    IdMap = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    QuantityStaff = table.Column<int>(type: "int", nullable: true),
                    QuantityFloor = table.Column<int>(type: "int", nullable: true),
                    QuantityRoom = table.Column<int>(type: "int", nullable: true),
                    Img = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    HotelId = table.Column<int>(type: "int", nullable: true),
                    DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppBranchHotel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppBranchHotel_AppHotel_HotelId",
                        column: x => x.HotelId,
                        principalTable: "AppHotel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppRolePermission",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppRoleId = table.Column<int>(type: "int", nullable: false),
                    MstPermissionId = table.Column<int>(type: "int", nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppRolePermission", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppRolePermission_AppRole_AppRoleId",
                        column: x => x.AppRoleId,
                        principalTable: "AppRole",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppRolePermission_MstPermission_MstPermissionId",
                        column: x => x.MstPermissionId,
                        principalTable: "MstPermission",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppRoom",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoomName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FloorNumber = table.Column<int>(type: "int", maxLength: 6, nullable: false),
                    RoomNumber = table.Column<int>(type: "int", maxLength: 6, nullable: false),
                    Slug = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Status = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, defaultValue: "Đã trả phòng - phòng trống"),
                    Price = table.Column<decimal>(type: "decimal(18,2)", maxLength: 10, nullable: false),
                    DiscountPrice = table.Column<decimal>(type: "decimal(18,2)", maxLength: 10, nullable: true),
                    DiscountFrom = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DiscountTo = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    BranchId = table.Column<int>(type: "int", nullable: true),
                    RoomTypeId = table.Column<int>(type: "int", nullable: true),
                    DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppRoom", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppRoom_AppBranchHotel_BranchId",
                        column: x => x.BranchId,
                        principalTable: "AppBranchHotel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppRoom_AppRoomType_RoomTypeId",
                        column: x => x.RoomTypeId,
                        principalTable: "AppRoomType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppUser",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(200)", maxLength: 200, nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(200)", maxLength: 200, nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PhoneNumber1 = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    PhoneNumber2 = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    Email = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Avatar = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    BlockedTo = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BlockedBy = table.Column<int>(type: "int", nullable: true),
                    CitizenId = table.Column<int>(type: "int", maxLength: 12, nullable: true),
                    Passport = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    Permanent = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    BranchId = table.Column<int>(type: "int", nullable: true),
                    AppRoleId = table.Column<int>(type: "int", nullable: true),
                    DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUser", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppUser_AppBranchHotel_BranchId",
                        column: x => x.BranchId,
                        principalTable: "AppBranchHotel",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppUser_AppRole_AppRoleId",
                        column: x => x.AppRoleId,
                        principalTable: "AppRole",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AppImgRoom",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImgSrc = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    RoomId = table.Column<int>(type: "int", nullable: true),
                    DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppImgRoom", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppImgRoom_AppRoom_RoomId",
                        column: x => x.RoomId,
                        principalTable: "AppRoom",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppRoomEquipment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoomId = table.Column<int>(type: "int", nullable: true),
                    EquipmentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppRoomEquipment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppRoomEquipment_AppEquipment_EquipmentId",
                        column: x => x.EquipmentId,
                        principalTable: "AppEquipment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppRoomEquipment_AppRoom_RoomId",
                        column: x => x.RoomId,
                        principalTable: "AppRoom",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppComment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppComment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppComment_AppUser_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AppUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AppNews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Slug = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Summary = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Content = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Views = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L),
                    Votes = table.Column<float>(type: "real", nullable: false, defaultValue: 0f),
                    Published = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    PublishedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CoverImgPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CoverImgThumbnailPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StampPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: true),
                    DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppNews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppNews_AppNewsCategory_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "AppNewsCategory",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppNews_AppUser_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AppUser",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AppOrder",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CheckInTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckOutTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TimeStay = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalPrice = table.Column<double>(type: "float", maxLength: 10, nullable: false),
                    Deposit = table.Column<double>(type: "float", maxLength: 10, nullable: false),
                    Status = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: true),
                    DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppOrder", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppOrder_AppUser_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AppUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AppOrder_AppUser_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "AppUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AppPayroll",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Salary = table.Column<double>(type: "float", maxLength: 10, nullable: false),
                    StaffId = table.Column<int>(type: "int", nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppPayroll", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppPayroll_AppUser_StaffId",
                        column: x => x.StaffId,
                        principalTable: "AppUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AppWorkSchedule",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Day = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    StaffId = table.Column<int>(type: "int", nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppWorkSchedule", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppWorkSchedule_AppUser_StaffId",
                        column: x => x.StaffId,
                        principalTable: "AppUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppOrderDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InvoiceDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RoomName = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    RoomNumber = table.Column<int>(type: "int", maxLength: 6, nullable: false),
                    RoomType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", maxLength: 10, nullable: false),
                    DiscountPrice = table.Column<double>(type: "float", maxLength: 10, nullable: true),
                    FullNameUser = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    QuantityRoom = table.Column<int>(type: "int", maxLength: 2, nullable: false),
                    RoomId = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppOrderDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppOrderDetail_AppOrder_OrderId",
                        column: x => x.OrderId,
                        principalTable: "AppOrder",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AppOrderDetail_AppRoom_RoomId",
                        column: x => x.RoomId,
                        principalTable: "AppRoom",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AppWorkShift",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    StartTime = table.Column<TimeOnly>(type: "time", nullable: false),
                    EndTime = table.Column<TimeOnly>(type: "time", nullable: false),
                    WorkScheduleId = table.Column<int>(type: "int", nullable: true),
                    DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppWorkShift", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppWorkShift_AppWorkSchedule_WorkScheduleId",
                        column: x => x.WorkScheduleId,
                        principalTable: "AppWorkSchedule",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AppEquipmentType",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedDate", "DisplayOrder", "Name", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Trang thiết bị phòng khách", null, null },
                    { 2, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Thiết bị vệ sinh", null, null }
                });

            migrationBuilder.InsertData(
                table: "AppHotel",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedDate", "Description", "DisplayOrder", "Email", "ImgBanner", "Name", "PhoneNumber1", "PhoneNumber2", "Slug", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Khách sạn 5 sao sang trọng tại Hà Nội.", null, "info@meliahanoi.com", "https://du-lich.chudu24.com/f/m/2105/20/khach-san-melia-hanoi.jpg", "Khách Sạn Melia Hanoi", "+842438223333", null, "khach-san-melia-hanoi", null, null },
                    { 2, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Khách sạn lịch sử và sang trọng tại TP. Hồ Chí Minh.", null, "info@rexhotel.com.vn", "https://images2.thanhnien.vn/Uploaded/ttt/images/Content/tan-huong/xach-vali-di/2016_12_w2/rex_hotel/Exterior_Rex_9.jpg", "Rex Hotel Saigon", "+842838292185", null, "rex-hotel-saigon", null, null },
                    { 3, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Khách sạn ven biển tuyệt đẹp tại Đà Nẵng.", null, "info@goldenbaydanang.com", "https://www.arttravel.com.vn/upload/news/golden-bay-(4)-9448.jpg", "Khách Sạn Đà Nẵng Golden Bay", "+842363921888", null, "khach-san-da-nang-golden-bay", null, null },
                    { 4, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Khách sạn với tầm nhìn ra biển tuyệt đẹp tại Nha Trang.", null, "info@nhatranglodge.com.vn", "https://cf.bstatic.com/xdata/images/hotel/max1024x768/81022752.jpg?k=d69140451157e29655c5d19999354e86b95d3654c7ffbe68081070bc8e041518&o=&hp=1", "Khách Sạn Nha Trang Lodge", "+842583525555", null, "khach-san-nha-trang-lodge", null, null },
                    { 5, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Khách sạn sang trọng tại trung tâm Hải Phòng.", null, "info@imperialhotel.com.vn", "https://cf.bstatic.com/xdata/images/hotel/max1024x768/467550547.webp?k=df9413c20e4dc78e4dd3a98618e2815ca246f2bc27a33edf99d9f1bae10e994c&o=", "Khách Sạn Imperial Hải Phòng", "+842253888888", null, "khach-san-imperial-hai-phong", null, null },
                    { 6, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Khách sạn sang trọng tại New York.", null, "info@langhamhotels.com", "https://cdn3.ivivu.com/2023/07/The-Langham-New-York-Fifth-Avenue-ivivu.jpg", "Khách Sạn Langham, New York", "+12123338888", null, "langham-new-york", null, null },
                    { 7, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Khách sạn sang trọng tại Tokyo.", null, "info@peninsula.com", "https://tokyo-marunouchi.jp/dmo_wp_YfehP9/wp-content/uploads/2017/03/banket_pe_07.jpg", "Khách Sạn The Peninsula Tokyo", "+81362701000", null, "the-peninsula-tokyo", null, null },
                    { 8, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Khách sạn sang trọng bên bờ biển Cancun.", null, "info@ritzcarlton.com", "https://ritzcarlton.cancunhotelsweb.net/data/Pics/1080x700w/15670/1567035/1567035848/pic-ritz-carlton-hotel-cancun-5.JPEG", "Khách Sạn The Ritz-Carlton, Cancun", "+5219988916200", null, "ritz-carlton-cancun", null, null },
                    { 9, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Khách sạn nổi tiếng tại Miami, Florida.", null, "info@biltmorehotel.com", "https://biltmore-coral-gables.hotelmix.vn/data/Photos/1920x1080/2004/200471/200471074/Biltmore-Hotel-Miami-Coral-Gables-Exterior.JPEG", "Khách Sạn The Biltmore Miami", "+13055284500", null, "the-biltmore-miami", null, null },
                    { 10, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Khách sạn cao cấp tại Paris, Pháp.", null, "info@shangri-la.com", "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/2a/36/f3/e2/caption.jpg?w=1200&h=-1&s=1", "Khách Sạn Shangri-La, Paris", "+33153003030", null, "shangri-la-paris", null, null },
                    { 11, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Khách sạn sang trọng tại Seoul.", null, "info@hyatt.com", "https://www.americanexpress.com/en-us/travel/discover/photos/197/56953/1600/GHS_Exterior.jpg?ch=560", "Khách Sạn Grand Hyatt Seoul", "+8227971234", null, "grand-hyatt-seoul", null, null },
                    { 12, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Khách sạn sang trọng tại Bangkok.", null, "info@fourseasons.com", "https://theluxurytraveller.com/wp-content/uploads/2022/05/FS-Bangkok-144-1080x480.jpg", "Khách Sạn Four Seasons Bangkok", "+6622501000", null, "four-seasons-bangkok", null, null },
                    { 13, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Khách sạn đẳng cấp tại Tokyo.", null, "info@hilton.com", "https://cf.bstatic.com/xdata/images/hotel/max1024x768/483824171.jpg?k=3fc70cd0fa564972470a3a08b248feff8fa34e9f8b3f2e0343f5105499238bee&o=&hp=1", "Khách Sạn Hilton Tokyo", "+81333451111", null, "hilton-tokyo", null, null },
                    { 14, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Khách sạn hiện đại tại Hong Kong.", null, "info@whotels.com", "https://cache.marriott.com/content/dam/marriott-renditions/HKGWH/hkgwh-pool-exterior-5271-hor-feat.jpg?output-quality=70&interpolation=progressive-bilinear&downsize=1920px:*", "Khách Sạn W Hong Kong", "+85237170000", null, "w-hong-kong", null, null },
                    { 15, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Khách sạn tuyệt đẹp tại Bali.", null, "info@stregis.com", "https://res.klook.com/images/fl_lossy.progressive,q_65/c_fill,w_1200,h_630/w_80,x_15,y_15,g_south_west,l_Klook_water_br_trans_yhcmh3/activities/aqglngrp8i0ecxrlwxsm/Tr%E1%BA%A3i%20nghi%E1%BB%87m%20%E1%BA%A9m%20th%E1%BB%B1c%20t%E1%BA%A1i%20The%20St.%20Regis%20Bali%20Resort.jpg", "Khách Sạn The St. Regis Bali", "+62361775200", null, "st-regis-bali", null, null },
                    { 16, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Khách sạn sang trọng tại Bangkok.", null, "info@mandarinoriental.com", "https://upload.wikimedia.org/wikipedia/commons/e/e5/Mandarin_Oriental_Bangkok_Bang_Rak.jpg", "Khách Sạn Mandarin Oriental Bangkok", "+6626599000", null, "mandarin-oriental-bangkok", null, null },
                    { 17, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Khách sạn cổ điển tại Paris.", null, "info@dorchestercollection.com", "https://strawberrymilkevents.com/wp-content/uploads/2014/03/le-meurice-paris-1.jpg", "Khách Sạn Le Meurice, Paris", "+33144723456", null, "le-meurice-paris", null, null },
                    { 18, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Khách sạn sang trọng tại Mumbai.", null, "info@oberoihotels.com", "https://cf.bstatic.com/xdata/images/hotel/max500/28759044.jpg?k=4a3e476214895d86a0e71808d9eb5b85acaebe0cbff06bbd2ecdbb3054d98600&o=&hp=1", "Khách Sạn The Oberoi, Mumbai", "+912266202020", null, "the-oberoi-mumbai", null, null },
                    { 19, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Khách sạn ven sông tại Sydney.", null, "info@hyatt.com", "https://www.jacadatravel.com/wp-content/uploads/fly-images/157913/park-hyatt-sydney-exterior-1600x500-cc.jpg", "Khách Sạn Park Hyatt Sydney", "+61292561111", null, "park-hyatt-sydney", null, null },
                    { 20, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Khách sạn hiện đại tại Bangkok.", null, "info@sukhothai.com", "https://kyluc.vn/Userfiles/Upload/images/The%20Sukhothai%20Bangkok.jpg", "Khách Sạn The Sukhothai Bangkok", "+6623448888", null, "the-sukhothai-bangkok", null, null },
                    { 21, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Khách sạn sang trọng tại Paris.", null, "info@ritzparis.com", "https://upload.wikimedia.org/wikipedia/commons/thumb/e/ec/H%C3%B4tel_Ritz.jpg/1200px-H%C3%B4tel_Ritz.jpg", "Khách Sạn Ritz Paris", "+33143261800", null, "ritz-paris", null, null },
                    { 22, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Khách sạn 5 sao tại Mumbai.", null, "info@theleela.com", "https://d25wybtmjgh8lz.cloudfront.net/sites/default/files/styles/ph_pdp_subheader_1000_x_333/public/property/img-mastheads/bomlm_4.jpg?h=7bc7d4e1", "Khách Sạn The Leela, Mumbai", "+912266486000", null, "the-leela-mumbai", null, null },
                    { 23, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Khách sạn sang trọng tại New York.", null, "info@stregis.com", "https://upload.wikimedia.org/wikipedia/commons/thumb/4/43/The_St._Regis_Hotel_New_York.JPG/1200px-The_St._Regis_Hotel_New_York.JPG", "Khách Sạn St. Regis New York", "+12125450500", null, "st-regis-new-york", null, null },
                    { 24, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Khách sạn sang trọng tại Dubai.", null, "info@jumeirah.com", "https://cf.bstatic.com/xdata/images/district/1020x340/45235.jpg?k=daf29066fcf29a01b738ead0998e878a221a3176c033e82a170da725278bc69c&o=", "Khách Sạn Jumeirah, Dubai", "+97144028888", null, "jumeirah-dubai", null, null },
                    { 25, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Khách sạn cổ điển tại Italy.", null, "info@belmond.com", "https://www.truetrips.com/images/api/hotels/Amalfi/Belmond_Hotel_Caruso/The_Balmoral_Caruso_bn_02.jpg", "Khách Sạn Belmond Hotel Caruso", "+39089812345", null, "belmond-caruso", null, null },
                    { 26, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Khách sạn 5 sao tại Phuket.", null, "info@banyantree.com", "https://greenmore.vn/wp-content/uploads/2019/12/canh-quan-resort-nghi-duong-banyan-tree-phuket-05-compressed.jpg", "Khách Sạn Banyan Tree, Phuket", "+6676377888", null, "banyan-tree-phuket", null, null },
                    { 27, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Khách sạn sang trọng tại Dubai.", null, "info@theaddress.com", "https://cf.bstatic.com/xdata/images/hotel/max1024x768/147760688.jpg?k=9604a9318b078228b302c62aaefdfe79aa03688c6d00b953ddc65ab46a337c12&o=&hp=1", "Khách Sạn The Address, Dubai", "+97144087777", null, "the-address-dubai", null, null },
                    { 28, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Khách sạn bên bờ sông tại Bangkok.", null, "info@shangri-la.com", "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/2a/9c/cc/45/shangri-la-bangkok.jpg?w=700&h=-1&s=1", "Khách Sạn Shangri-La, Bangkok", "+6622367777", null, "shangri-la-bangkok", null, null },
                    { 29, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Khách sạn tuyệt đẹp tại Bali.", null, "info@oberoihotels.com", "https://www.hotelsinheaven.com/wp-content/uploads/2020/05/the-oberoi-beach-resort-bali-main-pool-beach-scaled-1256x1000.jpg", "Khách Sạn The Oberoi, Bali", "+62361775688", null, "the-oberoi-bali", null, null },
                    { 30, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Khách sạn 5 sao tại Tokyo.", null, "info@mandarinoriental.com", "https://cf2.bstatic.com/xdata/images/hotel/max1280x900/565155779.jpg?k=6597ca16a17e31dfa517cd3e90b398fd52a5773dfe28ff2b3e5a0baa15f1d89c&o=&hp=1", "Khách Sạn Mandarin Oriental, Tokyo", "+81357770000", null, "mandarin-oriental-tokyo", null, null }
                });

            migrationBuilder.InsertData(
                table: "AppNewsCategory",
                columns: new[] { "Id", "Content", "CoverImgPath", "CreatedBy", "CreatedDate", "DeletedDate", "DisplayOrder", "Slug", "Title", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "Cung cấp thông tin về các tour du lịch", "files/ImgNewsCate/Tour.jpg", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "tour-du-lich", "Tour du lịch", null, null },
                    { 2, "Cung cấp thông tin về các địa điểm du lịch", "files/ImgNewsCate/Places-to-travel.jpg", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "dia-diem-du-lich", "Địa điểm du lịch", null, null }
                });

            migrationBuilder.InsertData(
                table: "AppRole",
                columns: new[] { "Id", "CanDelete", "CreatedBy", "CreatedDate", "DeletedDate", "Desc", "DisplayOrder", "Name", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, false, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Quản trị quản lý toàn bộ hệ thống", null, "Quản trị toàn hệ thống", null, null },
                    { 2, true, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Quản trị quản lý toàn bộ về loại và thiết bị", null, "Quản trị toàn bộ thiết bị", null, null },
                    { 3, true, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Khách hàng", null, "Khách hàng", null, null },
                    { 4, true, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Quản trị toàn bộ về thể loại và tin tức", null, "Quản trị toàn bộ tin tức", null, null },
                    { 5, true, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Quản trị toàn bộ thể loại tin tức", null, "Quản trị thể loại tin tức", null, null },
                    { 6, true, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Quản trị toàn bộ tin tức", null, "Quản trị tin tức", null, null },
                    { 7, true, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Quản trị quản lý toàn bộ về loại trang thiết bị", null, "Quản trị loại thiết bị", null, null },
                    { 8, true, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Quản trị quản lý toàn bộ về trang thiết bị", null, "Quản trị thiết bị", null, null },
                    { 9, true, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Quản trị toàn bộ hệ thống thuộc chi nhánh Hà Nội - Melia Hà Nội", null, "Quản trị - Chi nhánh Hà Nội - Melia Hà Nội", null, null },
                    { 10, true, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Quản trị toàn bộ hệ thống thuộc chi nhánh TP. Hồ Chí Minh - Rex Hotel Sài Gòn", null, "Quản trị - Chi nhánh TP. Hồ Chí Minh - Rex Hotel Sài Gòn", null, null },
                    { 11, true, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Quản trị toàn bộ hệ thống thuộc chi nhánh Đà Nẵng - Golden Bay", null, "Quản trị - Chi nhánh Đà Nẵng - Golden Bay", null, null },
                    { 12, true, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Quản trị toàn bộ hệ thống thuộc chi nhánh Nha Trang - Lodge", null, "Quản trị - Chi nhánh Nha Trang - Lodge", null, null },
                    { 13, true, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Quản trị toàn bộ hệ thống thuộc chi nhánh Hải Phòng - Imperial", null, "Quản trị - Chi nhánh Hải Phòng - Imperial", null, null },
                    { 14, true, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Quản trị toàn bộ hệ thống thuộc chi nhánh New York - Langham", null, "Quản trị - Chi nhánh New York - Langham", null, null },
                    { 15, true, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Quản trị toàn bộ hệ thống thuộc chi nhánh Tokyo - The Peninsula Tokyo", null, "Quản trị - Chi nhánh Tokyo - The Peninsula Tokyo", null, null },
                    { 16, true, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Quản trị toàn bộ hệ thống thuộc chi nhánh Cancun - The Ritz-Carlton", null, "Quản trị - Chi nhánh Cancun - The Ritz-Carlton", null, null },
                    { 17, true, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Quản trị toàn bộ hệ thống thuộc chi nhánh Miami - The Biltmore Miami", null, "Quản trị - Chi nhánh Miami - The Biltmore Miami", null, null },
                    { 18, true, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Quản trị toàn bộ hệ thống thuộc chi nhánh Paris - Shangri-La", null, "Quản trị - Chi nhánh Paris - Shangri-La", null, null },
                    { 19, true, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Quản trị toàn bộ hệ thống thuộc chi nhánh Seoul - Grand Hyatt Seoul", null, "Quản trị - Chi nhánh Seoul - Grand Hyatt Seoul", null, null },
                    { 20, true, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Quản trị toàn bộ hệ thống thuộc chi nhánh Bangkok - Four Seasons", null, "Quản trị - Chi nhánh Bangkok - Four Seasons", null, null },
                    { 21, true, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Quản trị toàn bộ hệ thống thuộc chi nhánh Tokyo - Hilton", null, "Quản trị - Chi nhánh Tokyo - Hilton", null, null },
                    { 22, true, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Quản trị toàn bộ hệ thống thuộc chi nhánh Hong Kong - W Hong Kong", null, "Quản trị - Chi nhánh Hong Kong - W Hong Kong", null, null },
                    { 23, true, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Quản trị toàn bộ hệ thống thuộc chi nhánh Bali - The St. Regis", null, "Quản trị - Chi nhánh Bali - The St. Regis", null, null },
                    { 24, true, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Quản trị toàn bộ hệ thống thuộc chi nhánh Bangkok - Mandarin Oriental", null, "Quản trị - Chi nhánh Bangkok - Mandarin Oriental", null, null },
                    { 25, true, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Quản trị toàn bộ hệ thống thuộc chi nhánh Paris - Le Meurice", null, "Quản trị - Chi nhánh Paris - Le Meurice", null, null },
                    { 26, true, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Quản trị toàn bộ hệ thống thuộc chi nhánh Mumbai - The Oberoi", null, "Quản trị - Chi nhánh Mumbai - The Oberoi", null, null },
                    { 27, true, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Quản trị toàn bộ hệ thống thuộc chi nhánh Sydney - Park Hyatt", null, "Quản trị - Chi nhánh Sydney - Park Hyatt", null, null },
                    { 28, true, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Quản trị toàn bộ hệ thống thuộc chi nhánh Bangkok - The Sukhothai", null, "Quản trị - Chi nhánh Bangkok - The Sukhothai", null, null },
                    { 29, true, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Quản trị toàn bộ hệ thống thuộc chi nhánh Paris - Ritz", null, "Quản trị - Chi nhánh Paris - Ritz", null, null },
                    { 30, true, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Quản trị toàn bộ hệ thống thuộc chi nhánh Mumbai - Taj Mahal Palace", null, "Quản trị - Chi nhánh Mumbai - Taj Mahal Palace", null, null },
                    { 31, true, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Quản trị toàn bộ hệ thống thuộc chi nhánh New York - St. Regis", null, "Quản trị - Chi nhánh New York - St. Regis", null, null },
                    { 32, true, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Quản trị toàn bộ hệ thống thuộc chi nhánh Dubai - Jumeirah", null, "Quản trị - Chi nhánh Dubai - Jumeirah", null, null },
                    { 33, true, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Quản trị toàn bộ hệ thống thuộc chi nhánh Italy - Belmond Hotel Caruso", null, "Quản trị - Chi nhánh Italy - Belmond Hotel Caruso", null, null },
                    { 34, true, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Quản trị toàn bộ hệ thống thuộc chi nhánh Phuket - Banyan Tree", null, "Quản trị - Chi nhánh Phuket - Banyan Tree", null, null },
                    { 35, true, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Quản trị toàn bộ hệ thống thuộc chi nhánh Dubai - The Address", null, "Quản trị - Chi nhánh Dubai - The Address", null, null },
                    { 36, true, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Quản trị toàn bộ hệ thống thuộc chi nhánh Bangkok - Shangri-La", null, "Quản trị - Chi nhánh Bangkok - Shangri-La", null, null },
                    { 37, true, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Quản trị toàn bộ hệ thống thuộc chi nhánh Bali - The Oberoi", null, "Quản trị - Chi nhánh Bali - The Oberoi", null, null },
                    { 38, true, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Quản trị toàn bộ hệ thống thuộc chi nhánh Tokyo - Aman", null, "Quản trị - Chi nhánh Tokyo - Aman", null, null },
                    { 39, true, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Quản trị toàn bộ hệ thống thuộc chi nhánh Hà Nội - Rex Hotel", null, "Quản trị - Chi nhánh Hà Nội - Rex Hotel", null, null },
                    { 40, true, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Quản trị toàn bộ hệ thống thuộc chi nhánh TP. Hồ Chí Minh - Golden Bay", null, "Quản trị - Chi nhánh TP. Hồ Chí Minh - Golden Bay", null, null },
                    { 41, true, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Quản trị toàn bộ hệ thống thuộc chi nhánh Đà Nẵng - Lodge", null, "Quản trị - Chi nhánh Đà Nẵng - Lodge", null, null },
                    { 42, true, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Quản trị toàn bộ hệ thống thuộc chi nhánh Nha Trang - Imperial", null, "Quản trị - Chi nhánh Nha Trang - Imperial", null, null },
                    { 43, true, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Quản trị toàn bộ hệ thống thuộc chi nhánh Hải Phòng - Langham", null, "Quản trị - Chi nhánh Hải Phòng - Langham", null, null },
                    { 44, true, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Quản trị toàn bộ hệ thống thuộc chi nhánh New York - The Peninsula", null, "Quản trị - Chi nhánh New York - The Peninsula", null, null },
                    { 45, true, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Quản trị toàn bộ hệ thống thuộc chi nhánh Tokyo - The Ritz-Carlton", null, "Quản trị - Chi nhánh Tokyo - The Ritz-Carlton", null, null },
                    { 46, true, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Quản trị toàn bộ hệ thống thuộc chi nhánh Cancun - The Biltmore", null, "Quản trị - Chi nhánh Cancun - The Biltmore", null, null },
                    { 47, true, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Quản trị toàn bộ hệ thống thuộc chi nhánh Miami - Shangri-La", null, "Quản trị - Chi nhánh Miami - Shangri-La", null, null },
                    { 48, true, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Quản trị toàn bộ hệ thống thuộc chi nhánh Paris - Grand Hyatt", null, "Quản trị - Chi nhánh Paris - Grand Hyatt", null, null },
                    { 49, true, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Quản trị toàn bộ hệ thống thuộc chi nhánh Seoul - Four Seasons", null, "Quản trị - Chi nhánh Seoul - Four Seasons", null, null },
                    { 50, true, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Quản trị toàn bộ hệ thống thuộc chi nhánh Bangkok - Hilton", null, "Quản trị - Chi nhánh Bangkok - Hilton", null, null },
                    { 51, true, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Quản trị toàn bộ hệ thống thuộc chi nhánh Tokyo - W Hong Kong", null, "Quản trị - Chi nhánh Tokyo - W Hong Kong", null, null },
                    { 52, true, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Quản trị toàn bộ hệ thống thuộc chi nhánh Hong Kong - The St. Regis", null, "Quản trị - Chi nhánh Hong Kong - The St. Regis", null, null },
                    { 53, true, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Quản trị toàn bộ hệ thống thuộc chi nhánh Bali - Mandarin Oriental", null, "Quản trị - Chi nhánh Bali - Mandarin Oriental", null, null },
                    { 54, true, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Quản trị toàn bộ hệ thống thuộc chi nhánh Bangkok - Ritz", null, "Quản trị - Chi nhánh Bangkok - Ritz", null, null },
                    { 55, true, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Quản trị toàn bộ hệ thống thuộc chi nhánh Paris - The Oberoi", null, "Quản trị - Chi nhánh Paris - The Oberoi", null, null },
                    { 56, true, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Quản trị toàn bộ hệ thống thuộc chi nhánh Mumbai - Park Hyatt", null, "Quản trị - Chi nhánh Mumbai - Park Hyatt", null, null },
                    { 57, true, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Quản trị toàn bộ hệ thống thuộc chi nhánh Sydney - The Sukhothai", null, "Quản trị - Chi nhánh Sydney - The Sukhothai", null, null },
                    { 58, true, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Quản trị toàn bộ hệ thống thuộc chi nhánh Bangkok - Ritz", null, "Quản trị - Chi nhánh Bangkok - Ritz", null, null },
                    { 59, true, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Quản trị toàn bộ hệ thống thuộc chi nhánh Bali - The Leela", null, "Quản trị - Chi nhánh Bali - The Leela", null, null },
                    { 60, true, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Quản trị toàn bộ hệ thống thuộc chi nhánh Tokyo - St. Regis", null, "Quản trị - Chi nhánh Tokyo - St. Regis", null, null },
                    { 61, true, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Quản trị toàn bộ hệ thống thuộc chi nhánh New York - Jumeirah", null, "Quản trị - Chi nhánh New York - Jumeirah", null, null },
                    { 62, true, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Quản trị toàn bộ hệ thống thuộc chi nhánh Dubai - Belmond Hotel Caruso", null, "Quản trị - Chi nhánh Dubai - Belmond Hotel Caruso", null, null },
                    { 63, true, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Quản trị toàn bộ hệ thống thuộc chi nhánh Italy - Banyan Tree", null, "Quản trị - Chi nhánh Italy - Banyan Tree", null, null },
                    { 64, true, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Quản trị toàn bộ hệ thống thuộc chi nhánh Phuket - The Address", null, "Quản trị - Chi nhánh Phuket - The Address", null, null },
                    { 65, true, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Quản trị toàn bộ hệ thống thuộc chi nhánh Dubai - Shangri-La", null, "Quản trị - Chi nhánh Dubai - Shangri-La", null, null },
                    { 66, true, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Quản trị toàn bộ hệ thống thuộc chi nhánh Bangkok - The Oberoi", null, "Quản trị - Chi nhánh Bangkok - The Oberoi", null, null },
                    { 67, true, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Quản trị toàn bộ hệ thống thuộc chi nhánh Bali - Aman", null, "Quản trị - Chi nhánh Bali - Aman", null, null },
                    { 68, true, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Quản trị toàn bộ hệ thống thuộc chi nhánh 60", null, "Quản trị - Chi nhánh 60", null, null }
                });

            migrationBuilder.InsertData(
                table: "AppRoomType",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedDate", "Description", "DisplayOrder", "PeopleStay", "RoomTypeName", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Phòng nhỏ cho 1 người, trang bị đầy đủ tiện nghi.", null, 1, "Phòng Đơn", null, null },
                    { 2, 1, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Phòng cho 2 người, thích hợp cho cặp đôi hoặc bạn bè.", null, 2, "Phòng Đôi", null, null }
                });

            migrationBuilder.InsertData(
                table: "AppRoomType",
                columns: new[] { "Id", "BringPet", "CreatedBy", "CreatedDate", "DeletedDate", "Description", "DisplayOrder", "PeopleStay", "RoomTypeName", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 3, true, 1, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Phòng rộng rãi cho gia đình, có giường đôi và giường đơn.", null, 4, "Phòng Gia Đình", null, null });

            migrationBuilder.InsertData(
                table: "AppRoomType",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedDate", "Description", "DisplayOrder", "PeopleStay", "RoomTypeName", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 4, 1, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Phòng cao cấp với tiện nghi hiện đại và tầm nhìn đẹp.", null, 2, "Phòng Sang Trọng", null, null },
                    { 5, 1, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Phòng VIP với các dịch vụ đặc biệt và riêng tư.", null, 2, "Phòng VIP", null, null }
                });

            migrationBuilder.InsertData(
                table: "MstPermission",
                columns: new[] { "Id", "Code", "CreatedBy", "CreatedDate", "DeletedDate", "Desc", "DisplayOrder", "GroupName", "Table", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1001, "VIEW_LIST", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Xem danh sách người dùng", null, "Quản lý người dùng", "AppUser", null, null },
                    { 1002, "VIEW_DETAIL", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Xem chi tiết người dùng", null, "Quản lý người dùng", "AppUser", null, null },
                    { 1003, "CREATE", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Thêm người dùng", null, "Quản lý người dùng", "AppUser", null, null },
                    { 1004, "UPDATE", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Cập nhật người dùng", null, "Quản lý người dùng", "AppUser", null, null },
                    { 1005, "UPDATE_PWD", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Đổi mật khẩu", null, "Quản lý người dùng", "AppUser", null, null },
                    { 1006, "BLOCK", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Khóa người dùng", null, "Quản lý người dùng", "AppUser", null, null },
                    { 1007, "UNBLOCK", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Mở khóa người dùng", null, "Quản lý người dùng", "AppUser", null, null },
                    { 1008, "DELETE", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Xóa người dùng", null, "Quản lý người dùng", "AppUser", null, null },
                    { 1101, "VIEW_LIST", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Xem danh sách quyền", null, "Quản lý phân quyền", "AppRole", null, null },
                    { 1102, "VIEW_DETAIL", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Xem chi tiết quyền", null, "Quản lý phân quyền", "AppRole", null, null },
                    { 1103, "CREATE", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Thêm quyền", null, "Quản lý phân quyền", "AppRole", null, null },
                    { 1104, "UPDATE", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sửa quyền", null, "Quản lý phân quyền", "AppRole", null, null },
                    { 1105, "DELETE", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Xóa quyền", null, "Quản lý phân quyền", "AppRole", null, null },
                    { 1201, "MANAGER", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Quản lý file hệ thống", null, "Quản lý file", "FileManager", null, null },
                    { 1301, "VIEW_LIST", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Xem danh sách bài viết", null, "Quản lý tin tức", "AppNews", null, null },
                    { 1302, "CREATE", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Thêm bài viết", null, "Quản lý tin tức", "AppNews", null, null },
                    { 1303, "UPDATE", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Cập nhật bài viết", null, "Quản lý tin tức", "AppNews", null, null },
                    { 1304, "DELETE", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Xóa bài viết", null, "Quản lý tin tức", "AppNews", null, null },
                    { 1305, "PUBLIC", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Công khai bài viết", null, "Quản lý tin tức", "AppNews", null, null },
                    { 1306, "UNPUBLIC", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Gỡ bỏ bài viết", null, "Quản lý tin tức", "AppNews", null, null },
                    { 1307, "SENDMAILREGISTER", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Gữi email người đăng ký", null, "Quản lý tin tức", "AppNews", null, null },
                    { 1401, "VIEW_LIST", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Xem danh sách thể loại tin", null, "Quản lý thể loại tin", "AppNewsCategory", null, null },
                    { 1402, "CREATE", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Thêm thể loại bài viết", null, "Quản lý thể loại tin", "AppNewsCategory", null, null },
                    { 1403, "UPDATE", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Cập nhật thể loại bài viết", null, "Quản lý thể loại tin", "AppNewsCategory", null, null },
                    { 1404, "DELETE", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Xóa thể loại bài viết", null, "Quản lý thể loại tin", "AppNewsCategory", null, null },
                    { 1501, "VIEW_LIST", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Xem danh sách chi nhánh khách sạn", null, "Quản lý chi nhánh khách sạn", "AppBranchHotel", null, null },
                    { 1502, "CREATE", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Thêm chi nhánh khách sạn", null, "Quản lý chi nhánh khách sạn", "AppBranchHotel", null, null },
                    { 1503, "UPDATE", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Cập nhật chi nhánh", null, "Quản lý chi nhánh khách sạn", "AppBranchHotel", null, null },
                    { 1504, "DELETE", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Xóa chi nhánh", null, "Quản lý chi nhánh khách sạn", "AppBranchHotel", null, null },
                    { 1601, "VIEW_LIST", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Xem danh sách khách sạn", null, "Quản lý khách sạn", "AppHotel", null, null },
                    { 1602, "CREATE", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Thêm khách sạn", null, "Quản lý khách sạn", "AppHotel", null, null },
                    { 1603, "UPDATE", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Cập nhật khách sạn", null, "Quản lý khách sạn", "AppHotel", null, null },
                    { 1604, "DELETE", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Xóa khách sạn", null, "Quản lý khách sạn", "AppHotel", null, null },
                    { 1605, "PUBLIC", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Công khai khách sạn", null, "Quản lý khách sạn", "AppHotel", null, null },
                    { 1606, "UNPUBLIC", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Gỡ khách sạn xuống", null, "Quản lý khách sạn", "AppHotel", null, null },
                    { 1701, "VIEW_LIST", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Xem danh sách phòng", null, "Quản lý phòng khách sạn", "AppRoom", null, null },
                    { 1702, "CREATE", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Thêm phòng", null, "Quản lý phòng khách sạn", "AppRoom", null, null },
                    { 1703, "UPDATE", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Cập nhật phòng", null, "Quản lý phòng khách sạn", "AppRoom", null, null },
                    { 1704, "DELETE", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Xóa phòng", null, "Quản lý phòng khách sạn", "AppRoom", null, null },
                    { 1705, "PUBLIC", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Công khai phòng", null, "Quản lý phòng khách sạn", "AppRoom", null, null },
                    { 1706, "UNPUBLIC", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Gỡ phòng xuống", null, "Quản lý phòng khách sạn", "AppRoom", null, null },
                    { 1801, "VIEW_LIST", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Quản lý loại phòng", null, "Quản lý loại phòng", "AppRoomType", null, null },
                    { 1802, "CREATE", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Thêm loại phòng", null, "Quản lý loại phòng", "AppRoomType", null, null },
                    { 1803, "UPDATE", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Cập nhật loại phòng", null, "Quản lý loại phòng", "AppRoomType", null, null },
                    { 1804, "DELETE", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Xóa loại phòng", null, "Quản lý loại phòng", "AppRoomType", null, null },
                    { 1901, "VIEW_LIST", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Quản lý trang thiết bị", null, "Quản lý trang thiết bị", "AppEquipment", null, null },
                    { 1902, "CREATE", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Thêm mới trang thiết bị", null, "Quản lý trang thiết bị", "AppEquipment", null, null },
                    { 1903, "UPDATE", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Cập nhật trang thiết bị", null, "Quản lý trang thiết bị", "AppEquipment", null, null },
                    { 1904, "DELETE", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Xóa trang thiết bị", null, "Quản lý trang thiết bị", "AppEquipment", null, null },
                    { 2001, "VIEW_LIST", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Quản lý loại trang thiết bị", null, "Quản lý loại trang thiết bị", "AppEquipmentType", null, null },
                    { 2002, "CREATE", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Thêm mới loại trang thiết bị", null, "Quản lý loại trang thiết bị", "AppEquipmentType", null, null },
                    { 2003, "UPDATE", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Cập nhật loại trang thiết bị", null, "Quản lý loại trang thiết bị", "AppEquipmentType", null, null },
                    { 2004, "DELETE", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Xóa loại trang thiết bị", null, "Quản lý loại trang thiết bị", "AppEquipmentType", null, null },
                    { 2101, "VIEW_LIST", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Xem danh sách lương nhân viên", null, "Quản lý lương nhân viên", "AppPayroll", null, null },
                    { 2102, "VIEW_LIST", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Xem chi tiết lương nhân viên", null, "Quản lý lương nhân viên", "AppPayroll", null, null },
                    { 2103, "CREATE", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Tạo bảng lương mới cho nhân viên", null, "Quản lý lương nhân viên", "AppPayroll", null, null },
                    { 2104, "UPDATE", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Cập nhật bảng lương cho nhân viên", null, "Quản lý lương nhân viên", "AppPayroll", null, null },
                    { 2105, "DELETE", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Xóa bảng lương của nhân viên", null, "Quản lý lương nhân viên", "AppPayroll", null, null },
                    { 2201, "VIEW_LIST", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Xem danh sách lịch làm nhân viên", null, "Quản lý lịch làm nhân viên", "AppWorkSchedule", null, null },
                    { 2202, "VIEW_LIST", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Xem chi tiết lịch làm nhân viên", null, "Quản lý lịch làm nhân viên", "AppWorkSchedule", null, null },
                    { 2203, "CREATE", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Tạo lịch làm cho nhân viên", null, "Quản lý lịch làm nhân viên", "AppWorkSchedule", null, null },
                    { 2204, "UPDATE", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Cập nhật lịch làm cho nhân viên", null, "Quản lý lịch làm nhân viên", "AppWorkSchedule", null, null },
                    { 2205, "DELETE", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Xóa lịch làm của nhân viên", null, "Quản lý lịch làm nhân viên", "AppWorkSchedule", null, null },
                    { 2301, "VIEW_LIST", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Xem danh sách ca làm nhân viên", null, "Quản lý ca làm nhân viên", "AppWorkShift", null, null },
                    { 2302, "VIEW_LIST", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Xem chi tiết ca làm nhân viên", null, "Quản lý ca làm nhân viên", "AppWorkShift", null, null },
                    { 2303, "CREATE", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Tạo ca làm cho nhân viên", null, "Quản lý ca làm nhân viên", "AppWorkShift", null, null },
                    { 2304, "UPDATE", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Cập nhật ca làm cho nhân viên", null, "Quản lý ca làm nhân viên", "AppWorkShift", null, null },
                    { 2305, "DELETE", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Xóa ca làm của nhân viên", null, "Quản lý ca làm nhân viên", "AppWorkShift", null, null },
                    { 2401, "VIEW_LIST", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Xem danh sách đặt phòng", null, "Quản lý đặt phòng", "AppOrder", null, null },
                    { 2402, "DETAILS", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Xem chi tiết phòng được đặt", null, "Quản lý đặt phòng", "AppOrderDetail", null, null },
                    { 2403, "UPDATE", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Cập nhật trang thái đặt phòng", null, "Quản lý đặt phòng", "AppOrder", null, null },
                    { 2404, "DELETE", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Xóa đặt phòng", null, "Quản lý đặt phòng", "AppOrder", null, null },
                    { 2501, "VIEW_LIST", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Xem danh sách các bình luận", null, "Quản lý bình luận người dùng", "AppComment", null, null },
                    { 2502, "DELETE", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Xóa bình luận vi phạn", null, "Quản lý bình luận người dùng", "AppComment", null, null }
                });

            migrationBuilder.InsertData(
                table: "AppBranchHotel",
                columns: new[] { "Id", "Address", "CreatedBy", "CreatedDate", "DeletedDate", "Description", "DisplayOrder", "HotelId", "IdMap", "Img", "Name", "QuantityFloor", "QuantityRoom", "QuantityStaff", "Slug", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "123 Phố Lý Thái Tổ, Quận Hoàn Kiếm, Hà Nội, Việt Nam", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chi nhánh của Melia Hà Nội tại Hà Nội", null, 1, null, "https://hoanghamobile.com/tin-tuc/wp-content/uploads/2024/04/anh-ha-noi.jpg", "Hà Nội - Melia Hà Nội", 200, 150, 20, "ha-noi-melia-ha-noi", null, null },
                    { 2, "456 Đường Nguyễn Huệ, Phường Bến Nghé, Quận 1, TP. Hồ Chí Minh, Việt Nam", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chi nhánh của Rex Hotel Sài Gòn tại TP. Hồ Chí Minh", null, 2, null, "https://cdnphoto.dantri.com.vn/JpeCWtGF6QU37njc1xDZc4wOKbM=/2021/04/28/ubnd-tp-1619582754877.jpg", "TP. Hồ Chí Minh - Rex Hotel Sài Gòn", 110, 180, 25, "tp-ho-chi-minh-rex-hotel-sai-gon", null, null },
                    { 3, "789 Đường Bạch Đằng, Phường Hải Châu, Đà Nẵng, Việt Nam", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chi nhánh của Đà Nẵng Golden Bay tại Đà Nẵng", null, 3, null, "https://images2.thanhnien.vn/528068263637045248/2023/4/23/cau-vang-da-nang-16822248307311159361992.jpg", "Đà Nẵng - Golden Bay", 190, 200, 15, "da-nang-golden-bay", null, null },
                    { 4, "101 Đường Trần Phú, Thành phố Nha Trang, Khánh Hòa, Việt Nam", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chi nhánh của Nha Trang Lodge tại Nha Trang", null, 4, null, "https://scontent.fvca1-1.fna.fbcdn.net/v/t1.6435-9/105491263_2363218890638032_4176841546494313648_n.jpg?_nc_cat=106&ccb=1-7&_nc_sid=2285d6&_nc_ohc=Am6nyPLhFTAQ7kNvgGcHsrl&_nc_zt=23&_nc_ht=scontent.fvca1-1.fna&_nc_gid=AdC-QhHD7kjqPE3Z4nZe9VW&oh=00_AYDLGhjVb-QnzZuzypqiIqVj_rcPwHBSosH70XxLoibW4g&oe=674CB979", "Nha Trang - Lodge", 120, 600, 18, "nha-trang-lodge", null, null },
                    { 5, "202 Đường Lê Đại Hành, Quận Hồng Bàng, Hải Phòng, Việt Nam", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chi nhánh của Imperial Hải Phòng tại Hải Phòng", null, 5, null, "https://i0.wp.com/heza.gov.vn/wp-content/uploads/2023/10/hai_phong-scaled.jpg?fit=2560%2C1662&ssl=1", "Hải Phòng - Imperial", 10, 30, 12, "hai-phong-imperial", null, null },
                    { 6, "600 Đường 5th Ave, New York, NY 10020, USA", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chi nhánh của Langham Hotel tại New York", null, 6, null, "https://upload.wikimedia.org/wikipedia/commons/thumb/0/05/View_of_Empire_State_Building_from_Rockefeller_Center_New_York_City_dllu.jpg/800px-View_of_Empire_State_Building_from_Rockefeller_Center_New_York_City_dllu.jpg", "New York - Langham", 100, 100, 40, "new-york-langham", null, null },
                    { 7, "123 Đường Chuo, Minato City, Tokyo, Nhật Bản", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chi nhánh của The Peninsula Tokyo tại Tokyo", null, 7, null, "https://www.agoda.com/wp-content/uploads/2024/06/tokyo-japan-1244x700.jpg", "Tokyo - The Peninsula Tokyo", 100, 90, 35, "tokyo-the-peninsula-tokyo", null, null },
                    { 8, "700 Boulevard Kukulcan, Cancun, Mexico", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chi nhánh của The Ritz-Carlton tại Cancun", null, 8, null, "https://pantravel.vn/wp-content/uploads/2024/01/cancun-thien-duong-nghi-duong-hang-dau-mexico.jpg", "Cancun - The Ritz-Carlton", 100, 75, 30, "cancun-the-ritz-carlton", null, null },
                    { 9, "500 South Florida Avenue, Miami, FL 33131, USA", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chi nhánh của The Biltmore Miami tại Miami", null, 9, null, "https://a.travel-assets.com/findyours-php/viewfinder/images/res70/471000/471674-Miami.jpg", "Miami - The Biltmore Miami", 100, 60, 28, "miami-the-biltmore-miami", null, null },
                    { 10, "70 Avenue de La Bourdonnais, 75007 Paris, Pháp", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chi nhánh của Shangri-La tại Paris", null, 10, null, "https://media.timeout.com/images/106181719/image.jpg", "Paris - Shangri-La", 100, 110, 45, "paris-shangri-la", null, null },
                    { 11, "747-7, Sinsa-dong, Gangnam-gu, Seoul, Hàn Quốc", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chi nhánh của Grand Hyatt tại Seoul", null, 11, null, "https://booking.pystravel.vn/uploads/posts/avatar/1693995460.jpg", "Seoul - Grand Hyatt Seoul", 100, 120, 50, "seoul-grand-hyatt-seoul", null, null },
                    { 12, "123, 123/1-3, Thanon Ratchadamri, Lumphini, Pathum Wan, Bangkok, Thái Lan", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chi nhánh của Four Seasons tại Bangkok", null, 12, null, "https://owa.bestprice.vn/images/destinations/uploads/bangkok-543c92d75fddd.jpg", "Bangkok - Four Seasons", 100, 80, 32, "bangkok-four-seasons", null, null },
                    { 13, "2-6-1 Nishishinjuku, Shinjuku City, Tokyo, Nhật Bản", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chi nhánh của Hilton tại Tokyo", null, 13, null, "https://media.cntraveler.com/photos/63482b255e7943ad4006df0b/16:9/w_2560%2Cc_limit/tokyoGettyImages-1031467664.jpeg", "Tokyo - Hilton", 100, 95, 38, "tokyo-hilton", null, null },
                    { 14, "1 Austin Road West, Tsim Sha Tsui, Hong Kong", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chi nhánh của W Hong Kong tại Hong Kong", null, 14, null, "https://www.discoverhongkong.com/content/dam/dhk/intl/explore/attractions/the-charm-of-the-bright-city/the-charm-of-the-bright-city-1920x1080.jpg", "Hong Kong - W Hong Kong", 100, 130, 55, "hong-kong-w-hong-kong", null, null },
                    { 15, "Nusa Dua, Bali, Indonesia", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chi nhánh của The St. Regis tại Bali", null, 15, null, "https://www.travelandleisure.com/thmb/KE0vV7K8Ngvc_7j-_FGx_jCUdCM=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc()/TAL-bali-lead-image-BALITG1223-101f43c88c044081a4558b737afbd094.jpg", "Bali - The St. Regis", 100, 70, 22, "bali-the-st-regis", null, null },
                    { 16, "48-5, Thanon Ruam Rudee, Lumphini, Pathum Wan, Bangkok, Thái Lan", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chi nhánh của Mandarin Oriental tại Bangkok", null, 16, null, "https://a0.muscache.com/im/pictures/INTERNAL/INTERNAL-ImageByPlaceId-ChIJ82ENKDJgHTERIEjiXbIAAQE-large_background/original/af044017-e151-4e68-bc01-e79bae614523.jpeg", "Bangkok - Mandarin Oriental", 100, 85, 35, "bangkok-mandarin-oriental", null, null },
                    { 17, "228 Rue de Rivoli, 75001 Paris, Pháp", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chi nhánh của Le Meurice tại Paris", null, 17, null, "https://www.vn.kayak.com/rimg/dimg/bd/d1/2f268866-city-36014-162f82486f9.jpg?width=1366&height=768&xhint=2485&yhint=1564&crop=true", "Paris - Le Meurice", 100, 140, 60, "paris-le-meurice", null, null },
                    { 18, "Balaji Towers, Juhu Beach, Mumbai, Ấn Độ", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chi nhánh của The Oberoi tại Mumbai", null, 18, null, "https://www.agoda.com/wp-content/uploads/2024/04/Chatrapati-Shivaji-Mumbai-India.jpg", "Mumbai - The Oberoi", 100, 75, 30, "mumbai-the-oberoi", null, null },
                    { 19, "7 Hickson Rd, Millers Point, Sydney, Australia", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chi nhánh của Park Hyatt tại Sydney", null, 19, null, "https://media.tatler.com/photos/6141d37b9ce9874a3e40107d/16:9/w_1280,c_limit/social_crop_sydney_opera_house_gettyimages-869714270.jpg", "Sydney - Park Hyatt", 100, 60, 29, "sydney-park-hyatt", null, null },
                    { 20, "5/5-7 Thanon Sukhumvit 23, Khlong Toei Nuea, Watthana, Bangkok, Thái Lan", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chi nhánh của The Sukhothai tại Bangkok", null, 20, null, "https://toplist.vn/images/800px/bangkok-thai-lan-1072633.jpg", "Bangkok - The Sukhothai", 100, 80, 33, "bangkok-the-sukhothai", null, null },
                    { 21, "15 Place Vendôme, 75001 Paris, Pháp", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chi nhánh của Ritz Paris tại Paris", null, 21, null, "https://i2.ex-cdn.com/crystalbay.com/files/content/2024/07/29/du-lich-paris-1-1540.jpg", "Paris - Ritz", 200, 125, 50, "paris-ritz", null, null },
                    { 22, "Mahalaxmi, Mumbai, Ấn Độ", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chi nhánh của Taj Mahal Palace tại Mumbai", null, 22, null, "https://thvl.vn/wp-content/uploads/2024/03/Mumbai-tr%E1%BB%9F-th%C3%A0nh-th%C3%A0nh-ph%E1%BB%91-c%C3%B3-nhi%E1%BB%81u-t%E1%BB%B7-ph%C3%BA-nh%E1%BA%A5t-ch%C3%A2u-%C3%81-scaled.jpg", "Mumbai - Taj Mahal Palace", 100, 75, 30, "mumbai-taj-mahal-palace", null, null },
                    { 23, "New York, USA", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chi nhánh của St. Regis tại New York", null, 23, null, "https://jtravel.com.vn/wp-content/uploads/2023/11/new-york.jpg", "New York - St. Regis", 100, 110, 42, "new-york-st-regis", null, null },
                    { 24, "Dubai, UAE", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chi nhánh của Jumeirah tại Dubai", null, 24, null, "https://lp-cms-production.imgix.net/features/2017/09/dubai-marina-skyline-2c8f1708f2a1.jpg?w=1440&h=810&fit=crop&auto=format&q=75", "Dubai - Jumeirah", 100, 150, 50, "dubai-jumeirah", null, null },
                    { 25, "Italy", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chi nhánh của Belmond Hotel Caruso tại Italy", null, 25, null, "https://cdn.britannica.com/82/195482-050-2373E635/Amalfi-Italy.jpg", "Italy - Belmond Hotel Caruso", 100, 60, 28, "italy-belmond-hotel-caruso", null, null },
                    { 26, "Phuket, Thái Lan", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chi nhánh của Banyan Tree tại Phuket", null, 26, null, "https://media-cdn.tripadvisor.com/media/photo-m/1280/1b/4b/5d/c8/caption.jpg", "Phuket - Banyan Tree", 100, 75, 30, "phuket-banyan-tree", null, null },
                    { 27, "Dubai, UAE", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chi nhánh của The Address tại Dubai", null, 27, null, "https://www.agoda.com/wp-content/uploads/2024/04/Featured-image-Dubai-UAE-1244x700.jpg", "Dubai - The Address", 100, 120, 45, "dubai-the-address", null, null },
                    { 28, "Bangkok, Thái Lan", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chi nhánh của Shangri-La tại Bangkok", null, 28, null, "https://www.flightmate.co.za/pictures/destination/thailand/bangkok/highres/landscape/cheap-trips-to-bangkok-10.jpg", "Bangkok - Shangri-La", 100, 90, 35, "bangkok-shangri-la", null, null },
                    { 29, "Bali, Indonesia", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chi nhánh của The Oberoi tại Bali", null, 29, null, "https://cloudinary.fclmedia.com/fctg/image/fetch/w_1600,c_fill,q_auto,g_auto,fl_progressive/https://live-fcl-site-fcb.pantheonsite.io/sites/default/files/Bingin%20Beach%20Bali%20-%20DESKTOP.jpg", "Bali - The Oberoi", 100, 65, 25, "bali-the-oberoi", null, null },
                    { 30, "Tokyo, Nhật Bản", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chi nhánh của Aman tại Tokyo", null, 30, null, "https://images.goway.com/production/styles/article_featured_image_2xl/s3/featured_images/japan_tokyo_akihabara_AdobeStock_295310062_Editorial_Use_Only.jpg?h=43fc81ba&itok=k1GsYr-r", "Tokyo - Aman", 100, 95, 38, "tokyo-aman", null, null },
                    { 31, "Hà Nội, Việt Nam", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chi nhánh của Rex Hotel Saigon tại Hà Nội", null, 2, null, "https://vietbis.vn/Image/Picture/Hanoi/duong-pho-ha-noi-maps.jpg", "Hà Nội - Rex Hotel", 100, 50, 20, "ha-noi-rex-hotel", null, null },
                    { 32, "TP. Hồ Chí Minh, Việt Nam", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chi nhánh của Đà Nẵng Golden Bay tại TP. Hồ Chí Minh", null, 3, null, "https://nhaf.net.vn/wp-content/uploads/2022/03/thanh-pho-ho-chi-minh-scaled.jpg", "TP. Hồ Chí Minh - Golden Bay", 100, 80, 25, "tp-ho-chi-minh-golden-bay", null, null },
                    { 33, "Đà Nẵng, Việt Nam", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chi nhánh của Nha Trang Lodge tại Đà Nẵng", null, 4, null, "https://www.vietnamairlines.com/~/media/Images/HeroBannerDestination/Vietnam/Herro%20banner/DANANG/Hero%20banner/1300x450/Danang_banner_2600x1111_0.jpg", "Đà Nẵng - Lodge", 100, 40, 15, "da-nang-lodge", null, null },
                    { 34, "Nha Trang, Việt Nam", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chi nhánh của Imperial Hải Phòng tại Nha Trang", null, 5, null, "https://focusasiatravel.vn/wp-content/uploads/2023/09/eb13dca8-82c2-42c0-8698-c37a468c001b.jpg", "Nha Trang - Imperial", 100, 60, 18, "nha-trang-imperial", null, null },
                    { 35, "Hải Phòng, Việt Nam", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chi nhánh của Langham Hotel tại Hải Phòng", null, 6, null, "https://file3.qdnd.vn/data/images/0/2023/03/31/nguyenthao/hai%20phong.jpg?dpi=150&quality=100&w=870", "Hải Phòng - Langham", 100, 30, 12, "hai-phong-langham", null, null },
                    { 36, "New York, USA", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chi nhánh của The Peninsula tại New York", null, 7, null, null, "New York - The Peninsula", 100, 100, 40, "new-york-the-peninsula", null, null },
                    { 37, "Tokyo, Nhật Bản", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chi nhánh của The Ritz-Carlton tại Tokyo", null, 8, null, "https://tnktravel.com.vn/wp-content/uploads/2022/10/tokyo-nh%E1%BA%ADt-b%E1%BA%A3n.jpg", "Tokyo - The Ritz-Carlton", 100, 90, 35, "tokyo-the-ritz-carlton", null, null },
                    { 38, "Cancun, Mexico", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chi nhánh của The Biltmore tại Cancun", null, 9, null, "https://media.tacdn.com/media/attractions-content--1x-1/12/29/06/2b.jpg", "Cancun - The Biltmore", 100, 75, 30, "cancun-the-biltmore", null, null },
                    { 39, "Miami, USA", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chi nhánh của Shangri-La tại Miami", null, 10, null, "https://i.natgeofe.com/n/5de6e34a-d550-4358-b7ef-4d79a09c680e/aerial-beach-miami-florida.jpg", "Miami - Shangri-La", 100, 60, 28, "miami-shangri-la", null, null },
                    { 40, "Paris, Pháp", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chi nhánh của Grand Hyatt tại Paris", null, 11, null, "https://www.agoda.com/wp-content/uploads/2024/02/Featured-image-Notre-Dame-de-Paris-Cathedral-Paris-France-1244x700.jpg", "Paris - Grand Hyatt", 100, 110, 45, "paris-grand-hyatt", null, null },
                    { 41, "Seoul, Hàn Quốc", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chi nhánh của Four Seasons tại Seoul", null, 12, null, "https://www.vietnamairlines.com/~/media/Images/HeroBannerDestination/Korea/Seoul/Hero%20banner/2600x900/Seoul_banner_2600x1111.jpg", "Seoul - Four Seasons", 100, 120, 50, "seoul-four-seasons", null, null },
                    { 42, "Bangkok, Thái Lan", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chi nhánh của Hilton tại Bangkok", null, 13, null, "https://saigontimestravel.com/wp-content/uploads/2024/08/bangkok-thai-lan-1.jpg", "Bangkok - Hilton", 100, 80, 32, "bangkok-hilton", null, null },
                    { 43, "Tokyo, Nhật Bản", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chi nhánh của W Hong Kong tại Tokyo", null, 14, null, "https://newswirengr.com/wp-content/uploads/2023/12/Tokyo.jpg", "Tokyo - W Hong Kong", 100, 95, 38, "tokyo-w-hong-kong", null, null },
                    { 44, "Hong Kong", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chi nhánh của The St. Regis tại Hong Kong", null, 15, null, "https://upload.wikimedia.org/wikipedia/commons/a/a4/Hong_Kong_Island_Skyline_201108.jpg", "Hong Kong - The St. Regis", 100, 130, 55, "hong-kong-the-st-regis", null, null },
                    { 45, "Bali, Indonesia", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chi nhánh của Mandarin Oriental tại Bali", null, 16, null, "https://songhongtourist.vn/upload/2020-02-25/kinh-nghiem-du-lich-bali-1-5.jpg", "Bali - Mandarin Oriental", 100, 70, 22, "bali-mandarin-oriental", null, null },
                    { 46, "Bangkok, Thái Lan", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chi nhánh của Ritz tại Bangkok", null, 17, null, "https://dichvuxinvisa.com/wp-content/uploads/2020/12/Thoi-gian-tot-nhat-Du-lich-Bangkok.jpg", "Bangkok - Ritz", 100, 85, 35, "bangkok-ritz", null, null },
                    { 47, "Paris, Pháp", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chi nhánh của The Oberoi tại Paris", null, 18, null, "https://static01.nyt.com/images/2023/07/01/travel/22hours-paris-tjzf/22hours-paris-tjzf-videoSixteenByNineJumbo1600.jpg", "Paris - The Oberoi", 100, 140, 60, "paris-the-oberoi", null, null },
                    { 48, "Mumbai, Ấn Độ", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chi nhánh của Park Hyatt tại Mumbai", null, 19, null, "https://res.klook.com/images/fl_lossy.progressive,q_65/c_fill,w_1200,h_630/w_80,x_15,y_15,g_south_west,l_Klook_water_br_trans_yhcmh3/activities/eybjjii82kbb7e4mclya/Highlights%20of%20Mumbai%20Day%20Tour.jpg", "Mumbai - Park Hyatt", 100, 75, 30, "mumbai-park-hyatt", null, null },
                    { 49, "Sydney, Australia", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chi nhánh của The Sukhothai tại Sydney", null, 20, null, "https://duhocuc.edu.vn/wp-content/uploads/2024/02/du-hoc-uc-tai-sydney.jpg", "Sydney - The Sukhothai", 100, 65, 29, "sydney-the-sukhothai", null, null },
                    { 50, "Bangkok, Thái Lan", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chi nhánh của Ritz tại Bangkok", null, 21, null, "https://hieutour.com.vn/public/upload/images/hinhsanpham/hanh-trinh-kham-pha-bangkok-pattaya---5-ngay-4-dem---ho5dtlbk1801-53611705657481.jpg", "Bangkok - Ritz", 100, 90, 33, "bangkok-ritz", null, null },
                    { 51, "Bali, Indonesia", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chi nhánh của The Leela tại Bali", null, 22, null, "https://ik.imagekit.io/tvlk/blog/2022/12/dia-diem-du-lich-bali-1.jpg?tr=dpr-2,w-675", "Bali - The Leela", 100, 65, 25, "bali-the-leela", null, null },
                    { 52, "Tokyo, Nhật Bản", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chi nhánh của St. Regis tại Tokyo", null, 23, null, "https://www.patrickopreis.nl/wp-content/uploads/2018/06/tokyo-5x-zien-en-doen.jpg", "Tokyo - St. Regis", 100, 92, 37, "tokyo-st-regis", null, null },
                    { 53, "New York, USA", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chi nhánh của Jumeirah tại New York", null, 24, null, "https://a.travel-assets.com/findyours-php/viewfinder/images/res70/471000/471585-New-York.jpg", "New York - Jumeirah", 100, 102, 41, "new-york-jumeirah", null, null },
                    { 54, "Dubai, UAE", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chi nhánh của Belmond Hotel Caruso tại Dubai", null, 25, null, "https://cdn3.ivivu.com/2022/06/du-lich-dubai-ivivu.jpg", "Dubai - Belmond Hotel Caruso", 100, 160, 53, "dubai-belmond-hotel-caruso", null, null },
                    { 55, "Italy", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chi nhánh của Banyan Tree tại Italy", null, 26, null, "https://www.hostelworld.com/blog/wp-content/uploads/dreamstime_m_140314930-2048x857.jpg", "Italy - Banyan Tree", 100, 70, 30, "italy-banyan-tree", null, null },
                    { 56, "Phuket, Thái Lan", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chi nhánh của The Address tại Phuket", null, 27, null, "https://www.fivestars-thailand.com/images/article/display/a_1709046726.jpg", "Phuket - The Address", 100, 80, 32, "phuket-the-address", null, null },
                    { 57, "Dubai, UAE", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chi nhánh của Shangri-La tại Dubai", null, 28, null, "https://www.vietourist.com.vn/public/frontend/uploads/kceditor/images/dao-co-trong-tour-dubai-min.jpg", "Dubai - Shangri-La", 100, 125, 45, "dubai-shangri-la", null, null },
                    { 58, "Bangkok, Thái Lan", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chi nhánh của The Oberoi tại Bangkok", null, 29, null, "https://bizweb.dktcdn.net/thumb/1024x1024/100/093/257/products/nguoi-viet-toi-thai-lan-du-lich-va-chua-benh-duoc-o-90-ngay-04-6338.jpg?v=1544343721263", "Bangkok - The Oberoi", 100, 90, 35, "bangkok-the-oberoi", null, null },
                    { 59, "Bali, Indonesia", null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chi nhánh của Aman tại Bali", null, 30, null, "https://balidave.com/wp-content/uploads/2022/11/best-hotel-bali.jpeg", "Bali - Aman", 100, 68, 27, "bali-aman", null, null }
                });

            migrationBuilder.InsertData(
                table: "AppEquipment",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedDate", "Description", "DisplayOrder", "Name", "TypeEquipmentId", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Tivi 4K 55 inch", null, "Tivi", 1, null, null },
                    { 2, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Điều hòa 2 chiều", null, "Điều hòa", 1, null, null },
                    { 3, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bàn làm việc gỗ", null, "Bàn làm việc", 1, null, null },
                    { 4, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Ghế xoay", null, "Ghế", 1, null, null },
                    { 5, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Tủ lạnh mini 100 lít", null, "Tủ lạnh mini", 1, null, null },
                    { 6, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bồn cầu thông minh", null, "Bồn cầu", 2, null, null },
                    { 7, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chậu rửa thông minh", null, "Chậu rửa", 2, null, null },
                    { 8, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Vòi sen tăng áp đảo chiều", null, "Vòi sen", 2, null, null },
                    { 9, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bồn tắm nằm", null, "Bồn tắm", 2, null, null }
                });

            migrationBuilder.InsertData(
                table: "AppRolePermission",
                columns: new[] { "Id", "AppRoleId", "CreatedBy", "CreatedDate", "DeletedDate", "DisplayOrder", "MstPermissionId", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 1, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1101, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 1, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1102, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 1, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1103, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 1, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1104, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 1, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1105, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 1, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1001, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 1, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1002, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 1, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1003, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 1, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1004, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, 1, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1005, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, 1, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1006, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, 1, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1007, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, 1, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1008, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, 1, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1201, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, 1, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1301, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, 1, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1302, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 17, 1, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1303, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 18, 1, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1304, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 19, 1, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1305, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 20, 1, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1306, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 21, 1, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1307, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 22, 1, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1401, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 23, 1, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1402, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 24, 1, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1403, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 25, 1, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1404, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 26, 1, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 2501, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 27, 1, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 2502, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 28, 1, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1501, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 29, 1, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1502, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 30, 1, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1503, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 31, 1, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1504, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 32, 1, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1601, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 33, 1, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1602, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 34, 1, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1603, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 35, 1, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1604, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 36, 1, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1605, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 37, 1, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1606, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 38, 1, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1701, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 39, 1, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1702, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 40, 1, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1703, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 41, 1, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1704, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 42, 1, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1705, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 43, 1, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1706, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 44, 1, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1801, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 45, 1, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1802, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 46, 1, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1803, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 47, 1, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1804, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 48, 1, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1901, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 49, 1, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1902, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 50, 1, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1903, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 51, 1, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1904, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 52, 1, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 2001, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 53, 1, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 2002, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 54, 1, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 2003, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 55, 1, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 2004, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 56, 1, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 2401, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 57, 1, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 2402, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 58, 1, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 2403, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 59, 1, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 2404, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 60, 1, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 2101, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 61, 1, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 2102, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 62, 1, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 2103, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 63, 1, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 2104, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 64, 1, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 2105, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 65, 1, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 2201, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 66, 1, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 2202, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 67, 1, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 2203, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 68, 1, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 2204, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 69, 1, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 2205, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 70, 1, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 2301, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 71, 1, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 2302, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 72, 1, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 2303, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 73, 1, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 2304, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 74, 1, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 2305, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 75, 2, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1901, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 76, 9, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1901, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 77, 2, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1902, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 78, 9, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1902, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 79, 2, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1903, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 80, 9, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1903, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 81, 2, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1904, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 82, 9, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1904, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 83, 2, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 2001, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 84, 8, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 2001, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 85, 2, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 2002, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 86, 8, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 2002, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 87, 2, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 2003, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 88, 8, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 2003, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 89, 2, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 2004, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 90, 8, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 2004, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 91, 5, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1301, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 92, 7, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1301, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 93, 5, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1302, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 94, 7, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1302, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 95, 5, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1303, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 96, 7, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1303, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 97, 5, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1304, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 98, 7, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1304, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 99, 5, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1305, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 100, 7, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1305, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 101, 5, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1306, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 102, 7, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1306, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 103, 5, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1307, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 104, 7, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1307, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 105, 5, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1401, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 106, 6, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1401, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 107, 5, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1402, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 108, 6, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1402, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 109, 5, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1403, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 110, 6, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1403, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 111, 5, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1404, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 112, 6, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1404, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 113, 4, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1101, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 114, 4, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1102, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 115, 4, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1103, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 116, 4, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1104, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 117, 4, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1105, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 118, 4, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1001, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 119, 4, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1002, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 120, 4, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1003, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 121, 4, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1004, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 122, 4, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1005, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 123, 4, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1006, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 124, 4, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1007, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 125, 4, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1008, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 126, 4, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1201, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 127, 4, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1301, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 128, 4, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1302, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 129, 4, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1303, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 130, 4, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1304, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 131, 4, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1305, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 132, 4, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1306, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 133, 4, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1307, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 134, 4, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1401, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 135, 4, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1402, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 136, 4, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1403, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 137, 4, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1404, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 138, 4, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 2501, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 139, 4, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 2502, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 140, 4, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1501, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 141, 4, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1502, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 142, 4, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1503, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 143, 4, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1504, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 144, 4, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1601, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 145, 4, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1602, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 146, 4, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1603, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 147, 4, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1604, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 148, 4, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1605, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 149, 4, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1606, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 150, 4, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1701, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 151, 4, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1702, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 152, 4, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1703, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 153, 4, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1704, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 154, 4, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1705, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 155, 4, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1706, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 156, 4, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1801, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 157, 4, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1802, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 158, 4, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1803, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 159, 4, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1804, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 160, 4, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1901, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 161, 4, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1902, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 162, 4, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1903, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 163, 4, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1904, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 164, 4, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 2001, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 165, 4, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 2002, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 166, 4, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 2003, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 167, 4, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 2004, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 168, 4, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 2401, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 169, 4, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 2402, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 170, 4, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 2403, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 171, 4, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 2404, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 172, 4, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 2101, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 173, 4, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 2102, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 174, 4, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 2103, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 175, 4, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 2104, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 176, 4, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 2105, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 177, 4, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 2201, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 178, 4, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 2202, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 179, 4, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 2203, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 180, 4, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 2204, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 181, 4, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 2205, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 182, 4, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 2301, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 183, 4, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 2302, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 184, 4, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 2303, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 185, 4, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 2304, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 186, 4, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 2305, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "AppUser",
                columns: new[] { "Id", "Address", "AppRoleId", "Avatar", "BlockedBy", "BlockedTo", "BranchId", "CitizenId", "CreatedBy", "CreatedDate", "DeletedDate", "DisplayOrder", "Email", "FullName", "Passport", "PasswordHash", "PasswordSalt", "Permanent", "PhoneNumber1", "PhoneNumber2", "UpdatedBy", "UpdatedDate", "Username" },
                values: new object[,]
                {
                    { 1, "Kiên Giang", 1, "/adminLTE/images/users/avatar-3.jpg", null, null, null, 912345678, -1, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "administrator@gmail.com", "Nguyễn Thanh Long", null, new byte[] { 68, 227, 89, 5, 170, 175, 167, 31, 42, 145, 83, 14, 244, 119, 76, 241, 138, 42, 177, 127, 222, 138, 61, 6, 136, 213, 81, 103, 197, 95, 160, 63, 217, 98, 20, 242, 161, 176, 61, 0, 80, 183, 69, 110, 245, 73, 236, 56, 219, 172, 183, 45, 84, 69, 102, 2, 17, 195, 37, 41, 57, 149, 252, 206 }, new byte[] { 130, 2, 255, 3, 144, 251, 31, 105, 68, 78, 205, 4, 80, 68, 22, 48, 255, 61, 135, 36, 141, 170, 110, 108, 40, 160, 84, 97, 74, 27, 124, 15, 233, 174, 23, 78, 16, 106, 69, 103, 62, 8, 133, 15, 18, 223, 246, 249, 139, 218, 114, 50, 206, 220, 236, 249, 195, 182, 24, 92, 252, 73, 61, 219, 244, 17, 202, 187, 254, 120, 192, 84, 29, 110, 35, 209, 17, 20, 165, 58, 40, 61, 150, 115, 208, 230, 214, 9, 110, 177, 75, 13, 35, 9, 74, 113, 162, 229, 61, 50, 202, 11, 234, 27, 20, 85, 193, 42, 151, 80, 241, 103, 74, 19, 250, 153, 83, 11, 12, 17, 43, 219, 145, 226, 49, 240, 167, 38 }, null, "+84928666158", "+84928666156", null, null, "administrator" },
                    { 2, "Thành phố Cần Thơ", 2, "/adminLTE/images/users/avatar-7.jpg", null, null, null, 917635678, -1, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "fullequipmentmanagement@gmail.com", "Trần Chí Dũng", null, new byte[] { 68, 227, 89, 5, 170, 175, 167, 31, 42, 145, 83, 14, 244, 119, 76, 241, 138, 42, 177, 127, 222, 138, 61, 6, 136, 213, 81, 103, 197, 95, 160, 63, 217, 98, 20, 242, 161, 176, 61, 0, 80, 183, 69, 110, 245, 73, 236, 56, 219, 172, 183, 45, 84, 69, 102, 2, 17, 195, 37, 41, 57, 149, 252, 206 }, new byte[] { 130, 2, 255, 3, 144, 251, 31, 105, 68, 78, 205, 4, 80, 68, 22, 48, 255, 61, 135, 36, 141, 170, 110, 108, 40, 160, 84, 97, 74, 27, 124, 15, 233, 174, 23, 78, 16, 106, 69, 103, 62, 8, 133, 15, 18, 223, 246, 249, 139, 218, 114, 50, 206, 220, 236, 249, 195, 182, 24, 92, 252, 73, 61, 219, 244, 17, 202, 187, 254, 120, 192, 84, 29, 110, 35, 209, 17, 20, 165, 58, 40, 61, 150, 115, 208, 230, 214, 9, 110, 177, 75, 13, 35, 9, 74, 113, 162, 229, 61, 50, 202, 11, 234, 27, 20, 85, 193, 42, 151, 80, 241, 103, 74, 19, 250, 153, 83, 11, 12, 17, 43, 219, 145, 226, 49, 240, 167, 38 }, null, "+84928666157", "+84928666158", null, null, "full_equipment_management" },
                    { 4, "Hà Nội", 5, "/adminLTE/images/users/avatar-1.jpg", null, null, null, 917673478, -1, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "fullnewsmanager@gmail.com", "Trần Thúy Hồng", null, new byte[] { 68, 227, 89, 5, 170, 175, 167, 31, 42, 145, 83, 14, 244, 119, 76, 241, 138, 42, 177, 127, 222, 138, 61, 6, 136, 213, 81, 103, 197, 95, 160, 63, 217, 98, 20, 242, 161, 176, 61, 0, 80, 183, 69, 110, 245, 73, 236, 56, 219, 172, 183, 45, 84, 69, 102, 2, 17, 195, 37, 41, 57, 149, 252, 206 }, new byte[] { 130, 2, 255, 3, 144, 251, 31, 105, 68, 78, 205, 4, 80, 68, 22, 48, 255, 61, 135, 36, 141, 170, 110, 108, 40, 160, 84, 97, 74, 27, 124, 15, 233, 174, 23, 78, 16, 106, 69, 103, 62, 8, 133, 15, 18, 223, 246, 249, 139, 218, 114, 50, 206, 220, 236, 249, 195, 182, 24, 92, 252, 73, 61, 219, 244, 17, 202, 187, 254, 120, 192, 84, 29, 110, 35, 209, 17, 20, 165, 58, 40, 61, 150, 115, 208, 230, 214, 9, 110, 177, 75, 13, 35, 9, 74, 113, 162, 229, 61, 50, 202, 11, 234, 27, 20, 85, 193, 42, 151, 80, 241, 103, 74, 19, 250, 153, 83, 11, 12, 17, 43, 219, 145, 226, 49, 240, 167, 38 }, null, "+84728756123", "+84227459233", null, null, "full_news_manager" },
                    { 5, "Thành phố Hồ Chí Minh", 6, "/adminLTE/images/users/avatar-10.jpg", null, null, null, 917674628, -1, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "catenewsmanager@gmail.com", "Nguyên Thị Thanh", null, new byte[] { 68, 227, 89, 5, 170, 175, 167, 31, 42, 145, 83, 14, 244, 119, 76, 241, 138, 42, 177, 127, 222, 138, 61, 6, 136, 213, 81, 103, 197, 95, 160, 63, 217, 98, 20, 242, 161, 176, 61, 0, 80, 183, 69, 110, 245, 73, 236, 56, 219, 172, 183, 45, 84, 69, 102, 2, 17, 195, 37, 41, 57, 149, 252, 206 }, new byte[] { 130, 2, 255, 3, 144, 251, 31, 105, 68, 78, 205, 4, 80, 68, 22, 48, 255, 61, 135, 36, 141, 170, 110, 108, 40, 160, 84, 97, 74, 27, 124, 15, 233, 174, 23, 78, 16, 106, 69, 103, 62, 8, 133, 15, 18, 223, 246, 249, 139, 218, 114, 50, 206, 220, 236, 249, 195, 182, 24, 92, 252, 73, 61, 219, 244, 17, 202, 187, 254, 120, 192, 84, 29, 110, 35, 209, 17, 20, 165, 58, 40, 61, 150, 115, 208, 230, 214, 9, 110, 177, 75, 13, 35, 9, 74, 113, 162, 229, 61, 50, 202, 11, 234, 27, 20, 85, 193, 42, 151, 80, 241, 103, 74, 19, 250, 153, 83, 11, 12, 17, 43, 219, 145, 226, 49, 240, 167, 38 }, null, "+84728864923", "+84227459873", null, null, "cate_news_manager" },
                    { 6, "Phú Quốc", 7, "/adminLTE/images/users/avatar-2.jpg", null, null, null, 917987628, -1, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "newsmanager@gmail.com", "Lê Thanh Hà", null, new byte[] { 68, 227, 89, 5, 170, 175, 167, 31, 42, 145, 83, 14, 244, 119, 76, 241, 138, 42, 177, 127, 222, 138, 61, 6, 136, 213, 81, 103, 197, 95, 160, 63, 217, 98, 20, 242, 161, 176, 61, 0, 80, 183, 69, 110, 245, 73, 236, 56, 219, 172, 183, 45, 84, 69, 102, 2, 17, 195, 37, 41, 57, 149, 252, 206 }, new byte[] { 130, 2, 255, 3, 144, 251, 31, 105, 68, 78, 205, 4, 80, 68, 22, 48, 255, 61, 135, 36, 141, 170, 110, 108, 40, 160, 84, 97, 74, 27, 124, 15, 233, 174, 23, 78, 16, 106, 69, 103, 62, 8, 133, 15, 18, 223, 246, 249, 139, 218, 114, 50, 206, 220, 236, 249, 195, 182, 24, 92, 252, 73, 61, 219, 244, 17, 202, 187, 254, 120, 192, 84, 29, 110, 35, 209, 17, 20, 165, 58, 40, 61, 150, 115, 208, 230, 214, 9, 110, 177, 75, 13, 35, 9, 74, 113, 162, 229, 61, 50, 202, 11, 234, 27, 20, 85, 193, 42, 151, 80, 241, 103, 74, 19, 250, 153, 83, 11, 12, 17, 43, 219, 145, 226, 49, 240, 167, 38 }, null, "+84752364923", "+84208739873", null, null, "news_manager" },
                    { 7, "Phú Quốc", 8, "/adminLTE/images/users/avatar-6.jpg", null, null, null, 917987986, -1, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "cateequipmentmanagement@gmail.com", "Lê Hồng Thị", null, new byte[] { 68, 227, 89, 5, 170, 175, 167, 31, 42, 145, 83, 14, 244, 119, 76, 241, 138, 42, 177, 127, 222, 138, 61, 6, 136, 213, 81, 103, 197, 95, 160, 63, 217, 98, 20, 242, 161, 176, 61, 0, 80, 183, 69, 110, 245, 73, 236, 56, 219, 172, 183, 45, 84, 69, 102, 2, 17, 195, 37, 41, 57, 149, 252, 206 }, new byte[] { 130, 2, 255, 3, 144, 251, 31, 105, 68, 78, 205, 4, 80, 68, 22, 48, 255, 61, 135, 36, 141, 170, 110, 108, 40, 160, 84, 97, 74, 27, 124, 15, 233, 174, 23, 78, 16, 106, 69, 103, 62, 8, 133, 15, 18, 223, 246, 249, 139, 218, 114, 50, 206, 220, 236, 249, 195, 182, 24, 92, 252, 73, 61, 219, 244, 17, 202, 187, 254, 120, 192, 84, 29, 110, 35, 209, 17, 20, 165, 58, 40, 61, 150, 115, 208, 230, 214, 9, 110, 177, 75, 13, 35, 9, 74, 113, 162, 229, 61, 50, 202, 11, 234, 27, 20, 85, 193, 42, 151, 80, 241, 103, 74, 19, 250, 153, 83, 11, 12, 17, 43, 219, 145, 226, 49, 240, 167, 38 }, null, "+84752369852", "+84208739842", null, null, "cate_equipment_management" },
                    { 8, "Hà Tiên", 9, "/adminLTE/images/users/avatar-4.jpg", null, null, null, 987987986, -1, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "equipmentmanagement@gmail.com", "Huỳnh Dương Thanh", null, new byte[] { 68, 227, 89, 5, 170, 175, 167, 31, 42, 145, 83, 14, 244, 119, 76, 241, 138, 42, 177, 127, 222, 138, 61, 6, 136, 213, 81, 103, 197, 95, 160, 63, 217, 98, 20, 242, 161, 176, 61, 0, 80, 183, 69, 110, 245, 73, 236, 56, 219, 172, 183, 45, 84, 69, 102, 2, 17, 195, 37, 41, 57, 149, 252, 206 }, new byte[] { 130, 2, 255, 3, 144, 251, 31, 105, 68, 78, 205, 4, 80, 68, 22, 48, 255, 61, 135, 36, 141, 170, 110, 108, 40, 160, 84, 97, 74, 27, 124, 15, 233, 174, 23, 78, 16, 106, 69, 103, 62, 8, 133, 15, 18, 223, 246, 249, 139, 218, 114, 50, 206, 220, 236, 249, 195, 182, 24, 92, 252, 73, 61, 219, 244, 17, 202, 187, 254, 120, 192, 84, 29, 110, 35, 209, 17, 20, 165, 58, 40, 61, 150, 115, 208, 230, 214, 9, 110, 177, 75, 13, 35, 9, 74, 113, 162, 229, 61, 50, 202, 11, 234, 27, 20, 85, 193, 42, 151, 80, 241, 103, 74, 19, 250, 153, 83, 11, 12, 17, 43, 219, 145, 226, 49, 240, 167, 38 }, null, "+84758576323", "+84208739823", null, null, "equipment_management" },
                    { 9, "Branch Address 9", 4, "/adminLTE/images/users/avatar-9.jpg", null, null, 0, 1000000996, -1, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "admin_branch_9@gmail.com", "Admin Branch 9", null, new byte[] { 68, 227, 89, 5, 170, 175, 167, 31, 42, 145, 83, 14, 244, 119, 76, 241, 138, 42, 177, 127, 222, 138, 61, 6, 136, 213, 81, 103, 197, 95, 160, 63, 217, 98, 20, 242, 161, 176, 61, 0, 80, 183, 69, 110, 245, 73, 236, 56, 219, 172, 183, 45, 84, 69, 102, 2, 17, 195, 37, 41, 57, 149, 252, 206 }, new byte[] { 130, 2, 255, 3, 144, 251, 31, 105, 68, 78, 205, 4, 80, 68, 22, 48, 255, 61, 135, 36, 141, 170, 110, 108, 40, 160, 84, 97, 74, 27, 124, 15, 233, 174, 23, 78, 16, 106, 69, 103, 62, 8, 133, 15, 18, 223, 246, 249, 139, 218, 114, 50, 206, 220, 236, 249, 195, 182, 24, 92, 252, 73, 61, 219, 244, 17, 202, 187, 254, 120, 192, 84, 29, 110, 35, 209, 17, 20, 165, 58, 40, 61, 150, 115, 208, 230, 214, 9, 110, 177, 75, 13, 35, 9, 74, 113, 162, 229, 61, 50, 202, 11, 234, 27, 20, 85, 193, 42, 151, 80, 241, 103, 74, 19, 250, 153, 83, 11, 12, 17, 43, 219, 145, 226, 49, 240, 167, 38 }, null, "+84900000009", "+84900000019", null, null, "admin_branch_9" }
                });

            migrationBuilder.InsertData(
                table: "AppComment",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedDate", "Description", "DisplayOrder", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 3, 4, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Khách sạn có vị trí thuận tiện, gần trung tâm thành phố. Phòng ốc sạch sẽ, tiện nghi.", null, null, null },
                    { 4, 5, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Dịch vụ đặt phòng nhanh chóng, nhân viên hỗ trợ nhiệt tình. Sẽ quay lại lần sau.", null, null, null },
                    { 5, 6, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Phòng rộng rãi, thoáng mát. Bữa sáng ngon miệng và đa dạng.", null, null, null },
                    { 6, 7, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Giá cả hợp lý, dịch vụ tốt. Nhân viên thân thiện và chuyên nghiệp.", null, null, null },
                    { 7, 8, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Khách sạn có hồ bơi và phòng gym, rất tiện lợi cho khách lưu trú dài ngày.", null, null, null },
                    { 8, 9, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Dịch vụ đặt phòng trực tuyến dễ dàng, nhanh chóng. Nhân viên hỗ trợ tận tình.", null, null, null },
                    { 9, 4, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Phòng có view đẹp, nhìn ra biển. Rất thích hợp cho kỳ nghỉ dưỡng.", null, null, null },
                    { 10, 5, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Khách sạn có nhiều tiện ích, từ nhà hàng, quán bar đến spa. Rất hài lòng với dịch vụ.", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "AppNews",
                columns: new[] { "Id", "CategoryId", "Content", "CoverImgPath", "CoverImgThumbnailPath", "CreatedBy", "CreatedDate", "DeletedDate", "DisplayOrder", "Published", "PublishedAt", "Slug", "StampPath", "Summary", "Title", "UpdatedBy", "UpdatedDate", "Views", "Votes" },
                values: new object[,]
                {
                    { 1, 1, "Nói về tour du lịch chợ nổi", "files/ImgNews/Cover-Chợ-Nổi_VN.jpg", "files/ImgNews/Thumbnail-Chợ-Nổi_VN.jpg", 1, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, true, null, "cho-noi-tuyet-voi-an-giau-va-con-kenh-nho-kenh-nho-khong-danh-cho-khach-du-lich", "files/ImgNews/Stamp-Chợ-Nổi_VN.jpg", "<blockquote><h3>Chúng tôi tự hào điều hành các tour du lịch của mình với những cam kết “Không” sau:</h3></blockquote><p>Không có cửa hàng du lịch dừng lại</p><p>Không có bẫy du lịch</p><p>Không có động vật nào có liên quan hoặc bị tổn hại</p><p>&nbsp;</p><blockquote><h4>Làm nổi bật các điểm tham quan:</h4></blockquote><p>• Chợ nổi lớn nhất (Cái Răng)</p><p>&nbsp;</p><p>• Nhà mì truyền thống địa phương nơi bạn tự làm bánh tráng và mì do người dân địa phương hướng dẫn.</p><p>&nbsp;</p><p>• Bữa sáng trên thuyền - Bữa sáng ngon nhất mà Master Chef Gordon Ramsey đã thử khi đến đây.</p><p>&nbsp;</p><p>• Kênh nhỏ đích thực.</p><p>&nbsp;</p><p>• Đi bộ qua ngôi làng đích thực</p><figure class=\"table\"><table><tbody><tr><td><h2>Bao gồm</h2><p>✅Phí vào cửa<br>✅Hướng dẫn viên nói tiếng Anh/Pháp (có tính phí)<br>✅Thuyền<br>✅Trái cây và đồ uống một lần<br>✅Bữa sáng<br>✅Xe đón và trả khách tại thành phố Cần Thơ.</p></td><td><h2>Không bao gồm những gì?</h2><p>❌Đồ uống có cồn (có sẵn để mua)</p><p>&nbsp;</p><p>&nbsp;</p><p>&nbsp;</p><p>&nbsp;</p></td></tr></tbody></table></figure><h3>Thông tin thêm</h3><p>Các lựa chọn giao thông công cộng có sẵn ở gần đó</p><p>Trẻ sơ sinh phải ngồi trên đùi người lớn</p><p>Không khuyến khích cho du khách mang thai</p><p>Không nên dùng cho du khách có sức khỏe tim mạch kém</p><p>Thích hợp cho mọi cấp độ thể chất</p><p>Có sẵn lựa chọn ăn chay, vui lòng thông báo tại thời điểm đặt chỗ nếu được yêu cầu</p><p>Trẻ em phải có người lớn đi kèm</p><p>Chúng tôi cung cấp dịch vụ đón khách miễn phí tại bất kỳ địa điểm nào trong trung tâm thành phố Cần Thơ, nếu bạn ở ngoài thành phố (bán kính 1km từ điểm tập trung)</p><p>Không thể sử dụng xe lăn</p><p>Vui lòng mang theo vé đến điểm tham quan.</p><p>Lưu ý rằng nhà cung cấp có thể hủy bỏ những lý do chưa biết trước đó.</p><p>Bạn phải đủ 18 tuổi trở lên mới có thể đặt vé hoặc phải đi cùng người lớn.</p><p>Điều hành bởi Fabulous Mekong Eco Tours</p>", "Chợ nổi tuyệt vời ẩn giấu và con kênh nhỏ (Kênh nhỏ không dành cho khách du lịch)", null, null, 100L, 15f },
                    { 2, 2, "Nói về tour du lịch chợ nổi", "files/ImgNews/Cover-Chợ-Nổi_VN.jpg", "files/ImgNews/Thumbnail-Chợ-Nổi_VN.jpg", 5, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, true, null, "cho-noi-tuyet-voi-an-giau-va-con-kenh-nho-kenh-nho-khong-danh-cho-khach-du-lich", "files/ImgNews/Stamp-Chợ-Nổi_VN.jpg", "<blockquote><h3>Chúng tôi tự hào điều hành các tour du lịch của mình với những cam kết “Không” sau:</h3></blockquote><p>Không có cửa hàng du lịch dừng lại</p><p>Không có bẫy du lịch</p><p>Không có động vật nào có liên quan hoặc bị tổn hại</p><p>&nbsp;</p><blockquote><h4>Làm nổi bật các điểm tham quan:</h4></blockquote><p>• Chợ nổi lớn nhất (Cái Răng)</p><p>&nbsp;</p><p>• Nhà mì truyền thống địa phương nơi bạn tự làm bánh tráng và mì do người dân địa phương hướng dẫn.</p><p>&nbsp;</p><p>• Bữa sáng trên thuyền - Bữa sáng ngon nhất mà Master Chef Gordon Ramsey đã thử khi đến đây.</p><p>&nbsp;</p><p>• Kênh nhỏ đích thực.</p><p>&nbsp;</p><p>• Đi bộ qua ngôi làng đích thực</p><figure class=\"table\"><table><tbody><tr><td><h2>Bao gồm</h2><p>✅Phí vào cửa<br>✅Hướng dẫn viên nói tiếng Anh/Pháp (có tính phí)<br>✅Thuyền<br>✅Trái cây và đồ uống một lần<br>✅Bữa sáng<br>✅Xe đón và trả khách tại thành phố Cần Thơ.</p></td><td><h2>Không bao gồm những gì?</h2><p>❌Đồ uống có cồn (có sẵn để mua)</p><p>&nbsp;</p><p>&nbsp;</p><p>&nbsp;</p><p>&nbsp;</p></td></tr></tbody></table></figure><h3>Thông tin thêm</h3><p>Các lựa chọn giao thông công cộng có sẵn ở gần đó</p><p>Trẻ sơ sinh phải ngồi trên đùi người lớn</p><p>Không khuyến khích cho du khách mang thai</p><p>Không nên dùng cho du khách có sức khỏe tim mạch kém</p><p>Thích hợp cho mọi cấp độ thể chất</p><p>Có sẵn lựa chọn ăn chay, vui lòng thông báo tại thời điểm đặt chỗ nếu được yêu cầu</p><p>Trẻ em phải có người lớn đi kèm</p><p>Chúng tôi cung cấp dịch vụ đón khách miễn phí tại bất kỳ địa điểm nào trong trung tâm thành phố Cần Thơ, nếu bạn ở ngoài thành phố (bán kính 1km từ điểm tập trung)</p><p>Không thể sử dụng xe lăn</p><p>Vui lòng mang theo vé đến điểm tham quan.</p><p>Lưu ý rằng nhà cung cấp có thể hủy bỏ những lý do chưa biết trước đó.</p><p>Bạn phải đủ 18 tuổi trở lên mới có thể đặt vé hoặc phải đi cùng người lớn.</p><p>Điều hành bởi Fabulous Mekong Eco Tours</p>", "Chợ nổi tuyệt vời ẩn giấu và con kênh nhỏ (Kênh nhỏ không dành cho khách du lịch)", null, null, 210L, 55f },
                    { 3, 2, "Nội dung nói về địa điểm tham quan ở Paris", "files/ImgNews/Cover-Sightseeing_France.jpg", "files/ImgNews/Thumbnail-Sightseeing_France.jpg", 1, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, true, null, "du-thuyen-ngam-canh-tu-thap-eiffel", "files/ImgNews/Stamp-Sightseeing_France.jpg", "<blockquote><h3>Chuyến đi ở Paris</h3></blockquote><p>Khởi hành từ Tháp Eiffel mang tính biểu tượng, chuyến đi có hướng dẫn kéo dài một giờ này sẽ mang đến cho bạn cơ hội chiêm ngưỡng những địa điểm hàng đầu của thành phố. Bạn sẽ đi dọc Sông Seine trên du thuyền trimaran - một chiếc thuyền được thiết kế để tham quan với boong ngoài trời lớn.</p><p><br>Bạn sẽ đi ngang qua các địa danh nổi tiếng như Louvre, Palais Bourbon, Notre-Dame và nhiều địa danh khác. Trên đường đi, âm thanh và bình luận trực tiếp sẽ nêu bật các chi tiết về lịch sử thủ đô nước Pháp và các di tích của nó.</p><h2>Vì sao nên đến đây?</h2><p>✅Quang cảnh các địa danh bao gồm bảo tàng Louvre và Notre-Dame</p><p>✅Đi thuyền dọc sông Seine bằng boong ngoài trời để ngắm cảnh</p><p>✅Hiểu biết sâu sắc về lịch sử của thành phố và các di tích mang tính biểu tượng của nó</p><figure class=\"table\"><table><tbody><tr><td><h2>Bao gồm</h2><p>✅Hành trình một giờ có bình luận</p></td><td><h2>Không bao gồm những gì?</h2><p>❌Hình ảnh lưu niệm<br>❌Thức ăn và đồ uống</p></td></tr></tbody></table></figure><h3>Thông tin thêm</h3><p>Thế vận hội Olympic Paris sẽ diễn ra từ ngày 26 tháng 7 đến ngày 11 tháng 8 năm 2024 và Thế vận hội Paralympic từ ngày 28 tháng 8 đến ngày 8 tháng 9 năm 2024. Do những sự kiện này, một số dịch vụ của nhà cung cấp tour du lịch sẽ bị ảnh hưởng:</p><ul><li>Ngày 14 tháng 7 năm 2024: đóng cửa hoàn toàn hoạt động bắt đầu từ 14:00</li><li>Ngày 27 tháng 7 năm 2024: khởi hành lần đầu lúc 12:00</li><li>Ngày 8 tháng 7 đến ngày 11 tháng 8 năm 2024: khởi hành lần đầu lúc 11:00</li><li>Ngày 1 và 2 tháng 9 năm 2024: khởi hành lần đầu lúc 13:30</li><li>Ngày 3 tháng 9 năm 2024: khởi hành lần đầu lúc 15:00</li></ul><p>Thời gian khởi hành chỉ được cung cấp để cung cấp thông tin và có thể thay đổi.</p><p>Vào ngày 18 tháng 7 năm 2024, hành trình bình luận kéo dài một giờ sẽ hoạt động như bình thường. Tuy nhiên, chỉ những người có thẻ kỹ thuật số mới được phép vào địa điểm, một biện pháp được Chính phủ Pháp thực hiện nhằm đảm bảo an ninh cho khu vực lân cận sông Seine, nơi sẽ trở thành địa điểm mang tính biểu tượng cho lễ khai mạc Thế vận hội.</p><p>Bạn có thể nhận được thẻ thông qua trang web chính thức của chính phủ. Nhà cung cấp tour du lịch từ chối mọi trách nhiệm trong trường hợp không xuất trình được thẻ dẫn đến việc từ chối vào cửa. Bạn nên bắt đầu quá trình này ít nhất 15 ngày trước ngày sử dụng dịch vụ.</p><p>Vui lòng tham khảo trang web của nhà cung cấp tour để biết giờ hoạt động được cập nhật.</p><p>Xin lưu ý rằng động vật không được phép lên tàu.</p><p>Xin lưu ý rằng hành lý vượt quá sức chứa 16 lít không được chấp nhận. Chỉ được phép mang ba lô nhỏ, túi xách và hộp đựng máy tính xách tay lên máy bay.</p>", "Du thuyền ngắm cảnh từ tháp Eiffel", null, null, 100L, 35f },
                    { 4, 1, "Nội dung nói về địa điểm tham quan ở Paris", "files/ImgNews/Cover-Sightseeing_France.jpg", "files/ImgNews/Thumbnail-Sightseeing_France.jpg", 5, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, true, null, "du-thuyen-ngam-canh-tu-thap-eiffel", "files/ImgNews/Stamp-Sightseeing_France.jpg", "<blockquote><h3>Chuyến đi ở Paris</h3></blockquote><p>Khởi hành từ Tháp Eiffel mang tính biểu tượng, chuyến đi có hướng dẫn kéo dài một giờ này sẽ mang đến cho bạn cơ hội chiêm ngưỡng những địa điểm hàng đầu của thành phố. Bạn sẽ đi dọc Sông Seine trên du thuyền trimaran - một chiếc thuyền được thiết kế để tham quan với boong ngoài trời lớn.</p><p><br>Bạn sẽ đi ngang qua các địa danh nổi tiếng như Louvre, Palais Bourbon, Notre-Dame và nhiều địa danh khác. Trên đường đi, âm thanh và bình luận trực tiếp sẽ nêu bật các chi tiết về lịch sử thủ đô nước Pháp và các di tích của nó.</p><h2>Vì sao nên đến đây?</h2><p>✅Quang cảnh các địa danh bao gồm bảo tàng Louvre và Notre-Dame</p><p>✅Đi thuyền dọc sông Seine bằng boong ngoài trời để ngắm cảnh</p><p>✅Hiểu biết sâu sắc về lịch sử của thành phố và các di tích mang tính biểu tượng của nó</p><figure class=\"table\"><table><tbody><tr><td><h2>Bao gồm</h2><p>✅Hành trình một giờ có bình luận</p></td><td><h2>Không bao gồm những gì?</h2><p>❌Hình ảnh lưu niệm<br>❌Thức ăn và đồ uống</p></td></tr></tbody></table></figure><h3>Thông tin thêm</h3><p>Thế vận hội Olympic Paris sẽ diễn ra từ ngày 26 tháng 7 đến ngày 11 tháng 8 năm 2024 và Thế vận hội Paralympic từ ngày 28 tháng 8 đến ngày 8 tháng 9 năm 2024. Do những sự kiện này, một số dịch vụ của nhà cung cấp tour du lịch sẽ bị ảnh hưởng:</p><ul><li>Ngày 14 tháng 7 năm 2024: đóng cửa hoàn toàn hoạt động bắt đầu từ 14:00</li><li>Ngày 27 tháng 7 năm 2024: khởi hành lần đầu lúc 12:00</li><li>Ngày 8 tháng 7 đến ngày 11 tháng 8 năm 2024: khởi hành lần đầu lúc 11:00</li><li>Ngày 1 và 2 tháng 9 năm 2024: khởi hành lần đầu lúc 13:30</li><li>Ngày 3 tháng 9 năm 2024: khởi hành lần đầu lúc 15:00</li></ul><p>Thời gian khởi hành chỉ được cung cấp để cung cấp thông tin và có thể thay đổi.</p><p>Vào ngày 18 tháng 7 năm 2024, hành trình bình luận kéo dài một giờ sẽ hoạt động như bình thường. Tuy nhiên, chỉ những người có thẻ kỹ thuật số mới được phép vào địa điểm, một biện pháp được Chính phủ Pháp thực hiện nhằm đảm bảo an ninh cho khu vực lân cận sông Seine, nơi sẽ trở thành địa điểm mang tính biểu tượng cho lễ khai mạc Thế vận hội.</p><p>Bạn có thể nhận được thẻ thông qua trang web chính thức của chính phủ. Nhà cung cấp tour du lịch từ chối mọi trách nhiệm trong trường hợp không xuất trình được thẻ dẫn đến việc từ chối vào cửa. Bạn nên bắt đầu quá trình này ít nhất 15 ngày trước ngày sử dụng dịch vụ.</p><p>Vui lòng tham khảo trang web của nhà cung cấp tour để biết giờ hoạt động được cập nhật.</p><p>Xin lưu ý rằng động vật không được phép lên tàu.</p><p>Xin lưu ý rằng hành lý vượt quá sức chứa 16 lít không được chấp nhận. Chỉ được phép mang ba lô nhỏ, túi xách và hộp đựng máy tính xách tay lên máy bay.</p>", "Du thuyền ngắm cảnh từ tháp Eiffel", null, null, 510L, 59f }
                });

            migrationBuilder.InsertData(
                table: "AppRoom",
                columns: new[] { "Id", "BranchId", "CreatedBy", "CreatedDate", "DeletedDate", "DiscountFrom", "DiscountPrice", "DiscountTo", "DisplayOrder", "FloorNumber", "IsActive", "Price", "RoomName", "RoomNumber", "RoomTypeId", "Slug", "Status", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 10, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 12000000m, new DateTime(2024, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 145, true, 15000000m, "T0145•101 Luxury", 101, 4, "t0145-101-luxury", "Đã trả phòng - phòng trống", null, null },
                    { 2, 2, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, 12, true, 1200000m, "T012•205 Double", 205, 2, "t012-205-double", "Phòng đang được đặt", null, null },
                    { 3, 1, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, 2, true, 120000m, "T02•15 Double", 15, 2, "t012-205-double", "Phòng đang được đặt", null, null },
                    { 4, 13, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, 3, true, 8000000m, "T03•101 Single", 101, 1, "t03-101-single", "Phòng đang được sửa chữa", null, null },
                    { 5, 3, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, 4, true, 80000m, "T04•102 Single", 102, 1, "t04-102-single", "Phòng đang được sửa chữa", null, null },
                    { 6, 7, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, 5, true, 200000m, "T05•201 Family", 201, 3, "t05-201-family", "Phòng đang được dọn dẹp", null, null },
                    { 7, 1, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, 6, true, 200000m, "T06•202 Family", 202, 3, "t06-202-family", "Phòng đang được đặt", null, null },
                    { 8, 1, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, 7, true, 20000000m, "T07•301 VIP", 301, 5, "t07-301-vip", "Khách đã nhận phòng", null, null },
                    { 9, 23, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, 8, true, 20000000m, "T08•302 VIP", 302, 5, "t08-302-vip", "Khách đã nhận phòng", null, null },
                    { 10, 23, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, 9, true, 15000000m, "T09•401 Luxury", 401, 4, "t09-401-luxury", "Đã hủy đặt phòng", null, null },
                    { 11, 15, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, 10, true, 15000000m, "T10•402 Luxury", 402, 4, "t10-402-luxury", "Đã hủy đặt phòng", null, null },
                    { 12, 1, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 18000000m, new DateTime(2024, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 11, true, 20000000m, "T11•501 VIP", 501, 5, "t11-501-vip", "Khách đã nhận phòng", null, null },
                    { 13, 2, null, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 14000000m, new DateTime(2024, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12, true, 15000000m, "T12•502 Luxury", 502, 4, "t12-502-luxury", "Đã trả phòng - phòng trống", null, null }
                });

            migrationBuilder.InsertData(
                table: "AppUser",
                columns: new[] { "Id", "Address", "AppRoleId", "Avatar", "BlockedBy", "BlockedTo", "BranchId", "CitizenId", "CreatedBy", "CreatedDate", "DeletedDate", "DisplayOrder", "Email", "FullName", "Passport", "PasswordHash", "PasswordSalt", "Permanent", "PhoneNumber1", "PhoneNumber2", "UpdatedBy", "UpdatedDate", "Username" },
                values: new object[,]
                {
                    { 3, "New York City", 3, "/adminLTE/images/users/avatar-9.jpg", null, null, 1, null, -1, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "johnsmith1992@gmail.com", "John Smith", "123456789", new byte[] { 68, 227, 89, 5, 170, 175, 167, 31, 42, 145, 83, 14, 244, 119, 76, 241, 138, 42, 177, 127, 222, 138, 61, 6, 136, 213, 81, 103, 197, 95, 160, 63, 217, 98, 20, 242, 161, 176, 61, 0, 80, 183, 69, 110, 245, 73, 236, 56, 219, 172, 183, 45, 84, 69, 102, 2, 17, 195, 37, 41, 57, 149, 252, 206 }, new byte[] { 130, 2, 255, 3, 144, 251, 31, 105, 68, 78, 205, 4, 80, 68, 22, 48, 255, 61, 135, 36, 141, 170, 110, 108, 40, 160, 84, 97, 74, 27, 124, 15, 233, 174, 23, 78, 16, 106, 69, 103, 62, 8, 133, 15, 18, 223, 246, 249, 139, 218, 114, 50, 206, 220, 236, 249, 195, 182, 24, 92, 252, 73, 61, 219, 244, 17, 202, 187, 254, 120, 192, 84, 29, 110, 35, 209, 17, 20, 165, 58, 40, 61, 150, 115, 208, 230, 214, 9, 110, 177, 75, 13, 35, 9, 74, 113, 162, 229, 61, 50, 202, 11, 234, 27, 20, 85, 193, 42, 151, 80, 241, 103, 74, 19, 250, 153, 83, 11, 12, 17, 43, 219, 145, 226, 49, 240, 167, 38 }, null, "+12025550123", "+12027450123", null, null, "user1" },
                    { 10, "Branch Address 10", 4, "/adminLTE/images/users/avatar-10.jpg", null, null, 1, 1000000997, -1, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "admin_branch_10@gmail.com", "Admin Branch 10", null, new byte[] { 68, 227, 89, 5, 170, 175, 167, 31, 42, 145, 83, 14, 244, 119, 76, 241, 138, 42, 177, 127, 222, 138, 61, 6, 136, 213, 81, 103, 197, 95, 160, 63, 217, 98, 20, 242, 161, 176, 61, 0, 80, 183, 69, 110, 245, 73, 236, 56, 219, 172, 183, 45, 84, 69, 102, 2, 17, 195, 37, 41, 57, 149, 252, 206 }, new byte[] { 130, 2, 255, 3, 144, 251, 31, 105, 68, 78, 205, 4, 80, 68, 22, 48, 255, 61, 135, 36, 141, 170, 110, 108, 40, 160, 84, 97, 74, 27, 124, 15, 233, 174, 23, 78, 16, 106, 69, 103, 62, 8, 133, 15, 18, 223, 246, 249, 139, 218, 114, 50, 206, 220, 236, 249, 195, 182, 24, 92, 252, 73, 61, 219, 244, 17, 202, 187, 254, 120, 192, 84, 29, 110, 35, 209, 17, 20, 165, 58, 40, 61, 150, 115, 208, 230, 214, 9, 110, 177, 75, 13, 35, 9, 74, 113, 162, 229, 61, 50, 202, 11, 234, 27, 20, 85, 193, 42, 151, 80, 241, 103, 74, 19, 250, 153, 83, 11, 12, 17, 43, 219, 145, 226, 49, 240, 167, 38 }, null, "+849000000010", "+849000000110", null, null, "admin_branch_10" },
                    { 11, "Branch Address 11", 4, "/adminLTE/images/users/avatar-1.jpg", null, null, 2, 1000000998, -1, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "admin_branch_11@gmail.com", "Admin Branch 11", null, new byte[] { 68, 227, 89, 5, 170, 175, 167, 31, 42, 145, 83, 14, 244, 119, 76, 241, 138, 42, 177, 127, 222, 138, 61, 6, 136, 213, 81, 103, 197, 95, 160, 63, 217, 98, 20, 242, 161, 176, 61, 0, 80, 183, 69, 110, 245, 73, 236, 56, 219, 172, 183, 45, 84, 69, 102, 2, 17, 195, 37, 41, 57, 149, 252, 206 }, new byte[] { 130, 2, 255, 3, 144, 251, 31, 105, 68, 78, 205, 4, 80, 68, 22, 48, 255, 61, 135, 36, 141, 170, 110, 108, 40, 160, 84, 97, 74, 27, 124, 15, 233, 174, 23, 78, 16, 106, 69, 103, 62, 8, 133, 15, 18, 223, 246, 249, 139, 218, 114, 50, 206, 220, 236, 249, 195, 182, 24, 92, 252, 73, 61, 219, 244, 17, 202, 187, 254, 120, 192, 84, 29, 110, 35, 209, 17, 20, 165, 58, 40, 61, 150, 115, 208, 230, 214, 9, 110, 177, 75, 13, 35, 9, 74, 113, 162, 229, 61, 50, 202, 11, 234, 27, 20, 85, 193, 42, 151, 80, 241, 103, 74, 19, 250, 153, 83, 11, 12, 17, 43, 219, 145, 226, 49, 240, 167, 38 }, null, "+849000000011", "+849000000111", null, null, "admin_branch_11" },
                    { 12, "Branch Address 12", 4, "/adminLTE/images/users/avatar-2.jpg", null, null, 3, 1000000999, -1, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "admin_branch_12@gmail.com", "Admin Branch 12", null, new byte[] { 68, 227, 89, 5, 170, 175, 167, 31, 42, 145, 83, 14, 244, 119, 76, 241, 138, 42, 177, 127, 222, 138, 61, 6, 136, 213, 81, 103, 197, 95, 160, 63, 217, 98, 20, 242, 161, 176, 61, 0, 80, 183, 69, 110, 245, 73, 236, 56, 219, 172, 183, 45, 84, 69, 102, 2, 17, 195, 37, 41, 57, 149, 252, 206 }, new byte[] { 130, 2, 255, 3, 144, 251, 31, 105, 68, 78, 205, 4, 80, 68, 22, 48, 255, 61, 135, 36, 141, 170, 110, 108, 40, 160, 84, 97, 74, 27, 124, 15, 233, 174, 23, 78, 16, 106, 69, 103, 62, 8, 133, 15, 18, 223, 246, 249, 139, 218, 114, 50, 206, 220, 236, 249, 195, 182, 24, 92, 252, 73, 61, 219, 244, 17, 202, 187, 254, 120, 192, 84, 29, 110, 35, 209, 17, 20, 165, 58, 40, 61, 150, 115, 208, 230, 214, 9, 110, 177, 75, 13, 35, 9, 74, 113, 162, 229, 61, 50, 202, 11, 234, 27, 20, 85, 193, 42, 151, 80, 241, 103, 74, 19, 250, 153, 83, 11, 12, 17, 43, 219, 145, 226, 49, 240, 167, 38 }, null, "+849000000012", "+849000000112", null, null, "admin_branch_12" },
                    { 13, "Branch Address 13", 4, "/adminLTE/images/users/avatar-3.jpg", null, null, 4, 1000001000, -1, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "admin_branch_13@gmail.com", "Admin Branch 13", null, new byte[] { 68, 227, 89, 5, 170, 175, 167, 31, 42, 145, 83, 14, 244, 119, 76, 241, 138, 42, 177, 127, 222, 138, 61, 6, 136, 213, 81, 103, 197, 95, 160, 63, 217, 98, 20, 242, 161, 176, 61, 0, 80, 183, 69, 110, 245, 73, 236, 56, 219, 172, 183, 45, 84, 69, 102, 2, 17, 195, 37, 41, 57, 149, 252, 206 }, new byte[] { 130, 2, 255, 3, 144, 251, 31, 105, 68, 78, 205, 4, 80, 68, 22, 48, 255, 61, 135, 36, 141, 170, 110, 108, 40, 160, 84, 97, 74, 27, 124, 15, 233, 174, 23, 78, 16, 106, 69, 103, 62, 8, 133, 15, 18, 223, 246, 249, 139, 218, 114, 50, 206, 220, 236, 249, 195, 182, 24, 92, 252, 73, 61, 219, 244, 17, 202, 187, 254, 120, 192, 84, 29, 110, 35, 209, 17, 20, 165, 58, 40, 61, 150, 115, 208, 230, 214, 9, 110, 177, 75, 13, 35, 9, 74, 113, 162, 229, 61, 50, 202, 11, 234, 27, 20, 85, 193, 42, 151, 80, 241, 103, 74, 19, 250, 153, 83, 11, 12, 17, 43, 219, 145, 226, 49, 240, 167, 38 }, null, "+849000000013", "+849000000113", null, null, "admin_branch_13" },
                    { 14, "Branch Address 14", 4, "/adminLTE/images/users/avatar-4.jpg", null, null, 5, 1000001001, -1, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "admin_branch_14@gmail.com", "Admin Branch 14", null, new byte[] { 68, 227, 89, 5, 170, 175, 167, 31, 42, 145, 83, 14, 244, 119, 76, 241, 138, 42, 177, 127, 222, 138, 61, 6, 136, 213, 81, 103, 197, 95, 160, 63, 217, 98, 20, 242, 161, 176, 61, 0, 80, 183, 69, 110, 245, 73, 236, 56, 219, 172, 183, 45, 84, 69, 102, 2, 17, 195, 37, 41, 57, 149, 252, 206 }, new byte[] { 130, 2, 255, 3, 144, 251, 31, 105, 68, 78, 205, 4, 80, 68, 22, 48, 255, 61, 135, 36, 141, 170, 110, 108, 40, 160, 84, 97, 74, 27, 124, 15, 233, 174, 23, 78, 16, 106, 69, 103, 62, 8, 133, 15, 18, 223, 246, 249, 139, 218, 114, 50, 206, 220, 236, 249, 195, 182, 24, 92, 252, 73, 61, 219, 244, 17, 202, 187, 254, 120, 192, 84, 29, 110, 35, 209, 17, 20, 165, 58, 40, 61, 150, 115, 208, 230, 214, 9, 110, 177, 75, 13, 35, 9, 74, 113, 162, 229, 61, 50, 202, 11, 234, 27, 20, 85, 193, 42, 151, 80, 241, 103, 74, 19, 250, 153, 83, 11, 12, 17, 43, 219, 145, 226, 49, 240, 167, 38 }, null, "+849000000014", "+849000000114", null, null, "admin_branch_14" },
                    { 15, "Branch Address 15", 4, "/adminLTE/images/users/avatar-5.jpg", null, null, 6, 1000001002, -1, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "admin_branch_15@gmail.com", "Admin Branch 15", null, new byte[] { 68, 227, 89, 5, 170, 175, 167, 31, 42, 145, 83, 14, 244, 119, 76, 241, 138, 42, 177, 127, 222, 138, 61, 6, 136, 213, 81, 103, 197, 95, 160, 63, 217, 98, 20, 242, 161, 176, 61, 0, 80, 183, 69, 110, 245, 73, 236, 56, 219, 172, 183, 45, 84, 69, 102, 2, 17, 195, 37, 41, 57, 149, 252, 206 }, new byte[] { 130, 2, 255, 3, 144, 251, 31, 105, 68, 78, 205, 4, 80, 68, 22, 48, 255, 61, 135, 36, 141, 170, 110, 108, 40, 160, 84, 97, 74, 27, 124, 15, 233, 174, 23, 78, 16, 106, 69, 103, 62, 8, 133, 15, 18, 223, 246, 249, 139, 218, 114, 50, 206, 220, 236, 249, 195, 182, 24, 92, 252, 73, 61, 219, 244, 17, 202, 187, 254, 120, 192, 84, 29, 110, 35, 209, 17, 20, 165, 58, 40, 61, 150, 115, 208, 230, 214, 9, 110, 177, 75, 13, 35, 9, 74, 113, 162, 229, 61, 50, 202, 11, 234, 27, 20, 85, 193, 42, 151, 80, 241, 103, 74, 19, 250, 153, 83, 11, 12, 17, 43, 219, 145, 226, 49, 240, 167, 38 }, null, "+849000000015", "+849000000115", null, null, "admin_branch_15" },
                    { 16, "Branch Address 16", 4, "/adminLTE/images/users/avatar-6.jpg", null, null, 7, 1000001003, -1, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "admin_branch_16@gmail.com", "Admin Branch 16", null, new byte[] { 68, 227, 89, 5, 170, 175, 167, 31, 42, 145, 83, 14, 244, 119, 76, 241, 138, 42, 177, 127, 222, 138, 61, 6, 136, 213, 81, 103, 197, 95, 160, 63, 217, 98, 20, 242, 161, 176, 61, 0, 80, 183, 69, 110, 245, 73, 236, 56, 219, 172, 183, 45, 84, 69, 102, 2, 17, 195, 37, 41, 57, 149, 252, 206 }, new byte[] { 130, 2, 255, 3, 144, 251, 31, 105, 68, 78, 205, 4, 80, 68, 22, 48, 255, 61, 135, 36, 141, 170, 110, 108, 40, 160, 84, 97, 74, 27, 124, 15, 233, 174, 23, 78, 16, 106, 69, 103, 62, 8, 133, 15, 18, 223, 246, 249, 139, 218, 114, 50, 206, 220, 236, 249, 195, 182, 24, 92, 252, 73, 61, 219, 244, 17, 202, 187, 254, 120, 192, 84, 29, 110, 35, 209, 17, 20, 165, 58, 40, 61, 150, 115, 208, 230, 214, 9, 110, 177, 75, 13, 35, 9, 74, 113, 162, 229, 61, 50, 202, 11, 234, 27, 20, 85, 193, 42, 151, 80, 241, 103, 74, 19, 250, 153, 83, 11, 12, 17, 43, 219, 145, 226, 49, 240, 167, 38 }, null, "+849000000016", "+849000000116", null, null, "admin_branch_16" },
                    { 17, "Branch Address 17", 4, "/adminLTE/images/users/avatar-7.jpg", null, null, 8, 1000001004, -1, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "admin_branch_17@gmail.com", "Admin Branch 17", null, new byte[] { 68, 227, 89, 5, 170, 175, 167, 31, 42, 145, 83, 14, 244, 119, 76, 241, 138, 42, 177, 127, 222, 138, 61, 6, 136, 213, 81, 103, 197, 95, 160, 63, 217, 98, 20, 242, 161, 176, 61, 0, 80, 183, 69, 110, 245, 73, 236, 56, 219, 172, 183, 45, 84, 69, 102, 2, 17, 195, 37, 41, 57, 149, 252, 206 }, new byte[] { 130, 2, 255, 3, 144, 251, 31, 105, 68, 78, 205, 4, 80, 68, 22, 48, 255, 61, 135, 36, 141, 170, 110, 108, 40, 160, 84, 97, 74, 27, 124, 15, 233, 174, 23, 78, 16, 106, 69, 103, 62, 8, 133, 15, 18, 223, 246, 249, 139, 218, 114, 50, 206, 220, 236, 249, 195, 182, 24, 92, 252, 73, 61, 219, 244, 17, 202, 187, 254, 120, 192, 84, 29, 110, 35, 209, 17, 20, 165, 58, 40, 61, 150, 115, 208, 230, 214, 9, 110, 177, 75, 13, 35, 9, 74, 113, 162, 229, 61, 50, 202, 11, 234, 27, 20, 85, 193, 42, 151, 80, 241, 103, 74, 19, 250, 153, 83, 11, 12, 17, 43, 219, 145, 226, 49, 240, 167, 38 }, null, "+849000000017", "+849000000117", null, null, "admin_branch_17" },
                    { 18, "Branch Address 18", 4, "/adminLTE/images/users/avatar-8.jpg", null, null, 9, 1000001005, -1, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "admin_branch_18@gmail.com", "Admin Branch 18", null, new byte[] { 68, 227, 89, 5, 170, 175, 167, 31, 42, 145, 83, 14, 244, 119, 76, 241, 138, 42, 177, 127, 222, 138, 61, 6, 136, 213, 81, 103, 197, 95, 160, 63, 217, 98, 20, 242, 161, 176, 61, 0, 80, 183, 69, 110, 245, 73, 236, 56, 219, 172, 183, 45, 84, 69, 102, 2, 17, 195, 37, 41, 57, 149, 252, 206 }, new byte[] { 130, 2, 255, 3, 144, 251, 31, 105, 68, 78, 205, 4, 80, 68, 22, 48, 255, 61, 135, 36, 141, 170, 110, 108, 40, 160, 84, 97, 74, 27, 124, 15, 233, 174, 23, 78, 16, 106, 69, 103, 62, 8, 133, 15, 18, 223, 246, 249, 139, 218, 114, 50, 206, 220, 236, 249, 195, 182, 24, 92, 252, 73, 61, 219, 244, 17, 202, 187, 254, 120, 192, 84, 29, 110, 35, 209, 17, 20, 165, 58, 40, 61, 150, 115, 208, 230, 214, 9, 110, 177, 75, 13, 35, 9, 74, 113, 162, 229, 61, 50, 202, 11, 234, 27, 20, 85, 193, 42, 151, 80, 241, 103, 74, 19, 250, 153, 83, 11, 12, 17, 43, 219, 145, 226, 49, 240, 167, 38 }, null, "+849000000018", "+849000000118", null, null, "admin_branch_18" },
                    { 19, "Branch Address 19", 4, "/adminLTE/images/users/avatar-9.jpg", null, null, 10, 1000001006, -1, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "admin_branch_19@gmail.com", "Admin Branch 19", null, new byte[] { 68, 227, 89, 5, 170, 175, 167, 31, 42, 145, 83, 14, 244, 119, 76, 241, 138, 42, 177, 127, 222, 138, 61, 6, 136, 213, 81, 103, 197, 95, 160, 63, 217, 98, 20, 242, 161, 176, 61, 0, 80, 183, 69, 110, 245, 73, 236, 56, 219, 172, 183, 45, 84, 69, 102, 2, 17, 195, 37, 41, 57, 149, 252, 206 }, new byte[] { 130, 2, 255, 3, 144, 251, 31, 105, 68, 78, 205, 4, 80, 68, 22, 48, 255, 61, 135, 36, 141, 170, 110, 108, 40, 160, 84, 97, 74, 27, 124, 15, 233, 174, 23, 78, 16, 106, 69, 103, 62, 8, 133, 15, 18, 223, 246, 249, 139, 218, 114, 50, 206, 220, 236, 249, 195, 182, 24, 92, 252, 73, 61, 219, 244, 17, 202, 187, 254, 120, 192, 84, 29, 110, 35, 209, 17, 20, 165, 58, 40, 61, 150, 115, 208, 230, 214, 9, 110, 177, 75, 13, 35, 9, 74, 113, 162, 229, 61, 50, 202, 11, 234, 27, 20, 85, 193, 42, 151, 80, 241, 103, 74, 19, 250, 153, 83, 11, 12, 17, 43, 219, 145, 226, 49, 240, 167, 38 }, null, "+849000000019", "+849000000119", null, null, "admin_branch_19" },
                    { 20, "Branch Address 20", 4, "/adminLTE/images/users/avatar-10.jpg", null, null, 11, 1000001007, -1, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "admin_branch_20@gmail.com", "Admin Branch 20", null, new byte[] { 68, 227, 89, 5, 170, 175, 167, 31, 42, 145, 83, 14, 244, 119, 76, 241, 138, 42, 177, 127, 222, 138, 61, 6, 136, 213, 81, 103, 197, 95, 160, 63, 217, 98, 20, 242, 161, 176, 61, 0, 80, 183, 69, 110, 245, 73, 236, 56, 219, 172, 183, 45, 84, 69, 102, 2, 17, 195, 37, 41, 57, 149, 252, 206 }, new byte[] { 130, 2, 255, 3, 144, 251, 31, 105, 68, 78, 205, 4, 80, 68, 22, 48, 255, 61, 135, 36, 141, 170, 110, 108, 40, 160, 84, 97, 74, 27, 124, 15, 233, 174, 23, 78, 16, 106, 69, 103, 62, 8, 133, 15, 18, 223, 246, 249, 139, 218, 114, 50, 206, 220, 236, 249, 195, 182, 24, 92, 252, 73, 61, 219, 244, 17, 202, 187, 254, 120, 192, 84, 29, 110, 35, 209, 17, 20, 165, 58, 40, 61, 150, 115, 208, 230, 214, 9, 110, 177, 75, 13, 35, 9, 74, 113, 162, 229, 61, 50, 202, 11, 234, 27, 20, 85, 193, 42, 151, 80, 241, 103, 74, 19, 250, 153, 83, 11, 12, 17, 43, 219, 145, 226, 49, 240, 167, 38 }, null, "+849000000020", "+849000000120", null, null, "admin_branch_20" },
                    { 21, "Branch Address 21", 4, "/adminLTE/images/users/avatar-1.jpg", null, null, 12, 1000001008, -1, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "admin_branch_21@gmail.com", "Admin Branch 21", null, new byte[] { 68, 227, 89, 5, 170, 175, 167, 31, 42, 145, 83, 14, 244, 119, 76, 241, 138, 42, 177, 127, 222, 138, 61, 6, 136, 213, 81, 103, 197, 95, 160, 63, 217, 98, 20, 242, 161, 176, 61, 0, 80, 183, 69, 110, 245, 73, 236, 56, 219, 172, 183, 45, 84, 69, 102, 2, 17, 195, 37, 41, 57, 149, 252, 206 }, new byte[] { 130, 2, 255, 3, 144, 251, 31, 105, 68, 78, 205, 4, 80, 68, 22, 48, 255, 61, 135, 36, 141, 170, 110, 108, 40, 160, 84, 97, 74, 27, 124, 15, 233, 174, 23, 78, 16, 106, 69, 103, 62, 8, 133, 15, 18, 223, 246, 249, 139, 218, 114, 50, 206, 220, 236, 249, 195, 182, 24, 92, 252, 73, 61, 219, 244, 17, 202, 187, 254, 120, 192, 84, 29, 110, 35, 209, 17, 20, 165, 58, 40, 61, 150, 115, 208, 230, 214, 9, 110, 177, 75, 13, 35, 9, 74, 113, 162, 229, 61, 50, 202, 11, 234, 27, 20, 85, 193, 42, 151, 80, 241, 103, 74, 19, 250, 153, 83, 11, 12, 17, 43, 219, 145, 226, 49, 240, 167, 38 }, null, "+849000000021", "+849000000121", null, null, "admin_branch_21" },
                    { 22, "Branch Address 22", 4, "/adminLTE/images/users/avatar-2.jpg", null, null, 13, 1000001009, -1, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "admin_branch_22@gmail.com", "Admin Branch 22", null, new byte[] { 68, 227, 89, 5, 170, 175, 167, 31, 42, 145, 83, 14, 244, 119, 76, 241, 138, 42, 177, 127, 222, 138, 61, 6, 136, 213, 81, 103, 197, 95, 160, 63, 217, 98, 20, 242, 161, 176, 61, 0, 80, 183, 69, 110, 245, 73, 236, 56, 219, 172, 183, 45, 84, 69, 102, 2, 17, 195, 37, 41, 57, 149, 252, 206 }, new byte[] { 130, 2, 255, 3, 144, 251, 31, 105, 68, 78, 205, 4, 80, 68, 22, 48, 255, 61, 135, 36, 141, 170, 110, 108, 40, 160, 84, 97, 74, 27, 124, 15, 233, 174, 23, 78, 16, 106, 69, 103, 62, 8, 133, 15, 18, 223, 246, 249, 139, 218, 114, 50, 206, 220, 236, 249, 195, 182, 24, 92, 252, 73, 61, 219, 244, 17, 202, 187, 254, 120, 192, 84, 29, 110, 35, 209, 17, 20, 165, 58, 40, 61, 150, 115, 208, 230, 214, 9, 110, 177, 75, 13, 35, 9, 74, 113, 162, 229, 61, 50, 202, 11, 234, 27, 20, 85, 193, 42, 151, 80, 241, 103, 74, 19, 250, 153, 83, 11, 12, 17, 43, 219, 145, 226, 49, 240, 167, 38 }, null, "+849000000022", "+849000000122", null, null, "admin_branch_22" },
                    { 23, "Branch Address 23", 4, "/adminLTE/images/users/avatar-3.jpg", null, null, 14, 1000001010, -1, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "admin_branch_23@gmail.com", "Admin Branch 23", null, new byte[] { 68, 227, 89, 5, 170, 175, 167, 31, 42, 145, 83, 14, 244, 119, 76, 241, 138, 42, 177, 127, 222, 138, 61, 6, 136, 213, 81, 103, 197, 95, 160, 63, 217, 98, 20, 242, 161, 176, 61, 0, 80, 183, 69, 110, 245, 73, 236, 56, 219, 172, 183, 45, 84, 69, 102, 2, 17, 195, 37, 41, 57, 149, 252, 206 }, new byte[] { 130, 2, 255, 3, 144, 251, 31, 105, 68, 78, 205, 4, 80, 68, 22, 48, 255, 61, 135, 36, 141, 170, 110, 108, 40, 160, 84, 97, 74, 27, 124, 15, 233, 174, 23, 78, 16, 106, 69, 103, 62, 8, 133, 15, 18, 223, 246, 249, 139, 218, 114, 50, 206, 220, 236, 249, 195, 182, 24, 92, 252, 73, 61, 219, 244, 17, 202, 187, 254, 120, 192, 84, 29, 110, 35, 209, 17, 20, 165, 58, 40, 61, 150, 115, 208, 230, 214, 9, 110, 177, 75, 13, 35, 9, 74, 113, 162, 229, 61, 50, 202, 11, 234, 27, 20, 85, 193, 42, 151, 80, 241, 103, 74, 19, 250, 153, 83, 11, 12, 17, 43, 219, 145, 226, 49, 240, 167, 38 }, null, "+849000000023", "+849000000123", null, null, "admin_branch_23" },
                    { 24, "Branch Address 24", 4, "/adminLTE/images/users/avatar-4.jpg", null, null, 15, 1000001011, -1, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "admin_branch_24@gmail.com", "Admin Branch 24", null, new byte[] { 68, 227, 89, 5, 170, 175, 167, 31, 42, 145, 83, 14, 244, 119, 76, 241, 138, 42, 177, 127, 222, 138, 61, 6, 136, 213, 81, 103, 197, 95, 160, 63, 217, 98, 20, 242, 161, 176, 61, 0, 80, 183, 69, 110, 245, 73, 236, 56, 219, 172, 183, 45, 84, 69, 102, 2, 17, 195, 37, 41, 57, 149, 252, 206 }, new byte[] { 130, 2, 255, 3, 144, 251, 31, 105, 68, 78, 205, 4, 80, 68, 22, 48, 255, 61, 135, 36, 141, 170, 110, 108, 40, 160, 84, 97, 74, 27, 124, 15, 233, 174, 23, 78, 16, 106, 69, 103, 62, 8, 133, 15, 18, 223, 246, 249, 139, 218, 114, 50, 206, 220, 236, 249, 195, 182, 24, 92, 252, 73, 61, 219, 244, 17, 202, 187, 254, 120, 192, 84, 29, 110, 35, 209, 17, 20, 165, 58, 40, 61, 150, 115, 208, 230, 214, 9, 110, 177, 75, 13, 35, 9, 74, 113, 162, 229, 61, 50, 202, 11, 234, 27, 20, 85, 193, 42, 151, 80, 241, 103, 74, 19, 250, 153, 83, 11, 12, 17, 43, 219, 145, 226, 49, 240, 167, 38 }, null, "+849000000024", "+849000000124", null, null, "admin_branch_24" },
                    { 25, "Branch Address 25", 4, "/adminLTE/images/users/avatar-5.jpg", null, null, 16, 1000001012, -1, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "admin_branch_25@gmail.com", "Admin Branch 25", null, new byte[] { 68, 227, 89, 5, 170, 175, 167, 31, 42, 145, 83, 14, 244, 119, 76, 241, 138, 42, 177, 127, 222, 138, 61, 6, 136, 213, 81, 103, 197, 95, 160, 63, 217, 98, 20, 242, 161, 176, 61, 0, 80, 183, 69, 110, 245, 73, 236, 56, 219, 172, 183, 45, 84, 69, 102, 2, 17, 195, 37, 41, 57, 149, 252, 206 }, new byte[] { 130, 2, 255, 3, 144, 251, 31, 105, 68, 78, 205, 4, 80, 68, 22, 48, 255, 61, 135, 36, 141, 170, 110, 108, 40, 160, 84, 97, 74, 27, 124, 15, 233, 174, 23, 78, 16, 106, 69, 103, 62, 8, 133, 15, 18, 223, 246, 249, 139, 218, 114, 50, 206, 220, 236, 249, 195, 182, 24, 92, 252, 73, 61, 219, 244, 17, 202, 187, 254, 120, 192, 84, 29, 110, 35, 209, 17, 20, 165, 58, 40, 61, 150, 115, 208, 230, 214, 9, 110, 177, 75, 13, 35, 9, 74, 113, 162, 229, 61, 50, 202, 11, 234, 27, 20, 85, 193, 42, 151, 80, 241, 103, 74, 19, 250, 153, 83, 11, 12, 17, 43, 219, 145, 226, 49, 240, 167, 38 }, null, "+849000000025", "+849000000125", null, null, "admin_branch_25" },
                    { 26, "Branch Address 26", 4, "/adminLTE/images/users/avatar-6.jpg", null, null, 17, 1000001013, -1, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "admin_branch_26@gmail.com", "Admin Branch 26", null, new byte[] { 68, 227, 89, 5, 170, 175, 167, 31, 42, 145, 83, 14, 244, 119, 76, 241, 138, 42, 177, 127, 222, 138, 61, 6, 136, 213, 81, 103, 197, 95, 160, 63, 217, 98, 20, 242, 161, 176, 61, 0, 80, 183, 69, 110, 245, 73, 236, 56, 219, 172, 183, 45, 84, 69, 102, 2, 17, 195, 37, 41, 57, 149, 252, 206 }, new byte[] { 130, 2, 255, 3, 144, 251, 31, 105, 68, 78, 205, 4, 80, 68, 22, 48, 255, 61, 135, 36, 141, 170, 110, 108, 40, 160, 84, 97, 74, 27, 124, 15, 233, 174, 23, 78, 16, 106, 69, 103, 62, 8, 133, 15, 18, 223, 246, 249, 139, 218, 114, 50, 206, 220, 236, 249, 195, 182, 24, 92, 252, 73, 61, 219, 244, 17, 202, 187, 254, 120, 192, 84, 29, 110, 35, 209, 17, 20, 165, 58, 40, 61, 150, 115, 208, 230, 214, 9, 110, 177, 75, 13, 35, 9, 74, 113, 162, 229, 61, 50, 202, 11, 234, 27, 20, 85, 193, 42, 151, 80, 241, 103, 74, 19, 250, 153, 83, 11, 12, 17, 43, 219, 145, 226, 49, 240, 167, 38 }, null, "+849000000026", "+849000000126", null, null, "admin_branch_26" },
                    { 27, "Branch Address 27", 4, "/adminLTE/images/users/avatar-7.jpg", null, null, 18, 1000001014, -1, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "admin_branch_27@gmail.com", "Admin Branch 27", null, new byte[] { 68, 227, 89, 5, 170, 175, 167, 31, 42, 145, 83, 14, 244, 119, 76, 241, 138, 42, 177, 127, 222, 138, 61, 6, 136, 213, 81, 103, 197, 95, 160, 63, 217, 98, 20, 242, 161, 176, 61, 0, 80, 183, 69, 110, 245, 73, 236, 56, 219, 172, 183, 45, 84, 69, 102, 2, 17, 195, 37, 41, 57, 149, 252, 206 }, new byte[] { 130, 2, 255, 3, 144, 251, 31, 105, 68, 78, 205, 4, 80, 68, 22, 48, 255, 61, 135, 36, 141, 170, 110, 108, 40, 160, 84, 97, 74, 27, 124, 15, 233, 174, 23, 78, 16, 106, 69, 103, 62, 8, 133, 15, 18, 223, 246, 249, 139, 218, 114, 50, 206, 220, 236, 249, 195, 182, 24, 92, 252, 73, 61, 219, 244, 17, 202, 187, 254, 120, 192, 84, 29, 110, 35, 209, 17, 20, 165, 58, 40, 61, 150, 115, 208, 230, 214, 9, 110, 177, 75, 13, 35, 9, 74, 113, 162, 229, 61, 50, 202, 11, 234, 27, 20, 85, 193, 42, 151, 80, 241, 103, 74, 19, 250, 153, 83, 11, 12, 17, 43, 219, 145, 226, 49, 240, 167, 38 }, null, "+849000000027", "+849000000127", null, null, "admin_branch_27" },
                    { 28, "Branch Address 28", 4, "/adminLTE/images/users/avatar-8.jpg", null, null, 19, 1000001015, -1, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "admin_branch_28@gmail.com", "Admin Branch 28", null, new byte[] { 68, 227, 89, 5, 170, 175, 167, 31, 42, 145, 83, 14, 244, 119, 76, 241, 138, 42, 177, 127, 222, 138, 61, 6, 136, 213, 81, 103, 197, 95, 160, 63, 217, 98, 20, 242, 161, 176, 61, 0, 80, 183, 69, 110, 245, 73, 236, 56, 219, 172, 183, 45, 84, 69, 102, 2, 17, 195, 37, 41, 57, 149, 252, 206 }, new byte[] { 130, 2, 255, 3, 144, 251, 31, 105, 68, 78, 205, 4, 80, 68, 22, 48, 255, 61, 135, 36, 141, 170, 110, 108, 40, 160, 84, 97, 74, 27, 124, 15, 233, 174, 23, 78, 16, 106, 69, 103, 62, 8, 133, 15, 18, 223, 246, 249, 139, 218, 114, 50, 206, 220, 236, 249, 195, 182, 24, 92, 252, 73, 61, 219, 244, 17, 202, 187, 254, 120, 192, 84, 29, 110, 35, 209, 17, 20, 165, 58, 40, 61, 150, 115, 208, 230, 214, 9, 110, 177, 75, 13, 35, 9, 74, 113, 162, 229, 61, 50, 202, 11, 234, 27, 20, 85, 193, 42, 151, 80, 241, 103, 74, 19, 250, 153, 83, 11, 12, 17, 43, 219, 145, 226, 49, 240, 167, 38 }, null, "+849000000028", "+849000000128", null, null, "admin_branch_28" },
                    { 29, "Branch Address 29", 4, "/adminLTE/images/users/avatar-9.jpg", null, null, 20, 1000001016, -1, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "admin_branch_29@gmail.com", "Admin Branch 29", null, new byte[] { 68, 227, 89, 5, 170, 175, 167, 31, 42, 145, 83, 14, 244, 119, 76, 241, 138, 42, 177, 127, 222, 138, 61, 6, 136, 213, 81, 103, 197, 95, 160, 63, 217, 98, 20, 242, 161, 176, 61, 0, 80, 183, 69, 110, 245, 73, 236, 56, 219, 172, 183, 45, 84, 69, 102, 2, 17, 195, 37, 41, 57, 149, 252, 206 }, new byte[] { 130, 2, 255, 3, 144, 251, 31, 105, 68, 78, 205, 4, 80, 68, 22, 48, 255, 61, 135, 36, 141, 170, 110, 108, 40, 160, 84, 97, 74, 27, 124, 15, 233, 174, 23, 78, 16, 106, 69, 103, 62, 8, 133, 15, 18, 223, 246, 249, 139, 218, 114, 50, 206, 220, 236, 249, 195, 182, 24, 92, 252, 73, 61, 219, 244, 17, 202, 187, 254, 120, 192, 84, 29, 110, 35, 209, 17, 20, 165, 58, 40, 61, 150, 115, 208, 230, 214, 9, 110, 177, 75, 13, 35, 9, 74, 113, 162, 229, 61, 50, 202, 11, 234, 27, 20, 85, 193, 42, 151, 80, 241, 103, 74, 19, 250, 153, 83, 11, 12, 17, 43, 219, 145, 226, 49, 240, 167, 38 }, null, "+849000000029", "+849000000129", null, null, "admin_branch_29" },
                    { 30, "Branch Address 30", 4, "/adminLTE/images/users/avatar-10.jpg", null, null, 21, 1000001017, -1, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "admin_branch_30@gmail.com", "Admin Branch 30", null, new byte[] { 68, 227, 89, 5, 170, 175, 167, 31, 42, 145, 83, 14, 244, 119, 76, 241, 138, 42, 177, 127, 222, 138, 61, 6, 136, 213, 81, 103, 197, 95, 160, 63, 217, 98, 20, 242, 161, 176, 61, 0, 80, 183, 69, 110, 245, 73, 236, 56, 219, 172, 183, 45, 84, 69, 102, 2, 17, 195, 37, 41, 57, 149, 252, 206 }, new byte[] { 130, 2, 255, 3, 144, 251, 31, 105, 68, 78, 205, 4, 80, 68, 22, 48, 255, 61, 135, 36, 141, 170, 110, 108, 40, 160, 84, 97, 74, 27, 124, 15, 233, 174, 23, 78, 16, 106, 69, 103, 62, 8, 133, 15, 18, 223, 246, 249, 139, 218, 114, 50, 206, 220, 236, 249, 195, 182, 24, 92, 252, 73, 61, 219, 244, 17, 202, 187, 254, 120, 192, 84, 29, 110, 35, 209, 17, 20, 165, 58, 40, 61, 150, 115, 208, 230, 214, 9, 110, 177, 75, 13, 35, 9, 74, 113, 162, 229, 61, 50, 202, 11, 234, 27, 20, 85, 193, 42, 151, 80, 241, 103, 74, 19, 250, 153, 83, 11, 12, 17, 43, 219, 145, 226, 49, 240, 167, 38 }, null, "+849000000030", "+849000000130", null, null, "admin_branch_30" },
                    { 31, "Branch Address 31", 4, "/adminLTE/images/users/avatar-1.jpg", null, null, 22, 1000001018, -1, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "admin_branch_31@gmail.com", "Admin Branch 31", null, new byte[] { 68, 227, 89, 5, 170, 175, 167, 31, 42, 145, 83, 14, 244, 119, 76, 241, 138, 42, 177, 127, 222, 138, 61, 6, 136, 213, 81, 103, 197, 95, 160, 63, 217, 98, 20, 242, 161, 176, 61, 0, 80, 183, 69, 110, 245, 73, 236, 56, 219, 172, 183, 45, 84, 69, 102, 2, 17, 195, 37, 41, 57, 149, 252, 206 }, new byte[] { 130, 2, 255, 3, 144, 251, 31, 105, 68, 78, 205, 4, 80, 68, 22, 48, 255, 61, 135, 36, 141, 170, 110, 108, 40, 160, 84, 97, 74, 27, 124, 15, 233, 174, 23, 78, 16, 106, 69, 103, 62, 8, 133, 15, 18, 223, 246, 249, 139, 218, 114, 50, 206, 220, 236, 249, 195, 182, 24, 92, 252, 73, 61, 219, 244, 17, 202, 187, 254, 120, 192, 84, 29, 110, 35, 209, 17, 20, 165, 58, 40, 61, 150, 115, 208, 230, 214, 9, 110, 177, 75, 13, 35, 9, 74, 113, 162, 229, 61, 50, 202, 11, 234, 27, 20, 85, 193, 42, 151, 80, 241, 103, 74, 19, 250, 153, 83, 11, 12, 17, 43, 219, 145, 226, 49, 240, 167, 38 }, null, "+849000000031", "+849000000131", null, null, "admin_branch_31" },
                    { 32, "Branch Address 32", 4, "/adminLTE/images/users/avatar-2.jpg", null, null, 23, 1000001019, -1, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "admin_branch_32@gmail.com", "Admin Branch 32", null, new byte[] { 68, 227, 89, 5, 170, 175, 167, 31, 42, 145, 83, 14, 244, 119, 76, 241, 138, 42, 177, 127, 222, 138, 61, 6, 136, 213, 81, 103, 197, 95, 160, 63, 217, 98, 20, 242, 161, 176, 61, 0, 80, 183, 69, 110, 245, 73, 236, 56, 219, 172, 183, 45, 84, 69, 102, 2, 17, 195, 37, 41, 57, 149, 252, 206 }, new byte[] { 130, 2, 255, 3, 144, 251, 31, 105, 68, 78, 205, 4, 80, 68, 22, 48, 255, 61, 135, 36, 141, 170, 110, 108, 40, 160, 84, 97, 74, 27, 124, 15, 233, 174, 23, 78, 16, 106, 69, 103, 62, 8, 133, 15, 18, 223, 246, 249, 139, 218, 114, 50, 206, 220, 236, 249, 195, 182, 24, 92, 252, 73, 61, 219, 244, 17, 202, 187, 254, 120, 192, 84, 29, 110, 35, 209, 17, 20, 165, 58, 40, 61, 150, 115, 208, 230, 214, 9, 110, 177, 75, 13, 35, 9, 74, 113, 162, 229, 61, 50, 202, 11, 234, 27, 20, 85, 193, 42, 151, 80, 241, 103, 74, 19, 250, 153, 83, 11, 12, 17, 43, 219, 145, 226, 49, 240, 167, 38 }, null, "+849000000032", "+849000000132", null, null, "admin_branch_32" },
                    { 33, "Branch Address 33", 4, "/adminLTE/images/users/avatar-3.jpg", null, null, 24, 1000001020, -1, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "admin_branch_33@gmail.com", "Admin Branch 33", null, new byte[] { 68, 227, 89, 5, 170, 175, 167, 31, 42, 145, 83, 14, 244, 119, 76, 241, 138, 42, 177, 127, 222, 138, 61, 6, 136, 213, 81, 103, 197, 95, 160, 63, 217, 98, 20, 242, 161, 176, 61, 0, 80, 183, 69, 110, 245, 73, 236, 56, 219, 172, 183, 45, 84, 69, 102, 2, 17, 195, 37, 41, 57, 149, 252, 206 }, new byte[] { 130, 2, 255, 3, 144, 251, 31, 105, 68, 78, 205, 4, 80, 68, 22, 48, 255, 61, 135, 36, 141, 170, 110, 108, 40, 160, 84, 97, 74, 27, 124, 15, 233, 174, 23, 78, 16, 106, 69, 103, 62, 8, 133, 15, 18, 223, 246, 249, 139, 218, 114, 50, 206, 220, 236, 249, 195, 182, 24, 92, 252, 73, 61, 219, 244, 17, 202, 187, 254, 120, 192, 84, 29, 110, 35, 209, 17, 20, 165, 58, 40, 61, 150, 115, 208, 230, 214, 9, 110, 177, 75, 13, 35, 9, 74, 113, 162, 229, 61, 50, 202, 11, 234, 27, 20, 85, 193, 42, 151, 80, 241, 103, 74, 19, 250, 153, 83, 11, 12, 17, 43, 219, 145, 226, 49, 240, 167, 38 }, null, "+849000000033", "+849000000133", null, null, "admin_branch_33" },
                    { 34, "Branch Address 34", 4, "/adminLTE/images/users/avatar-4.jpg", null, null, 25, 1000001021, -1, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "admin_branch_34@gmail.com", "Admin Branch 34", null, new byte[] { 68, 227, 89, 5, 170, 175, 167, 31, 42, 145, 83, 14, 244, 119, 76, 241, 138, 42, 177, 127, 222, 138, 61, 6, 136, 213, 81, 103, 197, 95, 160, 63, 217, 98, 20, 242, 161, 176, 61, 0, 80, 183, 69, 110, 245, 73, 236, 56, 219, 172, 183, 45, 84, 69, 102, 2, 17, 195, 37, 41, 57, 149, 252, 206 }, new byte[] { 130, 2, 255, 3, 144, 251, 31, 105, 68, 78, 205, 4, 80, 68, 22, 48, 255, 61, 135, 36, 141, 170, 110, 108, 40, 160, 84, 97, 74, 27, 124, 15, 233, 174, 23, 78, 16, 106, 69, 103, 62, 8, 133, 15, 18, 223, 246, 249, 139, 218, 114, 50, 206, 220, 236, 249, 195, 182, 24, 92, 252, 73, 61, 219, 244, 17, 202, 187, 254, 120, 192, 84, 29, 110, 35, 209, 17, 20, 165, 58, 40, 61, 150, 115, 208, 230, 214, 9, 110, 177, 75, 13, 35, 9, 74, 113, 162, 229, 61, 50, 202, 11, 234, 27, 20, 85, 193, 42, 151, 80, 241, 103, 74, 19, 250, 153, 83, 11, 12, 17, 43, 219, 145, 226, 49, 240, 167, 38 }, null, "+849000000034", "+849000000134", null, null, "admin_branch_34" },
                    { 35, "Branch Address 35", 4, "/adminLTE/images/users/avatar-5.jpg", null, null, 26, 1000001022, -1, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "admin_branch_35@gmail.com", "Admin Branch 35", null, new byte[] { 68, 227, 89, 5, 170, 175, 167, 31, 42, 145, 83, 14, 244, 119, 76, 241, 138, 42, 177, 127, 222, 138, 61, 6, 136, 213, 81, 103, 197, 95, 160, 63, 217, 98, 20, 242, 161, 176, 61, 0, 80, 183, 69, 110, 245, 73, 236, 56, 219, 172, 183, 45, 84, 69, 102, 2, 17, 195, 37, 41, 57, 149, 252, 206 }, new byte[] { 130, 2, 255, 3, 144, 251, 31, 105, 68, 78, 205, 4, 80, 68, 22, 48, 255, 61, 135, 36, 141, 170, 110, 108, 40, 160, 84, 97, 74, 27, 124, 15, 233, 174, 23, 78, 16, 106, 69, 103, 62, 8, 133, 15, 18, 223, 246, 249, 139, 218, 114, 50, 206, 220, 236, 249, 195, 182, 24, 92, 252, 73, 61, 219, 244, 17, 202, 187, 254, 120, 192, 84, 29, 110, 35, 209, 17, 20, 165, 58, 40, 61, 150, 115, 208, 230, 214, 9, 110, 177, 75, 13, 35, 9, 74, 113, 162, 229, 61, 50, 202, 11, 234, 27, 20, 85, 193, 42, 151, 80, 241, 103, 74, 19, 250, 153, 83, 11, 12, 17, 43, 219, 145, 226, 49, 240, 167, 38 }, null, "+849000000035", "+849000000135", null, null, "admin_branch_35" },
                    { 36, "Branch Address 36", 4, "/adminLTE/images/users/avatar-6.jpg", null, null, 27, 1000001023, -1, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "admin_branch_36@gmail.com", "Admin Branch 36", null, new byte[] { 68, 227, 89, 5, 170, 175, 167, 31, 42, 145, 83, 14, 244, 119, 76, 241, 138, 42, 177, 127, 222, 138, 61, 6, 136, 213, 81, 103, 197, 95, 160, 63, 217, 98, 20, 242, 161, 176, 61, 0, 80, 183, 69, 110, 245, 73, 236, 56, 219, 172, 183, 45, 84, 69, 102, 2, 17, 195, 37, 41, 57, 149, 252, 206 }, new byte[] { 130, 2, 255, 3, 144, 251, 31, 105, 68, 78, 205, 4, 80, 68, 22, 48, 255, 61, 135, 36, 141, 170, 110, 108, 40, 160, 84, 97, 74, 27, 124, 15, 233, 174, 23, 78, 16, 106, 69, 103, 62, 8, 133, 15, 18, 223, 246, 249, 139, 218, 114, 50, 206, 220, 236, 249, 195, 182, 24, 92, 252, 73, 61, 219, 244, 17, 202, 187, 254, 120, 192, 84, 29, 110, 35, 209, 17, 20, 165, 58, 40, 61, 150, 115, 208, 230, 214, 9, 110, 177, 75, 13, 35, 9, 74, 113, 162, 229, 61, 50, 202, 11, 234, 27, 20, 85, 193, 42, 151, 80, 241, 103, 74, 19, 250, 153, 83, 11, 12, 17, 43, 219, 145, 226, 49, 240, 167, 38 }, null, "+849000000036", "+849000000136", null, null, "admin_branch_36" },
                    { 37, "Branch Address 37", 4, "/adminLTE/images/users/avatar-7.jpg", null, null, 28, 1000001024, -1, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "admin_branch_37@gmail.com", "Admin Branch 37", null, new byte[] { 68, 227, 89, 5, 170, 175, 167, 31, 42, 145, 83, 14, 244, 119, 76, 241, 138, 42, 177, 127, 222, 138, 61, 6, 136, 213, 81, 103, 197, 95, 160, 63, 217, 98, 20, 242, 161, 176, 61, 0, 80, 183, 69, 110, 245, 73, 236, 56, 219, 172, 183, 45, 84, 69, 102, 2, 17, 195, 37, 41, 57, 149, 252, 206 }, new byte[] { 130, 2, 255, 3, 144, 251, 31, 105, 68, 78, 205, 4, 80, 68, 22, 48, 255, 61, 135, 36, 141, 170, 110, 108, 40, 160, 84, 97, 74, 27, 124, 15, 233, 174, 23, 78, 16, 106, 69, 103, 62, 8, 133, 15, 18, 223, 246, 249, 139, 218, 114, 50, 206, 220, 236, 249, 195, 182, 24, 92, 252, 73, 61, 219, 244, 17, 202, 187, 254, 120, 192, 84, 29, 110, 35, 209, 17, 20, 165, 58, 40, 61, 150, 115, 208, 230, 214, 9, 110, 177, 75, 13, 35, 9, 74, 113, 162, 229, 61, 50, 202, 11, 234, 27, 20, 85, 193, 42, 151, 80, 241, 103, 74, 19, 250, 153, 83, 11, 12, 17, 43, 219, 145, 226, 49, 240, 167, 38 }, null, "+849000000037", "+849000000137", null, null, "admin_branch_37" },
                    { 38, "Branch Address 38", 4, "/adminLTE/images/users/avatar-8.jpg", null, null, 29, 1000001025, -1, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "admin_branch_38@gmail.com", "Admin Branch 38", null, new byte[] { 68, 227, 89, 5, 170, 175, 167, 31, 42, 145, 83, 14, 244, 119, 76, 241, 138, 42, 177, 127, 222, 138, 61, 6, 136, 213, 81, 103, 197, 95, 160, 63, 217, 98, 20, 242, 161, 176, 61, 0, 80, 183, 69, 110, 245, 73, 236, 56, 219, 172, 183, 45, 84, 69, 102, 2, 17, 195, 37, 41, 57, 149, 252, 206 }, new byte[] { 130, 2, 255, 3, 144, 251, 31, 105, 68, 78, 205, 4, 80, 68, 22, 48, 255, 61, 135, 36, 141, 170, 110, 108, 40, 160, 84, 97, 74, 27, 124, 15, 233, 174, 23, 78, 16, 106, 69, 103, 62, 8, 133, 15, 18, 223, 246, 249, 139, 218, 114, 50, 206, 220, 236, 249, 195, 182, 24, 92, 252, 73, 61, 219, 244, 17, 202, 187, 254, 120, 192, 84, 29, 110, 35, 209, 17, 20, 165, 58, 40, 61, 150, 115, 208, 230, 214, 9, 110, 177, 75, 13, 35, 9, 74, 113, 162, 229, 61, 50, 202, 11, 234, 27, 20, 85, 193, 42, 151, 80, 241, 103, 74, 19, 250, 153, 83, 11, 12, 17, 43, 219, 145, 226, 49, 240, 167, 38 }, null, "+849000000038", "+849000000138", null, null, "admin_branch_38" },
                    { 39, "Branch Address 39", 4, "/adminLTE/images/users/avatar-9.jpg", null, null, 30, 1000001026, -1, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "admin_branch_39@gmail.com", "Admin Branch 39", null, new byte[] { 68, 227, 89, 5, 170, 175, 167, 31, 42, 145, 83, 14, 244, 119, 76, 241, 138, 42, 177, 127, 222, 138, 61, 6, 136, 213, 81, 103, 197, 95, 160, 63, 217, 98, 20, 242, 161, 176, 61, 0, 80, 183, 69, 110, 245, 73, 236, 56, 219, 172, 183, 45, 84, 69, 102, 2, 17, 195, 37, 41, 57, 149, 252, 206 }, new byte[] { 130, 2, 255, 3, 144, 251, 31, 105, 68, 78, 205, 4, 80, 68, 22, 48, 255, 61, 135, 36, 141, 170, 110, 108, 40, 160, 84, 97, 74, 27, 124, 15, 233, 174, 23, 78, 16, 106, 69, 103, 62, 8, 133, 15, 18, 223, 246, 249, 139, 218, 114, 50, 206, 220, 236, 249, 195, 182, 24, 92, 252, 73, 61, 219, 244, 17, 202, 187, 254, 120, 192, 84, 29, 110, 35, 209, 17, 20, 165, 58, 40, 61, 150, 115, 208, 230, 214, 9, 110, 177, 75, 13, 35, 9, 74, 113, 162, 229, 61, 50, 202, 11, 234, 27, 20, 85, 193, 42, 151, 80, 241, 103, 74, 19, 250, 153, 83, 11, 12, 17, 43, 219, 145, 226, 49, 240, 167, 38 }, null, "+849000000039", "+849000000139", null, null, "admin_branch_39" },
                    { 40, "Branch Address 40", 4, "/adminLTE/images/users/avatar-10.jpg", null, null, 31, 1000001027, -1, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "admin_branch_40@gmail.com", "Admin Branch 40", null, new byte[] { 68, 227, 89, 5, 170, 175, 167, 31, 42, 145, 83, 14, 244, 119, 76, 241, 138, 42, 177, 127, 222, 138, 61, 6, 136, 213, 81, 103, 197, 95, 160, 63, 217, 98, 20, 242, 161, 176, 61, 0, 80, 183, 69, 110, 245, 73, 236, 56, 219, 172, 183, 45, 84, 69, 102, 2, 17, 195, 37, 41, 57, 149, 252, 206 }, new byte[] { 130, 2, 255, 3, 144, 251, 31, 105, 68, 78, 205, 4, 80, 68, 22, 48, 255, 61, 135, 36, 141, 170, 110, 108, 40, 160, 84, 97, 74, 27, 124, 15, 233, 174, 23, 78, 16, 106, 69, 103, 62, 8, 133, 15, 18, 223, 246, 249, 139, 218, 114, 50, 206, 220, 236, 249, 195, 182, 24, 92, 252, 73, 61, 219, 244, 17, 202, 187, 254, 120, 192, 84, 29, 110, 35, 209, 17, 20, 165, 58, 40, 61, 150, 115, 208, 230, 214, 9, 110, 177, 75, 13, 35, 9, 74, 113, 162, 229, 61, 50, 202, 11, 234, 27, 20, 85, 193, 42, 151, 80, 241, 103, 74, 19, 250, 153, 83, 11, 12, 17, 43, 219, 145, 226, 49, 240, 167, 38 }, null, "+849000000040", "+849000000140", null, null, "admin_branch_40" },
                    { 41, "Branch Address 41", 4, "/adminLTE/images/users/avatar-1.jpg", null, null, 32, 1000001028, -1, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "admin_branch_41@gmail.com", "Admin Branch 41", null, new byte[] { 68, 227, 89, 5, 170, 175, 167, 31, 42, 145, 83, 14, 244, 119, 76, 241, 138, 42, 177, 127, 222, 138, 61, 6, 136, 213, 81, 103, 197, 95, 160, 63, 217, 98, 20, 242, 161, 176, 61, 0, 80, 183, 69, 110, 245, 73, 236, 56, 219, 172, 183, 45, 84, 69, 102, 2, 17, 195, 37, 41, 57, 149, 252, 206 }, new byte[] { 130, 2, 255, 3, 144, 251, 31, 105, 68, 78, 205, 4, 80, 68, 22, 48, 255, 61, 135, 36, 141, 170, 110, 108, 40, 160, 84, 97, 74, 27, 124, 15, 233, 174, 23, 78, 16, 106, 69, 103, 62, 8, 133, 15, 18, 223, 246, 249, 139, 218, 114, 50, 206, 220, 236, 249, 195, 182, 24, 92, 252, 73, 61, 219, 244, 17, 202, 187, 254, 120, 192, 84, 29, 110, 35, 209, 17, 20, 165, 58, 40, 61, 150, 115, 208, 230, 214, 9, 110, 177, 75, 13, 35, 9, 74, 113, 162, 229, 61, 50, 202, 11, 234, 27, 20, 85, 193, 42, 151, 80, 241, 103, 74, 19, 250, 153, 83, 11, 12, 17, 43, 219, 145, 226, 49, 240, 167, 38 }, null, "+849000000041", "+849000000141", null, null, "admin_branch_41" },
                    { 42, "Branch Address 42", 4, "/adminLTE/images/users/avatar-2.jpg", null, null, 33, 1000001029, -1, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "admin_branch_42@gmail.com", "Admin Branch 42", null, new byte[] { 68, 227, 89, 5, 170, 175, 167, 31, 42, 145, 83, 14, 244, 119, 76, 241, 138, 42, 177, 127, 222, 138, 61, 6, 136, 213, 81, 103, 197, 95, 160, 63, 217, 98, 20, 242, 161, 176, 61, 0, 80, 183, 69, 110, 245, 73, 236, 56, 219, 172, 183, 45, 84, 69, 102, 2, 17, 195, 37, 41, 57, 149, 252, 206 }, new byte[] { 130, 2, 255, 3, 144, 251, 31, 105, 68, 78, 205, 4, 80, 68, 22, 48, 255, 61, 135, 36, 141, 170, 110, 108, 40, 160, 84, 97, 74, 27, 124, 15, 233, 174, 23, 78, 16, 106, 69, 103, 62, 8, 133, 15, 18, 223, 246, 249, 139, 218, 114, 50, 206, 220, 236, 249, 195, 182, 24, 92, 252, 73, 61, 219, 244, 17, 202, 187, 254, 120, 192, 84, 29, 110, 35, 209, 17, 20, 165, 58, 40, 61, 150, 115, 208, 230, 214, 9, 110, 177, 75, 13, 35, 9, 74, 113, 162, 229, 61, 50, 202, 11, 234, 27, 20, 85, 193, 42, 151, 80, 241, 103, 74, 19, 250, 153, 83, 11, 12, 17, 43, 219, 145, 226, 49, 240, 167, 38 }, null, "+849000000042", "+849000000142", null, null, "admin_branch_42" },
                    { 43, "Branch Address 43", 4, "/adminLTE/images/users/avatar-3.jpg", null, null, 34, 1000001030, -1, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "admin_branch_43@gmail.com", "Admin Branch 43", null, new byte[] { 68, 227, 89, 5, 170, 175, 167, 31, 42, 145, 83, 14, 244, 119, 76, 241, 138, 42, 177, 127, 222, 138, 61, 6, 136, 213, 81, 103, 197, 95, 160, 63, 217, 98, 20, 242, 161, 176, 61, 0, 80, 183, 69, 110, 245, 73, 236, 56, 219, 172, 183, 45, 84, 69, 102, 2, 17, 195, 37, 41, 57, 149, 252, 206 }, new byte[] { 130, 2, 255, 3, 144, 251, 31, 105, 68, 78, 205, 4, 80, 68, 22, 48, 255, 61, 135, 36, 141, 170, 110, 108, 40, 160, 84, 97, 74, 27, 124, 15, 233, 174, 23, 78, 16, 106, 69, 103, 62, 8, 133, 15, 18, 223, 246, 249, 139, 218, 114, 50, 206, 220, 236, 249, 195, 182, 24, 92, 252, 73, 61, 219, 244, 17, 202, 187, 254, 120, 192, 84, 29, 110, 35, 209, 17, 20, 165, 58, 40, 61, 150, 115, 208, 230, 214, 9, 110, 177, 75, 13, 35, 9, 74, 113, 162, 229, 61, 50, 202, 11, 234, 27, 20, 85, 193, 42, 151, 80, 241, 103, 74, 19, 250, 153, 83, 11, 12, 17, 43, 219, 145, 226, 49, 240, 167, 38 }, null, "+849000000043", "+849000000143", null, null, "admin_branch_43" },
                    { 44, "Branch Address 44", 4, "/adminLTE/images/users/avatar-4.jpg", null, null, 35, 1000001031, -1, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "admin_branch_44@gmail.com", "Admin Branch 44", null, new byte[] { 68, 227, 89, 5, 170, 175, 167, 31, 42, 145, 83, 14, 244, 119, 76, 241, 138, 42, 177, 127, 222, 138, 61, 6, 136, 213, 81, 103, 197, 95, 160, 63, 217, 98, 20, 242, 161, 176, 61, 0, 80, 183, 69, 110, 245, 73, 236, 56, 219, 172, 183, 45, 84, 69, 102, 2, 17, 195, 37, 41, 57, 149, 252, 206 }, new byte[] { 130, 2, 255, 3, 144, 251, 31, 105, 68, 78, 205, 4, 80, 68, 22, 48, 255, 61, 135, 36, 141, 170, 110, 108, 40, 160, 84, 97, 74, 27, 124, 15, 233, 174, 23, 78, 16, 106, 69, 103, 62, 8, 133, 15, 18, 223, 246, 249, 139, 218, 114, 50, 206, 220, 236, 249, 195, 182, 24, 92, 252, 73, 61, 219, 244, 17, 202, 187, 254, 120, 192, 84, 29, 110, 35, 209, 17, 20, 165, 58, 40, 61, 150, 115, 208, 230, 214, 9, 110, 177, 75, 13, 35, 9, 74, 113, 162, 229, 61, 50, 202, 11, 234, 27, 20, 85, 193, 42, 151, 80, 241, 103, 74, 19, 250, 153, 83, 11, 12, 17, 43, 219, 145, 226, 49, 240, 167, 38 }, null, "+849000000044", "+849000000144", null, null, "admin_branch_44" },
                    { 45, "Branch Address 45", 4, "/adminLTE/images/users/avatar-5.jpg", null, null, 36, 1000001032, -1, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "admin_branch_45@gmail.com", "Admin Branch 45", null, new byte[] { 68, 227, 89, 5, 170, 175, 167, 31, 42, 145, 83, 14, 244, 119, 76, 241, 138, 42, 177, 127, 222, 138, 61, 6, 136, 213, 81, 103, 197, 95, 160, 63, 217, 98, 20, 242, 161, 176, 61, 0, 80, 183, 69, 110, 245, 73, 236, 56, 219, 172, 183, 45, 84, 69, 102, 2, 17, 195, 37, 41, 57, 149, 252, 206 }, new byte[] { 130, 2, 255, 3, 144, 251, 31, 105, 68, 78, 205, 4, 80, 68, 22, 48, 255, 61, 135, 36, 141, 170, 110, 108, 40, 160, 84, 97, 74, 27, 124, 15, 233, 174, 23, 78, 16, 106, 69, 103, 62, 8, 133, 15, 18, 223, 246, 249, 139, 218, 114, 50, 206, 220, 236, 249, 195, 182, 24, 92, 252, 73, 61, 219, 244, 17, 202, 187, 254, 120, 192, 84, 29, 110, 35, 209, 17, 20, 165, 58, 40, 61, 150, 115, 208, 230, 214, 9, 110, 177, 75, 13, 35, 9, 74, 113, 162, 229, 61, 50, 202, 11, 234, 27, 20, 85, 193, 42, 151, 80, 241, 103, 74, 19, 250, 153, 83, 11, 12, 17, 43, 219, 145, 226, 49, 240, 167, 38 }, null, "+849000000045", "+849000000145", null, null, "admin_branch_45" },
                    { 46, "Branch Address 46", 4, "/adminLTE/images/users/avatar-6.jpg", null, null, 37, 1000001033, -1, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "admin_branch_46@gmail.com", "Admin Branch 46", null, new byte[] { 68, 227, 89, 5, 170, 175, 167, 31, 42, 145, 83, 14, 244, 119, 76, 241, 138, 42, 177, 127, 222, 138, 61, 6, 136, 213, 81, 103, 197, 95, 160, 63, 217, 98, 20, 242, 161, 176, 61, 0, 80, 183, 69, 110, 245, 73, 236, 56, 219, 172, 183, 45, 84, 69, 102, 2, 17, 195, 37, 41, 57, 149, 252, 206 }, new byte[] { 130, 2, 255, 3, 144, 251, 31, 105, 68, 78, 205, 4, 80, 68, 22, 48, 255, 61, 135, 36, 141, 170, 110, 108, 40, 160, 84, 97, 74, 27, 124, 15, 233, 174, 23, 78, 16, 106, 69, 103, 62, 8, 133, 15, 18, 223, 246, 249, 139, 218, 114, 50, 206, 220, 236, 249, 195, 182, 24, 92, 252, 73, 61, 219, 244, 17, 202, 187, 254, 120, 192, 84, 29, 110, 35, 209, 17, 20, 165, 58, 40, 61, 150, 115, 208, 230, 214, 9, 110, 177, 75, 13, 35, 9, 74, 113, 162, 229, 61, 50, 202, 11, 234, 27, 20, 85, 193, 42, 151, 80, 241, 103, 74, 19, 250, 153, 83, 11, 12, 17, 43, 219, 145, 226, 49, 240, 167, 38 }, null, "+849000000046", "+849000000146", null, null, "admin_branch_46" },
                    { 47, "Branch Address 47", 4, "/adminLTE/images/users/avatar-7.jpg", null, null, 38, 1000001034, -1, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "admin_branch_47@gmail.com", "Admin Branch 47", null, new byte[] { 68, 227, 89, 5, 170, 175, 167, 31, 42, 145, 83, 14, 244, 119, 76, 241, 138, 42, 177, 127, 222, 138, 61, 6, 136, 213, 81, 103, 197, 95, 160, 63, 217, 98, 20, 242, 161, 176, 61, 0, 80, 183, 69, 110, 245, 73, 236, 56, 219, 172, 183, 45, 84, 69, 102, 2, 17, 195, 37, 41, 57, 149, 252, 206 }, new byte[] { 130, 2, 255, 3, 144, 251, 31, 105, 68, 78, 205, 4, 80, 68, 22, 48, 255, 61, 135, 36, 141, 170, 110, 108, 40, 160, 84, 97, 74, 27, 124, 15, 233, 174, 23, 78, 16, 106, 69, 103, 62, 8, 133, 15, 18, 223, 246, 249, 139, 218, 114, 50, 206, 220, 236, 249, 195, 182, 24, 92, 252, 73, 61, 219, 244, 17, 202, 187, 254, 120, 192, 84, 29, 110, 35, 209, 17, 20, 165, 58, 40, 61, 150, 115, 208, 230, 214, 9, 110, 177, 75, 13, 35, 9, 74, 113, 162, 229, 61, 50, 202, 11, 234, 27, 20, 85, 193, 42, 151, 80, 241, 103, 74, 19, 250, 153, 83, 11, 12, 17, 43, 219, 145, 226, 49, 240, 167, 38 }, null, "+849000000047", "+849000000147", null, null, "admin_branch_47" },
                    { 48, "Branch Address 48", 4, "/adminLTE/images/users/avatar-8.jpg", null, null, 39, 1000001035, -1, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "admin_branch_48@gmail.com", "Admin Branch 48", null, new byte[] { 68, 227, 89, 5, 170, 175, 167, 31, 42, 145, 83, 14, 244, 119, 76, 241, 138, 42, 177, 127, 222, 138, 61, 6, 136, 213, 81, 103, 197, 95, 160, 63, 217, 98, 20, 242, 161, 176, 61, 0, 80, 183, 69, 110, 245, 73, 236, 56, 219, 172, 183, 45, 84, 69, 102, 2, 17, 195, 37, 41, 57, 149, 252, 206 }, new byte[] { 130, 2, 255, 3, 144, 251, 31, 105, 68, 78, 205, 4, 80, 68, 22, 48, 255, 61, 135, 36, 141, 170, 110, 108, 40, 160, 84, 97, 74, 27, 124, 15, 233, 174, 23, 78, 16, 106, 69, 103, 62, 8, 133, 15, 18, 223, 246, 249, 139, 218, 114, 50, 206, 220, 236, 249, 195, 182, 24, 92, 252, 73, 61, 219, 244, 17, 202, 187, 254, 120, 192, 84, 29, 110, 35, 209, 17, 20, 165, 58, 40, 61, 150, 115, 208, 230, 214, 9, 110, 177, 75, 13, 35, 9, 74, 113, 162, 229, 61, 50, 202, 11, 234, 27, 20, 85, 193, 42, 151, 80, 241, 103, 74, 19, 250, 153, 83, 11, 12, 17, 43, 219, 145, 226, 49, 240, 167, 38 }, null, "+849000000048", "+849000000148", null, null, "admin_branch_48" },
                    { 49, "Branch Address 49", 4, "/adminLTE/images/users/avatar-9.jpg", null, null, 40, 1000001036, -1, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "admin_branch_49@gmail.com", "Admin Branch 49", null, new byte[] { 68, 227, 89, 5, 170, 175, 167, 31, 42, 145, 83, 14, 244, 119, 76, 241, 138, 42, 177, 127, 222, 138, 61, 6, 136, 213, 81, 103, 197, 95, 160, 63, 217, 98, 20, 242, 161, 176, 61, 0, 80, 183, 69, 110, 245, 73, 236, 56, 219, 172, 183, 45, 84, 69, 102, 2, 17, 195, 37, 41, 57, 149, 252, 206 }, new byte[] { 130, 2, 255, 3, 144, 251, 31, 105, 68, 78, 205, 4, 80, 68, 22, 48, 255, 61, 135, 36, 141, 170, 110, 108, 40, 160, 84, 97, 74, 27, 124, 15, 233, 174, 23, 78, 16, 106, 69, 103, 62, 8, 133, 15, 18, 223, 246, 249, 139, 218, 114, 50, 206, 220, 236, 249, 195, 182, 24, 92, 252, 73, 61, 219, 244, 17, 202, 187, 254, 120, 192, 84, 29, 110, 35, 209, 17, 20, 165, 58, 40, 61, 150, 115, 208, 230, 214, 9, 110, 177, 75, 13, 35, 9, 74, 113, 162, 229, 61, 50, 202, 11, 234, 27, 20, 85, 193, 42, 151, 80, 241, 103, 74, 19, 250, 153, 83, 11, 12, 17, 43, 219, 145, 226, 49, 240, 167, 38 }, null, "+849000000049", "+849000000149", null, null, "admin_branch_49" },
                    { 50, "Branch Address 50", 4, "/adminLTE/images/users/avatar-10.jpg", null, null, 41, 1000001037, -1, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "admin_branch_50@gmail.com", "Admin Branch 50", null, new byte[] { 68, 227, 89, 5, 170, 175, 167, 31, 42, 145, 83, 14, 244, 119, 76, 241, 138, 42, 177, 127, 222, 138, 61, 6, 136, 213, 81, 103, 197, 95, 160, 63, 217, 98, 20, 242, 161, 176, 61, 0, 80, 183, 69, 110, 245, 73, 236, 56, 219, 172, 183, 45, 84, 69, 102, 2, 17, 195, 37, 41, 57, 149, 252, 206 }, new byte[] { 130, 2, 255, 3, 144, 251, 31, 105, 68, 78, 205, 4, 80, 68, 22, 48, 255, 61, 135, 36, 141, 170, 110, 108, 40, 160, 84, 97, 74, 27, 124, 15, 233, 174, 23, 78, 16, 106, 69, 103, 62, 8, 133, 15, 18, 223, 246, 249, 139, 218, 114, 50, 206, 220, 236, 249, 195, 182, 24, 92, 252, 73, 61, 219, 244, 17, 202, 187, 254, 120, 192, 84, 29, 110, 35, 209, 17, 20, 165, 58, 40, 61, 150, 115, 208, 230, 214, 9, 110, 177, 75, 13, 35, 9, 74, 113, 162, 229, 61, 50, 202, 11, 234, 27, 20, 85, 193, 42, 151, 80, 241, 103, 74, 19, 250, 153, 83, 11, 12, 17, 43, 219, 145, 226, 49, 240, 167, 38 }, null, "+849000000050", "+849000000150", null, null, "admin_branch_50" },
                    { 51, "Branch Address 51", 4, "/adminLTE/images/users/avatar-1.jpg", null, null, 42, 1000001038, -1, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "admin_branch_51@gmail.com", "Admin Branch 51", null, new byte[] { 68, 227, 89, 5, 170, 175, 167, 31, 42, 145, 83, 14, 244, 119, 76, 241, 138, 42, 177, 127, 222, 138, 61, 6, 136, 213, 81, 103, 197, 95, 160, 63, 217, 98, 20, 242, 161, 176, 61, 0, 80, 183, 69, 110, 245, 73, 236, 56, 219, 172, 183, 45, 84, 69, 102, 2, 17, 195, 37, 41, 57, 149, 252, 206 }, new byte[] { 130, 2, 255, 3, 144, 251, 31, 105, 68, 78, 205, 4, 80, 68, 22, 48, 255, 61, 135, 36, 141, 170, 110, 108, 40, 160, 84, 97, 74, 27, 124, 15, 233, 174, 23, 78, 16, 106, 69, 103, 62, 8, 133, 15, 18, 223, 246, 249, 139, 218, 114, 50, 206, 220, 236, 249, 195, 182, 24, 92, 252, 73, 61, 219, 244, 17, 202, 187, 254, 120, 192, 84, 29, 110, 35, 209, 17, 20, 165, 58, 40, 61, 150, 115, 208, 230, 214, 9, 110, 177, 75, 13, 35, 9, 74, 113, 162, 229, 61, 50, 202, 11, 234, 27, 20, 85, 193, 42, 151, 80, 241, 103, 74, 19, 250, 153, 83, 11, 12, 17, 43, 219, 145, 226, 49, 240, 167, 38 }, null, "+849000000051", "+849000000151", null, null, "admin_branch_51" },
                    { 52, "Branch Address 52", 4, "/adminLTE/images/users/avatar-2.jpg", null, null, 43, 1000001039, -1, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "admin_branch_52@gmail.com", "Admin Branch 52", null, new byte[] { 68, 227, 89, 5, 170, 175, 167, 31, 42, 145, 83, 14, 244, 119, 76, 241, 138, 42, 177, 127, 222, 138, 61, 6, 136, 213, 81, 103, 197, 95, 160, 63, 217, 98, 20, 242, 161, 176, 61, 0, 80, 183, 69, 110, 245, 73, 236, 56, 219, 172, 183, 45, 84, 69, 102, 2, 17, 195, 37, 41, 57, 149, 252, 206 }, new byte[] { 130, 2, 255, 3, 144, 251, 31, 105, 68, 78, 205, 4, 80, 68, 22, 48, 255, 61, 135, 36, 141, 170, 110, 108, 40, 160, 84, 97, 74, 27, 124, 15, 233, 174, 23, 78, 16, 106, 69, 103, 62, 8, 133, 15, 18, 223, 246, 249, 139, 218, 114, 50, 206, 220, 236, 249, 195, 182, 24, 92, 252, 73, 61, 219, 244, 17, 202, 187, 254, 120, 192, 84, 29, 110, 35, 209, 17, 20, 165, 58, 40, 61, 150, 115, 208, 230, 214, 9, 110, 177, 75, 13, 35, 9, 74, 113, 162, 229, 61, 50, 202, 11, 234, 27, 20, 85, 193, 42, 151, 80, 241, 103, 74, 19, 250, 153, 83, 11, 12, 17, 43, 219, 145, 226, 49, 240, 167, 38 }, null, "+849000000052", "+849000000152", null, null, "admin_branch_52" },
                    { 53, "Branch Address 53", 4, "/adminLTE/images/users/avatar-3.jpg", null, null, 44, 1000001040, -1, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "admin_branch_53@gmail.com", "Admin Branch 53", null, new byte[] { 68, 227, 89, 5, 170, 175, 167, 31, 42, 145, 83, 14, 244, 119, 76, 241, 138, 42, 177, 127, 222, 138, 61, 6, 136, 213, 81, 103, 197, 95, 160, 63, 217, 98, 20, 242, 161, 176, 61, 0, 80, 183, 69, 110, 245, 73, 236, 56, 219, 172, 183, 45, 84, 69, 102, 2, 17, 195, 37, 41, 57, 149, 252, 206 }, new byte[] { 130, 2, 255, 3, 144, 251, 31, 105, 68, 78, 205, 4, 80, 68, 22, 48, 255, 61, 135, 36, 141, 170, 110, 108, 40, 160, 84, 97, 74, 27, 124, 15, 233, 174, 23, 78, 16, 106, 69, 103, 62, 8, 133, 15, 18, 223, 246, 249, 139, 218, 114, 50, 206, 220, 236, 249, 195, 182, 24, 92, 252, 73, 61, 219, 244, 17, 202, 187, 254, 120, 192, 84, 29, 110, 35, 209, 17, 20, 165, 58, 40, 61, 150, 115, 208, 230, 214, 9, 110, 177, 75, 13, 35, 9, 74, 113, 162, 229, 61, 50, 202, 11, 234, 27, 20, 85, 193, 42, 151, 80, 241, 103, 74, 19, 250, 153, 83, 11, 12, 17, 43, 219, 145, 226, 49, 240, 167, 38 }, null, "+849000000053", "+849000000153", null, null, "admin_branch_53" },
                    { 54, "Branch Address 54", 4, "/adminLTE/images/users/avatar-4.jpg", null, null, 45, 1000001041, -1, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "admin_branch_54@gmail.com", "Admin Branch 54", null, new byte[] { 68, 227, 89, 5, 170, 175, 167, 31, 42, 145, 83, 14, 244, 119, 76, 241, 138, 42, 177, 127, 222, 138, 61, 6, 136, 213, 81, 103, 197, 95, 160, 63, 217, 98, 20, 242, 161, 176, 61, 0, 80, 183, 69, 110, 245, 73, 236, 56, 219, 172, 183, 45, 84, 69, 102, 2, 17, 195, 37, 41, 57, 149, 252, 206 }, new byte[] { 130, 2, 255, 3, 144, 251, 31, 105, 68, 78, 205, 4, 80, 68, 22, 48, 255, 61, 135, 36, 141, 170, 110, 108, 40, 160, 84, 97, 74, 27, 124, 15, 233, 174, 23, 78, 16, 106, 69, 103, 62, 8, 133, 15, 18, 223, 246, 249, 139, 218, 114, 50, 206, 220, 236, 249, 195, 182, 24, 92, 252, 73, 61, 219, 244, 17, 202, 187, 254, 120, 192, 84, 29, 110, 35, 209, 17, 20, 165, 58, 40, 61, 150, 115, 208, 230, 214, 9, 110, 177, 75, 13, 35, 9, 74, 113, 162, 229, 61, 50, 202, 11, 234, 27, 20, 85, 193, 42, 151, 80, 241, 103, 74, 19, 250, 153, 83, 11, 12, 17, 43, 219, 145, 226, 49, 240, 167, 38 }, null, "+849000000054", "+849000000154", null, null, "admin_branch_54" },
                    { 55, "Branch Address 55", 4, "/adminLTE/images/users/avatar-5.jpg", null, null, 46, 1000001042, -1, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "admin_branch_55@gmail.com", "Admin Branch 55", null, new byte[] { 68, 227, 89, 5, 170, 175, 167, 31, 42, 145, 83, 14, 244, 119, 76, 241, 138, 42, 177, 127, 222, 138, 61, 6, 136, 213, 81, 103, 197, 95, 160, 63, 217, 98, 20, 242, 161, 176, 61, 0, 80, 183, 69, 110, 245, 73, 236, 56, 219, 172, 183, 45, 84, 69, 102, 2, 17, 195, 37, 41, 57, 149, 252, 206 }, new byte[] { 130, 2, 255, 3, 144, 251, 31, 105, 68, 78, 205, 4, 80, 68, 22, 48, 255, 61, 135, 36, 141, 170, 110, 108, 40, 160, 84, 97, 74, 27, 124, 15, 233, 174, 23, 78, 16, 106, 69, 103, 62, 8, 133, 15, 18, 223, 246, 249, 139, 218, 114, 50, 206, 220, 236, 249, 195, 182, 24, 92, 252, 73, 61, 219, 244, 17, 202, 187, 254, 120, 192, 84, 29, 110, 35, 209, 17, 20, 165, 58, 40, 61, 150, 115, 208, 230, 214, 9, 110, 177, 75, 13, 35, 9, 74, 113, 162, 229, 61, 50, 202, 11, 234, 27, 20, 85, 193, 42, 151, 80, 241, 103, 74, 19, 250, 153, 83, 11, 12, 17, 43, 219, 145, 226, 49, 240, 167, 38 }, null, "+849000000055", "+849000000155", null, null, "admin_branch_55" },
                    { 56, "Branch Address 56", 4, "/adminLTE/images/users/avatar-6.jpg", null, null, 47, 1000001043, -1, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "admin_branch_56@gmail.com", "Admin Branch 56", null, new byte[] { 68, 227, 89, 5, 170, 175, 167, 31, 42, 145, 83, 14, 244, 119, 76, 241, 138, 42, 177, 127, 222, 138, 61, 6, 136, 213, 81, 103, 197, 95, 160, 63, 217, 98, 20, 242, 161, 176, 61, 0, 80, 183, 69, 110, 245, 73, 236, 56, 219, 172, 183, 45, 84, 69, 102, 2, 17, 195, 37, 41, 57, 149, 252, 206 }, new byte[] { 130, 2, 255, 3, 144, 251, 31, 105, 68, 78, 205, 4, 80, 68, 22, 48, 255, 61, 135, 36, 141, 170, 110, 108, 40, 160, 84, 97, 74, 27, 124, 15, 233, 174, 23, 78, 16, 106, 69, 103, 62, 8, 133, 15, 18, 223, 246, 249, 139, 218, 114, 50, 206, 220, 236, 249, 195, 182, 24, 92, 252, 73, 61, 219, 244, 17, 202, 187, 254, 120, 192, 84, 29, 110, 35, 209, 17, 20, 165, 58, 40, 61, 150, 115, 208, 230, 214, 9, 110, 177, 75, 13, 35, 9, 74, 113, 162, 229, 61, 50, 202, 11, 234, 27, 20, 85, 193, 42, 151, 80, 241, 103, 74, 19, 250, 153, 83, 11, 12, 17, 43, 219, 145, 226, 49, 240, 167, 38 }, null, "+849000000056", "+849000000156", null, null, "admin_branch_56" },
                    { 57, "Branch Address 57", 4, "/adminLTE/images/users/avatar-7.jpg", null, null, 48, 1000001044, -1, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "admin_branch_57@gmail.com", "Admin Branch 57", null, new byte[] { 68, 227, 89, 5, 170, 175, 167, 31, 42, 145, 83, 14, 244, 119, 76, 241, 138, 42, 177, 127, 222, 138, 61, 6, 136, 213, 81, 103, 197, 95, 160, 63, 217, 98, 20, 242, 161, 176, 61, 0, 80, 183, 69, 110, 245, 73, 236, 56, 219, 172, 183, 45, 84, 69, 102, 2, 17, 195, 37, 41, 57, 149, 252, 206 }, new byte[] { 130, 2, 255, 3, 144, 251, 31, 105, 68, 78, 205, 4, 80, 68, 22, 48, 255, 61, 135, 36, 141, 170, 110, 108, 40, 160, 84, 97, 74, 27, 124, 15, 233, 174, 23, 78, 16, 106, 69, 103, 62, 8, 133, 15, 18, 223, 246, 249, 139, 218, 114, 50, 206, 220, 236, 249, 195, 182, 24, 92, 252, 73, 61, 219, 244, 17, 202, 187, 254, 120, 192, 84, 29, 110, 35, 209, 17, 20, 165, 58, 40, 61, 150, 115, 208, 230, 214, 9, 110, 177, 75, 13, 35, 9, 74, 113, 162, 229, 61, 50, 202, 11, 234, 27, 20, 85, 193, 42, 151, 80, 241, 103, 74, 19, 250, 153, 83, 11, 12, 17, 43, 219, 145, 226, 49, 240, 167, 38 }, null, "+849000000057", "+849000000157", null, null, "admin_branch_57" },
                    { 58, "Branch Address 58", 4, "/adminLTE/images/users/avatar-8.jpg", null, null, 49, 1000001045, -1, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "admin_branch_58@gmail.com", "Admin Branch 58", null, new byte[] { 68, 227, 89, 5, 170, 175, 167, 31, 42, 145, 83, 14, 244, 119, 76, 241, 138, 42, 177, 127, 222, 138, 61, 6, 136, 213, 81, 103, 197, 95, 160, 63, 217, 98, 20, 242, 161, 176, 61, 0, 80, 183, 69, 110, 245, 73, 236, 56, 219, 172, 183, 45, 84, 69, 102, 2, 17, 195, 37, 41, 57, 149, 252, 206 }, new byte[] { 130, 2, 255, 3, 144, 251, 31, 105, 68, 78, 205, 4, 80, 68, 22, 48, 255, 61, 135, 36, 141, 170, 110, 108, 40, 160, 84, 97, 74, 27, 124, 15, 233, 174, 23, 78, 16, 106, 69, 103, 62, 8, 133, 15, 18, 223, 246, 249, 139, 218, 114, 50, 206, 220, 236, 249, 195, 182, 24, 92, 252, 73, 61, 219, 244, 17, 202, 187, 254, 120, 192, 84, 29, 110, 35, 209, 17, 20, 165, 58, 40, 61, 150, 115, 208, 230, 214, 9, 110, 177, 75, 13, 35, 9, 74, 113, 162, 229, 61, 50, 202, 11, 234, 27, 20, 85, 193, 42, 151, 80, 241, 103, 74, 19, 250, 153, 83, 11, 12, 17, 43, 219, 145, 226, 49, 240, 167, 38 }, null, "+849000000058", "+849000000158", null, null, "admin_branch_58" },
                    { 59, "Branch Address 59", 4, "/adminLTE/images/users/avatar-9.jpg", null, null, 50, 1000001046, -1, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "admin_branch_59@gmail.com", "Admin Branch 59", null, new byte[] { 68, 227, 89, 5, 170, 175, 167, 31, 42, 145, 83, 14, 244, 119, 76, 241, 138, 42, 177, 127, 222, 138, 61, 6, 136, 213, 81, 103, 197, 95, 160, 63, 217, 98, 20, 242, 161, 176, 61, 0, 80, 183, 69, 110, 245, 73, 236, 56, 219, 172, 183, 45, 84, 69, 102, 2, 17, 195, 37, 41, 57, 149, 252, 206 }, new byte[] { 130, 2, 255, 3, 144, 251, 31, 105, 68, 78, 205, 4, 80, 68, 22, 48, 255, 61, 135, 36, 141, 170, 110, 108, 40, 160, 84, 97, 74, 27, 124, 15, 233, 174, 23, 78, 16, 106, 69, 103, 62, 8, 133, 15, 18, 223, 246, 249, 139, 218, 114, 50, 206, 220, 236, 249, 195, 182, 24, 92, 252, 73, 61, 219, 244, 17, 202, 187, 254, 120, 192, 84, 29, 110, 35, 209, 17, 20, 165, 58, 40, 61, 150, 115, 208, 230, 214, 9, 110, 177, 75, 13, 35, 9, 74, 113, 162, 229, 61, 50, 202, 11, 234, 27, 20, 85, 193, 42, 151, 80, 241, 103, 74, 19, 250, 153, 83, 11, 12, 17, 43, 219, 145, 226, 49, 240, 167, 38 }, null, "+849000000059", "+849000000159", null, null, "admin_branch_59" },
                    { 60, "Branch Address 60", 4, "/adminLTE/images/users/avatar-10.jpg", null, null, 51, 1000001047, -1, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "admin_branch_60@gmail.com", "Admin Branch 60", null, new byte[] { 68, 227, 89, 5, 170, 175, 167, 31, 42, 145, 83, 14, 244, 119, 76, 241, 138, 42, 177, 127, 222, 138, 61, 6, 136, 213, 81, 103, 197, 95, 160, 63, 217, 98, 20, 242, 161, 176, 61, 0, 80, 183, 69, 110, 245, 73, 236, 56, 219, 172, 183, 45, 84, 69, 102, 2, 17, 195, 37, 41, 57, 149, 252, 206 }, new byte[] { 130, 2, 255, 3, 144, 251, 31, 105, 68, 78, 205, 4, 80, 68, 22, 48, 255, 61, 135, 36, 141, 170, 110, 108, 40, 160, 84, 97, 74, 27, 124, 15, 233, 174, 23, 78, 16, 106, 69, 103, 62, 8, 133, 15, 18, 223, 246, 249, 139, 218, 114, 50, 206, 220, 236, 249, 195, 182, 24, 92, 252, 73, 61, 219, 244, 17, 202, 187, 254, 120, 192, 84, 29, 110, 35, 209, 17, 20, 165, 58, 40, 61, 150, 115, 208, 230, 214, 9, 110, 177, 75, 13, 35, 9, 74, 113, 162, 229, 61, 50, 202, 11, 234, 27, 20, 85, 193, 42, 151, 80, 241, 103, 74, 19, 250, 153, 83, 11, 12, 17, 43, 219, 145, 226, 49, 240, 167, 38 }, null, "+849000000060", "+849000000160", null, null, "admin_branch_60" },
                    { 61, "Branch Address 61", 4, "/adminLTE/images/users/avatar-1.jpg", null, null, 52, 1000001048, -1, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "admin_branch_61@gmail.com", "Admin Branch 61", null, new byte[] { 68, 227, 89, 5, 170, 175, 167, 31, 42, 145, 83, 14, 244, 119, 76, 241, 138, 42, 177, 127, 222, 138, 61, 6, 136, 213, 81, 103, 197, 95, 160, 63, 217, 98, 20, 242, 161, 176, 61, 0, 80, 183, 69, 110, 245, 73, 236, 56, 219, 172, 183, 45, 84, 69, 102, 2, 17, 195, 37, 41, 57, 149, 252, 206 }, new byte[] { 130, 2, 255, 3, 144, 251, 31, 105, 68, 78, 205, 4, 80, 68, 22, 48, 255, 61, 135, 36, 141, 170, 110, 108, 40, 160, 84, 97, 74, 27, 124, 15, 233, 174, 23, 78, 16, 106, 69, 103, 62, 8, 133, 15, 18, 223, 246, 249, 139, 218, 114, 50, 206, 220, 236, 249, 195, 182, 24, 92, 252, 73, 61, 219, 244, 17, 202, 187, 254, 120, 192, 84, 29, 110, 35, 209, 17, 20, 165, 58, 40, 61, 150, 115, 208, 230, 214, 9, 110, 177, 75, 13, 35, 9, 74, 113, 162, 229, 61, 50, 202, 11, 234, 27, 20, 85, 193, 42, 151, 80, 241, 103, 74, 19, 250, 153, 83, 11, 12, 17, 43, 219, 145, 226, 49, 240, 167, 38 }, null, "+849000000061", "+849000000161", null, null, "admin_branch_61" },
                    { 62, "Branch Address 62", 4, "/adminLTE/images/users/avatar-2.jpg", null, null, 53, 1000001049, -1, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "admin_branch_62@gmail.com", "Admin Branch 62", null, new byte[] { 68, 227, 89, 5, 170, 175, 167, 31, 42, 145, 83, 14, 244, 119, 76, 241, 138, 42, 177, 127, 222, 138, 61, 6, 136, 213, 81, 103, 197, 95, 160, 63, 217, 98, 20, 242, 161, 176, 61, 0, 80, 183, 69, 110, 245, 73, 236, 56, 219, 172, 183, 45, 84, 69, 102, 2, 17, 195, 37, 41, 57, 149, 252, 206 }, new byte[] { 130, 2, 255, 3, 144, 251, 31, 105, 68, 78, 205, 4, 80, 68, 22, 48, 255, 61, 135, 36, 141, 170, 110, 108, 40, 160, 84, 97, 74, 27, 124, 15, 233, 174, 23, 78, 16, 106, 69, 103, 62, 8, 133, 15, 18, 223, 246, 249, 139, 218, 114, 50, 206, 220, 236, 249, 195, 182, 24, 92, 252, 73, 61, 219, 244, 17, 202, 187, 254, 120, 192, 84, 29, 110, 35, 209, 17, 20, 165, 58, 40, 61, 150, 115, 208, 230, 214, 9, 110, 177, 75, 13, 35, 9, 74, 113, 162, 229, 61, 50, 202, 11, 234, 27, 20, 85, 193, 42, 151, 80, 241, 103, 74, 19, 250, 153, 83, 11, 12, 17, 43, 219, 145, 226, 49, 240, 167, 38 }, null, "+849000000062", "+849000000162", null, null, "admin_branch_62" },
                    { 63, "Branch Address 63", 4, "/adminLTE/images/users/avatar-3.jpg", null, null, 54, 1000001050, -1, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "admin_branch_63@gmail.com", "Admin Branch 63", null, new byte[] { 68, 227, 89, 5, 170, 175, 167, 31, 42, 145, 83, 14, 244, 119, 76, 241, 138, 42, 177, 127, 222, 138, 61, 6, 136, 213, 81, 103, 197, 95, 160, 63, 217, 98, 20, 242, 161, 176, 61, 0, 80, 183, 69, 110, 245, 73, 236, 56, 219, 172, 183, 45, 84, 69, 102, 2, 17, 195, 37, 41, 57, 149, 252, 206 }, new byte[] { 130, 2, 255, 3, 144, 251, 31, 105, 68, 78, 205, 4, 80, 68, 22, 48, 255, 61, 135, 36, 141, 170, 110, 108, 40, 160, 84, 97, 74, 27, 124, 15, 233, 174, 23, 78, 16, 106, 69, 103, 62, 8, 133, 15, 18, 223, 246, 249, 139, 218, 114, 50, 206, 220, 236, 249, 195, 182, 24, 92, 252, 73, 61, 219, 244, 17, 202, 187, 254, 120, 192, 84, 29, 110, 35, 209, 17, 20, 165, 58, 40, 61, 150, 115, 208, 230, 214, 9, 110, 177, 75, 13, 35, 9, 74, 113, 162, 229, 61, 50, 202, 11, 234, 27, 20, 85, 193, 42, 151, 80, 241, 103, 74, 19, 250, 153, 83, 11, 12, 17, 43, 219, 145, 226, 49, 240, 167, 38 }, null, "+849000000063", "+849000000163", null, null, "admin_branch_63" },
                    { 64, "Branch Address 64", 4, "/adminLTE/images/users/avatar-4.jpg", null, null, 55, 1000001051, -1, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "admin_branch_64@gmail.com", "Admin Branch 64", null, new byte[] { 68, 227, 89, 5, 170, 175, 167, 31, 42, 145, 83, 14, 244, 119, 76, 241, 138, 42, 177, 127, 222, 138, 61, 6, 136, 213, 81, 103, 197, 95, 160, 63, 217, 98, 20, 242, 161, 176, 61, 0, 80, 183, 69, 110, 245, 73, 236, 56, 219, 172, 183, 45, 84, 69, 102, 2, 17, 195, 37, 41, 57, 149, 252, 206 }, new byte[] { 130, 2, 255, 3, 144, 251, 31, 105, 68, 78, 205, 4, 80, 68, 22, 48, 255, 61, 135, 36, 141, 170, 110, 108, 40, 160, 84, 97, 74, 27, 124, 15, 233, 174, 23, 78, 16, 106, 69, 103, 62, 8, 133, 15, 18, 223, 246, 249, 139, 218, 114, 50, 206, 220, 236, 249, 195, 182, 24, 92, 252, 73, 61, 219, 244, 17, 202, 187, 254, 120, 192, 84, 29, 110, 35, 209, 17, 20, 165, 58, 40, 61, 150, 115, 208, 230, 214, 9, 110, 177, 75, 13, 35, 9, 74, 113, 162, 229, 61, 50, 202, 11, 234, 27, 20, 85, 193, 42, 151, 80, 241, 103, 74, 19, 250, 153, 83, 11, 12, 17, 43, 219, 145, 226, 49, 240, 167, 38 }, null, "+849000000064", "+849000000164", null, null, "admin_branch_64" },
                    { 65, "Branch Address 65", 4, "/adminLTE/images/users/avatar-5.jpg", null, null, 56, 1000001052, -1, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "admin_branch_65@gmail.com", "Admin Branch 65", null, new byte[] { 68, 227, 89, 5, 170, 175, 167, 31, 42, 145, 83, 14, 244, 119, 76, 241, 138, 42, 177, 127, 222, 138, 61, 6, 136, 213, 81, 103, 197, 95, 160, 63, 217, 98, 20, 242, 161, 176, 61, 0, 80, 183, 69, 110, 245, 73, 236, 56, 219, 172, 183, 45, 84, 69, 102, 2, 17, 195, 37, 41, 57, 149, 252, 206 }, new byte[] { 130, 2, 255, 3, 144, 251, 31, 105, 68, 78, 205, 4, 80, 68, 22, 48, 255, 61, 135, 36, 141, 170, 110, 108, 40, 160, 84, 97, 74, 27, 124, 15, 233, 174, 23, 78, 16, 106, 69, 103, 62, 8, 133, 15, 18, 223, 246, 249, 139, 218, 114, 50, 206, 220, 236, 249, 195, 182, 24, 92, 252, 73, 61, 219, 244, 17, 202, 187, 254, 120, 192, 84, 29, 110, 35, 209, 17, 20, 165, 58, 40, 61, 150, 115, 208, 230, 214, 9, 110, 177, 75, 13, 35, 9, 74, 113, 162, 229, 61, 50, 202, 11, 234, 27, 20, 85, 193, 42, 151, 80, 241, 103, 74, 19, 250, 153, 83, 11, 12, 17, 43, 219, 145, 226, 49, 240, 167, 38 }, null, "+849000000065", "+849000000165", null, null, "admin_branch_65" },
                    { 66, "Branch Address 66", 4, "/adminLTE/images/users/avatar-6.jpg", null, null, 57, 1000001053, -1, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "admin_branch_66@gmail.com", "Admin Branch 66", null, new byte[] { 68, 227, 89, 5, 170, 175, 167, 31, 42, 145, 83, 14, 244, 119, 76, 241, 138, 42, 177, 127, 222, 138, 61, 6, 136, 213, 81, 103, 197, 95, 160, 63, 217, 98, 20, 242, 161, 176, 61, 0, 80, 183, 69, 110, 245, 73, 236, 56, 219, 172, 183, 45, 84, 69, 102, 2, 17, 195, 37, 41, 57, 149, 252, 206 }, new byte[] { 130, 2, 255, 3, 144, 251, 31, 105, 68, 78, 205, 4, 80, 68, 22, 48, 255, 61, 135, 36, 141, 170, 110, 108, 40, 160, 84, 97, 74, 27, 124, 15, 233, 174, 23, 78, 16, 106, 69, 103, 62, 8, 133, 15, 18, 223, 246, 249, 139, 218, 114, 50, 206, 220, 236, 249, 195, 182, 24, 92, 252, 73, 61, 219, 244, 17, 202, 187, 254, 120, 192, 84, 29, 110, 35, 209, 17, 20, 165, 58, 40, 61, 150, 115, 208, 230, 214, 9, 110, 177, 75, 13, 35, 9, 74, 113, 162, 229, 61, 50, 202, 11, 234, 27, 20, 85, 193, 42, 151, 80, 241, 103, 74, 19, 250, 153, 83, 11, 12, 17, 43, 219, 145, 226, 49, 240, 167, 38 }, null, "+849000000066", "+849000000166", null, null, "admin_branch_66" },
                    { 67, "Branch Address 67", 4, "/adminLTE/images/users/avatar-7.jpg", null, null, 58, 1000001054, -1, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "admin_branch_67@gmail.com", "Admin Branch 67", null, new byte[] { 68, 227, 89, 5, 170, 175, 167, 31, 42, 145, 83, 14, 244, 119, 76, 241, 138, 42, 177, 127, 222, 138, 61, 6, 136, 213, 81, 103, 197, 95, 160, 63, 217, 98, 20, 242, 161, 176, 61, 0, 80, 183, 69, 110, 245, 73, 236, 56, 219, 172, 183, 45, 84, 69, 102, 2, 17, 195, 37, 41, 57, 149, 252, 206 }, new byte[] { 130, 2, 255, 3, 144, 251, 31, 105, 68, 78, 205, 4, 80, 68, 22, 48, 255, 61, 135, 36, 141, 170, 110, 108, 40, 160, 84, 97, 74, 27, 124, 15, 233, 174, 23, 78, 16, 106, 69, 103, 62, 8, 133, 15, 18, 223, 246, 249, 139, 218, 114, 50, 206, 220, 236, 249, 195, 182, 24, 92, 252, 73, 61, 219, 244, 17, 202, 187, 254, 120, 192, 84, 29, 110, 35, 209, 17, 20, 165, 58, 40, 61, 150, 115, 208, 230, 214, 9, 110, 177, 75, 13, 35, 9, 74, 113, 162, 229, 61, 50, 202, 11, 234, 27, 20, 85, 193, 42, 151, 80, 241, 103, 74, 19, 250, 153, 83, 11, 12, 17, 43, 219, 145, 226, 49, 240, 167, 38 }, null, "+849000000067", "+849000000167", null, null, "admin_branch_67" },
                    { 68, "Branch Address 68", 4, "/adminLTE/images/users/avatar-8.jpg", null, null, 59, 1000001055, -1, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "admin_branch_68@gmail.com", "Admin Branch 68", null, new byte[] { 68, 227, 89, 5, 170, 175, 167, 31, 42, 145, 83, 14, 244, 119, 76, 241, 138, 42, 177, 127, 222, 138, 61, 6, 136, 213, 81, 103, 197, 95, 160, 63, 217, 98, 20, 242, 161, 176, 61, 0, 80, 183, 69, 110, 245, 73, 236, 56, 219, 172, 183, 45, 84, 69, 102, 2, 17, 195, 37, 41, 57, 149, 252, 206 }, new byte[] { 130, 2, 255, 3, 144, 251, 31, 105, 68, 78, 205, 4, 80, 68, 22, 48, 255, 61, 135, 36, 141, 170, 110, 108, 40, 160, 84, 97, 74, 27, 124, 15, 233, 174, 23, 78, 16, 106, 69, 103, 62, 8, 133, 15, 18, 223, 246, 249, 139, 218, 114, 50, 206, 220, 236, 249, 195, 182, 24, 92, 252, 73, 61, 219, 244, 17, 202, 187, 254, 120, 192, 84, 29, 110, 35, 209, 17, 20, 165, 58, 40, 61, 150, 115, 208, 230, 214, 9, 110, 177, 75, 13, 35, 9, 74, 113, 162, 229, 61, 50, 202, 11, 234, 27, 20, 85, 193, 42, 151, 80, 241, 103, 74, 19, 250, 153, 83, 11, 12, 17, 43, 219, 145, 226, 49, 240, 167, 38 }, null, "+849000000068", "+849000000168", null, null, "admin_branch_68" }
                });

            migrationBuilder.InsertData(
                table: "AppComment",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedDate", "Description", "DisplayOrder", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 3, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Phòng và dịch vụ tuyệt vời! Chăn gối có mùi thơm nhẹ tui rất thích.", null, null, null },
                    { 2, 3, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Nhân viên lịch sự giao tiếp tốt, rất nhiệt tình đón tiếp chúng tôi, phòng ổn, phòng có vẻ như mới sơn lại nên nhìn sạch sẽ.", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "AppImgRoom",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedDate", "DisplayOrder", "ImgSrc", "RoomId", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, null, null, null, "files/ImgRoom/r-9.jpeg", 1, null, null },
                    { 2, null, null, null, null, "clientLTE/images/img_2.jpg", 1, null, null },
                    { 3, null, null, null, null, "clientLTE/images/img_3.jpg", 1, null, null },
                    { 4, null, null, null, null, "clientLTE/images/img_4.jpg", 1, null, null },
                    { 5, null, null, null, null, "files/ImgRoom/r-7.jpeg", 2, null, null },
                    { 6, null, null, null, null, "clientLTE/images/img_2.jpg", 2, null, null },
                    { 7, null, null, null, null, "clientLTE/images/img_3.jpg", 2, null, null },
                    { 8, null, null, null, null, "clientLTE/images/img_4.jpg", 2, null, null },
                    { 9, null, null, null, null, "files/ImgRoom/r-13.jpeg", 3, null, null },
                    { 10, null, null, null, null, "clientLTE/images/img_2.jpg", 3, null, null },
                    { 11, null, null, null, null, "clientLTE/images/img_3.jpg", 3, null, null },
                    { 12, null, null, null, null, "clientLTE/images/img_4.jpg", 3, null, null },
                    { 13, null, null, null, null, "files/ImgRoom/r-2.jpeg", 4, null, null },
                    { 14, null, null, null, null, "clientLTE/images/img_2.jpg", 4, null, null },
                    { 15, null, null, null, null, "clientLTE/images/img_3.jpg", 4, null, null },
                    { 16, null, null, null, null, "clientLTE/images/img_4.jpg", 4, null, null },
                    { 17, null, null, null, null, "files/ImgRoom/r-1.jpeg", 5, null, null },
                    { 18, null, null, null, null, "clientLTE/images/img_2.jpg", 5, null, null },
                    { 19, null, null, null, null, "clientLTE/images/img_3.jpg", 5, null, null },
                    { 20, null, null, null, null, "clientLTE/images/img_4.jpg", 5, null, null },
                    { 21, null, null, null, null, "files/ImgRoom/r-3.jpeg", 6, null, null },
                    { 22, null, null, null, null, "clientLTE/images/img_2.jpg", 6, null, null },
                    { 23, null, null, null, null, "clientLTE/images/img_3.jpg", 6, null, null },
                    { 24, null, null, null, null, "clientLTE/images/img_4.jpg", 6, null, null },
                    { 25, null, null, null, null, "files/ImgRoom/r-4.jpeg", 7, null, null },
                    { 26, null, null, null, null, "clientLTE/images/img_2.jpg", 7, null, null },
                    { 27, null, null, null, null, "clientLTE/images/img_3.jpg", 7, null, null },
                    { 28, null, null, null, null, "clientLTE/images/img_4.jpg", 7, null, null },
                    { 29, null, null, null, null, "files/ImgRoom/r-5.jpeg", 8, null, null },
                    { 30, null, null, null, null, "clientLTE/images/img_2.jpg", 8, null, null },
                    { 31, null, null, null, null, "clientLTE/images/img_3.jpg", 8, null, null },
                    { 32, null, null, null, null, "clientLTE/images/img_4.jpg", 8, null, null },
                    { 33, null, null, null, null, "files/ImgRoom/r-6.jpeg", 9, null, null },
                    { 34, null, null, null, null, "clientLTE/images/img_2.jpg", 9, null, null },
                    { 35, null, null, null, null, "clientLTE/images/img_3.jpg", 9, null, null },
                    { 36, null, null, null, null, "clientLTE/images/img_4.jpg", 9, null, null },
                    { 37, null, null, null, null, "files/ImgRoom/r-8.jpeg", 10, null, null },
                    { 38, null, null, null, null, "clientLTE/images/img_2.jpg", 10, null, null },
                    { 39, null, null, null, null, "clientLTE/images/img_3.jpg", 10, null, null },
                    { 40, null, null, null, null, "clientLTE/images/img_4.jpg", 10, null, null },
                    { 41, null, null, null, null, "files/ImgRoom/r-10.jpeg", 11, null, null },
                    { 42, null, null, null, null, "clientLTE/images/img_2.jpg", 11, null, null },
                    { 43, null, null, null, null, "clientLTE/images/img_3.jpg", 11, null, null },
                    { 44, null, null, null, null, "clientLTE/images/img_4.jpg", 11, null, null },
                    { 45, null, null, null, null, "files/ImgRoom/r-11.jpeg", 12, null, null },
                    { 46, null, null, null, null, "clientLTE/images/img_2.jpg", 12, null, null },
                    { 47, null, null, null, null, "clientLTE/images/img_3.jpg", 12, null, null },
                    { 48, null, null, null, null, "clientLTE/images/img_4.jpg", 12, null, null },
                    { 49, null, null, null, null, "files/ImgRoom/r-12.jpeg", 13, null, null },
                    { 50, null, null, null, null, "clientLTE/images/img_2.jpg", 13, null, null },
                    { 51, null, null, null, null, "clientLTE/images/img_3.jpg", 13, null, null },
                    { 52, null, null, null, null, "clientLTE/images/img_4.jpg", 13, null, null }
                });

            migrationBuilder.InsertData(
                table: "AppRoomEquipment",
                columns: new[] { "Id", "EquipmentId", "RoomId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 1 },
                    { 3, 3, 1 },
                    { 4, 4, 2 },
                    { 5, 5, 2 },
                    { 6, 6, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AppBranchHotel_HotelId",
                table: "AppBranchHotel",
                column: "HotelId");

            migrationBuilder.CreateIndex(
                name: "IX_AppComment_CreatedBy",
                table: "AppComment",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_AppEquipment_TypeEquipmentId",
                table: "AppEquipment",
                column: "TypeEquipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_AppImgRoom_RoomId",
                table: "AppImgRoom",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_AppNews_CategoryId",
                table: "AppNews",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_AppNews_CreatedBy",
                table: "AppNews",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_AppOrder_CreatedBy",
                table: "AppOrder",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_AppOrder_EmployeeId",
                table: "AppOrder",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_AppOrderDetail_OrderId",
                table: "AppOrderDetail",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_AppOrderDetail_RoomId",
                table: "AppOrderDetail",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_AppPayroll_StaffId",
                table: "AppPayroll",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_AppRolePermission_AppRoleId",
                table: "AppRolePermission",
                column: "AppRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_AppRolePermission_MstPermissionId",
                table: "AppRolePermission",
                column: "MstPermissionId");

            migrationBuilder.CreateIndex(
                name: "IX_AppRoom_BranchId",
                table: "AppRoom",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_AppRoom_RoomTypeId",
                table: "AppRoom",
                column: "RoomTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_AppRoomEquipment_EquipmentId",
                table: "AppRoomEquipment",
                column: "EquipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_AppRoomEquipment_RoomId",
                table: "AppRoomEquipment",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_AppUser_AppRoleId",
                table: "AppUser",
                column: "AppRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_AppUser_BranchId",
                table: "AppUser",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_AppUser_Username",
                table: "AppUser",
                column: "Username",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppWorkSchedule_StaffId",
                table: "AppWorkSchedule",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_AppWorkShift_WorkScheduleId",
                table: "AppWorkShift",
                column: "WorkScheduleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppComment");

            migrationBuilder.DropTable(
                name: "AppImgRoom");

            migrationBuilder.DropTable(
                name: "AppNews");

            migrationBuilder.DropTable(
                name: "AppOrderDetail");

            migrationBuilder.DropTable(
                name: "AppPayroll");

            migrationBuilder.DropTable(
                name: "AppRolePermission");

            migrationBuilder.DropTable(
                name: "AppRoomEquipment");

            migrationBuilder.DropTable(
                name: "AppWorkShift");

            migrationBuilder.DropTable(
                name: "AppNewsCategory");

            migrationBuilder.DropTable(
                name: "AppOrder");

            migrationBuilder.DropTable(
                name: "MstPermission");

            migrationBuilder.DropTable(
                name: "AppEquipment");

            migrationBuilder.DropTable(
                name: "AppRoom");

            migrationBuilder.DropTable(
                name: "AppWorkSchedule");

            migrationBuilder.DropTable(
                name: "AppEquipmentType");

            migrationBuilder.DropTable(
                name: "AppRoomType");

            migrationBuilder.DropTable(
                name: "AppUser");

            migrationBuilder.DropTable(
                name: "AppBranchHotel");

            migrationBuilder.DropTable(
                name: "AppRole");

            migrationBuilder.DropTable(
                name: "AppHotel");
        }
    }
}
