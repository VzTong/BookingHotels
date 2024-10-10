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
                name: "AppCategoryNews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Slug = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Content = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CoverImgPath = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppCategoryNews", x => x.Id);
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
                    ImgBanner = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
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
                name: "AppTypeEquipment",
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
                    table.PrimaryKey("PK_AppTypeEquipment", x => x.Id);
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
                    Img = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
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
                        name: "FK_AppEquipment_AppTypeEquipment_TypeEquipmentId",
                        column: x => x.TypeEquipmentId,
                        principalTable: "AppTypeEquipment",
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
                    Avatar = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
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
                    EquipmentId = table.Column<int>(type: "int", nullable: true),
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
                        name: "FK_AppRoom_AppEquipment_EquipmentId",
                        column: x => x.EquipmentId,
                        principalTable: "AppEquipment",
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
                        name: "FK_AppNews_AppCategoryNews_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "AppCategoryNews",
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
                    ImgSrc = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
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

            migrationBuilder.InsertData(
                table: "AppBranchHotel",
                columns: new[] { "Id", "Address", "CreatedBy", "CreatedDate", "DeletedDate", "Description", "DisplayOrder", "HotelId", "IdMap", "Img", "Name", "QuantityRoom", "QuantityStaff", "Slug", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "Hà Nội, Việt Nam", null, null, null, null, null, null, null, null, "Hà Nội", null, null, "ha-noi", null, null },
                    { 2, "TP. Hồ Chí Minh, Việt Nam", null, null, null, null, null, null, null, null, "TP. Hồ Chí Minh", null, null, "tp-ho-chi-minh", null, null },
                    { 3, "Đà Nẵng, Việt Nam", null, null, null, null, null, null, null, null, "Đà Nẵng", null, null, "da-nang", null, null },
                    { 4, "Nha Trang, Việt Nam", null, null, null, null, null, null, null, null, "Nha Trang", null, null, "nha-trang", null, null },
                    { 5, "Hải Phòng, Việt Nam", null, null, null, null, null, null, null, null, "Hải Phòng", null, null, "hai-phong", null, null },
                    { 6, "California, United States", null, null, null, null, null, null, null, null, "California", null, null, "california", null, null },
                    { 7, "New York, United States", null, null, null, null, null, null, null, null, "New York", null, null, "new-york", null, null },
                    { 8, "Texas, United States", null, null, null, null, null, null, null, null, "Texas", null, null, "texas", null, null },
                    { 9, "Florida, United States", null, null, null, null, null, null, null, null, "Florida", null, null, "florida", null, null },
                    { 10, "Illinois, United States", null, null, null, null, null, null, null, null, "Illinois", null, null, "illinois", null, null },
                    { 11, "Tokyo, Japan", null, null, null, null, null, null, null, null, "Tokyo", null, null, "tokyo", null, null },
                    { 12, "Osaka, Japan", null, null, null, null, null, null, null, null, "Osaka", null, null, "osaka", null, null },
                    { 13, "Kyoto, Japan", null, null, null, null, null, null, null, null, "Kyoto", null, null, "kyoto", null, null },
                    { 14, "Hokkaido, Japan", null, null, null, null, null, null, null, null, "Hokkaido", null, null, "hokkaido", null, null },
                    { 15, "Fukuoka, Japan", null, null, null, null, null, null, null, null, "Fukuoka", null, null, "fukuoka", null, null },
                    { 16, "Delhi, India", null, null, null, null, null, null, null, null, "Delhi", null, null, "delhi", null, null },
                    { 17, "Maharashtra, India", null, null, null, null, null, null, null, null, "Maharashtra (Mumbai)", null, null, "maharashtra-mumbai", null, null },
                    { 18, "Karnataka, India", null, null, null, null, null, null, null, null, "Karnataka (Bangalore)", null, null, "karnataka-bangalore", null, null },
                    { 19, "Tamil Nadu, India", null, null, null, null, null, null, null, null, "Tamil Nadu (Chennai)", null, null, "tamil-nadu-chennai", null, null },
                    { 20, "West Bengal, India", null, null, null, null, null, null, null, null, "West Bengal (Kolkata)", null, null, "west-bengal-kolkata", null, null },
                    { 21, "New South Wales, Australia", null, null, null, null, null, null, null, null, "New South Wales (Sydney)", null, null, "new-south-wales-sydney", null, null },
                    { 22, "Victoria, Australia", null, null, null, null, null, null, null, null, "Victoria (Melbourne)", null, null, "victoria-melbourne", null, null },
                    { 23, "Queensland, Australia", null, null, null, null, null, null, null, null, "Queensland (Brisbane)", null, null, "queensland-brisbane", null, null },
                    { 24, "Western Australia, Australia", null, null, null, null, null, null, null, null, "Western Australia (Perth)", null, null, "western-australia-perth", null, null },
                    { 25, "South Australia, Australia", null, null, null, null, null, null, null, null, "South Australia (Adelaide)", null, null, "south-australia-adelaide", null, null },
                    { 26, "Ontario, Canada", null, null, null, null, null, null, null, null, "Ontario (Toronto)", null, null, "ontario-toronto", null, null },
                    { 27, "British Columbia, Canada", null, null, null, null, null, null, null, null, "British Columbia (Vancouver)", null, null, "british-columbia-vancouver", null, null },
                    { 28, "Quebec, Canada", null, null, null, null, null, null, null, null, "Quebec (Montreal)", null, null, "quebec-montreal", null, null },
                    { 29, "Alberta, Canada", null, null, null, null, null, null, null, null, "Alberta (Calgary)", null, null, "alberta-calgary", null, null },
                    { 30, "Nova Scotia, Canada", null, null, null, null, null, null, null, null, "Nova Scotia (Halifax)", null, null, "nova-scotia-halifax", null, null }
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
                table: "AppTypeEquipment",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedDate", "DisplayOrder", "Name", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Trang thiết bị phòng khách", null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Thiết bị vệ sinh", null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) }
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
                    { 1401, "VIEW_LIST", null, new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Xem danh sách thể loại tin", null, "Quản lý thể loại tin", "AppCategoryNews", null, null },
                    { 1402, "CREATE", null, new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Thêm thể loại bài viết", null, "Quản lý thể loại tin", "AppCategoryNews", null, null },
                    { 1403, "UPDATE", null, new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Cập nhật thể loại bài viết", null, "Quản lý thể loại tin", "AppCategoryNews", null, null },
                    { 1404, "DELETE", null, new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Xóa thể loại bài viết", null, "Quản lý thể loại tin", "AppCategoryNews", null, null },
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
                    { 2001, "VIEW_LIST", null, new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Quản lý loại trang thiết bị", null, "Quản lý loại trang thiết bị", "AppTypeEquipment", null, null },
                    { 2002, "CREATE", null, new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Thêm mới loại trang thiết bị", null, "Quản lý loại trang thiết bị", "AppTypeEquipment", null, null },
                    { 2003, "UPDATE", null, new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Cập nhật loại trang thiết bị", null, "Quản lý loại trang thiết bị", "AppTypeEquipment", null, null },
                    { 2004, "DELETE", null, new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Xóa loại trang thiết bị", null, "Quản lý loại trang thiết bị", "AppTypeEquipment", null, null },
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
                    { 1, "Thành phố Hồ Chí Minh", 1, null, null, null, 1, 912345678, -1, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "admin_test@gmail.com", "Nguyễn Thanh Long", null, new byte[] { 210, 254, 115, 204, 30, 139, 89, 147, 86, 123, 233, 60, 172, 165, 20, 171, 255, 33, 167, 224, 76, 181, 26, 217, 210, 136, 248, 129, 74, 149, 128, 155, 180, 164, 230, 244, 53, 95, 39, 228, 170, 240, 172, 82, 136, 199, 16, 24, 43, 127, 151, 100, 79, 199, 23, 239, 223, 102, 71, 34, 72, 152, 155, 81 }, new byte[] { 26, 182, 176, 205, 218, 242, 159, 117, 145, 83, 21, 202, 167, 115, 4, 197, 233, 167, 161, 248, 8, 178, 174, 23, 158, 184, 68, 24, 224, 236, 114, 239, 97, 6, 129, 224, 163, 174, 106, 243, 203, 247, 18, 196, 20, 151, 168, 233, 10, 170, 136, 169, 234, 148, 80, 214, 253, 45, 63, 136, 2, 150, 109, 210, 165, 134, 82, 221, 81, 177, 243, 110, 180, 127, 139, 62, 123, 196, 45, 22, 171, 255, 0, 24, 47, 119, 155, 18, 65, 214, 242, 81, 184, 211, 19, 61, 54, 208, 158, 97, 24, 119, 124, 78, 45, 82, 134, 26, 93, 56, 28, 170, 30, 55, 189, 39, 251, 141, 44, 38, 39, 61, 53, 49, 195, 140, 19, 142 }, null, "+84928666158", "+84928666156", -1, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin" },
                    { 2, "Thành phố Cần Thơ", 2, null, null, null, 1, 917635678, -1, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "tranthib2001@gmail.com", "Trần Chí Dũng", null, new byte[] { 210, 254, 115, 204, 30, 139, 89, 147, 86, 123, 233, 60, 172, 165, 20, 171, 255, 33, 167, 224, 76, 181, 26, 217, 210, 136, 248, 129, 74, 149, 128, 155, 180, 164, 230, 244, 53, 95, 39, 228, 170, 240, 172, 82, 136, 199, 16, 24, 43, 127, 151, 100, 79, 199, 23, 239, 223, 102, 71, 34, 72, 152, 155, 81 }, new byte[] { 26, 182, 176, 205, 218, 242, 159, 117, 145, 83, 21, 202, 167, 115, 4, 197, 233, 167, 161, 248, 8, 178, 174, 23, 158, 184, 68, 24, 224, 236, 114, 239, 97, 6, 129, 224, 163, 174, 106, 243, 203, 247, 18, 196, 20, 151, 168, 233, 10, 170, 136, 169, 234, 148, 80, 214, 253, 45, 63, 136, 2, 150, 109, 210, 165, 134, 82, 221, 81, 177, 243, 110, 180, 127, 139, 62, 123, 196, 45, 22, 171, 255, 0, 24, 47, 119, 155, 18, 65, 214, 242, 81, 184, 211, 19, 61, 54, 208, 158, 97, 24, 119, 124, 78, 45, 82, 134, 26, 93, 56, 28, 170, 30, 55, 189, 39, 251, 141, 44, 38, 39, 61, 53, 49, 195, 140, 19, 142 }, null, "+84928666157", "+84928666158", -1, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "staff" },
                    { 3, "New York City", 3, null, null, null, 1, null, -1, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "thanhnguyendt2000@gmail.com", "John Smith", "123456789", new byte[] { 210, 254, 115, 204, 30, 139, 89, 147, 86, 123, 233, 60, 172, 165, 20, 171, 255, 33, 167, 224, 76, 181, 26, 217, 210, 136, 248, 129, 74, 149, 128, 155, 180, 164, 230, 244, 53, 95, 39, 228, 170, 240, 172, 82, 136, 199, 16, 24, 43, 127, 151, 100, 79, 199, 23, 239, 223, 102, 71, 34, 72, 152, 155, 81 }, new byte[] { 26, 182, 176, 205, 218, 242, 159, 117, 145, 83, 21, 202, 167, 115, 4, 197, 233, 167, 161, 248, 8, 178, 174, 23, 158, 184, 68, 24, 224, 236, 114, 239, 97, 6, 129, 224, 163, 174, 106, 243, 203, 247, 18, 196, 20, 151, 168, 233, 10, 170, 136, 169, 234, 148, 80, 214, 253, 45, 63, 136, 2, 150, 109, 210, 165, 134, 82, 221, 81, 177, 243, 110, 180, 127, 139, 62, 123, 196, 45, 22, 171, 255, 0, 24, 47, 119, 155, 18, 65, 214, 242, 81, 184, 211, 19, 61, 54, 208, 158, 97, 24, 119, 124, 78, 45, 82, 134, 26, 93, 56, 28, 170, 30, 55, 189, 39, 251, 141, 44, 38, 39, 61, 53, 49, 195, 140, 19, 142 }, null, "+12025550123", "+12027450123", -1, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "user1" }
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
                name: "IX_AppRoom_EquipmentId",
                table: "AppRoom",
                column: "EquipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_AppRoom_RoomTypeId",
                table: "AppRoom",
                column: "RoomTypeId");

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
                name: "AppWorkShift");

            migrationBuilder.DropTable(
                name: "AppComment");

            migrationBuilder.DropTable(
                name: "AppCategoryNews");

            migrationBuilder.DropTable(
                name: "AppOrder");

            migrationBuilder.DropTable(
                name: "MstPermission");

            migrationBuilder.DropTable(
                name: "AppWorkSchedule");

            migrationBuilder.DropTable(
                name: "AppRoom");

            migrationBuilder.DropTable(
                name: "AppUser");

            migrationBuilder.DropTable(
                name: "AppEquipment");

            migrationBuilder.DropTable(
                name: "AppRoomType");

            migrationBuilder.DropTable(
                name: "AppBranchHotel");

            migrationBuilder.DropTable(
                name: "AppRole");

            migrationBuilder.DropTable(
                name: "AppTypeEquipment");

            migrationBuilder.DropTable(
                name: "AppHotel");
        }
    }
}
