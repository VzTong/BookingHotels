function setCookie(cname, cvalue, exdays) {
    var d = new Date();
    d.setTime(d.getTime() + (exdays * 24 * 60 * 60 * 1000));
    var expires = "expires=" + d.toUTCString();
    document.cookie = cname + "=" + cvalue + ";" + expires + ";path=/";
}

function getCookie(cname) {
    var name = cname + "=";
    var ca = document.cookie.split(';');
    for (var i = 0; i < ca.length; i++) {
        var c = ca[i];
        while (c.charAt(0) == ' ') {
            c = c.substring(1);
        }
        if (c.indexOf(name) == 0) {
            return c.substring(name.length, c.length);
        }
    }
    return "";
}

function updateProductCount(isUp = true, quan = 1) {
    var point = document.querySelector(".cart-shopping .cart-text");
    var num = Number(point.innerText);
    num = isUp ? quan + num : num - quan;
    point.innerText = num;
}

function setProductCount(val = 1) {
    var point = $(`<span class="cart-text color">${val}</span>`);
    var cart = $("a.cart-shopping");
    cart.find(".cart-text").remove();
    cart.append(point);
}

function hasProductCount() {
    var point = $(".cart-shopping .cart-text");
    return point.length > 0;
}

function addToCart(roomId) {
    var cName = "sp_" + roomId;
    if (getCookie(cName)) {
        // Room is already in the cart, hide the button
        $("#addToCartButton").hide();
        return;
    }
    var quan = 1;   // Chỉ thêm vào 1 sản phẩm mỗi lần click
    var expDay = 30;    // Giỏ hàng tồn tại 1 tháng
    setCookie(cName, quan, expDay);
    recountCart();
    var totalEle = $(".cart-total");
    if (!totalEle.length) {
        // ở trang giỏ hàng thì không show thông báo
        notyf.success("Đã thêm phòng vào danh mục đặt phòng");
    }
    // Hide the button after adding to cart
    $("#addToCartButton").hide();
}

function deleteProductFromCart(evt, id) {
    setCookie("sp_" + id, 0, -1);
    $(evt.target).closest(".accordion-item").remove(); // Adjusted selector to match the structure in Index.cshtml
    recountCart();
    setTimeout(() => {
        $(".accordion-item").each(function (i, ele) {
            $(ele).find(".cart-no").text(i + 1); // Update item numbers
        });
    }, 0);
}

function removeFromCart(productId) {
    var cName = "sp_" + productId;
    var quan = -1;   // Giảm 1 sản phẩm mỗi lần click
    var expDay = 30;    // Giỏ hàng tồn tại 1 tháng
    if (Number(getCookie(cName)) <= 1) {
        return;
    }
    if (getCookie(cName)) {
        setCookie(cName, Number(getCookie(cName)) + quan, expDay);
    }
    recountCart();
}

function recountCart() {
    var cookie = document.cookie.split(";");
    var numOfProduct = 0;
    for (let i = 0; i < cookie.length; i++) {
        if (cookie[i].indexOf("sp_") >= 0) {
            numOfProduct += Number(cookie[i].split("=")[1]);
        }
    }

    setProductCount(numOfProduct);
    var totalEle = $(".cart-total-avc");
    if (totalEle.length) {
        setTimeout(() => {
            let prices = $(".cart-price[data-price]");
            let total = 0;
            prices.each(function () {
                total += Number($(this).attr("data-price"));
            });
            totalEle.text(total.toString().replace(/\B(?=(\d{3})+(?!\d))/g, ","));
        }, 100);
    }
    if (numOfProduct <= 0) {
        $(".cart-shopping .cart-text").remove();
    }
}


function updateInput(ev, productId) {
    $(ev.target)
        .closest(".cart-quantity")
        .find("input")
        .val(getCookie("sp_" + productId));
}

$(function () {
    recountCart();
});

function buyNow(evt, productId) {
    evt.preventDefault();
    addToCart(productId);
    location.href = $(evt.currentTarget).attr("href");
}
