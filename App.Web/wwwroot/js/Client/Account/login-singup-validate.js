$(document).ready(function () {
    // User name validation
    $('#username').on('input', function () {
        var name = $(this);
        var value = name.val().trim();
        var isValid = /^(?!.*[_.]{2})[a-zA-Z0-9_]+$/.test(value) && value.length >= 4 && value.length <= 200;

        if (isValid) {
            name[0].setCustomValidity('');
            name.removeClass('is-invalid').addClass('is-valid');
        } else {
            name[0].setCustomValidity('Tên đăng nhập không hợp lệ');
            name.removeClass('is-valid').addClass('is-invalid');
        }
    });

    // User pass validation
    $('#password').on('input', function () {
        var pass = $(this);
        var value = pass.val().trim();
        var isValid = value.length > 4;

        if (isValid) {
            pass[0].setCustomValidity('');
            pass.removeClass('is-invalid').addClass('is-valid');
        } else {
            pass[0].setCustomValidity('Mật khẩu không hợp lệ');
            pass.removeClass('is-valid').addClass('is-invalid');
        }
    });

    // User fullName validation
    $('#fullName').on('input', function () {
        var fullName = $(this);
        var value = fullName.val().trim();
        var isValid = value.length >= 1;

        if (isValid) {
            fullName[0].setCustomValidity('');
            fullName.removeClass('is-invalid').addClass('is-valid');
        } else {
            fullName[0].setCustomValidity('Tên không hợp lệ');
            fullName.removeClass('is-valid').addClass('is-invalid');
        }
    });

    // Email validation
    $('#email').on('input', function () {
        var email = $(this);
        var value = email.val();
        var isValid = /^[^\s@]+@[^\s@]+\.[^\s@]+$/.test(value) && value.length <= 200;

        if (isValid) {
            email[0].setCustomValidity('');
            email.removeClass('is-invalid').addClass('is-valid');
        } else {
            email[0].setCustomValidity('Địa chỉ email không hợp lệ');
            email.removeClass('is-valid').addClass('is-invalid');
        }
    });

    // phoneNumber1 validation
    $('#phoneNumber1').on('input', function () {
        var phoneNumber = $(this);
        var value = phoneNumber.val().replace(/[^0-9+]/g, ''); // Remove all non-numeric characters
        if (value.length > 15) {
            value = value.slice(0, 15); // Truncate the input value to 15 characters
        }
        phoneNumber.val(value);

        var isValid = value.length >= 10 && value.length <= 15;

        if (isValid) {
            phoneNumber[0].setCustomValidity('');
            phoneNumber.removeClass('is-invalid').addClass('is-valid');
        } else {
            phoneNumber[0].setCustomValidity('Số điện thoại không hợp lệ');
            phoneNumber.removeClass('is-valid').addClass('is-invalid');
        }
    });

    // address validation
    $('#address').on('input', function () {
        var address = $(this);
        var value = address.val().trim();
        var isValid = value.length > 0;

        if (isValid) {
            address[0].setCustomValidity('');
            address.removeClass('is-invalid').addClass('is-valid');
        } else {
            address[0].setCustomValidity('Địa chỉ không hợp lệ');
            address.removeClass('is-valid').addClass('is-invalid');
        }
    });
});