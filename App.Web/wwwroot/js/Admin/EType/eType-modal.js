function UpdateEType(id, name) {
	// Đặt các giá trị trong modal cập nhật
	$('#updateEType #idEdit').val(id);
	$('#updateEType #eTypeName-field').val(name);
}

function setDeleteId(id) {
	const deleteConfirmBtn = document.getElementById('deleteConfirmBtn');
	deleteConfirmBtn.href = `/Admin/AppEType/Delete/${id}`;
}