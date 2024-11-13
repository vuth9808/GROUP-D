// Function for Koi Consulting
function consultKoi() {
    const element = document.getElementById("element-select").value;
    const result = document.getElementById("result");

    if (!element) {
        result.innerHTML = "<p>Vui lòng chọn bản mệnh để được tư vấn.</p>";
        return;
    }

    let advice = "";

    switch (element) {
        case "kim":
            advice = `
                <h4>Bản mệnh Kim</h4>
                <p><strong>Số lượng:</strong> 4 hoặc 9 con</p>
                <p><strong>Màu sắc:</strong> Trắng, bạc hoặc vàng ánh kim</p>
                <p><strong>Loại cá:</strong> Kohaku (đỏ trắng), Ogon (vàng ánh kim)</p>
            `;
            break;
        case "moc":
            advice = `
                <h4>Bản mệnh Mộc</h4>
                <p><strong>Số lượng:</strong> 3 hoặc 8 con</p>
                <p><strong>Màu sắc:</strong> Xanh lá cây, xanh lam</p>
                <p><strong>Loại cá:</strong> Shusui (xanh nhạt), Midori (xanh lá cây)</p>
            `;
            break;
        case "thuy":
            advice = `
                <h4>Bản mệnh Thủy</h4>
                <p><strong>Số lượng:</strong> 1 hoặc 6 con</p>
                <p><strong>Màu sắc:</strong> Đen, xanh dương</p>
                <p><strong>Loại cá:</strong> Kumonryu (đen trắng), Shiro Utsuri (đen trắng)</p>
            `;
            break;
        case "hoa":
            advice = `
                <h4>Bản mệnh Hỏa</h4>
                <p><strong>Số lượng:</strong> 2 hoặc 7 con</p>
                <p><strong>Màu sắc:</strong> Đỏ, cam</p>
                <p><strong>Loại cá:</strong> Hi Utsuri (đỏ đen), Tancho (trắng với chấm đỏ trên đầu)</p>
            `;
            break;
        case "tho":
            advice = `
                <h4>Bản mệnh Thổ</h4>
                <p><strong>Số lượng:</strong> 5 hoặc 10 con</p>
                <p><strong>Màu sắc:</strong> Vàng, nâu</p>
                <p><strong>Loại cá:</strong> Ki Utsuri (vàng đen), Chagoi (nâu)</p>
            `;
            break;
        default:
            advice = "<p>Không tìm thấy bản mệnh phù hợp.</p>";
            break;
    }

    result.innerHTML = advice;
}

// Back to Top Button
window.onscroll = function() { scrollFunction() };

function scrollFunction() {
    const backToTopButton = document.getElementById("back-to-top");
    if (document.body.scrollTop > 200 || document.documentElement.scrollTop > 200) {
        backToTopButton.style.display = "block";
    } else {
        backToTopButton.style.display = "none";
    }
}

function backToTop() {
    document.body.scrollTop = 0;
    document.documentElement.scrollTop = 0;
}
