$(document).ready(function () {
    // Equipment type name validation
    $('#eTypeName-field').on('input', function () {
        var name = $(this);
        var value = name.val().trim();
        var isValid = value.length >= 1 && value.length <= 200;

        if (isValid) {
            name[0].setCustomValidity('');
            name.removeClass('is-invalid').addClass('is-valid');
        } else {
            name[0].setCustomValidity('Tên loại thiết bị không hợp lệ');
            name.removeClass('is-valid').addClass('is-invalid');
        }
    });
});