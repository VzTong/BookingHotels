$(document).ready(function () {
    // Room Floor Numbervalidation
    $('#roomFloorNumber-field').on('input', function () {
        var name = $(this);
        var value = name.val().trim();
        var isValid = value.length >= 1;

        if (isValid) {
            name[0].setCustomValidity('');
            name.removeClass('is-invalid').addClass('is-valid');
        } else {
            name[0].setCustomValidity('Số tầng không hợp lệ');
            name.removeClass('is-valid').addClass('is-invalid');
        }
    });

    // Room Number validation
    $('#roomNumber-field').on('input', function () {
        var name = $(this);
        var value = name.val().trim();
        var isValid = value.length >= 1;

        if (isValid) {
            name[0].setCustomValidity('');
            name.removeClass('is-invalid').addClass('is-valid');
        } else {
            name[0].setCustomValidity('Số phòng không hợp lệ');
            name.removeClass('is-valid').addClass('is-invalid');
        }
    });

    // Price validation
    $('#price-field').on('input', function () {
        var name = $(this);
        var value = name.val().trim();
        if (value.length > 10) {
            value = value.slice(0, 10);
        }
        phoneNumber.val(value);

        var isValid = value.length >= 1 && value.length <= 10;

        if (isValid) {
            name[0].setCustomValidity('');
            name.removeClass('is-invalid').addClass('is-valid');
        } else {
            name[0].setCustomValidity('Giá phòng không hợp lệ');
            name.removeClass('is-valid').addClass('is-invalid');
        }
    });

    // Discount Price validation
    $('#discountPrice-field').on('input', function () {
        var name = $(this);
        var value = name.val().trim();
        if (value.length > 10) {
            value = value.slice(0, 10);
        }
        name.val(value);

        var roomPrice = parseFloat($('#price-field').val().trim());
        var discountPrice = parseFloat(value);

        var isValid = (value.length >= 1 && value.length <= 10 && discountPrice < roomPrice) || value.length == 0;

        if (isValid) {
            name[0].setCustomValidity('');
            name.removeClass('is-invalid').addClass('is-valid');
        } else {
            name[0].setCustomValidity('Giá giảm phải nhỏ hơn giá phòng');
            name.removeClass('is-valid').addClass('is-invalid');
        }
    });

    // Remove spaces before form submission
    $('form').on('submit', function () {
        var priceField = $('#price-field');
        var discountPriceField = $('#discountPrice-field');

        if (priceField.length) {
            priceField.val(priceField.val().replace(/\s+/g, ''));
        }

        if (discountPriceField.length) {
            discountPriceField.val(discountPriceField.val().replace(/\s+/g, ''));
        }
    });
});