$(document).ready(function () {
    // Branch name validation
    $('#branchName-field').on('input', function () {
        var name = $(this);
        var value = name.val().trim();
        var isValid = value.length >= 1 && value.length <= 200;

        if (isValid) {
            name[0].setCustomValidity('');
            name.removeClass('is-invalid').addClass('is-valid');
        } else {
            name[0].setCustomValidity('Invalid branch name');
            name.removeClass('is-valid').addClass('is-invalid');
        }
    });

    // Branch address validation
    $('#branchAddress-field').on('input', function () {
        var address = $(this);
        var value = address.val().trim();
        var isValid = value.length > 0;

        if (isValid) {
            address[0].setCustomValidity('');
            address.removeClass('is-invalid').addClass('is-valid');
        } else {
            address[0].setCustomValidity('Invalid address');
            address.removeClass('is-valid').addClass('is-invalid');
        }
    });

    // Branch map ID validation
    $('#branchIdMap-field').on('input', function () {
        var idMap = $(this);
        var value = idMap.val().trim();
        var isValid = value.length > 0;

        if (isValid) {
            idMap[0].setCustomValidity('');
            idMap.removeClass('is-invalid').addClass('is-valid');
        } else {
            idMap[0].setCustomValidity('Invalid map ID');
            idMap.removeClass('is-valid').addClass('is-invalid');
        }
    });

    // Quantity staff validation
    $('#branchQuantityStaff-field').on('input', function () {
        var quantityStaff = $(this);
        var value = quantityStaff.val();
        var isValid = value > 0;

        if (isValid) {
            quantityStaff[0].setCustomValidity('');
            quantityStaff.removeClass('is-invalid').addClass('is-valid');
        } else {
            quantityStaff[0].setCustomValidity('Invalid quantity');
            quantityStaff.removeClass('is-valid').addClass('is-invalid');
        }
    });

    // Quantity room validation
    $('#branchQuantityRoom-field').on('input', function () {
        var quantityRoom = $(this);
        var value = quantityRoom.val();
        var isValid = value > 0;

        if (isValid) {
            quantityRoom[0].setCustomValidity('');
            quantityRoom.removeClass('is-invalid').addClass('is-valid');
        } else {
            quantityRoom[0].setCustomValidity('Invalid quantity');
            quantityRoom.removeClass('is-valid').addClass('is-invalid');
        }
    });

    // Description validation
    $('#branchDesc-field').on('input', function () {
        var description = $(this);
        var value = description.val().trim();
        var isValid = value.length > 0;

        if (isValid) {
            description[0].setCustomValidity('');
            description.removeClass('is-invalid').addClass('is-valid');
        } else {
            description[0].setCustomValidity('Invalid description');
            description.removeClass('is-valid').addClass('is-invalid');
        }
    });

    // Image validation
    $('#fileInput').on('change', function () {
        var fileInput = $(this);
        var file = fileInput[0].files[0];
        var isValid = file && file.type.startsWith('image/');

        if (isValid) {
            fileInput[0].setCustomValidity('');
            fileInput.removeClass('is-invalid').addClass('is-valid');
        } else {
            fileInput[0].setCustomValidity('Invalid image file');
            fileInput.removeClass('is-valid').addClass('is-invalid');
        }
    });

    // Validate Hotel selection
    $('#branchHotelId-field').on('change', function () {
        var hotelSelect = $(this);
        var value = hotelSelect.val();
        var isValid = value && value !== '';

        if (isValid) {
            hotelSelect[0].setCustomValidity('');
            hotelSelect.removeClass('is-invalid').addClass('is-valid');
        } else {
            hotelSelect[0].setCustomValidity('Invalid hotel selection');
            hotelSelect.removeClass('is-valid').addClass('is-invalid');
        }
    });

    // Trigger validation on form submit
    $('form').on('submit', function (event) {
        $('#branchHotelId-field').trigger('change');
        if (!this.checkValidity()) {
            event.preventDefault();
            event.stopPropagation();
        }
        this.classList.add('was-validated');
    });
});