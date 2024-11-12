$(document).ready(function () {
    "use strict";
    var forms = $(".needs-validation");
    forms.each(function () {
        $(this).on("submit", function (event) {
            if (this.checkValidity() === false) {
                event.preventDefault();
                event.stopPropagation();
            }
            $(this).addClass("was-validated");
        });
    });
});