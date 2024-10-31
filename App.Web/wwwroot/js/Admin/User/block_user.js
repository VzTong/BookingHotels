$(document).ready(function () {
	$('.js-block').on("click", function (ev) {
		const idUser = $(this).attr('data-id');
		const username = $(this).attr('data-username');

		$('.js-name').text(`Khóa tài khoản [${username}]`);
		$("#blockUser #Id").val(idUser);
	});
});