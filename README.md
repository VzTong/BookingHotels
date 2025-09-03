# 🏨 BookingHotels - Hệ Thống Đặt Phòng Khách Sạn

<div align="center">

[![.NET](https://img.shields.io/badge/.NET-8.0-purple?logo=dotnet)](https://dotnet.microsoft.com/)
[![Entity Framework](https://img.shields.io/badge/Entity%20Framework-Core-blue?logo=microsoft)](https://docs.microsoft.com/en-us/ef/)
[![SQL Server](https://img.shields.io/badge/SQL%20Server-2019+-orange?logo=microsoftsqlserver)](https://www.microsoft.com/en-us/sql-server)
[![Bootstrap](https://img.shields.io/badge/Bootstrap-5.0-purple?logo=bootstrap)](https://getbootstrap.com/)
[![AdminLTE](https://img.shields.io/badge/AdminLTE-3.0-green?logo=adminlte)](https://adminlte.io/)

*"Một project khiêm tốn nhưng đầy tự hào của dev nghiệp dư nhưng có chí hướng thượng" 😄*

</div>

---

## 🇻🇳 Tiếng Việt

### 📖 Giới Thiệu

Chào mừng đến với **BookingHotels** - một hệ thống đặt phòng khách sạn được xây dựng bằng ASP.NET Core MVC với niềm đam mê và... một chút cafe ☕. Đây không phải là Booking.com thế hệ mới đâu nhé, chỉ là một project sinh viên được làm với tình yêu thương và sự cần cù của đôi bàn tay non trẻ 😊.

### 🎯 Tính Năng Chính

#### 👥 Dành cho Khách Hàng:
- **🔐 Đăng ký/Đăng nhập**: Tạo tài khoản và đăng nhập với bảo mật
- **🔍 Tìm kiếm phòng**: Tìm phòng theo ngày, số người, loại phòng, giá
- **🏠 Xem chi tiết phòng**: Hình ảnh, mô tả, thiết bị, tiện nghi
- **📅 Đặt phòng**: Booking phòng với thông tin đầy đủ
- **📋 Quản lý đặt phòng**: Xem lịch sử booking, chi tiết đơn hàng
- **❌ Hủy đặt phòng**: Hủy booking với các điều kiện
- **⭐ Đánh giá & Comment**: Viết review, đánh giá khách sạn
- **📰 Xem tin tức**: Đọc tin tức du lịch, khuyến mãi
- **👤 Quản lý profile**: Cập nhật thông tin cá nhân, đổi mật khẩu

#### 🔧 Dành cho Admin:

**🏨 Quản Lý Khách Sạn:**
- **CRUD Hotels**: Thêm, sửa, xóa thông tin khách sạn
- **CRUD Branches**: Quản lý chi nhánh khách sạn
- **Upload Images**: Quản lý hình ảnh khách sạn

**🛏️ Quản Lý Phòng:**
- **CRUD Rooms**: Quản lý phòng (tên, giá, mô tả)
- **CRUD Room Types**: Quản lý loại phòng
- **CRUD Equipment**: Quản lý thiết bị, tiện nghi
- **CRUD Equipment Types**: Phân loại thiết bị
- **Room-Equipment Mapping**: Gán thiết bị cho phòng

**📦 Quản Lý Đơn Hàng:**
- **View Orders**: Xem tất cả đơn đặt phòng
- **Order Processing**: Xử lý, xác nhận đơn hàng
- **Order Details**: Xem chi tiết từng booking
- **Cancel Orders**: Hủy đơn hàng với lý do

**👥 Quản Lý Người Dùng:**
- **CRUD Users**: Quản lý tài khoản người dùng
- **Role Management**: Phân quyền theo vai trò
- **Permission Control**: Kiểm soát quyền truy cập
- **User Analytics**: Thống kê người dùng

**📰 Quản Lý Tin Tức:**
- **CRUD News**: Đăng, sửa, xóa tin tức
- **News Categories**: Quản lý danh mục tin tức
- **Content Management**: Quản lý nội dung bài viết

**💬 Quản Lý Comment:**
- **View Comments**: Xem tất cả đánh giá
- **Moderate Comments**: Duyệt, xóa comment
- **Response Management**: Trả lời đánh giá

**📊 Báo Cáo & Thống Kê:**
- **Revenue Reports**: Báo cáo doanh thu
- **Booking Statistics**: Thống kê đặt phòng

### 🏗️ Kiến Trúc & Công Nghệ

#### 📂 Cấu Trúc Project (3-Layer Architecture):

```
📁 BookingHotels/
├── 🗃️ App.Data/          # Data Access Layer
│   ├── Entities/         # Domain Models
│   ├── Configurations/   # EF Configurations
│   ├── Repositories/     # Repository Pattern
│   ├── DataSeeders/      # Sample Data
│   └── Migrations/       # EF Migrations
├── 🔧 App.Share/         # Shared Components
│   ├── Attributes/       # Custom Validation
│   ├── Extensions/       # Helper Methods
│   └── Consts/          # Constants
└── 🌐 App.Web/          # Presentation Layer
    ├── Areas/Admin/      # Admin Panel
    ├── Controllers/      # MVC Controllers
    ├── Views/           # Razor Views
    ├── ViewModels/      # Data Transfer Objects
    ├── Services/        # Business Logic
    └── wwwroot/         # Static Files
```

#### 💻 Stack Công Nghệ:

**Backend:**
- **.NET 8.0** - Framework chính (mới nhất đấy!)
- **ASP.NET Core MVC** - Web framework
- **Entity Framework Core** - ORM cho database
- **SQL Server** - Database chính
- **AutoMapper** - Object mapping
- **Repository Pattern** - Data access pattern
- **Code-First Migrations** - Database versioning
- **Entity Configuration** - Fluent API configurations
- **Data Seeding** - Tự động tạo sample data
- **Constants Management** - Quản lý hằng số tập trung

**Frontend:**
- **Razor Pages** - Server-side rendering
- **Bootstrap 5** - CSS framework
- **AdminLTE 3** - Admin template
- **jQuery** - JavaScript library
- **toastr/Notyf** - Notifications

**Features:**
- **Authentication & Authorization** - Bảo mật đăng nhập
- **Role-based Access** - Phân quyền theo vai trò
- **Email Service** - Hệ thống gửi mail (đã chuẩn bị, chưa active)
- **File Upload** - Upload hình ảnh
- **Pagination** - Phân trang dữ liệu
- **Validation** - Validate form đầy đủ
- **Custom Attributes** - Validation attributes tự tạo
- **Extension Methods** - Helper methods tiện ích

### 🛠️ Cài Đặt & Chạy Project

#### 📋 Yêu Cầu Hệ Thống:
- **Windows 10/11** (hoặc macOS/Linux nếu bạn thích phiêu lưu)
- **.NET 8.0 SDK** - [Tải về](https://dotnet.microsoft.com/download)
- **SQL Server 2019+** hoặc **SQL Server LocalDB**
- **Visual Studio 2022** hoặc **VS Code** (khuyến nghị VS 2022)

#### 🚀 Các Bước Cài Đặt:

1. **Clone Repository:**
   ```bash
   git clone https://github.com/VzTong/BookingHotels.git
   cd BookingHotels
   ```

2. **Cấu Hình Database:**
   - Mở `App.Web/appsettings.json`
   - Sửa connection string:
   ```json
   "ConnectionStrings": {
     "Database": "Server=TÊN_SERVER;Database=BookingHotelPJ;Trusted_Connection=True;Encrypt=false;"
   }
   ```

3. **Restore NuGet Packages:**
   ```bash
   dotnet restore
   ```

4. **Tạo Database & Migration:**
   ```bash
   cd App.Data
   dotnet ef database update
   ```
   *Database sẽ tự động tạo với sample data nhé!*

5. **Chạy Application:**
   ```bash
   cd ../App.Web
   dotnet run
   ```
   Hoặc nhấn **F5** trong Visual Studio

6. **Truy Cập Ứng Dụng:**
   - **Client:** `https://localhost:5001`
   - **Admin:** `https://localhost:5001/Admin`
   - **Admin Login:** `admin@hotel.com` / `123456`

#### ⚙️ Cấu Hình Tùy Chọn:

**Email Service (Đã chuẩn bị sẵn - chưa active):**
Project đã có đầy đủ mail system nhưng chưa được kích hoạt. Để enable:
```json
"Mail": {
  "Email": "your-email@gmail.com",
  "Password": "your-app-password",
  "SmtpServer": "smtp.gmail.com",
  "Port": 465,
  "Signature": "Được gửi từ BookingHotels System"
}
```
*Lưu ý: Cần implement thêm logic gửi mail trong controllers*

### 🗄️ Database Schema

Hệ thống sử dụng **Code-First approach** với Entity Framework:

#### 📋 Entities:
- **Users**: Quản lý người dùng và phân quyền
- **Hotels & Branches**: Thông tin khách sạn và chi nhánh
- **Rooms**: Phòng, loại phòng, thiết bị
- **Orders**: Đơn đặt phòng và chi tiết
- **News**: Tin tức và danh mục
- **Comments**: Đánh giá của khách hàng

#### 🔧 Technical Features:
- **Entity Configurations**: Sử dụng Fluent API trong thư mục `Configurations/`
- **Data Seeders**: Tự động tạo data mẫu với các `*Seeder.cs` files
- **Migrations**: EF Core migrations cho version control database
- **Base Entity**: Tất cả entity kế thừa `AppEntityBase` với audit fields
- **Value Generators**: Custom value generators (VD: `RoomNameValueGenerator`)

#### 📊 Audit Trail:
Mọi entity đều có các field chuẩn:
```csharp
public abstract class AppEntityBase
{
    public int Id { get; set; }
    public int? DisplayOrder { get; set; }
    public int? CreatedBy { get; set; }
    public int? UpdatedBy { get; set; }
    public DateTime? CreatedDate { get; set; }
    public DateTime? UpdatedDate { get; set; }
    public DateTime? DeletedDate { get; set; } // Soft Delete
}
```

### 📝 CRUD Operations

Hệ thống triển khai **đầy đủ CRUD** cho tất cả entities:

#### 🏗️ Repository Pattern:
- **Generic Repository** với các operations cơ bản
- **Async/Await** operations cho performance
- **Pagination** và **Filtering**
- **Soft Delete** (sử dụng DeletedDate)
- **Audit Trail** (CreatedBy, UpdatedBy, etc.)

#### 🔧 Technical Implementation:
- **Entity Configurations**: Fluent API configs trong `App.Data/Configurations/`
- **Data Seeding**: Auto-seed data với `App.Data/DataSeeders/`
- **Constants Management**: Centralized constants trong `App.Share/Consts/`
- **Custom Validation**: Custom attributes trong `App.Share/Attributes/`
- **Extension Methods**: Utility methods trong `App.Share/Extensions/`
- **Repository Files**:
  - `GenericRepository.cs` - Base repository
  - `GenericRepository.Add.cs` - Create operations
  - `GenericRepository.GetAll.cs` - Read operations
  - `GenericRepository.Update.cs` - Update operations
  - `GenericRepository.Delete.cs` - Delete operations
  - `GenericRepository.Helpers.cs` - Utility methods

#### 📊 Validation System:
Custom validation attributes được tạo riêng:
- `AppRequiredAttribute` - Required validation
- `AppEmailAttribute` - Email validation
- `AppPhoneAttribute` - Phone validation
- `AppStringLengthAttribute` - String length validation
- `AppConfirmPwdAttribute` - Password confirmation
- Và nhiều custom attributes khác...

### 🎨 UI/UX Design

- **Responsive Design** - Tương thích mọi thiết bị
- **AdminLTE** - Giao diện admin đẹp và chuyên nghiệp
- **Bootstrap 5** - UI components hiện đại
- **Toast Notifications** - Thông báo user-friendly

---

## 🇺🇸 English

### 📖 Introduction

Welcome to **BookingHotels** - a hotel booking system built with ASP.NET Core MVC with passion and... a little bit of coffee ☕. This isn't the next-gen Booking.com, just a student project made with love and the diligence of young, eager hands 😊.

### 🎯 Key Features

#### 👥 For Customers:
- **🔐 Registration/Login**: Create account and secure login
- **🔍 Room Search**: Find rooms by date, guests, room type, price
- **🏠 Room Details**: View images, descriptions, equipment, amenities
- **📅 Room Booking**: Book rooms with complete information
- **📋 Booking Management**: View booking history, order details
- **❌ Cancel Booking**: Cancel bookings with conditions
- **⭐ Reviews & Comments**: Write reviews, rate hotels
- **📰 News Reading**: Browse travel news and promotions
- **👤 Profile Management**: Update personal info, change password

#### 🔧 For Admins:

**🏨 Hotel Management:**
- **CRUD Hotels**: Add, edit, delete hotel information
- **CRUD Branches**: Manage hotel branches
- **Upload Images**: Manage hotel images

**🛏️ Room Management:**
- **CRUD Rooms**: Manage rooms (name, price, description)
- **CRUD Room Types**: Manage room types
- **CRUD Equipment**: Manage equipment and amenities
- **CRUD Equipment Types**: Categorize equipment
- **Room-Equipment Mapping**: Assign equipment to rooms

**📦 Order Management:**
- **View Orders**: View all booking orders
- **Order Processing**: Process and confirm orders
- **Order Details**: View detailed booking information
- **Cancel Orders**: Cancel orders with reasons

**👥 User Management:**
- **CRUD Users**: Manage user accounts
- **Role Management**: Assign roles and permissions
- **Permission Control**: Access control management
- **User Analytics**: User statistics

**📰 News Management:**
- **CRUD News**: Post, edit, delete news articles
- **News Categories**: Manage news categories
- **Content Management**: Manage article content

**💬 Comment Management:**
- **View Comments**: View all reviews and ratings
- **Moderate Comments**: Approve, delete comments
- **Response Management**: Reply to reviews

**📊 Reports & Analytics:**
- **Revenue Reports**: Revenue reporting
- **Booking Statistics**: Booking analytics

### 🏗️ Architecture & Technology

#### 📂 Project Structure (3-Layer Architecture):

```
📁 BookingHotels/
├── 🗃️ App.Data/          # Data Access Layer
│   ├── Entities/         # Domain Models
│   ├── Configurations/   # EF Configurations
│   ├── Repositories/     # Repository Pattern
│   ├── DataSeeders/      # Sample Data
│   └── Migrations/       # EF Migrations
├── 🔧 App.Share/         # Shared Components
│   ├── Attributes/       # Custom Validation
│   ├── Extensions/       # Helper Methods
│   └── Consts/          # Constants
└── 🌐 App.Web/          # Presentation Layer
    ├── Areas/Admin/      # Admin Panel
    ├── Controllers/      # MVC Controllers
    ├── Views/           # Razor Views
    ├── ViewModels/      # Data Transfer Objects
    ├── Services/        # Business Logic
    └── wwwroot/         # Static Files
```

#### 💻 Technology Stack:

**Backend:**
- **.NET 8.0** - Main framework (latest!)
- **ASP.NET Core MVC** - Web framework
- **Entity Framework Core** - Database ORM
- **SQL Server** - Primary database
- **AutoMapper** - Object mapping
- **Repository Pattern** - Data access pattern
- **Code-First Migrations** - Database versioning
- **Entity Configuration** - Fluent API configurations
- **Data Seeding** - Automatic sample data generation
- **Constants Management** - Centralized constants handling

**Frontend:**
- **Razor Pages** - Server-side rendering
- **Bootstrap 5** - CSS framework
- **AdminLTE 3** - Admin template
- **jQuery** - JavaScript library
- **toastr/Notyf** - Notifications

**Features:**
- **Authentication & Authorization** - Secure login
- **Role-based Access** - Role-based permissions
- **Email Service** - Email system (prepared, not active yet)
- **File Upload** - Image uploads
- **Pagination** - Data pagination
- **Validation** - Complete form validation
- **Custom Attributes** - Custom validation attributes
- **Extension Methods** - Utility helper methods

### 🛠️ Installation & Setup

#### 📋 System Requirements:
- **Windows 10/11** (or macOS/Linux if you're adventurous)
- **.NET 8.0 SDK** - [Download](https://dotnet.microsoft.com/download)
- **SQL Server 2019+** or **SQL Server LocalDB**
- **Visual Studio 2022** or **VS Code** (VS 2022 recommended)

#### 🚀 Installation Steps:

1. **Clone Repository:**
   ```bash
   git clone https://github.com/VzTong/BookingHotels.git
   cd BookingHotels
   ```

2. **Configure Database:**
   - Open `App.Web/appsettings.json`
   - Update connection string:
   ```json
   "ConnectionStrings": {
     "Database": "Server=YOUR_SERVER;Database=BookingHotelPJ;Trusted_Connection=True;Encrypt=false;"
   }
   ```

3. **Restore NuGet Packages:**
   ```bash
   dotnet restore
   ```

4. **Create Database & Apply Migrations:**
   ```bash
   cd App.Data
   dotnet ef database update
   ```
   *Database will be created automatically with sample data!*

5. **Run Application:**
   ```bash
   cd ../App.Web
   dotnet run
   ```
   Or press **F5** in Visual Studio

6. **Access Application:**
   - **Client:** `https://localhost:5001`
   - **Admin:** `https://localhost:5001/Admin`
   - **Admin Login:** `admin@hotel.com` / `123456`

#### ⚙️ Optional Configuration:

**Email Service (Prepared - not active yet):**
Project has complete mail system but not activated. To enable:
```json
"Mail": {
  "Email": "your-email@gmail.com",
  "Password": "your-app-password",
  "SmtpServer": "smtp.gmail.com",
  "Port": 465,
  "Signature": "Sent from BookingHotels System"
}
```
*Note: Need to implement mail sending logic in controllers*

### 🗄️ Database Schema

The system uses **Code-First approach** with Entity Framework:

#### 📋 Entities:
- **Users**: User management and permissions
- **Hotels & Branches**: Hotel and branch information
- **Rooms**: Rooms, room types, equipment
- **Orders**: Booking orders and details
- **News**: News and categories
- **Comments**: Customer reviews

#### 🔧 Technical Features:
- **Entity Configurations**: Using Fluent API in `Configurations/` folder
- **Data Seeders**: Automatic sample data generation with `*Seeder.cs` files
- **Migrations**: EF Core migrations for database version control
- **Base Entity**: All entities inherit from `AppEntityBase` with audit fields
- **Value Generators**: Custom value generators (e.g., `RoomNameValueGenerator`)

#### 📊 Audit Trail:
All entities have standard fields:
```csharp
public abstract class AppEntityBase
{
    public int Id { get; set; }
    public int? DisplayOrder { get; set; }
    public int? CreatedBy { get; set; }
    public int? UpdatedBy { get; set; }
    public DateTime? CreatedDate { get; set; }
    public DateTime? UpdatedDate { get; set; }
    public DateTime? DeletedDate { get; set; } // Soft Delete
}
```

### 📝 CRUD Operations

The system implements **complete CRUD** for all entities:

#### 🏗️ Repository Pattern:
- **Generic Repository** with basic operations
- **Async/Await** operations for performance
- **Pagination** and **Filtering**
- **Soft Delete** (using DeletedDate)
- **Audit Trail** (CreatedBy, UpdatedBy, etc.)

#### 🔧 Technical Implementation:
- **Entity Configurations**: Fluent API configs in `App.Data/Configurations/`
- **Data Seeding**: Auto-seed data with `App.Data/DataSeeders/`
- **Constants Management**: Centralized constants in `App.Share/Consts/`
- **Custom Validation**: Custom attributes in `App.Share/Attributes/`
- **Extension Methods**: Utility methods in `App.Share/Extensions/`
- **Repository Files**:
  - `GenericRepository.cs` - Base repository
  - `GenericRepository.Add.cs` - Create operations
  - `GenericRepository.GetAll.cs` - Read operations
  - `GenericRepository.Update.cs` - Update operations
  - `GenericRepository.Delete.cs` - Delete operations
  - `GenericRepository.Helpers.cs` - Utility methods

#### 📊 Validation System:
Custom validation attributes created specifically:
- `AppRequiredAttribute` - Required validation
- `AppEmailAttribute` - Email validation
- `AppPhoneAttribute` - Phone validation
- `AppStringLengthAttribute` - String length validation
- `AppConfirmPwdAttribute` - Password confirmation
- And many other custom attributes...

### 🎨 UI/UX Design

- **Responsive Design** - Compatible with all devices
- **AdminLTE** - Beautiful and professional admin interface
- **Bootstrap 5** - Modern UI components
- **Toast Notifications** - User-friendly notifications

---

## 👥 Team & Contributors

### 🇻🇳 Đội Ngũ Phát Triển:
- **🚀 VzTong** - *Team Lead & Backend Developer*
  - Phụ trách architecture, database design, business logic
  - Hỗ trợ frontend development cho team member

- **💻 nhuy456** - *Frontend Developer*
  - Phụ trách UI/UX cho phần User Interface
  - Tạo nên những trải nghiệm người dùng mượt mà
  - "Bàn tay vàng trong làng frontend" ✨

### 🎨 Special Thanks:
- **Admin Template**: Sử dụng AdminLTE 3.0 - một template tuyệt vời
- **Mentor**: Cảm ơn những người thầy đã hướng dẫn và chia sẻ kinh nghiệm quý báu

### 🇺🇸 Development Team:
- **🚀 VzTong** - *Team Lead & Backend Developer*
  - Responsible for architecture, database design, business logic
  - Supporting frontend development for team member

- **💻 nhuy456** - *Frontend Developer*
  - Responsible for User Interface UI/UX
  - Creating smooth user experiences
  - "The golden hand in frontend development" ✨

### 🎨 Special Thanks:
- **Admin Template**: Using AdminLTE 3.0 - an amazing template
- **Mentors**: Thanks to the teachers who guided and shared valuable experiences

## 🤝 Contributing

Mặc dù đây là project sinh viên, nhưng chúng tôi vẫn hoan nghênh mọi đóng góp! Nếu bạn phát hiện bug hoặc có ý tưởng cải thiện, hãy tạo **Issue** hoặc **Pull Request**.

*Although this is a student project, we welcome all contributions! If you find bugs or have improvement ideas, please create an **Issue** or **Pull Request**.*

## 📞 Liên Hệ / Contact

- **Team Lead & Backend Developer**: VzTong
- **Frontend Dev**: nhuy456
- **Repository**: [BookingHotels](https://github.com/VzTong/BookingHotels)
- **Issues**: [Report bugs here](https://github.com/VzTong/BookingHotels/issues)

---

<div align="center">

**⭐ Nếu project này hữu ích, đừng quên cho một star nhé! / If this project is helpful, don't forget to give it a star!**

*"Code như cuộc sống - không hoàn hảo nhưng đầy hy vọng!" 🌟*

</div>