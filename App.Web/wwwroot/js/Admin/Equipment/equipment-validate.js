$(document).ready(function () {
    // Equipment name validation
    $('#equipmentName-field').on('input', function () {
        var name = $(this);
        var value = name.val().trim();
        var isValid = value.length >= 1 && value.length <= 200;

        if (isValid) {
            name[0].setCustomValidity('');
            name.removeClass('is-invalid').addClass('is-valid');
        } else {
            name[0].setCustomValidity('Invalid equipment name');
            name.removeClass('is-valid').addClass('is-invalid');
        }
    });

    // Description validation
    $('#equipmentDesc-field').on('input', function () {
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

    // Validate Type selection
    $('#equipmentType-field').on('change', function () {
        var typeSelect = $(this);
        var value = typeSelect.val();
        var isValid = value && value !== '';

        if (isValid) {
            typeSelect[0].setCustomValidity('');
            typeSelect.removeClass('is-invalid').addClass('is-valid');
        } else {
            typeSelect[0].setCustomValidity('Invalid type selection');
            typeSelect.removeClass('is-valid').addClass('is-invalid');
        }
    });

    // Trigger validation on form submit
    $('form').on('submit', function (event) {
        $('#equipmentType-field').trigger('change');
        if (!this.checkValidity()) {
            event.preventDefault();
            event.stopPropagation();
        }
        this.classList.add('was-validated');
    });
});