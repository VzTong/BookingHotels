$(document).ready(function () {

    // Image Stamp validation
    $('#fileNewsInput_Stamp').on('change', function () {
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
    });// Image Stamp validation
    $('#fileNewsInput_Stamp_update').on('change', function () {
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

    // Image Thumbnail validation
    $('#fileNewsInput_Thumbnail').on('change', function () {
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
    });// Image Thumbnail validation
    $('#fileNewsInput_Thumbnail_update').on('change', function () {
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

    // Image validation
    $('#fileNewsInput').on('change', function () {
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
    });// Image validation
    $('#fileNewsInput_update').on('change', function () {
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

    // Title validation
    $('#newsTitle-field').on('input', function () {
        var title = $(this);
        var value = title.val().trim();
        var isValid = value.length >= 10 && value.length <= 255;

        if (isValid) {
            title[0].setCustomValidity('');
            title.removeClass('is-invalid').addClass('is-valid');
        } else {
            title[0].setCustomValidity('Tiêu đề không hợp lệ');
            title.removeClass('is-valid').addClass('is-invalid');
        }
    });

    // Content validation
    $('#newsContent-field').on('input', function () {
        var content = $(this);
        var value = content.val().trim();
        var isValid = value.length >= 1 && value.length <= 500;

        if (isValid) {
            content[0].setCustomValidity('');
            content.removeClass('is-invalid').addClass('is-valid');
        } else {
            content[0].setCustomValidity('Nội dung không hợp lệ');
            content.removeClass('is-valid').addClass('is-invalid');
        }
    });

    // Summary validation
    $('#newsSummary-field').on('input', function () {
        var summary = $(this);
        var value = summary.val().trim();
        var isValid = value.length >= 1 && value.length <= 500;

        if (isValid) {
            summary[0].setCustomValidity('');
            summary.removeClass('is-invalid').addClass('is-valid');
        } else {
            summary[0].setCustomValidity('Nội dung không hợp lệ');
            summary.removeClass('is-valid').addClass('is-invalid');
        }
    });
});