$(document).ready(function () {

    // Phone number validation
    $('#phoneNumber-field').on('input', function () {
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

    // Phone number validation
    $('#phoneNumber-field-2').on('input', function () {
        var phoneNumber = $(this);
        var value = phoneNumber.val().replace(/[^0-9+]/g, ''); // Remove all non-numeric characters
        if (value.length > 15) {
            value = value.slice(0, 15); // Truncate the input value to 15 characters
        }
        phoneNumber.val(value);

        var isValid = (value.length >= 10 && value.length <= 15) || value.length == 0;

        if (isValid) {
            phoneNumber[0].setCustomValidity('');
            phoneNumber.removeClass('is-invalid').addClass('is-valid');
        } else {
            phoneNumber[0].setCustomValidity('Số điện thoại không hợp lệ');
            phoneNumber.removeClass('is-valid').addClass('is-invalid');
        }
    });

    // Email validation
    $('#userEmail-field').on('input', function () {
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

    // Addr validation
    $('#userAddr-field').on('input', function () {
        var addr = $(this);
        var value = addr.val();
        var isValid = value.length >= 1;

        if (isValid) {
            addr[0].setCustomValidity('');
            addr.removeClass('is-invalid').addClass('is-valid');
        } else {
            addr[0].setCustomValidity('Địa chỉ không hợp lệ');
            addr.removeClass('is-valid').addClass('is-invalid');
        }
    });

    // Name validation
    $('#userName-field').on('input', function () {
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

    // FullName validation
    $('#userFullName-field').on('input', function () {
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

    // password validation
    $('#new-password-input').on('input', function () {
        var pass = $(this);
        var value = pass.val().trim();
        var isValid = value.length >= 1;

        if (isValid) {
            pass[0].setCustomValidity('');
            pass.removeClass('is-invalid').addClass('is-valid');
        } else {
            pass[0].setCustomValidity('Vui lòng nhập mật khẩu');
            pass.removeClass('is-valid').addClass('is-invalid');
        }
    });

    // Confirm password validation
    $('#confirm-password-input').on('input', function () {
        var confirmPass = $(this);
        var value = confirmPass.val().trim();
        var isValid = value.length >= 1;

        if (isValid) {
            confirmPass[0].setCustomValidity('');
            confirmPass.removeClass('is-invalid').addClass('is-valid');
        } else {
            confirmPass[0].setCustomValidity('Hãy xác nhận mật khẩu');
            confirmPass.removeClass('is-valid').addClass('is-invalid');
        }
    });
});