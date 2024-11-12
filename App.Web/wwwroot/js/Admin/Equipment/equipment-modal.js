const choice = new Choices('.js-choice', {
	searchEnabled: true,
	itemSelectText: '',
});
function UpdateEquipment(id, name, description, typeEquipmentId) {
	// Đặt các giá trị trong modal cập nhật
	$('#updateEquipment #idEdit').val(id);
	$('#updateEquipment #equipmentName-field').val(name);
	$('#updateEquipment #equipmentDesc-field').val(description);

	// Debugging: Log the typeEquipmentId value
	$('#updateEquipment select[name="TypeEquipmentId"]').val(typeEquipmentId).change();
	choices.setChoiceByValue(typeEquipmentId);

	// Set value for the equipment type dropdown
	var dropdown = $('#updateEquipment select[name="TypeEquipmentId"]');
	console.log("Dropdown before setting value:", dropdown.val());

	// Polling mechanism to ensure the dropdown options are loaded
	var interval = setInterval(function () {
		if (dropdown.find('option').length > 0) {
			dropdown.val(typeEquipmentId).change();
			console.log("Dropdown after setting value:", dropdown.val());
			clearInterval(interval);
		}
	}, 100); // Check every 100ms
}

function setDeleteId(id) {
	const deleteConfirmBtn = document.getElementById('deleteConfirmBtn');
	deleteConfirmBtn.href = `/Admin/AppEquipment/Delete/${id}`;
}