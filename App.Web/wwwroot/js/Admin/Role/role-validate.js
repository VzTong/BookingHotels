$(document).ready(function () {
    // Role name validation
    $('#roleName-field').on('input', function () {
        var name = $(this);
        var value = name.val().trim();
        var isValid = value.length >= 1 && value.length <= 50;

        if (isValid) {
            name[0].setCustomValidity('');
            name.removeClass('is-invalid').addClass('is-valid');
        } else {
            name[0].setCustomValidity('Tên quyền không hợp lệ');
            name.removeClass('is-valid').addClass('is-invalid');
        }
    });

    // Role desc validation
    $('#roleDesc-field').on('input', function () {
        var name = $(this);
        var value = name.val().trim();
        var isValid = value.length >= 1 && value.length <= 100;

        if (isValid) {
            name[0].setCustomValidity('');
            name.removeClass('is-invalid').addClass('is-valid');
        } else {
            name[0].setCustomValidity('Mô tả không hợp lệ');
            name.removeClass('is-valid').addClass('is-invalid');
        }
    });
});