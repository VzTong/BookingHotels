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
                    RoomName = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    RoomNumber = table.Column<int>(type: "int", maxLength: 6, nullable: false),
                    Slug = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Status = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Price = table.Column<double>(type: "float", maxLength: 10, nullable: false),
                    DiscountPrice = table.Column<double>(type: "float", maxLength: 10, nullable: false),
                    DiscountFrom = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DiscountTo = table.Column<DateTime>(type: "datetime2", nullable: false),
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
                    BranchId = table.Column<int>(type: "int", nullable: false),
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
                name: "AppComment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    RoomId = table.Column<int>(type: "int", nullable: false),
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
                        name: "FK_AppComment_AppRoom_RoomId",
                        column: x => x.RoomId,
                        principalTable: "AppRoom",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                name: "AppNews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Slug = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Summary = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Views = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L),
                    Votes = table.Column<float>(type: "real", nullable: false, defaultValue: 0f),
                    Published = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    PublishedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CoverImgPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CoverImgThumbnailPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StampPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false),
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
                        name: "FK_AppNews_AppUser_UserId",
                        column: x => x.UserId,
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
                name: "AppCommentDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CmtDesc = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    RoomName = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    RoomNumber = table.Column<int>(type: "int", maxLength: 6, nullable: false),
                    CommentId = table.Column<int>(type: "int", nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppCommentDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppCommentDetail_AppComment_CommentId",
                        column: x => x.CommentId,
                        principalTable: "AppComment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AppCommentDetail_AppUser_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AppUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                    { 1, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Trang thiết bị phòng khách", null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Thiết bị vệ sinh", null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "AppHotel",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedDate", "Description", "DisplayOrder", "Email", "ImgBanner", "Name", "PhoneNumber1", "PhoneNumber2", "Slug", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Khách sạn 5 sao sang trọng tại Hà Nội.", null, "info@meliahanoi.com", "https://du-lich.chudu24.com/f/m/2105/20/khach-san-melia-hanoi.jpg", "Khách Sạn Melia Hanoi", "+842438223333", null, "khach-san-melia-hanoi", null, null },
                    { 2, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Khách sạn lịch sử và sang trọng tại TP. Hồ Chí Minh.", null, "info@rexhotel.com.vn", "https://images2.thanhnien.vn/Uploaded/ttt/images/Content/tan-huong/xach-vali-di/2016_12_w2/rex_hotel/Exterior_Rex_9.jpg", "Rex Hotel Saigon", "+842838292185", null, "rex-hotel-saigon", null, null },
                    { 3, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Khách sạn ven biển tuyệt đẹp tại Đà Nẵng.", null, "info@goldenbaydanang.com", "https://www.arttravel.com.vn/upload/news/golden-bay-(4)-9448.jpg", "Khách Sạn Đà Nẵng Golden Bay", "+842363921888", null, "khach-san-da-nang-golden-bay", null, null },
                    { 4, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Khách sạn với tầm nhìn ra biển tuyệt đẹp tại Nha Trang.", null, "info@nhatranglodge.com.vn", "https://cf.bstatic.com/xdata/images/hotel/max1024x768/81022752.jpg?k=d69140451157e29655c5d19999354e86b95d3654c7ffbe68081070bc8e041518&o=&hp=1", "Khách Sạn Nha Trang Lodge", "+842583525555", null, "khach-san-nha-trang-lodge", null, null },
                    { 5, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Khách sạn sang trọng tại trung tâm Hải Phòng.", null, "info@imperialhotel.com.vn", "https://cf.bstatic.com/xdata/images/hotel/max1024x768/467550547.webp?k=df9413c20e4dc78e4dd3a98618e2815ca246f2bc27a33edf99d9f1bae10e994c&o=", "Khách Sạn Imperial Hải Phòng", "+842253888888", null, "khach-san-imperial-hai-phong", null, null },
                    { 6, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Khách sạn sang trọng tại New York.", null, "info@langhamhotels.com", "https://cdn3.ivivu.com/2023/07/The-Langham-New-York-Fifth-Avenue-ivivu.jpg", "Khách Sạn Langham, New York", "+12123338888", null, "langham-new-york", null, null },
                    { 7, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Khách sạn sang trọng tại Tokyo.", null, "info@peninsula.com", "https://tokyo-marunouchi.jp/dmo_wp_YfehP9/wp-content/uploads/2017/03/banket_pe_07.jpg", "Khách Sạn The Peninsula Tokyo", "+81362701000", null, "the-peninsula-tokyo", null, null },
                    { 8, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Khách sạn sang trọng bên bờ biển Cancun.", null, "info@ritzcarlton.com", "https://ritzcarlton.cancunhotelsweb.net/data/Pics/1080x700w/15670/1567035/1567035848/pic-ritz-carlton-hotel-cancun-5.JPEG", "Khách Sạn The Ritz-Carlton, Cancun", "+5219988916200", null, "ritz-carlton-cancun", null, null },
                    { 9, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Khách sạn nổi tiếng tại Miami, Florida.", null, "info@biltmorehotel.com", "https://biltmore-coral-gables.hotelmix.vn/data/Photos/1920x1080/2004/200471/200471074/Biltmore-Hotel-Miami-Coral-Gables-Exterior.JPEG", "Khách Sạn The Biltmore Miami", "+13055284500", null, "the-biltmore-miami", null, null },
                    { 10, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Khách sạn cao cấp tại Paris, Pháp.", null, "info@shangri-la.com", "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/2a/36/f3/e2/caption.jpg?w=1200&h=-1&s=1", "Khách Sạn Shangri-La, Paris", "+33153003030", null, "shangri-la-paris", null, null },
                    { 11, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Khách sạn sang trọng tại Seoul.", null, "info@hyatt.com", "https://www.americanexpress.com/en-us/travel/discover/photos/197/56953/1600/GHS_Exterior.jpg?ch=560", "Khách Sạn Grand Hyatt Seoul", "+8227971234", null, "grand-hyatt-seoul", null, null },
                    { 12, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Khách sạn sang trọng tại Bangkok.", null, "info@fourseasons.com", "https://theluxurytraveller.com/wp-content/uploads/2022/05/FS-Bangkok-144-1080x480.jpg", "Khách Sạn Four Seasons Bangkok", "+6622501000", null, "four-seasons-bangkok", null, null },
                    { 13, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Khách sạn đẳng cấp tại Tokyo.", null, "info@hilton.com", "https://cf.bstatic.com/xdata/images/hotel/max1024x768/483824171.jpg?k=3fc70cd0fa564972470a3a08b248feff8fa34e9f8b3f2e0343f5105499238bee&o=&hp=1", "Khách Sạn Hilton Tokyo", "+81333451111", null, "hilton-tokyo", null, null },
                    { 14, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Khách sạn hiện đại tại Hong Kong.", null, "info@whotels.com", "https://cache.marriott.com/content/dam/marriott-renditions/HKGWH/hkgwh-pool-exterior-5271-hor-feat.jpg?output-quality=70&interpolation=progressive-bilinear&downsize=1920px:*", "Khách Sạn W Hong Kong", "+85237170000", null, "w-hong-kong", null, null },
                    { 15, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Khách sạn tuyệt đẹp tại Bali.", null, "info@stregis.com", "https://res.klook.com/images/fl_lossy.progressive,q_65/c_fill,w_1200,h_630/w_80,x_15,y_15,g_south_west,l_Klook_water_br_trans_yhcmh3/activities/aqglngrp8i0ecxrlwxsm/Tr%E1%BA%A3i%20nghi%E1%BB%87m%20%E1%BA%A9m%20th%E1%BB%B1c%20t%E1%BA%A1i%20The%20St.%20Regis%20Bali%20Resort.jpg", "Khách Sạn The St. Regis Bali", "+62361775200", null, "st-regis-bali", null, null },
                    { 16, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Khách sạn sang trọng tại Bangkok.", null, "info@mandarinoriental.com", "https://upload.wikimedia.org/wikipedia/commons/e/e5/Mandarin_Oriental_Bangkok_Bang_Rak.jpg", "Khách Sạn Mandarin Oriental Bangkok", "+6626599000", null, "mandarin-oriental-bangkok", null, null },
                    { 17, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Khách sạn cổ điển tại Paris.", null, "info@dorchestercollection.com", "https://strawberrymilkevents.com/wp-content/uploads/2014/03/le-meurice-paris-1.jpg", "Khách Sạn Le Meurice, Paris", "+33144723456", null, "le-meurice-paris", null, null },
                    { 18, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Khách sạn sang trọng tại Mumbai.", null, "info@oberoihotels.com", "https://cf.bstatic.com/xdata/images/hotel/max500/28759044.jpg?k=4a3e476214895d86a0e71808d9eb5b85acaebe0cbff06bbd2ecdbb3054d98600&o=&hp=1", "Khách Sạn The Oberoi, Mumbai", "+912266202020", null, "the-oberoi-mumbai", null, null },
                    { 19, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Khách sạn ven sông tại Sydney.", null, "info@hyatt.com", "https://www.jacadatravel.com/wp-content/uploads/fly-images/157913/park-hyatt-sydney-exterior-1600x500-cc.jpg", "Khách Sạn Park Hyatt Sydney", "+61292561111", null, "park-hyatt-sydney", null, null },
                    { 20, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Khách sạn hiện đại tại Bangkok.", null, "info@sukhothai.com", "https://kyluc.vn/Userfiles/Upload/images/The%20Sukhothai%20Bangkok.jpg", "Khách Sạn The Sukhothai Bangkok", "+6623448888", null, "the-sukhothai-bangkok", null, null },
                    { 21, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Khách sạn sang trọng tại Paris.", null, "info@ritzparis.com", "https://upload.wikimedia.org/wikipedia/commons/thumb/e/ec/H%C3%B4tel_Ritz.jpg/1200px-H%C3%B4tel_Ritz.jpg", "Khách Sạn Ritz Paris", "+33143261800", null, "ritz-paris", null, null },
                    { 22, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Khách sạn 5 sao tại Mumbai.", null, "info@theleela.com", "https://d25wybtmjgh8lz.cloudfront.net/sites/default/files/styles/ph_pdp_subheader_1000_x_333/public/property/img-mastheads/bomlm_4.jpg?h=7bc7d4e1", "Khách Sạn The Leela, Mumbai", "+912266486000", null, "the-leela-mumbai", null, null },
                    { 23, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Khách sạn sang trọng tại New York.", null, "info@stregis.com", "https://upload.wikimedia.org/wikipedia/commons/thumb/4/43/The_St._Regis_Hotel_New_York.JPG/1200px-The_St._Regis_Hotel_New_York.JPG", "Khách Sạn St. Regis New York", "+12125450500", null, "st-regis-new-york", null, null },
                    { 24, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Khách sạn sang trọng tại Dubai.", null, "info@jumeirah.com", "https://cf.bstatic.com/xdata/images/district/1020x340/45235.jpg?k=daf29066fcf29a01b738ead0998e878a221a3176c033e82a170da725278bc69c&o=", "Khách Sạn Jumeirah, Dubai", "+97144028888", null, "jumeirah-dubai", null, null },
                    { 25, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Khách sạn cổ điển tại Italy.", null, "info@belmond.com", "https://www.truetrips.com/images/api/hotels/Amalfi/Belmond_Hotel_Caruso/The_Balmoral_Caruso_bn_02.jpg", "Khách Sạn Belmond Hotel Caruso", "+39089812345", null, "belmond-caruso", null, null },
                    { 26, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Khách sạn 5 sao tại Phuket.", null, "info@banyantree.com", "https://greenmore.vn/wp-content/uploads/2019/12/canh-quan-resort-nghi-duong-banyan-tree-phuket-05-compressed.jpg", "Khách Sạn Banyan Tree, Phuket", "+6676377888", null, "banyan-tree-phuket", null, null },
                    { 27, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Khách sạn sang trọng tại Dubai.", null, "info@theaddress.com", "https://cf.bstatic.com/xdata/images/hotel/max1024x768/147760688.jpg?k=9604a9318b078228b302c62aaefdfe79aa03688c6d00b953ddc65ab46a337c12&o=&hp=1", "Khách Sạn The Address, Dubai", "+97144087777", null, "the-address-dubai", null, null },
                    { 28, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Khách sạn bên bờ sông tại Bangkok.", null, "info@shangri-la.com", "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/2a/9c/cc/45/shangri-la-bangkok.jpg?w=700&h=-1&s=1", "Khách Sạn Shangri-La, Bangkok", "+6622367777", null, "shangri-la-bangkok", null, null },
                    { 29, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Khách sạn tuyệt đẹp tại Bali.", null, "info@oberoihotels.com", "https://www.hotelsinheaven.com/wp-content/uploads/2020/05/the-oberoi-beach-resort-bali-main-pool-beach-scaled-1256x1000.jpg", "Khách Sạn The Oberoi, Bali", "+62361775688", null, "the-oberoi-bali", null, null },
                    { 30, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Khách sạn 5 sao tại Tokyo.", null, "info@mandarinoriental.com", "https://cf2.bstatic.com/xdata/images/hotel/max1280x900/565155779.jpg?k=6597ca16a17e31dfa517cd3e90b398fd52a5773dfe28ff2b3e5a0baa15f1d89c&o=&hp=1", "Khách Sạn Mandarin Oriental, Tokyo", "+81357770000", null, "mandarin-oriental-tokyo", null, null }
                });

            migrationBuilder.InsertData(
                table: "AppRole",
                columns: new[] { "Id", "CanDelete", "CreatedBy", "CreatedDate", "DeletedDate", "Desc", "DisplayOrder", "Name", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, false, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Quản trị toàn bộ hệ thống", null, "Quản trị hệ thống", null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, true, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Nhân viên", null, "Nhân viên", null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, true, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Khách hàng", null, "Khách hàng", null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "AppRoomType",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedDate", "Description", "DisplayOrder", "PeopleStay", "RoomTypeName", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Phòng nhỏ cho 1 người, trang bị đầy đủ tiện nghi.", null, 1, "Phòng Đơn", null, null },
                    { 2, 1, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Phòng cho 2 người, thích hợp cho cặp đôi hoặc bạn bè.", null, 2, "Phòng Đôi", null, null }
                });

            migrationBuilder.InsertData(
                table: "AppRoomType",
                columns: new[] { "Id", "BringPet", "CreatedBy", "CreatedDate", "DeletedDate", "Description", "DisplayOrder", "PeopleStay", "RoomTypeName", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 3, true, 1, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Phòng rộng rãi cho gia đình, có giường đôi và giường đơn.", null, 4, "Phòng Gia Đình", null, null });

            migrationBuilder.InsertData(
                table: "AppRoomType",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedDate", "Description", "DisplayOrder", "PeopleStay", "RoomTypeName", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 4, 1, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Phòng cao cấp với tiện nghi hiện đại và tầm nhìn đẹp.", null, 2, "Phòng Sang Trọng", null, null },
                    { 5, 1, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Phòng VIP với các dịch vụ đặc biệt và riêng tư.", null, 2, "Phòng VIP", null, null }
                });

            migrationBuilder.InsertData(
                table: "MstPermission",
                columns: new[] { "Id", "Code", "CreatedBy", "CreatedDate", "DeletedDate", "Desc", "DisplayOrder", "GroupName", "Table", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1001, "VIEW_LIST", null, new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Xem danh sách người dùng", null, "Quản lý người dùng", "AppUser", null, null },
                    { 1002, "VIEW_DETAIL", null, new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Xem chi tiết người dùng", null, "Quản lý người dùng", "AppUser", null, null },
                    { 1003, "CREATE", null, new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Thêm người dùng", null, "Quản lý người dùng", "AppUser", null, null },
                    { 1004, "UPDATE", null, new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Cập nhật người dùng", null, "Quản lý người dùng", "AppUser", null, null },
                    { 1005, "UPDATE_PWD", null, new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Đổi mật khẩu", null, "Quản lý người dùng", "AppUser", null, null },
                    { 1006, "BLOCK", null, new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Khóa người dùng", null, "Quản lý người dùng", "AppUser", null, null },
                    { 1007, "UNBLOCK", null, new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Mở khóa người dùng", null, "Quản lý người dùng", "AppUser", null, null },
                    { 1008, "DELETE", null, new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Xóa người dùng", null, "Quản lý người dùng", "AppUser", null, null },
                    { 1101, "VIEW_LIST", null, new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Xem danh sách quyền", null, "Quản lý phân quyền", "AppRole", null, null },
                    { 1102, "VIEW_DETAIL", null, new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Xem chi tiết quyền", null, "Quản lý phân quyền", "AppRole", null, null },
                    { 1103, "CREATE", null, new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Thêm quyền", null, "Quản lý phân quyền", "AppRole", null, null },
                    { 1104, "UPDATE", null, new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sửa quyền", null, "Quản lý phân quyền", "AppRole", null, null },
                    { 1105, "DELETE", null, new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Xóa quyền", null, "Quản lý phân quyền", "AppRole", null, null },
                    { 1201, "MANAGER", null, new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Quản lý file hệ thống", null, "Quản lý file", "FileManager", null, null },
                    { 1301, "VIEW_LIST", null, new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Xem danh sách bài viết", null, "Quản lý tin tức", "AppNews", null, null },
                    { 1302, "CREATE", null, new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Thêm bài viết", null, "Quản lý tin tức", "AppNews", null, null },
                    { 1303, "UPDATE", null, new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Cập nhật bài viết", null, "Quản lý tin tức", "AppNews", null, null },
                    { 1304, "DELETE", null, new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Xóa bài viết", null, "Quản lý tin tức", "AppNews", null, null },
                    { 1305, "PUBLIC", null, new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Công khai bài viết", null, "Quản lý tin tức", "AppNews", null, null },
                    { 1306, "UNPUBLIC", null, new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Gỡ bỏ bài viết", null, "Quản lý tin tức", "AppNews", null, null },
                    { 1307, "SENDMAILREGISTER", null, new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Gữi email người đăng ký", null, "Quản lý tin tức", "AppNews", null, null },
                    { 1401, "VIEW_LIST", null, new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Xem danh sách thể loại tin", null, "Quản lý thể loại tin", "AppNewsCategory", null, null },
                    { 1402, "CREATE", null, new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Thêm thể loại bài viết", null, "Quản lý thể loại tin", "AppNewsCategory", null, null },
                    { 1403, "UPDATE", null, new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Cập nhật thể loại bài viết", null, "Quản lý thể loại tin", "AppNewsCategory", null, null },
                    { 1404, "DELETE", null, new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Xóa thể loại bài viết", null, "Quản lý thể loại tin", "AppNewsCategory", null, null },
                    { 1501, "VIEW_LIST", null, new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Xem danh sách chi nhánh khách sạn", null, "Quản lý chi nhánh khách sạn", "AppBranchHotel", null, null },
                    { 1502, "CREATE", null, new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Thêm chi nhánh khách sạn", null, "Quản lý chi nhánh khách sạn", "AppBranchHotel", null, null },
                    { 1503, "UPDATE", null, new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Cập nhật chi nhánh", null, "Quản lý chi nhánh khách sạn", "AppBranchHotel", null, null },
                    { 1504, "DELETE", null, new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Xóa chi nhánh", null, "Quản lý chi nhánh khách sạn", "AppBranchHotel", null, null },
                    { 1601, "VIEW_LIST", null, new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Xem danh sách khách sạn", null, "Quản lý khách sạn", "AppHotel", null, null },
                    { 1602, "CREATE", null, new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Thêm khách sạn", null, "Quản lý khách sạn", "AppHotel", null, null },
                    { 1603, "UPDATE", null, new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Cập nhật khách sạn", null, "Quản lý khách sạn", "AppHotel", null, null },
                    { 1604, "DELETE", null, new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Xóa khách sạn", null, "Quản lý khách sạn", "AppHotel", null, null },
                    { 1605, "PUBLIC", null, new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Công khai khách sạn", null, "Quản lý khách sạn", "AppHotel", null, null },
                    { 1606, "UNPUBLIC", null, new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Gỡ khách sạn xuống", null, "Quản lý khách sạn", "AppHotel", null, null },
                    { 1701, "VIEW_LIST", null, new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Xem danh sách phòng", null, "Quản lý phòng khách sạn", "AppRoom", null, null },
                    { 1702, "CREATE", null, new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Thêm phòng", null, "Quản lý phòng khách sạn", "AppRoom", null, null },
                    { 1703, "UPDATE", null, new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Cập nhật phòng", null, "Quản lý phòng khách sạn", "AppRoom", null, null },
                    { 1704, "DELETE", null, new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Xóa phòng", null, "Quản lý phòng khách sạn", "AppRoom", null, null },
                    { 1705, "PUBLIC", null, new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Công khai phòng", null, "Quản lý phòng khách sạn", "AppRoom", null, null },
                    { 1706, "UNPUBLIC", null, new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Gỡ phòng xuống", null, "Quản lý phòng khách sạn", "AppRoom", null, null },
                    { 1801, "VIEW_LIST", null, new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Quản lý loại phòng", null, "Quản lý loại phòng", "AppRoomType", null, null },
                    { 1802, "CREATE", null, new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Thêm loại phòng", null, "Quản lý loại phòng", "AppRoomType", null, null },
                    { 1803, "UPDATE", null, new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Cập nhật loại phòng", null, "Quản lý loại phòng", "AppRoomType", null, null },
                    { 1804, "DELETE", null, new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Xóa loại phòng", null, "Quản lý loại phòng", "AppRoomType", null, null },
                    { 1901, "VIEW_LIST", null, new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Quản lý trang thiết bị", null, "Quản lý trang thiết bị", "AppEquipment", null, null },
                    { 1902, "CREATE", null, new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Thêm mới trang thiết bị", null, "Quản lý trang thiết bị", "AppEquipment", null, null },
                    { 1903, "UPDATE", null, new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Cập nhật trang thiết bị", null, "Quản lý trang thiết bị", "AppEquipment", null, null },
                    { 1904, "DELETE", null, new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Xóa trang thiết bị", null, "Quản lý trang thiết bị", "AppEquipment", null, null },
                    { 2001, "VIEW_LIST", null, new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Quản lý loại trang thiết bị", null, "Quản lý loại trang thiết bị", "AppEquipmentType", null, null },
                    { 2002, "CREATE", null, new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Thêm mới loại trang thiết bị", null, "Quản lý loại trang thiết bị", "AppEquipmentType", null, null },
                    { 2003, "UPDATE", null, new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Cập nhật loại trang thiết bị", null, "Quản lý loại trang thiết bị", "AppEquipmentType", null, null },
                    { 2004, "DELETE", null, new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Xóa loại trang thiết bị", null, "Quản lý loại trang thiết bị", "AppEquipmentType", null, null },
                    { 2101, "VIEW_LIST", null, new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Xem danh sách lương nhân viên", null, "Quản lý lương nhân viên", "AppPayroll", null, null },
                    { 2102, "VIEW_LIST", null, new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Xem chi tiết lương nhân viên", null, "Quản lý lương nhân viên", "AppPayroll", null, null },
                    { 2103, "CREATE", null, new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Tạo bảng lương mới cho nhân viên", null, "Quản lý lương nhân viên", "AppPayroll", null, null },
                    { 2104, "UPDATE", null, new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Cập nhật bảng lương cho nhân viên", null, "Quản lý lương nhân viên", "AppPayroll", null, null },
                    { 2105, "DELETE", null, new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Xóa bảng lương của nhân viên", null, "Quản lý lương nhân viên", "AppPayroll", null, null },
                    { 2201, "VIEW_LIST", null, new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Xem danh sách lịch làm nhân viên", null, "Quản lý lịch làm nhân viên", "AppWorkSchedule", null, null },
                    { 2202, "VIEW_LIST", null, new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Xem chi tiết lịch làm nhân viên", null, "Quản lý lịch làm nhân viên", "AppWorkSchedule", null, null },
                    { 2203, "CREATE", null, new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Tạo lịch làm cho nhân viên", null, "Quản lý lịch làm nhân viên", "AppWorkSchedule", null, null },
                    { 2204, "UPDATE", null, new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Cập nhật lịch làm cho nhân viên", null, "Quản lý lịch làm nhân viên", "AppWorkSchedule", null, null },
                    { 2205, "DELETE", null, new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Xóa lịch làm của nhân viên", null, "Quản lý lịch làm nhân viên", "AppWorkSchedule", null, null },
                    { 2301, "VIEW_LIST", null, new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Xem danh sách ca làm nhân viên", null, "Quản lý ca làm nhân viên", "AppWorkShift", null, null },
                    { 2302, "VIEW_LIST", null, new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Xem chi tiết ca làm nhân viên", null, "Quản lý ca làm nhân viên", "AppWorkShift", null, null },
                    { 2303, "CREATE", null, new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Tạo ca làm cho nhân viên", null, "Quản lý ca làm nhân viên", "AppWorkShift", null, null },
                    { 2304, "UPDATE", null, new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Cập nhật ca làm cho nhân viên", null, "Quản lý ca làm nhân viên", "AppWorkShift", null, null },
                    { 2305, "DELETE", null, new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Xóa ca làm của nhân viên", null, "Quản lý ca làm nhân viên", "AppWorkShift", null, null },
                    { 2401, "VIEW_LIST", null, new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Xem danh sách đặt phòng", null, "Quản lý đặt phòng", "AppOrder", null, null },
                    { 2402, "DETAILS", null, new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Xem chi tiết phòng được đặt", null, "Quản lý đặt phòng", "AppOrderDetail", null, null },
                    { 2403, "UPDATE", null, new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Cập nhật trang thái đặt phòng", null, "Quản lý đặt phòng", "AppOrder", null, null },
                    { 2404, "DELETE", null, new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Xóa đặt phòng", null, "Quản lý đặt phòng", "AppOrder", null, null },
                    { 2501, "VIEW_LIST", null, new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Xem danh sách các bình luận", null, "Quản lý bình luận người dùng", "AppComment", null, null },
                    { 2502, "DELETE", null, new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Xóa bình luận vi phạn", null, "Quản lý bình luận người dùng", "AppComment", null, null }
                });

            migrationBuilder.InsertData(
                table: "AppBranchHotel",
                columns: new[] { "Id", "Address", "CreatedBy", "CreatedDate", "DeletedDate", "Description", "DisplayOrder", "HotelId", "IdMap", "Img", "Name", "QuantityRoom", "QuantityStaff", "Slug", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "123 Phố Lý Thái Tổ, Quận Hoàn Kiếm, Hà Nội, Việt Nam", null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chi nhánh của Melia Hà Nội tại Hà Nội", null, 1, null, null, "Hà Nội", 50, 20, "ha-noi", null, null },
                    { 2, "456 Đường Nguyễn Huệ, Phường Bến Nghé, Quận 1, TP. Hồ Chí Minh, Việt Nam", null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chi nhánh của Rex Hotel Sài Gòn tại TP. Hồ Chí Minh", null, 2, null, null, "TP. Hồ Chí Minh", 80, 25, "tp-ho-chi-minh", null, null },
                    { 3, "789 Đường Bạch Đằng, Phường Hải Châu, Đà Nẵng, Việt Nam", null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chi nhánh của Đà Nẵng Golden Bay tại Đà Nẵng", null, 3, null, null, "Đà Nẵng", 40, 15, "da-nang", null, null },
                    { 4, "101 Đường Trần Phú, Thành phố Nha Trang, Khánh Hòa, Việt Nam", null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chi nhánh của Nha Trang Lodge tại Nha Trang", null, 4, null, null, "Nha Trang", 60, 18, "nha-trang", null, null },
                    { 5, "202 Đường Lê Đại Hành, Quận Hồng Bàng, Hải Phòng, Việt Nam", null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chi nhánh của Imperial Hải Phòng tại Hải Phòng", null, 5, null, null, "Hải Phòng", 30, 12, "hai-phong", null, null },
                    { 6, "600 Đường 5th Ave, New York, NY 10020, USA", null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chi nhánh của Langham Hotel tại New York", null, 6, null, null, "New York", 100, 40, "new-york", null, null },
                    { 7, "123 Đường Chuo, Minato City, Tokyo, Nhật Bản", null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chi nhánh của The Peninsula Tokyo tại Tokyo", null, 7, null, null, "Tokyo", 90, 35, "tokyo", null, null },
                    { 8, "700 Boulevard Kukulcan, Cancun, Mexico", null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chi nhánh của The Ritz-Carlton tại Cancun", null, 8, null, null, "Cancun", 75, 30, "cancun", null, null },
                    { 9, "500 South Florida Avenue, Miami, FL 33131, USA", null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chi nhánh của The Biltmore Miami tại Miami", null, 9, null, null, "Miami", 60, 28, "miami", null, null },
                    { 10, "70 Avenue de La Bourdonnais, 75007 Paris, Pháp", null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chi nhánh của Shangri-La tại Paris", null, 10, null, null, "Paris", 110, 45, "paris", null, null },
                    { 11, "747-7, Sinsa-dong, Gangnam-gu, Seoul, Hàn Quốc", null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chi nhánh của Grand Hyatt tại Seoul", null, 11, null, null, "Seoul", 120, 50, "seoul", null, null },
                    { 12, "123, 123/1-3, Thanon Ratchadamri, Lumphini, Pathum Wan, Bangkok, Thái Lan", null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chi nhánh của Four Seasons tại Bangkok", null, 12, null, null, "Bangkok", 80, 32, "bangkok", null, null },
                    { 13, "2-6-1 Nishishinjuku, Shinjuku City, Tokyo, Nhật Bản", null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chi nhánh của Hilton tại Tokyo", null, 13, null, null, "Tokyo", 95, 38, "tokyo", null, null },
                    { 14, "1 Austin Road West, Tsim Sha Tsui, Hong Kong", null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chi nhánh của W Hong Kong tại Hong Kong", null, 14, null, null, "Hong Kong", 130, 55, "hong-kong", null, null },
                    { 15, "Nusa Dua, Bali, Indonesia", null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chi nhánh của The St. Regis tại Bali", null, 15, null, null, "Bali", 70, 22, "bali", null, null },
                    { 16, "48-5, Thanon Ruam Rudee, Lumphini, Pathum Wan, Bangkok, Thái Lan", null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chi nhánh của Mandarin Oriental tại Bangkok", null, 16, null, null, "Bangkok", 85, 35, "bangkok", null, null },
                    { 17, "228 Rue de Rivoli, 75001 Paris, Pháp", null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chi nhánh của Le Meurice tại Paris", null, 17, null, null, "Paris", 140, 60, "paris", null, null },
                    { 18, "Balaji Towers, Juhu Beach, Mumbai, Ấn Độ", null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chi nhánh của The Oberoi tại Mumbai", null, 18, null, null, "Mumbai", 75, 30, "mumbai", null, null },
                    { 19, "7 Hickson Rd, Millers Point, Sydney, Australia", null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chi nhánh của Park Hyatt tại Sydney", null, 19, null, null, "Sydney", 60, 29, "sydney", null, null },
                    { 20, "5/5-7 Thanon Sukhumvit 23, Khlong Toei Nuea, Watthana, Bangkok, Thái Lan", null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chi nhánh của The Sukhothai tại Bangkok", null, 20, null, null, "Bangkok", 80, 33, "bangkok", null, null },
                    { 21, "15 Place Vendôme, 75001 Paris, Pháp", null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chi nhánh của Ritz Paris tại Paris", null, 21, null, null, "Paris", 125, 50, "paris", null, null },
                    { 22, "Mahalaxmi, Mumbai, Ấn Độ", null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chi nhánh của Taj Mahal Palace tại Mumbai", null, 22, null, null, "Mumbai", 75, 30, "mumbai", null, null },
                    { 23, "New York, USA", null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chi nhánh của St. Regis tại New York", null, 23, null, null, "New York", 110, 42, "new-york", null, null },
                    { 24, "Dubai, UAE", null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chi nhánh của Jumeirah tại Dubai", null, 24, null, null, "Dubai", 150, 50, "dubai", null, null },
                    { 25, "Italy", null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chi nhánh của Belmond Hotel Caruso tại Italy", null, 25, null, null, "Italy", 60, 28, "italy", null, null },
                    { 26, "Phuket, Thái Lan", null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chi nhánh của Banyan Tree tại Phuket", null, 26, null, null, "Phuket", 75, 30, "phuket", null, null },
                    { 27, "Dubai, UAE", null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chi nhánh của The Address tại Dubai", null, 27, null, null, "Dubai", 120, 45, "dubai", null, null },
                    { 28, "Bangkok, Thái Lan", null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chi nhánh của Shangri-La tại Bangkok", null, 28, null, null, "Bangkok", 90, 35, "bangkok", null, null },
                    { 29, "Bali, Indonesia", null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chi nhánh của The Oberoi tại Bali", null, 29, null, null, "Bali", 65, 25, "bali", null, null },
                    { 30, "Tokyo, Nhật Bản", null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chi nhánh của Aman tại Tokyo", null, 30, null, null, "Tokyo", 95, 38, "tokyo", null, null },
                    { 31, "Hà Nội, Việt Nam", null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chi nhánh của Rex Hotel Saigon tại Hà Nội", null, 2, null, null, "Hà Nội", 50, 20, "ha-noi-2", null, null },
                    { 32, "TP. Hồ Chí Minh, Việt Nam", null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chi nhánh của Đà Nẵng Golden Bay tại TP. Hồ Chí Minh", null, 3, null, null, "TP. Hồ Chí Minh", 80, 25, "tp-ho-chi-minh-2", null, null },
                    { 33, "Đà Nẵng, Việt Nam", null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chi nhánh của Nha Trang Lodge tại Đà Nẵng", null, 4, null, null, "Đà Nẵng", 40, 15, "da-nang-2", null, null },
                    { 34, "Nha Trang, Việt Nam", null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chi nhánh của Imperial Hải Phòng tại Nha Trang", null, 5, null, null, "Nha Trang", 60, 18, "nha-trang-2", null, null },
                    { 35, "Hải Phòng, Việt Nam", null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chi nhánh của Langham Hotel tại Hải Phòng", null, 6, null, null, "Hải Phòng", 30, 12, "hai-phong-2", null, null },
                    { 36, "New York, USA", null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chi nhánh của The Peninsula tại New York", null, 7, null, null, "New York", 100, 40, "new-york-2", null, null },
                    { 37, "Tokyo, Nhật Bản", null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chi nhánh của The Ritz-Carlton tại Tokyo", null, 8, null, null, "Tokyo", 90, 35, "tokyo-2", null, null },
                    { 38, "Cancun, Mexico", null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chi nhánh của The Biltmore tại Cancun", null, 9, null, null, "Cancun", 75, 30, "cancun-2", null, null },
                    { 39, "Miami, USA", null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chi nhánh của Shangri-La tại Miami", null, 10, null, null, "Miami", 60, 28, "miami-2", null, null },
                    { 40, "Paris, Pháp", null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chi nhánh của Grand Hyatt tại Paris", null, 11, null, null, "Paris", 110, 45, "paris-2", null, null },
                    { 41, "Seoul, Hàn Quốc", null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chi nhánh của Four Seasons tại Seoul", null, 12, null, null, "Seoul", 120, 50, "seoul-2", null, null },
                    { 42, "Bangkok, Thái Lan", null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chi nhánh của Hilton tại Bangkok", null, 13, null, null, "Bangkok", 80, 32, "bangkok-2", null, null },
                    { 43, "Tokyo, Nhật Bản", null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chi nhánh của W Hong Kong tại Tokyo", null, 14, null, null, "Tokyo", 95, 38, "tokyo-3", null, null },
                    { 44, "Hong Kong", null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chi nhánh của The St. Regis tại Hong Kong", null, 15, null, null, "Hong Kong", 130, 55, "hong-kong-2", null, null },
                    { 45, "Bali, Indonesia", null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chi nhánh của Mandarin Oriental tại Bali", null, 16, null, null, "Bali", 70, 22, "bali-2", null, null },
                    { 46, "Bangkok, Thái Lan", null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chi nhánh của Ritz tại Bangkok", null, 17, null, null, "Bangkok", 85, 35, "bangkok-3", null, null },
                    { 47, "Paris, Pháp", null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chi nhánh của The Oberoi tại Paris", null, 18, null, null, "Paris", 140, 60, "paris-3", null, null },
                    { 48, "Mumbai, Ấn Độ", null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chi nhánh của Park Hyatt tại Mumbai", null, 19, null, null, "Mumbai", 75, 30, "mumbai-2", null, null },
                    { 49, "Sydney, Australia", null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chi nhánh của The Sukhothai tại Sydney", null, 20, null, null, "Sydney", 65, 29, "sydney-2", null, null },
                    { 50, "Bangkok, Thái Lan", null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chi nhánh của Ritz tại Bangkok", null, 21, null, null, "Bangkok", 90, 33, "bangkok-4", null, null },
                    { 51, "Bali, Indonesia", null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chi nhánh của The Leela tại Bali", null, 22, null, null, "Bali", 65, 25, "bali-3", null, null },
                    { 52, "Tokyo, Nhật Bản", null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chi nhánh của St. Regis tại Tokyo", null, 23, null, null, "Tokyo", 92, 37, "tokyo-4", null, null },
                    { 53, "New York, USA", null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chi nhánh của Jumeirah tại New York", null, 24, null, null, "New York", 102, 41, "new-york-3", null, null },
                    { 54, "Dubai, UAE", null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chi nhánh của Belmond Hotel Caruso tại Dubai", null, 25, null, null, "Dubai", 160, 53, "dubai-3", null, null },
                    { 55, "Italy", null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chi nhánh của Banyan Tree tại Italy", null, 26, null, null, "Italy", 70, 30, "italy-2", null, null },
                    { 56, "Phuket, Thái Lan", null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chi nhánh của The Address tại Phuket", null, 27, null, null, "Phuket", 80, 32, "phuket-2", null, null },
                    { 57, "Dubai, UAE", null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chi nhánh của Shangri-La tại Dubai", null, 28, null, null, "Dubai", 125, 45, "dubai-4", null, null },
                    { 58, "Bangkok, Thái Lan", null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chi nhánh của The Oberoi tại Bangkok", null, 29, null, null, "Bangkok", 90, 35, "bangkok-5", null, null },
                    { 59, "Bali, Indonesia", null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chi nhánh của Aman tại Bali", null, 30, null, null, "Bali", 68, 27, "bali-4", null, null }
                });

            migrationBuilder.InsertData(
                table: "AppEquipment",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedDate", "Description", "DisplayOrder", "Name", "TypeEquipmentId", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "Tivi", 1, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "Điều hòa", 1, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "Bàn làm việc", 1, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "Ghế", 1, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "Tủ lạnh mini", 1, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "Bồn cầu", 2, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "Chậu rửa", 2, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "Vòi sen", 2, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "Bồn tắm", 2, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "AppRolePermission",
                columns: new[] { "Id", "AppRoleId", "CreatedBy", "CreatedDate", "DeletedDate", "DisplayOrder", "MstPermissionId", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 1, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1101, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 1, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1102, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 1, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1103, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 1, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1104, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 1, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1105, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 1, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1001, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 1, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1002, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 1, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1003, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 1, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1004, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, 1, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1005, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, 1, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1006, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, 1, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1007, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, 1, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1008, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, 1, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1201, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, 1, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1301, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, 1, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1302, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 17, 1, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1303, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 18, 1, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1304, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 19, 1, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1305, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 20, 1, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1306, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 21, 1, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1307, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 22, 1, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1401, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 23, 1, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1402, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 24, 1, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1403, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 25, 1, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1404, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 26, 1, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1501, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 27, 1, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1502, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 28, 1, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1503, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 29, 1, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1504, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 30, 1, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1601, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 31, 1, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1602, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 32, 1, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1603, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 33, 1, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1604, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 34, 1, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1605, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 35, 1, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1606, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 36, 1, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1701, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 37, 1, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1702, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 38, 1, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1703, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 39, 1, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1704, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 40, 1, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1705, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 41, 1, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1706, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 42, 1, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1801, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 43, 1, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1802, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 44, 1, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1803, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 45, 1, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1804, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 46, 1, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1901, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 47, 1, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1902, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 48, 1, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1903, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 49, 1, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1904, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 50, 1, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 2001, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 51, 1, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 2002, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 52, 1, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 2003, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 53, 1, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 2004, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 54, 1, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 2401, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 55, 1, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 2402, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 56, 1, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 2403, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 57, 1, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 2404, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 58, 1, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 2101, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 59, 1, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 2102, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 60, 1, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 2103, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 61, 1, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 2104, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 62, 1, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 2105, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 63, 1, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 2201, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 64, 1, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 2202, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 65, 1, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 2203, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 66, 1, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 2204, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 67, 1, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 2205, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 68, 1, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 2301, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 69, 1, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 2302, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 70, 1, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 2303, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 71, 1, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 2304, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 72, 1, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 2305, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "AppUser",
                columns: new[] { "Id", "Address", "AppRoleId", "Avatar", "BlockedBy", "BlockedTo", "BranchId", "CitizenId", "CreatedBy", "CreatedDate", "DeletedDate", "DisplayOrder", "Email", "FullName", "Passport", "PasswordHash", "PasswordSalt", "Permanent", "PhoneNumber1", "PhoneNumber2", "UpdatedBy", "UpdatedDate", "Username" },
                values: new object[,]
                {
                    { 1, "Thành phố Hồ Chí Minh", 1, null, null, null, 1, 912345678, -1, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "admin_test@gmail.com", "Nguyễn Thanh Long", null, new byte[] { 252, 107, 170, 202, 197, 153, 127, 105, 225, 76, 134, 72, 146, 37, 197, 157, 189, 177, 51, 112, 126, 245, 28, 5, 253, 163, 126, 217, 6, 213, 73, 236, 98, 8, 172, 162, 250, 100, 84, 101, 70, 235, 147, 60, 30, 58, 194, 142, 212, 227, 113, 45, 8, 44, 240, 78, 2, 82, 59, 226, 41, 194, 242, 97 }, new byte[] { 103, 109, 112, 39, 151, 137, 69, 69, 236, 93, 114, 87, 124, 161, 59, 184, 7, 217, 254, 141, 17, 229, 40, 176, 82, 246, 115, 107, 111, 135, 113, 96, 222, 227, 171, 3, 93, 214, 4, 65, 7, 204, 143, 85, 69, 48, 222, 51, 185, 128, 216, 38, 136, 148, 46, 229, 218, 237, 246, 80, 94, 253, 73, 195, 39, 174, 91, 113, 103, 104, 212, 227, 74, 22, 180, 150, 249, 86, 186, 11, 14, 214, 101, 64, 209, 87, 207, 245, 214, 156, 143, 164, 228, 8, 164, 242, 208, 58, 77, 118, 187, 34, 125, 240, 54, 226, 109, 185, 221, 5, 114, 189, 83, 58, 178, 108, 138, 240, 8, 6, 142, 233, 56, 5, 71, 240, 150, 248 }, null, "+84928666158", "+84928666156", -1, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin" },
                    { 2, "Thành phố Cần Thơ", 2, null, null, null, 1, 917635678, -1, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "tranthib2001@gmail.com", "Trần Chí Dũng", null, new byte[] { 252, 107, 170, 202, 197, 153, 127, 105, 225, 76, 134, 72, 146, 37, 197, 157, 189, 177, 51, 112, 126, 245, 28, 5, 253, 163, 126, 217, 6, 213, 73, 236, 98, 8, 172, 162, 250, 100, 84, 101, 70, 235, 147, 60, 30, 58, 194, 142, 212, 227, 113, 45, 8, 44, 240, 78, 2, 82, 59, 226, 41, 194, 242, 97 }, new byte[] { 103, 109, 112, 39, 151, 137, 69, 69, 236, 93, 114, 87, 124, 161, 59, 184, 7, 217, 254, 141, 17, 229, 40, 176, 82, 246, 115, 107, 111, 135, 113, 96, 222, 227, 171, 3, 93, 214, 4, 65, 7, 204, 143, 85, 69, 48, 222, 51, 185, 128, 216, 38, 136, 148, 46, 229, 218, 237, 246, 80, 94, 253, 73, 195, 39, 174, 91, 113, 103, 104, 212, 227, 74, 22, 180, 150, 249, 86, 186, 11, 14, 214, 101, 64, 209, 87, 207, 245, 214, 156, 143, 164, 228, 8, 164, 242, 208, 58, 77, 118, 187, 34, 125, 240, 54, 226, 109, 185, 221, 5, 114, 189, 83, 58, 178, 108, 138, 240, 8, 6, 142, 233, 56, 5, 71, 240, 150, 248 }, null, "+84928666157", "+84928666158", -1, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "staff" },
                    { 3, "New York City", 3, null, null, null, 1, null, -1, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "thanhnguyendt2000@gmail.com", "John Smith", "123456789", new byte[] { 252, 107, 170, 202, 197, 153, 127, 105, 225, 76, 134, 72, 146, 37, 197, 157, 189, 177, 51, 112, 126, 245, 28, 5, 253, 163, 126, 217, 6, 213, 73, 236, 98, 8, 172, 162, 250, 100, 84, 101, 70, 235, 147, 60, 30, 58, 194, 142, 212, 227, 113, 45, 8, 44, 240, 78, 2, 82, 59, 226, 41, 194, 242, 97 }, new byte[] { 103, 109, 112, 39, 151, 137, 69, 69, 236, 93, 114, 87, 124, 161, 59, 184, 7, 217, 254, 141, 17, 229, 40, 176, 82, 246, 115, 107, 111, 135, 113, 96, 222, 227, 171, 3, 93, 214, 4, 65, 7, 204, 143, 85, 69, 48, 222, 51, 185, 128, 216, 38, 136, 148, 46, 229, 218, 237, 246, 80, 94, 253, 73, 195, 39, 174, 91, 113, 103, 104, 212, 227, 74, 22, 180, 150, 249, 86, 186, 11, 14, 214, 101, 64, 209, 87, 207, 245, 214, 156, 143, 164, 228, 8, 164, 242, 208, 58, 77, 118, 187, 34, 125, 240, 54, 226, 109, 185, 221, 5, 114, 189, 83, 58, 178, 108, 138, 240, 8, 6, 142, 233, 56, 5, 71, 240, 150, 248 }, null, "+12025550123", "+12027450123", -1, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "user1" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AppBranchHotel_HotelId",
                table: "AppBranchHotel",
                column: "HotelId");

            migrationBuilder.CreateIndex(
                name: "IX_AppComment_RoomId",
                table: "AppComment",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_AppCommentDetail_CommentId",
                table: "AppCommentDetail",
                column: "CommentId");

            migrationBuilder.CreateIndex(
                name: "IX_AppCommentDetail_CreatedBy",
                table: "AppCommentDetail",
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
                name: "IX_AppNews_UserId",
                table: "AppNews",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "uq_slug",
                table: "AppNews",
                column: "Slug",
                unique: true);

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
                name: "AppCommentDetail");

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
                name: "AppComment");

            migrationBuilder.DropTable(
                name: "AppNewsCategory");

            migrationBuilder.DropTable(
                name: "AppOrder");

            migrationBuilder.DropTable(
                name: "MstPermission");

            migrationBuilder.DropTable(
                name: "AppEquipment");

            migrationBuilder.DropTable(
                name: "AppWorkSchedule");

            migrationBuilder.DropTable(
                name: "AppRoom");

            migrationBuilder.DropTable(
                name: "AppEquipmentType");

            migrationBuilder.DropTable(
                name: "AppUser");

            migrationBuilder.DropTable(
                name: "AppRoomType");

            migrationBuilder.DropTable(
                name: "AppBranchHotel");

            migrationBuilder.DropTable(
                name: "AppRole");

            migrationBuilder.DropTable(
                name: "AppHotel");
        }
    }
}
