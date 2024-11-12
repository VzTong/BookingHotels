const fileInput = $('#fileInput');
const fileInput2 = $('#fileInput2');
const imagePreview = $('#imagePreview');
const iconPreview = $('#iconPreview');
let choices;

$(document).ready(function () {
	choices = new Choices('.js-choice', {
		searchEnabled: true,
		itemSelectText: '',
	});
});

// Sử dụng .on thay vì addEventListener để đăng ký sự kiện trong jQuery
fileInput.on('change', function (ev) {
	const file = fileInput[0].files[0];
	if (file) {
		imagePreview.show(); // Hiển thị thẻ img
		iconPreview.hide(); // Ẩn thẻ icon
		imagePreview.attr('src', URL.createObjectURL(file));
	}
});

// Handle file input change for update modal
$('#fileInput2').on('change', function (ev) {
	const file = this.files[0];
	if (file) {
		$('#updateBranchHotel #imagePreview').show(); // Show img tag
		$('#updateBranchHotel #iconPreview').hide(); // Hide icon tag
		$('#updateBranchHotel #imagePreview').attr('src', URL.createObjectURL(file));
	}
});

function UpdateBranch(id, name, address, iMap, quantityStaff, quantityRoom, hotelId, description, img) {
	// Set values in the update modal
	$('#updateBranchHotel #idEdit').val(id);
	$('#updateBranchHotel #branchName-field').val(name);
	$('#updateBranchHotel #branchAddress-field').val(address);
	$('#updateBranchHotel #branchIdMap-field').val(iMap);
	$('#updateBranchHotel #branchQuantityStaff-field').val(quantityStaff);
	$('#updateBranchHotel #branchQuantityRoom-field').val(quantityRoom);
	$('#updateBranchHotel #branchDesc-field').val(description);

	// Set value for hotel dropdown
	$('#updateBranchHotel select[name="HotelId"]').val(hotelId).change();
	choices.setChoiceByValue(hotelId);

	// Set image preview
	if (img) {
		var imgSrc = img.toLowerCase().startsWith("https") ? img : "/" + img;
		$('#updateBranchHotel #imagePreview').attr('src', imgSrc).show();
		$('#updateBranchHotel #iconPreview').hide();
	} else {
		$('#updateBranchHotel #imagePreview').hide();
		$('#updateBranchHotel #iconPreview').show();
	}

	// Clear file input value
	$('#updateBranchHotel #fileInput2').val('');
}

function setDeleteId(id) {
	const deleteConfirmBtn = document.getElementById('deleteConfirmBtn');
	deleteConfirmBtn.href = `/Admin/AppBranchHotel/Delete/${id}`;
}