using App.Data.Entities.News;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Data.DataSeeders
{
	public static class AppNewsSeeder
	{
		public static void SeedData(this EntityTypeBuilder<AppNews> builder)
		{
			var now = new DateTime(year: 2024, month: 10, day: 10);

			// Tạo thiết bị
			builder.HasData(
				new AppNews
				{
					Id = 1,
					Title = "Chợ nổi tuyệt vời ẩn giấu và con kênh nhỏ (Kênh nhỏ không dành cho khách du lịch)",
					Slug = "cho-noi-tuyet-voi-an-giau-va-con-kenh-nho-kenh-nho-khong-danh-cho-khach-du-lich",
					Content = "Nói về tour du lịch chợ nổi",
					Summary = "<blockquote><h3>Chúng tôi tự hào điều hành các tour du lịch của mình với những cam kết “Không” sau:</h3></blockquote><p>Không có cửa hàng du lịch dừng lại</p><p>Không có bẫy du lịch</p><p>Không có động vật nào có liên quan hoặc bị tổn hại</p><p>&nbsp;</p><blockquote><h4>Làm nổi bật các điểm tham quan:</h4></blockquote><p>• Chợ nổi lớn nhất (Cái Răng)</p><p>&nbsp;</p><p>• Nhà mì truyền thống địa phương nơi bạn tự làm bánh tráng và mì do người dân địa phương hướng dẫn.</p><p>&nbsp;</p><p>• Bữa sáng trên thuyền - Bữa sáng ngon nhất mà Master Chef Gordon Ramsey đã thử khi đến đây.</p><p>&nbsp;</p><p>• Kênh nhỏ đích thực.</p><p>&nbsp;</p><p>• Đi bộ qua ngôi làng đích thực</p><figure class=\"table\"><table><tbody><tr><td><h2>Bao gồm</h2><p>✅Phí vào cửa<br>✅Hướng dẫn viên nói tiếng Anh/Pháp (có tính phí)<br>✅Thuyền<br>✅Trái cây và đồ uống một lần<br>✅Bữa sáng<br>✅Xe đón và trả khách tại thành phố Cần Thơ.</p></td><td><h2>Không bao gồm những gì?</h2><p>❌Đồ uống có cồn (có sẵn để mua)</p><p>&nbsp;</p><p>&nbsp;</p><p>&nbsp;</p><p>&nbsp;</p></td></tr></tbody></table></figure><h3>Thông tin thêm</h3><p>Các lựa chọn giao thông công cộng có sẵn ở gần đó</p><p>Trẻ sơ sinh phải ngồi trên đùi người lớn</p><p>Không khuyến khích cho du khách mang thai</p><p>Không nên dùng cho du khách có sức khỏe tim mạch kém</p><p>Thích hợp cho mọi cấp độ thể chất</p><p>Có sẵn lựa chọn ăn chay, vui lòng thông báo tại thời điểm đặt chỗ nếu được yêu cầu</p><p>Trẻ em phải có người lớn đi kèm</p><p>Chúng tôi cung cấp dịch vụ đón khách miễn phí tại bất kỳ địa điểm nào trong trung tâm thành phố Cần Thơ, nếu bạn ở ngoài thành phố (bán kính 1km từ điểm tập trung)</p><p>Không thể sử dụng xe lăn</p><p>Vui lòng mang theo vé đến điểm tham quan.</p><p>Lưu ý rằng nhà cung cấp có thể hủy bỏ những lý do chưa biết trước đó.</p><p>Bạn phải đủ 18 tuổi trở lên mới có thể đặt vé hoặc phải đi cùng người lớn.</p><p>Điều hành bởi Fabulous Mekong Eco Tours</p>",
					CoverImgThumbnailPath = "files/ImgNews/Thumbnail-Chợ-Nổi_VN.jpg",
					CoverImgPath = "files/ImgNews/Cover-Chợ-Nổi_VN.jpg",
					StampPath = "files/ImgNews/Stamp-Chợ-Nổi_VN.jpg",
					Views = 100,
					Votes = 15,
					CategoryId = 1,
					Published = true,
					CreatedBy = 1,
					CreatedDate = now
				},
				new AppNews
				{
					Id = 2,
					Title = "Chợ nổi tuyệt vời ẩn giấu và con kênh nhỏ (Kênh nhỏ không dành cho khách du lịch)",
					Slug = "cho-noi-tuyet-voi-an-giau-va-con-kenh-nho-kenh-nho-khong-danh-cho-khach-du-lich",
					Content = "Nói về tour du lịch chợ nổi",
					Summary = "<blockquote><h3>Chúng tôi tự hào điều hành các tour du lịch của mình với những cam kết “Không” sau:</h3></blockquote><p>Không có cửa hàng du lịch dừng lại</p><p>Không có bẫy du lịch</p><p>Không có động vật nào có liên quan hoặc bị tổn hại</p><p>&nbsp;</p><blockquote><h4>Làm nổi bật các điểm tham quan:</h4></blockquote><p>• Chợ nổi lớn nhất (Cái Răng)</p><p>&nbsp;</p><p>• Nhà mì truyền thống địa phương nơi bạn tự làm bánh tráng và mì do người dân địa phương hướng dẫn.</p><p>&nbsp;</p><p>• Bữa sáng trên thuyền - Bữa sáng ngon nhất mà Master Chef Gordon Ramsey đã thử khi đến đây.</p><p>&nbsp;</p><p>• Kênh nhỏ đích thực.</p><p>&nbsp;</p><p>• Đi bộ qua ngôi làng đích thực</p><figure class=\"table\"><table><tbody><tr><td><h2>Bao gồm</h2><p>✅Phí vào cửa<br>✅Hướng dẫn viên nói tiếng Anh/Pháp (có tính phí)<br>✅Thuyền<br>✅Trái cây và đồ uống một lần<br>✅Bữa sáng<br>✅Xe đón và trả khách tại thành phố Cần Thơ.</p></td><td><h2>Không bao gồm những gì?</h2><p>❌Đồ uống có cồn (có sẵn để mua)</p><p>&nbsp;</p><p>&nbsp;</p><p>&nbsp;</p><p>&nbsp;</p></td></tr></tbody></table></figure><h3>Thông tin thêm</h3><p>Các lựa chọn giao thông công cộng có sẵn ở gần đó</p><p>Trẻ sơ sinh phải ngồi trên đùi người lớn</p><p>Không khuyến khích cho du khách mang thai</p><p>Không nên dùng cho du khách có sức khỏe tim mạch kém</p><p>Thích hợp cho mọi cấp độ thể chất</p><p>Có sẵn lựa chọn ăn chay, vui lòng thông báo tại thời điểm đặt chỗ nếu được yêu cầu</p><p>Trẻ em phải có người lớn đi kèm</p><p>Chúng tôi cung cấp dịch vụ đón khách miễn phí tại bất kỳ địa điểm nào trong trung tâm thành phố Cần Thơ, nếu bạn ở ngoài thành phố (bán kính 1km từ điểm tập trung)</p><p>Không thể sử dụng xe lăn</p><p>Vui lòng mang theo vé đến điểm tham quan.</p><p>Lưu ý rằng nhà cung cấp có thể hủy bỏ những lý do chưa biết trước đó.</p><p>Bạn phải đủ 18 tuổi trở lên mới có thể đặt vé hoặc phải đi cùng người lớn.</p><p>Điều hành bởi Fabulous Mekong Eco Tours</p>",
					CoverImgThumbnailPath = "files/ImgNews/Thumbnail-Chợ-Nổi_VN.jpg",
					CoverImgPath = "files/ImgNews/Cover-Chợ-Nổi_VN.jpg",
					StampPath = "files/ImgNews/Stamp-Chợ-Nổi_VN.jpg",
					Views = 210,
					Votes = 55,
					CategoryId = 2,
					Published = true,
					CreatedBy = 5,
					CreatedDate = now
				},
				new AppNews
				{
					Id = 3,
					Title = "Du thuyền ngắm cảnh từ tháp Eiffel",
					Slug = "du-thuyen-ngam-canh-tu-thap-eiffel",
					Content = "Nội dung nói về địa điểm tham quan ở Paris",
					Summary = "<blockquote><h3>Chuyến đi ở Paris</h3></blockquote><p>Khởi hành từ Tháp Eiffel mang tính biểu tượng, chuyến đi có hướng dẫn kéo dài một giờ này sẽ mang đến cho bạn cơ hội chiêm ngưỡng những địa điểm hàng đầu của thành phố. Bạn sẽ đi dọc Sông Seine trên du thuyền trimaran - một chiếc thuyền được thiết kế để tham quan với boong ngoài trời lớn.</p><p><br>Bạn sẽ đi ngang qua các địa danh nổi tiếng như Louvre, Palais Bourbon, Notre-Dame và nhiều địa danh khác. Trên đường đi, âm thanh và bình luận trực tiếp sẽ nêu bật các chi tiết về lịch sử thủ đô nước Pháp và các di tích của nó.</p><h2>Vì sao nên đến đây?</h2><p>✅Quang cảnh các địa danh bao gồm bảo tàng Louvre và Notre-Dame</p><p>✅Đi thuyền dọc sông Seine bằng boong ngoài trời để ngắm cảnh</p><p>✅Hiểu biết sâu sắc về lịch sử của thành phố và các di tích mang tính biểu tượng của nó</p><figure class=\"table\"><table><tbody><tr><td><h2>Bao gồm</h2><p>✅Hành trình một giờ có bình luận</p></td><td><h2>Không bao gồm những gì?</h2><p>❌Hình ảnh lưu niệm<br>❌Thức ăn và đồ uống</p></td></tr></tbody></table></figure><h3>Thông tin thêm</h3><p>Thế vận hội Olympic Paris sẽ diễn ra từ ngày 26 tháng 7 đến ngày 11 tháng 8 năm 2024 và Thế vận hội Paralympic từ ngày 28 tháng 8 đến ngày 8 tháng 9 năm 2024. Do những sự kiện này, một số dịch vụ của nhà cung cấp tour du lịch sẽ bị ảnh hưởng:</p><ul><li>Ngày 14 tháng 7 năm 2024: đóng cửa hoàn toàn hoạt động bắt đầu từ 14:00</li><li>Ngày 27 tháng 7 năm 2024: khởi hành lần đầu lúc 12:00</li><li>Ngày 8 tháng 7 đến ngày 11 tháng 8 năm 2024: khởi hành lần đầu lúc 11:00</li><li>Ngày 1 và 2 tháng 9 năm 2024: khởi hành lần đầu lúc 13:30</li><li>Ngày 3 tháng 9 năm 2024: khởi hành lần đầu lúc 15:00</li></ul><p>Thời gian khởi hành chỉ được cung cấp để cung cấp thông tin và có thể thay đổi.</p><p>Vào ngày 18 tháng 7 năm 2024, hành trình bình luận kéo dài một giờ sẽ hoạt động như bình thường. Tuy nhiên, chỉ những người có thẻ kỹ thuật số mới được phép vào địa điểm, một biện pháp được Chính phủ Pháp thực hiện nhằm đảm bảo an ninh cho khu vực lân cận sông Seine, nơi sẽ trở thành địa điểm mang tính biểu tượng cho lễ khai mạc Thế vận hội.</p><p>Bạn có thể nhận được thẻ thông qua trang web chính thức của chính phủ. Nhà cung cấp tour du lịch từ chối mọi trách nhiệm trong trường hợp không xuất trình được thẻ dẫn đến việc từ chối vào cửa. Bạn nên bắt đầu quá trình này ít nhất 15 ngày trước ngày sử dụng dịch vụ.</p><p>Vui lòng tham khảo trang web của nhà cung cấp tour để biết giờ hoạt động được cập nhật.</p><p>Xin lưu ý rằng động vật không được phép lên tàu.</p><p>Xin lưu ý rằng hành lý vượt quá sức chứa 16 lít không được chấp nhận. Chỉ được phép mang ba lô nhỏ, túi xách và hộp đựng máy tính xách tay lên máy bay.</p>",
					CoverImgThumbnailPath = "files/ImgNews/Thumbnail-Sightseeing_France.jpg",
					CoverImgPath = "files/ImgNews/Cover-Sightseeing_France.jpg",
					StampPath = "files/ImgNews/Stamp-Sightseeing_France.jpg",
					Views = 100,
					Votes = 35,
					CategoryId = 2,
					Published = true,
					CreatedBy = 1,
					CreatedDate = now
				},
				new AppNews
				{
					Id = 4,
					Title = "Du thuyền ngắm cảnh từ tháp Eiffel",
					Slug = "du-thuyen-ngam-canh-tu-thap-eiffel",
					Content = "Nội dung nói về địa điểm tham quan ở Paris",
					Summary = "<blockquote><h3>Chuyến đi ở Paris</h3></blockquote><p>Khởi hành từ Tháp Eiffel mang tính biểu tượng, chuyến đi có hướng dẫn kéo dài một giờ này sẽ mang đến cho bạn cơ hội chiêm ngưỡng những địa điểm hàng đầu của thành phố. Bạn sẽ đi dọc Sông Seine trên du thuyền trimaran - một chiếc thuyền được thiết kế để tham quan với boong ngoài trời lớn.</p><p><br>Bạn sẽ đi ngang qua các địa danh nổi tiếng như Louvre, Palais Bourbon, Notre-Dame và nhiều địa danh khác. Trên đường đi, âm thanh và bình luận trực tiếp sẽ nêu bật các chi tiết về lịch sử thủ đô nước Pháp và các di tích của nó.</p><h2>Vì sao nên đến đây?</h2><p>✅Quang cảnh các địa danh bao gồm bảo tàng Louvre và Notre-Dame</p><p>✅Đi thuyền dọc sông Seine bằng boong ngoài trời để ngắm cảnh</p><p>✅Hiểu biết sâu sắc về lịch sử của thành phố và các di tích mang tính biểu tượng của nó</p><figure class=\"table\"><table><tbody><tr><td><h2>Bao gồm</h2><p>✅Hành trình một giờ có bình luận</p></td><td><h2>Không bao gồm những gì?</h2><p>❌Hình ảnh lưu niệm<br>❌Thức ăn và đồ uống</p></td></tr></tbody></table></figure><h3>Thông tin thêm</h3><p>Thế vận hội Olympic Paris sẽ diễn ra từ ngày 26 tháng 7 đến ngày 11 tháng 8 năm 2024 và Thế vận hội Paralympic từ ngày 28 tháng 8 đến ngày 8 tháng 9 năm 2024. Do những sự kiện này, một số dịch vụ của nhà cung cấp tour du lịch sẽ bị ảnh hưởng:</p><ul><li>Ngày 14 tháng 7 năm 2024: đóng cửa hoàn toàn hoạt động bắt đầu từ 14:00</li><li>Ngày 27 tháng 7 năm 2024: khởi hành lần đầu lúc 12:00</li><li>Ngày 8 tháng 7 đến ngày 11 tháng 8 năm 2024: khởi hành lần đầu lúc 11:00</li><li>Ngày 1 và 2 tháng 9 năm 2024: khởi hành lần đầu lúc 13:30</li><li>Ngày 3 tháng 9 năm 2024: khởi hành lần đầu lúc 15:00</li></ul><p>Thời gian khởi hành chỉ được cung cấp để cung cấp thông tin và có thể thay đổi.</p><p>Vào ngày 18 tháng 7 năm 2024, hành trình bình luận kéo dài một giờ sẽ hoạt động như bình thường. Tuy nhiên, chỉ những người có thẻ kỹ thuật số mới được phép vào địa điểm, một biện pháp được Chính phủ Pháp thực hiện nhằm đảm bảo an ninh cho khu vực lân cận sông Seine, nơi sẽ trở thành địa điểm mang tính biểu tượng cho lễ khai mạc Thế vận hội.</p><p>Bạn có thể nhận được thẻ thông qua trang web chính thức của chính phủ. Nhà cung cấp tour du lịch từ chối mọi trách nhiệm trong trường hợp không xuất trình được thẻ dẫn đến việc từ chối vào cửa. Bạn nên bắt đầu quá trình này ít nhất 15 ngày trước ngày sử dụng dịch vụ.</p><p>Vui lòng tham khảo trang web của nhà cung cấp tour để biết giờ hoạt động được cập nhật.</p><p>Xin lưu ý rằng động vật không được phép lên tàu.</p><p>Xin lưu ý rằng hành lý vượt quá sức chứa 16 lít không được chấp nhận. Chỉ được phép mang ba lô nhỏ, túi xách và hộp đựng máy tính xách tay lên máy bay.</p>",
					CoverImgThumbnailPath = "files/ImgNews/Thumbnail-Sightseeing_France.jpg",
					CoverImgPath = "files/ImgNews/Cover-Sightseeing_France.jpg",
					StampPath = "files/ImgNews/Stamp-Sightseeing_France.jpg",
					Views = 510,
					Votes = 59,
					CategoryId = 1,
					Published = true,
					CreatedBy = 5,
					CreatedDate = now
				}
			);
		}
	}
}