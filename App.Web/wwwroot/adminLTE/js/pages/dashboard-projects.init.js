// Dữ liệu mẫu cho 2 năm với dữ liệu khác nhau
const defaultOptionsYears = {
    2023: {
        series: [
            { name: "Khách sạn", type: "bar", data: [34, 65, 46, 68, 49, 61, 42, 44, 78, 52, 63, 67] },
            { name: "Tổng doanh thu", type: "area", data: [89.25, 98.58, 68.74, 108.87, 77.54, 84.03, 51.24, 28.57, 92.57, 42.36, 88.51, 36.57] },
            { name: "Phòng được đặt", type: "bar", data: [8, 12, 7, 17, 21, 11, 5, 9, 7, 29, 12, 35] }
        ]
    },
    2022: {
        series: [
            { name: "Khách sạn", type: "bar", data: [28, 55, 38, 60, 43, 50, 30, 36, 65, 40, 53, 60] },
            { name: "Tổng doanh thu", type: "area", data: [70.25, 85.58, 60.74, 90.87, 70.54, 76.03, 45.24, 20.57, 80.57, 35.36, 70.51, 33.57] },
            { name: "Phòng được đặt", type: "bar", data: [5, 9, 4, 14, 17, 8, 4, 6, 5, 20, 9, 25] }
        ]
    }
};

// Mặc định hiển thị dữ liệu của tất cả các năm
let defaultOptions = {
    series: [],
    chart: {
        height: 374,
        type: "line",
        toolbar: { show: false }
    },
    stroke: {
        curve: "smooth",
        dashArray: [0, 3, 0],
        width: [0, 1, 0]
    },
    fill: {
        opacity: [1, 0.1, 1]
    },
    markers: {
        size: [0, 4, 0],
        strokeWidth: 2,
        hover: { size: 4 }
    },
    xaxis: {
        categories: ["Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"],
        axisTicks: { show: false },
        axisBorder: { show: false }
    },
    grid: {
        show: true,
        xaxis: { lines: { show: true } },
        yaxis: { lines: { show: false } },
        padding: { top: 0, right: -2, bottom: 15, left: 10 }
    },
    legend: {
        show: true,
        horizontalAlign: "center",
        offsetX: 0,
        offsetY: -5,
        markers: { width: 9, height: 9, radius: 6 },
        itemMargin: { horizontal: 10, vertical: 0 }
    },
    plotOptions: {
        bar: { columnWidth: "30%", barHeight: "70%" }
    },
    colors: getChartColorsArray("projects-overview-chart"),
    tooltip: {
        shared: true,
        y: [
            { formatter: function (e) { return void 0 !== e ? e.toFixed(0) : e } },
            { formatter: function (e) { return void 0 !== e ? "$" + e.toFixed(2) + "k" : e } },
            { formatter: function (e) { return void 0 !== e ? e.toFixed(0) : e } }
        ]
    }
};

// Khởi tạo biểu đồ mặc định
var chart = new ApexCharts(document.querySelector("#projects-overview-chart"), defaultOptions);
chart.render();

// Biến lưu trạng thái bộ lọc
let currentFilter = 'ALL';

// Cập nhật dữ liệu biểu đồ khi chọn nút
function updateChartData(filter) {
    currentFilter = filter; // Cập nhật bộ lọc hiện tại
    const year = document.getElementById('yearSelector').value; // Năm được chọn
    let newData = [];
    const currentYearData = defaultOptionsYears[year];
    const currentMonth = new Date().getMonth(); // tháng hiện tại
    const monthsAvailable = currentYearData.series[0].data.length;

    switch (filter) {
        case 'ALL':
            // Hiển thị dữ liệu của tất cả các năm
            let allSeries = [];
            let categories = defaultOptions.xaxis.categories;
            for (const year in defaultOptionsYears) {
                const data = defaultOptionsYears[year];
                allSeries.push({
                    name: data.series[0].name + ' ' + year,
                    type: data.series[0].type,
                    data: data.series[0].data
                });
                allSeries.push({
                    name: data.series[1].name + ' ' + year,
                    type: data.series[1].type,
                    data: data.series[1].data
                });
                allSeries.push({
                    name: data.series[2].name + ' ' + year,
                    type: data.series[2].type,
                    data: data.series[2].data
                });
            }
            newData = {
                series: allSeries,
                xaxis: { categories: categories }
            };
            break;

        case '1M':
            let monthToShow = monthsAvailable <= currentMonth ? monthsAvailable - 1 : currentMonth;
            newData = {
                series: [
                    { name: "Khách sạn", type: "bar", data: [currentYearData.series[0].data[monthToShow]] },
                    { name: "Tổng doanh thu", type: "area", data: [currentYearData.series[1].data[monthToShow]] },
                    { name: "Phòng được đặt", type: "bar", data: [currentYearData.series[2].data[monthToShow]] }
                ],
                xaxis: { categories: [defaultOptions.xaxis.categories[monthToShow]] }
            };
            break;

        case '6M':
            let startMonth6M = currentMonth - 5;
            let months6M = [];
            let hotelData6M = [];
            let revenueData6M = [];
            let bookingsData6M = [];

            for (let i = 0; i < 6 && (startMonth6M + i) < monthsAvailable; i++) {
                let monthIndex = (startMonth6M + i + 12) % 12;
                months6M.push(defaultOptions.xaxis.categories[monthIndex]);
                hotelData6M.push(currentYearData.series[0].data[monthIndex]);
                revenueData6M.push(currentYearData.series[1].data[monthIndex]);
                bookingsData6M.push(currentYearData.series[2].data[monthIndex]);
            }

            newData = {
                series: [
                    { name: "Khách sạn", type: "bar", data: hotelData6M },
                    { name: "Tổng doanh thu", type: "area", data: revenueData6M },
                    { name: "Phòng được đặt", type: "bar", data: bookingsData6M }
                ],
                xaxis: { categories: months6M }
            };
            break;

        case '1Y':
            // Hiển thị dữ liệu của năm hiện tại
            newData = {
                series: currentYearData.series,
                xaxis: { categories: defaultOptions.xaxis.categories }
            };
            break;
    }

    // Cập nhật biểu đồ với dữ liệu mới
    chart.updateOptions({
        series: newData.series,
        xaxis: newData.xaxis
    });
}

// Hàm lấy màu cho biểu đồ từ CSS
function getChartColorsArray(e) {
    if (null !== document.getElementById(e)) {
        var t = document.getElementById(e).getAttribute("data-colors");
        if (t)
            return (t = JSON.parse(t)).map(function (e) {
                var t = e.replace(" ", "");
                return -1 === t.indexOf(",") ? getComputedStyle(document.documentElement).getPropertyValue(t) || t : 2 == (e = e.split(",")).length ? "rgba(" + getComputedStyle(document.documentElement).getPropertyValue(e[0]) + "," + e[1] + ")" : t
            });
        console.warn("data-colors Attribute not found on:", e)
    }
}

// Mặc định chọn "All" khi mở trang
document.addEventListener('DOMContentLoaded', () => {
    updateChartData('ALL'); // Cập nhật dữ liệu cho nút "All"
});