using App.Data.Entities.Hotel;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Data.DataSeeders
{
	public static class AppHotelSeeder
	{
		public static void SeedData(this EntityTypeBuilder<AppHotel> builder)
		{
			var now = new DateTime(year: 2024, month: 10, day: 10);

			// Tạo khách sạn
			builder.HasData(
				new AppHotel
				{
					Id = 1,
					Name = "Khách Sạn Melia Hanoi",
					Slug = "khach-san-melia-hanoi",
					Description = "Khách sạn 5 sao sang trọng tại Hà Nội.",
					PhoneNumber1 = "+842438223333",
					Email = "info@meliahanoi.com",
					ImgBanner = "https://du-lich.chudu24.com/f/m/2105/20/khach-san-melia-hanoi.jpg",
					CreatedDate = new DateTime(2023, 10, 1),
				},
				new AppHotel
				{
					Id = 2,
					Name = "Rex Hotel Saigon",
					Slug = "rex-hotel-saigon",
					Description = "Khách sạn lịch sử và sang trọng tại TP. Hồ Chí Minh.",
					PhoneNumber1 = "+842838292185",
					Email = "info@rexhotel.com.vn",
					ImgBanner = "https://images2.thanhnien.vn/Uploaded/ttt/images/Content/tan-huong/xach-vali-di/2016_12_w2/rex_hotel/Exterior_Rex_9.jpg",
					CreatedDate = now
				},
				new AppHotel
				{
					Id = 3,
					Name = "Khách Sạn Đà Nẵng Golden Bay",
					Slug = "khach-san-da-nang-golden-bay",
					Description = "Khách sạn ven biển tuyệt đẹp tại Đà Nẵng.",
					PhoneNumber1 = "+842363921888",
					Email = "info@goldenbaydanang.com",
					ImgBanner = "https://www.arttravel.com.vn/upload/news/golden-bay-(4)-9448.jpg",
					CreatedDate = new DateTime(2023, 10, 15),
				},
				new AppHotel
				{
					Id = 4,
					Name = "Khách Sạn Nha Trang Lodge",
					Slug = "khach-san-nha-trang-lodge",
					Description = "Khách sạn với tầm nhìn ra biển tuyệt đẹp tại Nha Trang.",
					PhoneNumber1 = "+842583525555",
					Email = "info@nhatranglodge.com.vn",
					ImgBanner = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/81022752.jpg?k=d69140451157e29655c5d19999354e86b95d3654c7ffbe68081070bc8e041518&o=&hp=1",
					CreatedDate = now
				},
				new AppHotel
				{
					Id = 5,
					Name = "Khách Sạn Imperial Hải Phòng",
					Slug = "khach-san-imperial-hai-phong",
					Description = "Khách sạn sang trọng tại trung tâm Hải Phòng.",
					PhoneNumber1 = "+842253888888",
					Email = "info@imperialhotel.com.vn",
					ImgBanner = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/467550547.webp?k=df9413c20e4dc78e4dd3a98618e2815ca246f2bc27a33edf99d9f1bae10e994c&o=",
					CreatedDate = new DateTime(2024, 7, 19)
				},
				new AppHotel
				{
					Id = 6,
					Name = "Khách Sạn Langham, New York",
					Slug = "langham-new-york",
					Description = "Khách sạn sang trọng tại New York.",
					PhoneNumber1 = "+12123338888",
					Email = "info@langhamhotels.com",
					ImgBanner = "https://cdn3.ivivu.com/2023/07/The-Langham-New-York-Fifth-Avenue-ivivu.jpg",
					CreatedDate = now
				},
				new AppHotel
				{
					Id = 7,
					Name = "Khách Sạn The Peninsula Tokyo",
					Slug = "the-peninsula-tokyo",
					Description = "Khách sạn sang trọng tại Tokyo.",
					PhoneNumber1 = "+81362701000",
					Email = "info@peninsula.com",
					ImgBanner = "https://tokyo-marunouchi.jp/dmo_wp_YfehP9/wp-content/uploads/2017/03/banket_pe_07.jpg",
					CreatedDate = new DateTime(2024, 10, 15)
				},
				new AppHotel
				{
					Id = 8,
					Name = "Khách Sạn The Ritz-Carlton, Cancun",
					Slug = "ritz-carlton-cancun",
					Description = "Khách sạn sang trọng bên bờ biển Cancun.",
					PhoneNumber1 = "+5219988916200",
					Email = "info@ritzcarlton.com",
					ImgBanner = "https://ritzcarlton.cancunhotelsweb.net/data/Pics/1080x700w/15670/1567035/1567035848/pic-ritz-carlton-hotel-cancun-5.JPEG",
					CreatedDate = now
				},
				new AppHotel
				{
					Id = 9,
					Name = "Khách Sạn The Biltmore Miami",
					Slug = "the-biltmore-miami",
					Description = "Khách sạn nổi tiếng tại Miami, Florida.",
					PhoneNumber1 = "+13055284500",
					Email = "info@biltmorehotel.com",
					ImgBanner = "https://biltmore-coral-gables.hotelmix.vn/data/Photos/1920x1080/2004/200471/200471074/Biltmore-Hotel-Miami-Coral-Gables-Exterior.JPEG",
					CreatedDate = new DateTime(2024, 7, 15)
				},
				new AppHotel
				{
					Id = 10,
					Name = "Khách Sạn Shangri-La, Paris",
					Slug = "shangri-la-paris",
					Description = "Khách sạn cao cấp tại Paris, Pháp.",
					PhoneNumber1 = "+33153003030",
					Email = "info@shangri-la.com",
					ImgBanner = "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/2a/36/f3/e2/caption.jpg?w=1200&h=-1&s=1",
					CreatedDate = now
				},
				new AppHotel
				{
					Id = 11,
					Name = "Khách Sạn Grand Hyatt Seoul",
					Slug = "grand-hyatt-seoul",
					Description = "Khách sạn sang trọng tại Seoul.",
					PhoneNumber1 = "+8227971234",
					Email = "info@hyatt.com",
					ImgBanner = "https://www.americanexpress.com/en-us/travel/discover/photos/197/56953/1600/GHS_Exterior.jpg?ch=560",
					CreatedDate = now
				},
				new AppHotel
				{
					Id = 12,
					Name = "Khách Sạn Four Seasons Bangkok",
					Slug = "four-seasons-bangkok",
					Description = "Khách sạn sang trọng tại Bangkok.",
					PhoneNumber1 = "+6622501000",
					Email = "info@fourseasons.com",
					ImgBanner = "https://theluxurytraveller.com/wp-content/uploads/2022/05/FS-Bangkok-144-1080x480.jpg",
					CreatedDate = now
				},
				new AppHotel
				{
					Id = 13,
					Name = "Khách Sạn Hilton Tokyo",
					Slug = "hilton-tokyo",
					Description = "Khách sạn đẳng cấp tại Tokyo.",
					PhoneNumber1 = "+81333451111",
					Email = "info@hilton.com",
					ImgBanner = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/483824171.jpg?k=3fc70cd0fa564972470a3a08b248feff8fa34e9f8b3f2e0343f5105499238bee&o=&hp=1",
					CreatedDate = now
				},
				new AppHotel
				{
					Id = 14,
					Name = "Khách Sạn W Hong Kong",
					Slug = "w-hong-kong",
					Description = "Khách sạn hiện đại tại Hong Kong.",
					PhoneNumber1 = "+85237170000",
					Email = "info@whotels.com",
					ImgBanner = "https://cache.marriott.com/content/dam/marriott-renditions/HKGWH/hkgwh-pool-exterior-5271-hor-feat.jpg?output-quality=70&interpolation=progressive-bilinear&downsize=1920px:*",
					CreatedDate = now
				},
				new AppHotel
				{
					Id = 15,
					Name = "Khách Sạn The St. Regis Bali",
					Slug = "st-regis-bali",
					Description = "Khách sạn tuyệt đẹp tại Bali.",
					PhoneNumber1 = "+62361775200",
					Email = "info@stregis.com",
					ImgBanner = "https://res.klook.com/images/fl_lossy.progressive,q_65/c_fill,w_1200,h_630/w_80,x_15,y_15,g_south_west,l_Klook_water_br_trans_yhcmh3/activities/aqglngrp8i0ecxrlwxsm/Tr%E1%BA%A3i%20nghi%E1%BB%87m%20%E1%BA%A9m%20th%E1%BB%B1c%20t%E1%BA%A1i%20The%20St.%20Regis%20Bali%20Resort.jpg",
					CreatedDate = now
				},
				new AppHotel
				{
					Id = 16,
					Name = "Khách Sạn Mandarin Oriental Bangkok",
					Slug = "mandarin-oriental-bangkok",
					Description = "Khách sạn sang trọng tại Bangkok.",
					PhoneNumber1 = "+6626599000",
					Email = "info@mandarinoriental.com",
					ImgBanner = "https://upload.wikimedia.org/wikipedia/commons/e/e5/Mandarin_Oriental_Bangkok_Bang_Rak.jpg",
					CreatedDate = now
				},
				new AppHotel
				{
					Id = 17,
					Name = "Khách Sạn Le Meurice, Paris",
					Slug = "le-meurice-paris",
					Description = "Khách sạn cổ điển tại Paris.",
					PhoneNumber1 = "+33144723456",
					Email = "info@dorchestercollection.com",
					ImgBanner = "https://strawberrymilkevents.com/wp-content/uploads/2014/03/le-meurice-paris-1.jpg",
					CreatedDate = now
				},
				new AppHotel
				{
					Id = 18,
					Name = "Khách Sạn The Oberoi, Mumbai",
					Slug = "the-oberoi-mumbai",
					Description = "Khách sạn sang trọng tại Mumbai.",
					PhoneNumber1 = "+912266202020",
					Email = "info@oberoihotels.com",
					ImgBanner = "https://cf.bstatic.com/xdata/images/hotel/max500/28759044.jpg?k=4a3e476214895d86a0e71808d9eb5b85acaebe0cbff06bbd2ecdbb3054d98600&o=&hp=1",
					CreatedDate = now
				},
				new AppHotel
				{
					Id = 19,
					Name = "Khách Sạn Park Hyatt Sydney",
					Slug = "park-hyatt-sydney",
					Description = "Khách sạn ven sông tại Sydney.",
					PhoneNumber1 = "+61292561111",
					Email = "info@hyatt.com",
					ImgBanner = "https://www.jacadatravel.com/wp-content/uploads/fly-images/157913/park-hyatt-sydney-exterior-1600x500-cc.jpg",
					CreatedDate = now
				},
				new AppHotel
				{
					Id = 20,
					Name = "Khách Sạn The Sukhothai Bangkok",
					Slug = "the-sukhothai-bangkok",
					Description = "Khách sạn hiện đại tại Bangkok.",
					PhoneNumber1 = "+6623448888",
					Email = "info@sukhothai.com",
					ImgBanner = "https://kyluc.vn/Userfiles/Upload/images/The%20Sukhothai%20Bangkok.jpg",
					CreatedDate = now
				},
				new AppHotel
				{
					Id = 21,
					Name = "Khách Sạn Ritz Paris",
					Slug = "ritz-paris",
					Description = "Khách sạn sang trọng tại Paris.",
					PhoneNumber1 = "+33143261800",
					Email = "info@ritzparis.com",
					ImgBanner = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/ec/H%C3%B4tel_Ritz.jpg/1200px-H%C3%B4tel_Ritz.jpg",
					CreatedDate = now
				},
				new AppHotel
				{
					Id = 22,
					Name = "Khách Sạn The Leela, Mumbai",
					Slug = "the-leela-mumbai",
					Description = "Khách sạn 5 sao tại Mumbai.",
					PhoneNumber1 = "+912266486000",
					Email = "info@theleela.com",
					ImgBanner = "https://d25wybtmjgh8lz.cloudfront.net/sites/default/files/styles/ph_pdp_subheader_1000_x_333/public/property/img-mastheads/bomlm_4.jpg?h=7bc7d4e1",
					CreatedDate = now
				},
				new AppHotel
				{
					Id = 23,
					Name = "Khách Sạn St. Regis New York",
					Slug = "st-regis-new-york",
					Description = "Khách sạn sang trọng tại New York.",
					PhoneNumber1 = "+12125450500",
					Email = "info@stregis.com",
					ImgBanner = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/43/The_St._Regis_Hotel_New_York.JPG/1200px-The_St._Regis_Hotel_New_York.JPG",
					CreatedDate = now
				},
				new AppHotel
				{
					Id = 24,
					Name = "Khách Sạn Jumeirah, Dubai",
					Slug = "jumeirah-dubai",
					Description = "Khách sạn sang trọng tại Dubai.",
					PhoneNumber1 = "+97144028888",
					Email = "info@jumeirah.com",
					ImgBanner = "https://cf.bstatic.com/xdata/images/district/1020x340/45235.jpg?k=daf29066fcf29a01b738ead0998e878a221a3176c033e82a170da725278bc69c&o=",
					CreatedDate = now
				},
				new AppHotel
				{
					Id = 25,
					Name = "Khách Sạn Belmond Hotel Caruso",
					Slug = "belmond-caruso",
					Description = "Khách sạn cổ điển tại Italy.",
					PhoneNumber1 = "+39089812345",
					Email = "info@belmond.com",
					ImgBanner = "https://www.truetrips.com/images/api/hotels/Amalfi/Belmond_Hotel_Caruso/The_Balmoral_Caruso_bn_02.jpg",
					CreatedDate = now
				},
				new AppHotel
				{
					Id = 26,
					Name = "Khách Sạn Banyan Tree, Phuket",
					Slug = "banyan-tree-phuket",
					Description = "Khách sạn 5 sao tại Phuket.",
					PhoneNumber1 = "+6676377888",
					Email = "info@banyantree.com",
					ImgBanner = "https://greenmore.vn/wp-content/uploads/2019/12/canh-quan-resort-nghi-duong-banyan-tree-phuket-05-compressed.jpg",
					CreatedDate = now
				},
				new AppHotel
				{
					Id = 27,
					Name = "Khách Sạn The Address, Dubai",
					Slug = "the-address-dubai",
					Description = "Khách sạn sang trọng tại Dubai.",
					PhoneNumber1 = "+97144087777",
					Email = "info@theaddress.com",
					ImgBanner = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/147760688.jpg?k=9604a9318b078228b302c62aaefdfe79aa03688c6d00b953ddc65ab46a337c12&o=&hp=1",
					CreatedDate = now
				},
				new AppHotel
				{
					Id = 28,
					Name = "Khách Sạn Shangri-La, Bangkok",
					Slug = "shangri-la-bangkok",
					Description = "Khách sạn bên bờ sông tại Bangkok.",
					PhoneNumber1 = "+6622367777",
					Email = "info@shangri-la.com",
					ImgBanner = "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/2a/9c/cc/45/shangri-la-bangkok.jpg?w=700&h=-1&s=1",
					CreatedDate = now
				},
				new AppHotel
				{
					Id = 29,
					Name = "Khách Sạn The Oberoi, Bali",
					Slug = "the-oberoi-bali",
					Description = "Khách sạn tuyệt đẹp tại Bali.",
					PhoneNumber1 = "+62361775688",
					Email = "info@oberoihotels.com",
					ImgBanner = "https://www.hotelsinheaven.com/wp-content/uploads/2020/05/the-oberoi-beach-resort-bali-main-pool-beach-scaled-1256x1000.jpg",
					CreatedDate = now
				},
				new AppHotel
				{
					Id = 30,
					Name = "Khách Sạn Mandarin Oriental, Tokyo",
					Slug = "mandarin-oriental-tokyo",
					Description = "Khách sạn 5 sao tại Tokyo.",
					PhoneNumber1 = "+81357770000",
					Email = "info@mandarinoriental.com",
					ImgBanner = "https://cf2.bstatic.com/xdata/images/hotel/max1280x900/565155779.jpg?k=6597ca16a17e31dfa517cd3e90b398fd52a5773dfe28ff2b3e5a0baa15f1d89c&o=&hp=1",
					CreatedDate = now
				}
			);
		}
	}
}