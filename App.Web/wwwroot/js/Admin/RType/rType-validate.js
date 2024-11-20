$(document).ready(function () {
    // Room type name validation
    $('#rTypeName-field').on('input', function () {
        var name = $(this);
        var value = name.val().trim();
        var isValid = value.length >= 1 && value.length <= 100;

        if (isValid) {
            name[0].setCustomValidity('');
            name.removeClass('is-invalid').addClass('is-valid');
        } else {
            name[0].setCustomValidity('Tên loại phòng không hợp lệ');
            name.removeClass('is-valid').addClass('is-invalid');
        }
    });

    // PeopleStay validation
    $('#rTypePeopleStay-field').on('input', function () {
        var name = $(this);
        var value = name.val().trim();
        var isValid = value.length >= 1 && value.length <= 2;

        if (isValid) {
            name[0].setCustomValidity('');
            name.removeClass('is-invalid').addClass('is-valid');
        } else {
            name[0].setCustomValidity('Số người ở không hợp lệ');
            name.removeClass('is-valid').addClass('is-invalid');
        }
    });
});