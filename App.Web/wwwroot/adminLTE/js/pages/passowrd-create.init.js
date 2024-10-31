/*Array.from(document.querySelectorAll("form .auth-pass-inputgroup")).forEach(function (s) { Array.from(s.querySelectorAll(".password-addon")).forEach(function (t) { t.addEventListener("click", function (t) { var e = s.querySelector(".password-input"); "password" === e.type ? e.type = "text" : e.type = "password" }) }) }); var passwordOld = document.getElementById("old-password-input"), passwordNew = document.getElementById("new-password-input"), confirm_password = document.getElementById("confirm-password-input"); var myInput = document.getElementById("new-password-input"), length = document.getElementById("pass-length"), capital = document.getElementById("unicode-check"); myInput.onfocus = function () { document.getElementById("password-contain").style.display = "block" }, myInput.onblur = function () { document.getElementById("password-contain").style.display = "block" }, myInput.onkeyup = function () { 4 <= myInput.value.length ? (length.classList.remove("invalid"), length.classList.add("valid")) : (length.classList.remove("valid"), length.classList.add("invalid")); (!myInput.value.match(/[^\x00-\x7F]/)) && myInput.value.length != 0 ? (capital.classList.remove("invalid"), capital.classList.add("valid")) : (capital.classList.remove("valid"), capital.classList.add("invalid")) };*/
Array.from(document.querySelectorAll("form .auth-pass-inputgroup")).forEach(function (s) {
    Array.from(s.querySelectorAll(".password-addon")).forEach(function (t) {
        t.addEventListener("click", function (t) {
            var e = s.querySelector(".password-input");
            "password" === e.type ? e.type = "text" : e.type = "password";
        });
    });
});

var passwordOld = document.getElementById("old-password-input"),
    passwordNew = document.getElementById("new-password-input"),
    confirm_password = document.getElementById("confirm-password-input");

var myInput = document.getElementById("new-password-input"),
    length = document.getElementById("pass-length"),
    capital = document.getElementById("unicode-check");

myInput.onfocus = function () {
    document.getElementById("password-contain").style.display = "block";
};

myInput.onblur = function () {
    document.getElementById("password-contain").style.display = "block";
};

myInput.onkeyup = function () {
    var isLengthValid = myInput.value.length >= 4;
    var isCapitalValid = myInput.value.length != 0 && !myInput.value.match(/[^\x00-\x7F]/);

    if (isLengthValid) {
        length.classList.remove("invalid");
        length.classList.add("valid");
    } else {
        length.classList.remove("valid");
        length.classList.add("invalid");
    }

    if (isCapitalValid) {
        capital.classList.remove("invalid");
        capital.classList.add("valid");
    } else {
        capital.classList.remove("valid");
        capital.classList.add("invalid");
    }

    if (isLengthValid && isCapitalValid) {
        myInput.setCustomValidity("");
    } else {
        myInput.setCustomValidity("Invalid password");
    }
};
