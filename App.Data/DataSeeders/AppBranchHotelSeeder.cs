using App.Data.Entities.Hotel;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Data.DataSeeders
{
    public static class AppBranchHotelSeeder
    {
        public static void SeedData(this EntityTypeBuilder<AppBranchHotel> builder)
        {
            var now = new DateTime(year: 2024, month: 10, day: 10);

            builder.HasData(
                new AppBranchHotel
                {
                    Id = 1,
                    Name = "Hà Nội - Melia Hà Nội",
                    Slug = "ha-noi-melia-ha-noi",
                    Address = "123 Phố Lý Thái Tổ, Quận Hoàn Kiếm, Hà Nội, Việt Nam",
                    QuantityStaff = 20,
                    QuantityRoom = 50,
                    CreatedDate = now,
                    HotelId = 1, // Khách Sạn Melia Hà Nội
                    Img = "https://hoanghamobile.com/tin-tuc/wp-content/uploads/2024/04/anh-ha-noi.jpg",
                    Description = "Chi nhánh của Melia Hà Nội tại Hà Nội"
                },
                new AppBranchHotel
                {
                    Id = 2,
                    Name = "TP. Hồ Chí Minh - Rex Hotel Sài Gòn",
                    Slug = "tp-ho-chi-minh-rex-hotel-sai-gon",
                    Address = "456 Đường Nguyễn Huệ, Phường Bến Nghé, Quận 1, TP. Hồ Chí Minh, Việt Nam",
                    QuantityStaff = 25,
                    QuantityRoom = 80,
                    CreatedDate = now,
                    HotelId = 2, // Rex Hotel Sài Gòn
                    Img = "https://cdnphoto.dantri.com.vn/JpeCWtGF6QU37njc1xDZc4wOKbM=/2021/04/28/ubnd-tp-1619582754877.jpg",
                    Description = "Chi nhánh của Rex Hotel Sài Gòn tại TP. Hồ Chí Minh"
                },
                new AppBranchHotel
                {
                    Id = 3,
                    Name = "Đà Nẵng - Golden Bay",
                    Slug = "da-nang-golden-bay",
                    Address = "789 Đường Bạch Đằng, Phường Hải Châu, Đà Nẵng, Việt Nam",
                    QuantityStaff = 15,
                    QuantityRoom = 40,
                    CreatedDate = now,
                    HotelId = 3, // Khách Sạn Đà Nẵng Golden Bay
                    Img = "https://images2.thanhnien.vn/528068263637045248/2023/4/23/cau-vang-da-nang-16822248307311159361992.jpg",
                    Description = "Chi nhánh của Đà Nẵng Golden Bay tại Đà Nẵng"
                },
                new AppBranchHotel
                {
                    Id = 4,
                    Name = "Nha Trang - Lodge",
                    Slug = "nha-trang-lodge",
                    Address = "101 Đường Trần Phú, Thành phố Nha Trang, Khánh Hòa, Việt Nam",
                    QuantityStaff = 18,
                    QuantityRoom = 60,
                    CreatedDate = now,
                    HotelId = 4, // Khách Sạn Nha Trang Lodge
                    Img = "https://scontent.fvca1-1.fna.fbcdn.net/v/t1.6435-9/105491263_2363218890638032_4176841546494313648_n.jpg?_nc_cat=106&ccb=1-7&_nc_sid=2285d6&_nc_ohc=Am6nyPLhFTAQ7kNvgGcHsrl&_nc_zt=23&_nc_ht=scontent.fvca1-1.fna&_nc_gid=AdC-QhHD7kjqPE3Z4nZe9VW&oh=00_AYDLGhjVb-QnzZuzypqiIqVj_rcPwHBSosH70XxLoibW4g&oe=674CB979",
                    Description = "Chi nhánh của Nha Trang Lodge tại Nha Trang"
                },
                new AppBranchHotel
                {
                    Id = 5,
                    Name = "Hải Phòng - Imperial",
                    Slug = "hai-phong-imperial",
                    Address = "202 Đường Lê Đại Hành, Quận Hồng Bàng, Hải Phòng, Việt Nam",
                    QuantityStaff = 12,
                    QuantityRoom = 30,
                    CreatedDate = now,
                    HotelId = 5, // Khách Sạn Imperial Hải Phòng
                    Img = "https://i0.wp.com/heza.gov.vn/wp-content/uploads/2023/10/hai_phong-scaled.jpg?fit=2560%2C1662&ssl=1",
                    Description = "Chi nhánh của Imperial Hải Phòng tại Hải Phòng"
                },
                new AppBranchHotel
                {
                    Id = 6,
                    Name = "New York - Langham",
                    Slug = "new-york-langham",
                    Address = "600 Đường 5th Ave, New York, NY 10020, USA",
                    QuantityStaff = 40,
                    QuantityRoom = 100,
                    CreatedDate = now,
                    HotelId = 6, // Khách Sạn Langham, New York
                    Img = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/05/View_of_Empire_State_Building_from_Rockefeller_Center_New_York_City_dllu.jpg/800px-View_of_Empire_State_Building_from_Rockefeller_Center_New_York_City_dllu.jpg",
                    Description = "Chi nhánh của Langham Hotel tại New York"
                },
                new AppBranchHotel
                {
                    Id = 7,
                    Name = "Tokyo - The Peninsula Tokyo",
                    Slug = "tokyo-the-peninsula-tokyo",
                    Address = "123 Đường Chuo, Minato City, Tokyo, Nhật Bản",
                    QuantityStaff = 35,
                    QuantityRoom = 90,
                    CreatedDate = now,
                    HotelId = 7, // Khách Sạn The Peninsula Tokyo
                    Img = "https://www.agoda.com/wp-content/uploads/2024/06/tokyo-japan-1244x700.jpg",
                    Description = "Chi nhánh của The Peninsula Tokyo tại Tokyo"
                },
                new AppBranchHotel
                {
                    Id = 8,
                    Name = "Cancun - The Ritz-Carlton",
                    Slug = "cancun-the-ritz-carlton",
                    Address = "700 Boulevard Kukulcan, Cancun, Mexico",
                    QuantityStaff = 30,
                    QuantityRoom = 75,
                    CreatedDate = now,
                    HotelId = 8, // Khách Sạn The Ritz-Carlton, Cancun
                    Img = "https://pantravel.vn/wp-content/uploads/2024/01/cancun-thien-duong-nghi-duong-hang-dau-mexico.jpg",
                    Description = "Chi nhánh của The Ritz-Carlton tại Cancun"
                },
                new AppBranchHotel
                {
                    Id = 9,
                    Name = "Miami - The Biltmore Miami",
                    Slug = "miami-the-biltmore-miami",
                    Address = "500 South Florida Avenue, Miami, FL 33131, USA",
                    QuantityStaff = 28,
                    QuantityRoom = 60,
                    CreatedDate = now,
                    HotelId = 9, // Khách Sạn The Biltmore Miami
                    Img = "https://a.travel-assets.com/findyours-php/viewfinder/images/res70/471000/471674-Miami.jpg",
                    Description = "Chi nhánh của The Biltmore Miami tại Miami"
                },
                new AppBranchHotel
                {
                    Id = 10,
                    Name = "Paris - Shangri-La",
                    Slug = "paris-shangri-la",
                    Address = "70 Avenue de La Bourdonnais, 75007 Paris, Pháp",
                    QuantityStaff = 45,
                    QuantityRoom = 110,
                    CreatedDate = now,
                    HotelId = 10, // Khách Sạn Shangri-La, Paris
                    Img = "https://media.timeout.com/images/106181719/image.jpg",
                    Description = "Chi nhánh của Shangri-La tại Paris"
                },
                new AppBranchHotel
                {
                    Id = 11,
                    Name = "Seoul - Grand Hyatt Seoul",
                    Slug = "seoul-grand-hyatt-seoul",
                    Address = "747-7, Sinsa-dong, Gangnam-gu, Seoul, Hàn Quốc",
                    QuantityStaff = 50,
                    QuantityRoom = 120,
                    CreatedDate = now,
                    HotelId = 11, // Khách Sạn Grand Hyatt Seoul
                    Img = "https://booking.pystravel.vn/uploads/posts/avatar/1693995460.jpg",
                    Description = "Chi nhánh của Grand Hyatt tại Seoul"
                },
                new AppBranchHotel
                {
                    Id = 12,
                    Name = "Bangkok - Four Seasons",
                    Slug = "bangkok-four-seasons",
                    Address = "123, 123/1-3, Thanon Ratchadamri, Lumphini, Pathum Wan, Bangkok, Thái Lan",
                    QuantityStaff = 32,
                    QuantityRoom = 80,
                    CreatedDate = now,
                    HotelId = 12, // Khách Sạn Four Seasons Bangkok
                    Img = "https://owa.bestprice.vn/images/destinations/uploads/bangkok-543c92d75fddd.jpg",
                    Description = "Chi nhánh của Four Seasons tại Bangkok"
                },
                new AppBranchHotel
                {
                    Id = 13,
                    Name = "Tokyo - Hilton",
                    Slug = "tokyo-hilton",
                    Address = "2-6-1 Nishishinjuku, Shinjuku City, Tokyo, Nhật Bản",
                    QuantityStaff = 38,
                    QuantityRoom = 95,
                    CreatedDate = now,
                    HotelId = 13, // Khách Sạn Hilton Tokyo
                    Img = "https://media.cntraveler.com/photos/63482b255e7943ad4006df0b/16:9/w_2560%2Cc_limit/tokyoGettyImages-1031467664.jpeg",
                    Description = "Chi nhánh của Hilton tại Tokyo"
                },
                new AppBranchHotel
                {
                    Id = 14,
                    Name = "Hong Kong - W Hong Kong",
                    Slug = "hong-kong-w-hong-kong",
                    Address = "1 Austin Road West, Tsim Sha Tsui, Hong Kong",
                    QuantityStaff = 55,
                    QuantityRoom = 130,
                    CreatedDate = now,
                    HotelId = 14, // Khách Sạn W Hong Kong
                    Img = "https://www.discoverhongkong.com/content/dam/dhk/intl/explore/attractions/the-charm-of-the-bright-city/the-charm-of-the-bright-city-1920x1080.jpg",
                    Description = "Chi nhánh của W Hong Kong tại Hong Kong"
                },
                new AppBranchHotel
                {
                    Id = 15,
                    Name = "Bali - The St. Regis",
                    Slug = "bali-the-st-regis",
                    Address = "Nusa Dua, Bali, Indonesia",
                    QuantityStaff = 22,
                    QuantityRoom = 70,
                    CreatedDate = now,
                    HotelId = 15, // Khách Sạn The St. Regis Bali
                    Img = "https://www.travelandleisure.com/thmb/KE0vV7K8Ngvc_7j-_FGx_jCUdCM=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc()/TAL-bali-lead-image-BALITG1223-101f43c88c044081a4558b737afbd094.jpg",
                    Description = "Chi nhánh của The St. Regis tại Bali"
                },
                new AppBranchHotel
                {
                    Id = 16,
                    Name = "Bangkok - Mandarin Oriental",
                    Slug = "bangkok-mandarin-oriental",
                    Address = "48-5, Thanon Ruam Rudee, Lumphini, Pathum Wan, Bangkok, Thái Lan",
                    QuantityStaff = 35,
                    QuantityRoom = 85,
                    CreatedDate = now,
                    HotelId = 16, // Khách Sạn Mandarin Oriental Bangkok
                    Img = "https://a0.muscache.com/im/pictures/INTERNAL/INTERNAL-ImageByPlaceId-ChIJ82ENKDJgHTERIEjiXbIAAQE-large_background/original/af044017-e151-4e68-bc01-e79bae614523.jpeg",
                    Description = "Chi nhánh của Mandarin Oriental tại Bangkok"
                },
                new AppBranchHotel
                {
                    Id = 17,
                    Name = "Paris - Le Meurice",
                    Slug = "paris-le-meurice",
                    Address = "228 Rue de Rivoli, 75001 Paris, Pháp",
                    QuantityStaff = 60,
                    QuantityRoom = 140,
                    CreatedDate = now,
                    HotelId = 17, // Khách Sạn Le Meurice, Paris
                    Img = "https://www.vn.kayak.com/rimg/dimg/bd/d1/2f268866-city-36014-162f82486f9.jpg?width=1366&height=768&xhint=2485&yhint=1564&crop=true",
                    Description = "Chi nhánh của Le Meurice tại Paris"
                },
                new AppBranchHotel
                {
                    Id = 18,
                    Name = "Mumbai - The Oberoi",
                    Slug = "mumbai-the-oberoi",
                    Address = "Balaji Towers, Juhu Beach, Mumbai, Ấn Độ",
                    QuantityStaff = 30,
                    QuantityRoom = 75,
                    CreatedDate = now,
                    HotelId = 18, // Khách Sạn The Oberoi, Mumbai
                    Img = "https://www.agoda.com/wp-content/uploads/2024/04/Chatrapati-Shivaji-Mumbai-India.jpg",
                    Description = "Chi nhánh của The Oberoi tại Mumbai"
                },
                new AppBranchHotel
                {
                    Id = 19,
                    Name = "Sydney - Park Hyatt",
                    Slug = "sydney-park-hyatt",
                    Address = "7 Hickson Rd, Millers Point, Sydney, Australia",
                    QuantityStaff = 29,
                    QuantityRoom = 60,
                    CreatedDate = now,
                    HotelId = 19, // Khách Sạn Park Hyatt Sydney
                    Img = "https://media.tatler.com/photos/6141d37b9ce9874a3e40107d/16:9/w_1280,c_limit/social_crop_sydney_opera_house_gettyimages-869714270.jpg",
                    Description = "Chi nhánh của Park Hyatt tại Sydney"
                },
                new AppBranchHotel
                {
                    Id = 20,
                    Name = "Bangkok - The Sukhothai",
                    Slug = "bangkok-the-sukhothai",
                    Address = "5/5-7 Thanon Sukhumvit 23, Khlong Toei Nuea, Watthana, Bangkok, Thái Lan",
                    QuantityStaff = 33,
                    QuantityRoom = 80,
                    CreatedDate = now,
                    HotelId = 20, // Khách Sạn The Sukhothai Bangkok
                    Img = "https://toplist.vn/images/800px/bangkok-thai-lan-1072633.jpg",
                    Description = "Chi nhánh của The Sukhothai tại Bangkok"
                },
                new AppBranchHotel
                {
                    Id = 21,
                    Name = "Paris - Ritz",
                    Slug = "paris-ritz",
                    Address = "15 Place Vendôme, 75001 Paris, Pháp",
                    QuantityStaff = 50,
                    QuantityRoom = 125,
                    CreatedDate = now,
                    HotelId = 21, // Khách Sạn Ritz Paris
                    Img = "https://i2.ex-cdn.com/crystalbay.com/files/content/2024/07/29/du-lich-paris-1-1540.jpg",
                    Description = "Chi nhánh của Ritz Paris tại Paris"
                },
                new AppBranchHotel
                {
                    Id = 22,
                    Name = "Mumbai - Taj Mahal Palace",
                    Slug = "mumbai-taj-mahal-palace",
                    Address = "Mahalaxmi, Mumbai, Ấn Độ",
                    QuantityStaff = 30,
                    QuantityRoom = 75,
                    CreatedDate = now,
                    HotelId = 22, // Khách Sạn Taj Mahal Palace, Mumbai
                    Img = "https://thvl.vn/wp-content/uploads/2024/03/Mumbai-tr%E1%BB%9F-th%C3%A0nh-th%C3%A0nh-ph%E1%BB%91-c%C3%B3-nhi%E1%BB%81u-t%E1%BB%B7-ph%C3%BA-nh%E1%BA%A5t-ch%C3%A2u-%C3%81-scaled.jpg",
                    Description = "Chi nhánh của Taj Mahal Palace tại Mumbai"
                },
                new AppBranchHotel
                {
                    Id = 23,
                    Name = "New York - St. Regis",
                    Slug = "new-york-st-regis",
                    Address = "New York, USA",
                    QuantityStaff = 42,
                    QuantityRoom = 110,
                    CreatedDate = now,
                    HotelId = 23, // Khách Sạn St. Regis New York
                    Img = "https://jtravel.com.vn/wp-content/uploads/2023/11/new-york.jpg",
                    Description = "Chi nhánh của St. Regis tại New York"
                },
                new AppBranchHotel
                {
                    Id = 24,
                    Name = "Dubai - Jumeirah",
                    Slug = "dubai-jumeirah",
                    Address = "Dubai, UAE",
                    QuantityStaff = 50,
                    QuantityRoom = 150,
                    CreatedDate = now,
                    HotelId = 24, // Khách Sạn Jumeirah, Dubai
                    Img = "https://lp-cms-production.imgix.net/features/2017/09/dubai-marina-skyline-2c8f1708f2a1.jpg?w=1440&h=810&fit=crop&auto=format&q=75",
                    Description = "Chi nhánh của Jumeirah tại Dubai"
                },
                new AppBranchHotel
                {
                    Id = 25,
                    Name = "Italy - Belmond Hotel Caruso",
                    Slug = "italy-belmond-hotel-caruso",
                    Address = "Italy",
                    QuantityStaff = 28,
                    QuantityRoom = 60,
                    CreatedDate = now,
                    HotelId = 25, // Khách Sạn Belmond Hotel Caruso
                    Img = "https://cdn.britannica.com/82/195482-050-2373E635/Amalfi-Italy.jpg",
                    Description = "Chi nhánh của Belmond Hotel Caruso tại Italy"
                },
                new AppBranchHotel
                {
                    Id = 26,
                    Name = "Phuket - Banyan Tree",
                    Slug = "phuket-banyan-tree",
                    Address = "Phuket, Thái Lan",
                    QuantityStaff = 30,
                    QuantityRoom = 75,
                    CreatedDate = now,
                    HotelId = 26, // Khách Sạn Banyan Tree, Phuket
                    Img = "https://media-cdn.tripadvisor.com/media/photo-m/1280/1b/4b/5d/c8/caption.jpg",
                    Description = "Chi nhánh của Banyan Tree tại Phuket"
                },
                new AppBranchHotel
                {
                    Id = 27,
                    Name = "Dubai - The Address",
                    Slug = "dubai-the-address",
                    Address = "Dubai, UAE",
                    QuantityStaff = 45,
                    QuantityRoom = 120,
                    CreatedDate = now,
                    HotelId = 27, // Khách Sạn The Address, Dubai
                    Img = "https://www.agoda.com/wp-content/uploads/2024/04/Featured-image-Dubai-UAE-1244x700.jpg",
                    Description = "Chi nhánh của The Address tại Dubai"
                },
                new AppBranchHotel
                {
                    Id = 28,
                    Name = "Bangkok - Shangri-La",
                    Slug = "bangkok-shangri-la",
                    Address = "Bangkok, Thái Lan",
                    QuantityStaff = 35,
                    QuantityRoom = 90,
                    CreatedDate = now,
                    HotelId = 28, // Khách Sạn Shangri-La, Bangkok
                    Img = "https://www.flightmate.co.za/pictures/destination/thailand/bangkok/highres/landscape/cheap-trips-to-bangkok-10.jpg",
                    Description = "Chi nhánh của Shangri-La tại Bangkok"
                },
                new AppBranchHotel
                {
                    Id = 29,
                    Name = "Bali - The Oberoi",
                    Slug = "bali-the-oberoi",
                    Address = "Bali, Indonesia",
                    QuantityStaff = 25,
                    QuantityRoom = 65,
                    CreatedDate = now,
                    HotelId = 29, // Khách Sạn The Oberoi, Bali
                    Img = "https://cloudinary.fclmedia.com/fctg/image/fetch/w_1600,c_fill,q_auto,g_auto,fl_progressive/https://live-fcl-site-fcb.pantheonsite.io/sites/default/files/Bingin%20Beach%20Bali%20-%20DESKTOP.jpg",
                    Description = "Chi nhánh của The Oberoi tại Bali"
                },
                new AppBranchHotel
                {
                    Id = 30,
                    Name = "Tokyo - Aman",
                    Slug = "tokyo-aman",
                    Address = "Tokyo, Nhật Bản",
                    QuantityStaff = 38,
                    QuantityRoom = 95,
                    CreatedDate = now,
                    HotelId = 30, // Khách Sạn Aman Tokyo
                    Img = "https://images.goway.com/production/styles/article_featured_image_2xl/s3/featured_images/japan_tokyo_akihabara_AdobeStock_295310062_Editorial_Use_Only.jpg?h=43fc81ba&itok=k1GsYr-r",
                    Description = "Chi nhánh của Aman tại Tokyo"
                },
                new AppBranchHotel
                {
                    Id = 31,
                    Name = "Hà Nội - Rex Hotel",
                    Slug = "ha-noi-rex-hotel",
                    Address = "Hà Nội, Việt Nam",
                    QuantityStaff = 20,
                    QuantityRoom = 50,
                    CreatedDate = now,
                    HotelId = 2, // Rex Hotel Saigon
                    Img = "https://vietbis.vn/Image/Picture/Hanoi/duong-pho-ha-noi-maps.jpg",
                    Description = "Chi nhánh của Rex Hotel Saigon tại Hà Nội"
                },
                new AppBranchHotel
                {
                    Id = 32,
                    Name = "TP. Hồ Chí Minh - Golden Bay",
                    Slug = "tp-ho-chi-minh-golden-bay",
                    Address = "TP. Hồ Chí Minh, Việt Nam",
                    QuantityStaff = 25,
                    QuantityRoom = 80,
                    CreatedDate = now,
                    HotelId = 3, // Khách Sạn Đà Nẵng Golden Bay
                    Img = "https://nhaf.net.vn/wp-content/uploads/2022/03/thanh-pho-ho-chi-minh-scaled.jpg",
                    Description = "Chi nhánh của Đà Nẵng Golden Bay tại TP. Hồ Chí Minh"
                },
                new AppBranchHotel
                {
                    Id = 33,
                    Name = "Đà Nẵng - Lodge",
                    Slug = "da-nang-lodge",
                    Address = "Đà Nẵng, Việt Nam",
                    QuantityStaff = 15,
                    QuantityRoom = 40,
                    CreatedDate = now,
                    HotelId = 4, // Khách Sạn Nha Trang Lodge
                    Img = "https://www.vietnamairlines.com/~/media/Images/HeroBannerDestination/Vietnam/Herro%20banner/DANANG/Hero%20banner/1300x450/Danang_banner_2600x1111_0.jpg",
                    Description = "Chi nhánh của Nha Trang Lodge tại Đà Nẵng"
                },
                new AppBranchHotel
                {
                    Id = 34,
                    Name = "Nha Trang - Imperial",
                    Slug = "nha-trang-imperial",
                    Address = "Nha Trang, Việt Nam",
                    QuantityStaff = 18,
                    QuantityRoom = 60,
                    CreatedDate = now,
                    HotelId = 5, // Khách Sạn Imperial Hải Phòng
                    Img = "https://focusasiatravel.vn/wp-content/uploads/2023/09/eb13dca8-82c2-42c0-8698-c37a468c001b.jpg",
                    Description = "Chi nhánh của Imperial Hải Phòng tại Nha Trang"
                },
                new AppBranchHotel
                {
                    Id = 35,
                    Name = "Hải Phòng - Langham",
                    Slug = "hai-phong-langham",
                    Address = "Hải Phòng, Việt Nam",
                    QuantityStaff = 12,
                    QuantityRoom = 30,
                    CreatedDate = now,
                    HotelId = 6, // Khách Sạn Langham, New York
                    Img = "https://file3.qdnd.vn/data/images/0/2023/03/31/nguyenthao/hai%20phong.jpg?dpi=150&quality=100&w=870",
                    Description = "Chi nhánh của Langham Hotel tại Hải Phòng"
                },
                new AppBranchHotel
                {
                    Id = 36,
                    Name = "New York - The Peninsula",
                    Slug = "new-york-the-peninsula",
                    Address = "New York, USA",
                    QuantityStaff = 40,
                    QuantityRoom = 100,
                    CreatedDate = now,
                    HotelId = 7, // Khách Sạn The Peninsula Tokyo
                    Description = "Chi nhánh của The Peninsula tại New York"
                },
                new AppBranchHotel
                {
                    Id = 37,
                    Name = "Tokyo - The Ritz-Carlton",
                    Slug = "tokyo-the-ritz-carlton",
                    Address = "Tokyo, Nhật Bản",
                    QuantityStaff = 35,
                    QuantityRoom = 90,
                    CreatedDate = now,
                    HotelId = 8, // Khách Sạn The Ritz-Carlton, Cancun
                    Img = "https://tnktravel.com.vn/wp-content/uploads/2022/10/tokyo-nh%E1%BA%ADt-b%E1%BA%A3n.jpg",
                    Description = "Chi nhánh của The Ritz-Carlton tại Tokyo"
                },
                new AppBranchHotel
                {
                    Id = 38,
                    Name = "Cancun - The Biltmore",
                    Slug = "cancun-the-biltmore",
                    Address = "Cancun, Mexico",
                    QuantityStaff = 30,
                    QuantityRoom = 75,
                    CreatedDate = now,
                    HotelId = 9, // Khách Sạn The Biltmore Miami
                    Img = "https://media.tacdn.com/media/attractions-content--1x-1/12/29/06/2b.jpg",
                    Description = "Chi nhánh của The Biltmore tại Cancun"
                },
                new AppBranchHotel
                {
                    Id = 39,
                    Name = "Miami - Shangri-La",
                    Slug = "miami-shangri-la",
                    Address = "Miami, USA",
                    QuantityStaff = 28,
                    QuantityRoom = 60,
                    CreatedDate = now,
                    HotelId = 10, // Khách Sạn Shangri-La, Paris
                    Img = "https://i.natgeofe.com/n/5de6e34a-d550-4358-b7ef-4d79a09c680e/aerial-beach-miami-florida.jpg",
                    Description = "Chi nhánh của Shangri-La tại Miami"
                },
                new AppBranchHotel
                {
                    Id = 40,
                    Name = "Paris - Grand Hyatt",
                    Slug = "paris-grand-hyatt",
                    Address = "Paris, Pháp",
                    QuantityStaff = 45,
                    QuantityRoom = 110,
                    CreatedDate = now,
                    HotelId = 11, // Khách Sạn Grand Hyatt Seoul
                    Img = "https://www.agoda.com/wp-content/uploads/2024/02/Featured-image-Notre-Dame-de-Paris-Cathedral-Paris-France-1244x700.jpg",
                    Description = "Chi nhánh của Grand Hyatt tại Paris"
                },
                new AppBranchHotel
                {
                    Id = 41,
                    Name = "Seoul - Four Seasons",
                    Slug = "seoul-four-seasons",
                    Address = "Seoul, Hàn Quốc",
                    QuantityStaff = 50,
                    QuantityRoom = 120,
                    CreatedDate = now,
                    HotelId = 12, // Khách Sạn Four Seasons Bangkok
                    Img = "https://www.vietnamairlines.com/~/media/Images/HeroBannerDestination/Korea/Seoul/Hero%20banner/2600x900/Seoul_banner_2600x1111.jpg",
                    Description = "Chi nhánh của Four Seasons tại Seoul"
                },
                new AppBranchHotel
                {
                    Id = 42,
                    Name = "Bangkok - Hilton",
                    Slug = "bangkok-hilton",
                    Address = "Bangkok, Thái Lan",
                    QuantityStaff = 32,
                    QuantityRoom = 80,
                    CreatedDate = now,
                    HotelId = 13, // Khách Sạn Hilton Tokyo
                    Img = "https://saigontimestravel.com/wp-content/uploads/2024/08/bangkok-thai-lan-1.jpg",
                    Description = "Chi nhánh của Hilton tại Bangkok"
                },
                new AppBranchHotel
                {
                    Id = 43,
                    Name = "Tokyo - W Hong Kong",
                    Slug = "tokyo-w-hong-kong",
                    Address = "Tokyo, Nhật Bản",
                    QuantityStaff = 38,
                    QuantityRoom = 95,
                    CreatedDate = now,
                    HotelId = 14, // Khách Sạn W Hong Kong
                    Img = "https://newswirengr.com/wp-content/uploads/2023/12/Tokyo.jpg",
                    Description = "Chi nhánh của W Hong Kong tại Tokyo"
                },
                new AppBranchHotel
                {
                    Id = 44,
                    Name = "Hong Kong - The St. Regis",
                    Slug = "hong-kong-the-st-regis",
                    Address = "Hong Kong",
                    QuantityStaff = 55,
                    QuantityRoom = 130,
                    CreatedDate = now,
                    HotelId = 15, // Khách Sạn The St. Regis Bali
                    Img = "https://upload.wikimedia.org/wikipedia/commons/a/a4/Hong_Kong_Island_Skyline_201108.jpg",
                    Description = "Chi nhánh của The St. Regis tại Hong Kong"
                },
                new AppBranchHotel
                {
                    Id = 45,
                    Name = "Bali - Mandarin Oriental",
                    Slug = "bali-mandarin-oriental",
                    Address = "Bali, Indonesia",
                    QuantityStaff = 22,
                    QuantityRoom = 70,
                    CreatedDate = now,
                    HotelId = 16, // Khách Sạn Mandarin Oriental Bangkok
                    Img = "https://songhongtourist.vn/upload/2020-02-25/kinh-nghiem-du-lich-bali-1-5.jpg",
                    Description = "Chi nhánh của Mandarin Oriental tại Bali"
                },
                new AppBranchHotel
                {
                    Id = 46,
                    Name = "Bangkok - Ritz",
                    Slug = "bangkok-ritz",
                    Address = "Bangkok, Thái Lan",
                    QuantityStaff = 35,
                    QuantityRoom = 85,
                    CreatedDate = now,
                    HotelId = 17, // Khách Sạn Ritz Paris
                    Img = "https://dichvuxinvisa.com/wp-content/uploads/2020/12/Thoi-gian-tot-nhat-Du-lich-Bangkok.jpg",
                    Description = "Chi nhánh của Ritz tại Bangkok"
                },
                new AppBranchHotel
                {
                    Id = 47,
                    Name = "Paris - The Oberoi",
                    Slug = "paris-the-oberoi",
                    Address = "Paris, Pháp",
                    QuantityStaff = 60,
                    QuantityRoom = 140,
                    CreatedDate = now,
                    HotelId = 18, // Khách Sạn The Oberoi, Mumbai
                    Img = "https://static01.nyt.com/images/2023/07/01/travel/22hours-paris-tjzf/22hours-paris-tjzf-videoSixteenByNineJumbo1600.jpg",
                    Description = "Chi nhánh của The Oberoi tại Paris"
                },
                new AppBranchHotel
                {
                    Id = 48,
                    Name = "Mumbai - Park Hyatt",
                    Slug = "mumbai-park-hyatt",
                    Address = "Mumbai, Ấn Độ",
                    QuantityStaff = 30,
                    QuantityRoom = 75,
                    CreatedDate = now,
                    HotelId = 19, // Khách Sạn Park Hyatt Sydney
                    Img = "https://res.klook.com/images/fl_lossy.progressive,q_65/c_fill,w_1200,h_630/w_80,x_15,y_15,g_south_west,l_Klook_water_br_trans_yhcmh3/activities/eybjjii82kbb7e4mclya/Highlights%20of%20Mumbai%20Day%20Tour.jpg",
                    Description = "Chi nhánh của Park Hyatt tại Mumbai"
                },
                new AppBranchHotel
                {
                    Id = 49,
                    Name = "Sydney - The Sukhothai",
                    Slug = "sydney-the-sukhothai",
                    Address = "Sydney, Australia",
                    QuantityStaff = 29,
                    QuantityRoom = 65,
                    CreatedDate = now,
                    HotelId = 20, // Khách Sạn The Sukhothai Bangkok
                    Img = "https://duhocuc.edu.vn/wp-content/uploads/2024/02/du-hoc-uc-tai-sydney.jpg",
                    Description = "Chi nhánh của The Sukhothai tại Sydney"
                },
                new AppBranchHotel
                {
                    Id = 50,
                    Name = "Bangkok - Ritz",
                    Slug = "bangkok-ritz",
                    Address = "Bangkok, Thái Lan",
                    QuantityStaff = 33,
                    QuantityRoom = 90,
                    CreatedDate = now,
                    HotelId = 21, // Khách Sạn Ritz Paris
                    Img = "https://hieutour.com.vn/public/upload/images/hinhsanpham/hanh-trinh-kham-pha-bangkok-pattaya---5-ngay-4-dem---ho5dtlbk1801-53611705657481.jpg",
                    Description = "Chi nhánh của Ritz tại Bangkok"
                },
                new AppBranchHotel
                {
                    Id = 51,
                    Name = "Bali - The Leela",
                    Slug = "bali-the-leela",
                    Address = "Bali, Indonesia",
                    QuantityStaff = 25,
                    QuantityRoom = 65,
                    CreatedDate = now,
                    HotelId = 22, // Khách Sạn The Leela, Mumbai
                    Img = "https://ik.imagekit.io/tvlk/blog/2022/12/dia-diem-du-lich-bali-1.jpg?tr=dpr-2,w-675",
                    Description = "Chi nhánh của The Leela tại Bali"
                },
                new AppBranchHotel
                {
                    Id = 52,
                    Name = "Tokyo - St. Regis",
                    Slug = "tokyo-st-regis",
                    Address = "Tokyo, Nhật Bản",
                    QuantityStaff = 37,
                    QuantityRoom = 92,
                    CreatedDate = now,
                    HotelId = 23, // Khách Sạn St. Regis New York
                    Img = "https://www.patrickopreis.nl/wp-content/uploads/2018/06/tokyo-5x-zien-en-doen.jpg",
                    Description = "Chi nhánh của St. Regis tại Tokyo"
                },
                new AppBranchHotel
                {
                    Id = 53,
                    Name = "New York - Jumeirah",
                    Slug = "new-york-jumeirah",
                    Address = "New York, USA",
                    QuantityStaff = 41,
                    QuantityRoom = 102,
                    CreatedDate = now,
                    HotelId = 24, // Khách Sạn Jumeirah, Dubai
                    Img = "https://a.travel-assets.com/findyours-php/viewfinder/images/res70/471000/471585-New-York.jpg",
                    Description = "Chi nhánh của Jumeirah tại New York"
                },
                new AppBranchHotel
                {
                    Id = 54,
                    Name = "Dubai - Belmond Hotel Caruso",
                    Slug = "dubai-belmond-hotel-caruso",
                    Address = "Dubai, UAE",
                    QuantityStaff = 53,
                    QuantityRoom = 160,
                    CreatedDate = now,
                    HotelId = 25, // Khách Sạn Belmond Hotel Caruso
                    Img = "https://cdn3.ivivu.com/2022/06/du-lich-dubai-ivivu.jpg",
                    Description = "Chi nhánh của Belmond Hotel Caruso tại Dubai"
                },
                new AppBranchHotel
                {
                    Id = 55,
                    Name = "Italy - Banyan Tree",
                    Slug = "italy-banyan-tree",
                    Address = "Italy",
                    QuantityStaff = 30,
                    QuantityRoom = 70,
                    CreatedDate = now,
                    HotelId = 26, // Khách Sạn Banyan Tree, Phuket
                    Img = "https://www.hostelworld.com/blog/wp-content/uploads/dreamstime_m_140314930-2048x857.jpg",
                    Description = "Chi nhánh của Banyan Tree tại Italy"
                },
                new AppBranchHotel
                {
                    Id = 56,
                    Name = "Phuket - The Address",
                    Slug = "phuket-the-address",
                    Address = "Phuket, Thái Lan",
                    QuantityStaff = 32,
                    QuantityRoom = 80,
                    CreatedDate = now,
                    HotelId = 27, // Khách Sạn The Address, Dubai
                    Img = "https://www.fivestars-thailand.com/images/article/display/a_1709046726.jpg",
                    Description = "Chi nhánh của The Address tại Phuket"
                },
                new AppBranchHotel
                {
                    Id = 57,
                    Name = "Dubai - Shangri-La",
                    Slug = "dubai-shangri-la",
                    Address = "Dubai, UAE",
                    QuantityStaff = 45,
                    QuantityRoom = 125,
                    CreatedDate = now,
                    HotelId = 28, // Khách Sạn Shangri-La, Bangkok
                    Img = "https://www.vietourist.com.vn/public/frontend/uploads/kceditor/images/dao-co-trong-tour-dubai-min.jpg",
                    Description = "Chi nhánh của Shangri-La tại Dubai"
                },
                new AppBranchHotel
                {
                    Id = 58,
                    Name = "Bangkok - The Oberoi",
                    Slug = "bangkok-the-oberoi",
                    Address = "Bangkok, Thái Lan",
                    QuantityStaff = 35,
                    QuantityRoom = 90,
                    CreatedDate = now,
                    HotelId = 29, // Khách Sạn The Oberoi, Bali
                    Img = "https://bizweb.dktcdn.net/thumb/1024x1024/100/093/257/products/nguoi-viet-toi-thai-lan-du-lich-va-chua-benh-duoc-o-90-ngay-04-6338.jpg?v=1544343721263",
                    Description = "Chi nhánh của The Oberoi tại Bangkok"
                },
                new AppBranchHotel
                {
                    Id = 59,
                    Name = "Bali - Aman",
                    Slug = "bali-aman",
                    Address = "Bali, Indonesia",
                    QuantityStaff = 27,
                    QuantityRoom = 68,
                    CreatedDate = now,
                    HotelId = 30, // Khách Sạn Aman Tokyo
                    Img = "https://balidave.com/wp-content/uploads/2022/11/best-hotel-bali.jpeg",
                    Description = "Chi nhánh của Aman tại Bali"
                }

            );
        }
    }
}