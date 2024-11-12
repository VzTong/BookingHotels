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
    $('#hotelEmail-field').on('input', function () {
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

    // Image validation
    $('#fileHotelInput').on('change', function () {
        var fileInput = $(this);
        var file = fileInput[0].files[0];
        var isValid = file && file.type.startsWith('image/');

        if (isValid) {
            fileInput[0].setCustomValidity('');
            fileInput.removeClass('is-invalid').addClass('is-valid');
        } else {
            fileInput[0].setCustomValidity('Tệp hình ảnh không hợp lệ');
            fileInput.removeClass('is-valid').addClass('is-invalid');
        }
    });

    // Name validation
    $('#hotelName-field').on('input', function () {
        var name = $(this);
        var value = name.val().trim();
        var isValid = value.length >= 1 && value.length <= 200;

        if (isValid) {
            name[0].setCustomValidity('');
            name.removeClass('is-invalid').addClass('is-valid');
        } else {
            name[0].setCustomValidity('Tên không hợp lệ');
            name.removeClass('is-valid').addClass('is-invalid');
        }
    });

    // Reset button click event
    $('button[type="reset"]').on('click', function () {
        $('#imgHotelPreview').css('display', 'none').attr('src', '');
        $('#iconHotelPreview').show();
        $('#fileHotelInput').val('');
    });
});