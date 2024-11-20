function UpdateRType(id, roomTypeName, peopleStay, bringPet, description) {
    // Set values in the update modal
    $('#updateRType #idRType').val(id);
    $('#updateRType #rTypeName-field').val(roomTypeName);
    $('#updateRType #rTypePeopleStay-field').val(peopleStay);
    if (bringPet == 'True') {
        $('#updateRType #rTypeBringPet-field').prop('checked', bringPet);
    }
    $('#updateRType #rTypeDecs-field').val(description);
}

function setDeleteId(id) {
	const deleteConfirmBtn = document.getElementById('deleteConfirmBtn');
	deleteConfirmBtn.href = `/Admin/AppRType/Delete/${id}`;
}