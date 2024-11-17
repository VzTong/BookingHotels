$(document).ready(function () {
    
    // Image validation
    $('#fileCateNewsInput').on('change', function () {
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
    $('#cateNewsTitle-field').on('input', function () {
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
    $('#cateNewsContent-field').on('input', function () {
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
});