// Placeholder for chart data for different years
let defaultOptionsYears = {};

// Biến toàn cục cho các tùy chọn biểu đồ
let defaultOptions = {};

// Biến toàn cục cho thể hiện biểu đồ
let chart;

// Hàm lấy dữ liệu biểu đồ từ máy chủ
function fetchChartData() {
    fetch('/Admin/Home/GetChartData')
        .then(response => response.json())
        .then(data => {
            defaultOptionsYears = formatChartData(data);
            initializeChart(defaultOptionsYears);
            updateChartData('1Y');
        })
        .catch(error => console.error('Lỗi khi tìm nạp dữ liệu biểu đồ:', error));
}

// Function to format the fetched chart data
function formatChartData(data) {
    const formattedData = {};
    for (const year in data) {
        formattedData[year] = {
            series: [
                { name: "SL Khách sạn", type: "bar", data: fillMissingData(data[year].series[0].data) },
                { name: "Tổng doanh thu", type: "area", data: fillMissingData(data[year].series[1].data) },
                { name: "SL phòng được đặt", type: "bar", data: fillMissingData(data[year].series[2].data) }
            ]
        };
    }
    return formattedData;
}

// Hàm điền dữ liệu còn thiếu bằng số 0
function fillMissingData(data) {
    const filledData = Array(12).fill(0);
    (data || []).forEach((value, index) => {
        filledData[index] = value;
    });
    return filledData;
}

// Hàm khởi tạo biểu đồ với dữ liệu được định dạng
function initializeChart(chartData) {
    const year = new Date().getFullYear();
    if (!chartData[year] || !chartData[year].series) {
        console.error('Không có dữ liệu cho năm đã chọn.');
        return;
    }

    defaultOptions = {
        series: chartData[year].series,
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
            categories: ["T1", "T2", "T3", "T4", "T5", "T6", "T7", "T8", "T9", "T10", "T11", "T12"],
            axisTicks: { show: false },
            axisBorder: { show: false }
        },
        yaxis: [
            {
                title: {
                    text: 'Tổng doanh thu'
                },
                labels: {
                    formatter: function (value) {
                        return new Intl.NumberFormat('vi-VN', { minimumFractionDigits: 0 }).format(value);
                    }
                }
            },
            {
                opposite: true,
                title: {
                    text: 'Số lượng'
                },
                labels: {
                    formatter: function (value) {
                        return value.toFixed(0); // Display as integer
                    }
                }
            }
        ],
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
                { formatter: function (e) { return void 0 !== e ? ": " + e.toFixed(0) : e } },
                { formatter: function (e) { return void 0 !== e ? ": " + new Intl.NumberFormat('vi-VN', { minimumFractionDigits: 0 }).format(e) + " vnđ" : e } },
                { formatter: function (e) { return void 0 !== e ? ": " + e.toFixed(0) : e } }
            ]
        }
    };

    chart = new ApexCharts(document.querySelector("#projects-overview-chart"), defaultOptions);
    chart.render();
}

// Function to update chart data when a filter is selected
function updateChartData(filter) {
    const year = document.getElementById('yearSelector').value || new Date().getFullYear(); // Selected year or current year
    let newData = [];
    const currentYearData = defaultOptionsYears[year];
    const currentMonth = new Date().getMonth(); // Current month
    const monthsAvailable = currentYearData.series[0].data.length;

    let allDataPoints = [];

    switch (filter) {
        case 'ALL':
            // Show data for all years
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
                    data: data.series[1].data,
                    yAxisIndex: 0 // Use primary y-axis
                });
                allSeries.push({
                    name: data.series[2].name + ' ' + year,
                    type: data.series[2].type,
                    data: data.series[2].data,
                    yAxisIndex: 2 // Use secondary y-axis
                });

                // Collect all data points for min/max calculation
                allDataPoints = allDataPoints.concat(data.series[0].data, data.series[2].data);
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
                    { name: "SL Khách sạn", type: "bar", data: [currentYearData.series[0].data[monthToShow]], yAxisIndex: 1 },
                    { name: "Tổng doanh thu", type: "area", data: [currentYearData.series[1].data[monthToShow]], yAxisIndex: 0 },
                    { name: "SL phòng được đặt", type: "bar", data: [currentYearData.series[2].data[monthToShow]], yAxisIndex: 2 }
                ],
                xaxis: { categories: [defaultOptions.xaxis.categories[monthToShow]] }
            };
            allDataPoints = currentYearData.series[0].data.concat(currentYearData.series[2].data);
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
                    { name: "SL Khách sạn", type: "bar", data: hotelData6M, yAxisIndex: 1 },
                    { name: "Tổng doanh thu", type: "area", data: revenueData6M, yAxisIndex: 0 },
                    { name: "SL phòng được đặt", type: "bar", data: bookingsData6M, yAxisIndex: 2 }
                ],
                xaxis: { categories: months6M }
            };
            allDataPoints = hotelData6M.concat(bookingsData6M);
            break;

        case '1Y':
            // Show data for the selected year
            newData = {
                series: [
                    { name: "SL Khách sạn", type: "bar", data: currentYearData.series[0].data, yAxisIndex: 1 },
                    { name: "Tổng doanh thu", type: "area", data: currentYearData.series[1].data, yAxisIndex: 0 },
                    { name: "SL phòng được đặt", type: "bar", data: currentYearData.series[2].data, yAxisIndex: 2 }
                ],
                xaxis: { categories: defaultOptions.xaxis.categories }
            };
            allDataPoints = currentYearData.series[0].data.concat(currentYearData.series[2].data);
            break;
    }

    // Calculate min and max values for y-axis
    const minValue = Math.min(...allDataPoints);
    const maxValue = Math.max(...allDataPoints);

    // Update the chart with the new data
    chart.updateOptions({
        series: newData.series,
        xaxis: newData.xaxis,
        yaxis: [
            {
                title: {
                    text: 'Số lượng'
                },
                labels: {
                    formatter: function (value) {
                        return value.toFixed(0); // Display as integer
                    }
                },
                min: minValue,
                max: maxValue
            },
            {
                opposite: true,
                title: {
                    text: 'Tổng doanh thu'
                },
                labels: {
                    formatter: function (value) {
                        return new Intl.NumberFormat('vi-VN', { minimumFractionDigits: 0 }).format(value);
                    }
                }
            },
            {
                show: false,
                title: {
                    text: 'SL Phòng đặt'
                },
                labels: {
                    formatter: function (value) {
                        return value.toFixed(0); // Display as integer
                    }
                },
                min: minValue,
                max: maxValue
            }
        ]
    });
}

// Function to get chart colors from CSS
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

// Default to "1Y" when the page loads
document.addEventListener('DOMContentLoaded', () => {
    fetchChartData();
});
