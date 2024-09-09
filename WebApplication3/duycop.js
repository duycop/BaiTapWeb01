﻿//code jquery viết thế nào??
$(document).ready(function () {

	function gui_api() {
		var data = {
			a: $('#TextBox1').val(),
			b: $('#TextBox2').val(),
			c: $('#TextBox3').val(),
		};
		if (data.a == '' || isNaN(data.a)) {
			$('#ketqua_web').html('Kiểm tra lại giá trị của A');
			$('#TextBox1').focus();
			return;
		}
		if (data.b == '' || isNaN(data.b)) {
			$('#ketqua_web').html('Kiểm tra lại giá trị của B');
			$('#TextBox2').focus();
			return;
		}
		if (data.c == '' || isNaN(data.c)) {
			$('#ketqua_web').html('Kiểm tra lại giá trị của C');
			$('#TextBox3').focus();
			return;
		}
		$('#ketqua_web').html('Đang gửi API tính toán...');

		$.post("api.aspx",
			data,
			function (kq, status) {
				if (status == "success") {
					//tiền xử lý kq -> json
					var json = JSON.parse(kq);
					if (json.ok) {
						var dientich = json.msg;
						var html = "Diện tích tam giác = " + dientich;
						$('#ketqua_web').html(html);
					}
					else {
						$('#ketqua_web').html(json.msg);
					}
				}
			});
	}
	$("#Button1").click(function () {
		gui_api();
	});
});