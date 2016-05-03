(function () {
    var getAllCustomers = function () {
        function createTable(response) {
            var target = $("table>tbody"),
                    data = response;

            data.forEach(function (item) {
                var tableRow = createTableRow(item);
                target.append(tableRow);
            });
        }

        function createTableRow(item) {
            var tableRow = $("<tr/>");
            tableRow.append($("<td/>").text(item.Id));
            tableRow.append($("<td/>").text(item.Name));
            tableRow.append($("<td/>").text(item.Phone));
            tableRow.append($("<td/>").append($("<a/>").attr("href", "Edit/".concat(item.Id)).text("edit")));
            tableRow.append($("<td/>").append($("<a/>").attr("href", "Detail/".concat(item.Id)).text("details")));
            tableRow.append($("<td/>").append($("<a/>").attr("href", "Delete/".concat(item.Id)).text("delete")));
            return tableRow;
        }

        function createTableCell(item) {
            var tableCell = $("<td/>");
            tableCell.text(item.Id);
            return tableCell;
        }

        $.ajax({
            type: "GET",
            contentType: "application/json; charset=utf-8",
            url: "http://localhost:3782/Services/CustomerServiceWcf.svc/customers",
            data: "",
            processData: false,
            dataType: "json",
            success: createTable,
            error: function (a, b, c) {
                alert(a.responseText);
            }
        });
    };

    $(document).ready(getAllCustomers);
}());