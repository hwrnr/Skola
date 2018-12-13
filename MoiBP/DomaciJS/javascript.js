var filmovi = [
  {
    "name" : "Brzi Brzic", "img" : "film1.jpg", "link" : "film1.html"
  },
  {
    "name" : "Park uzasa", "img" : "film2.jpg", "link" : "film2.html"
  },
  {
    "name" : "Zvezda je rodjena", "img" : "film3.jpg", "link" : "film3.html"
  }
]
function getData() {
  return filmovi;
}

function arrayToTable(tableData) {
    console.log(tableData);
    var table = $('<table></table>');
    $(tableData).each(function (i, rowData) {
        var row = $('<tr></tr>');
        $(rowData).each(function (j, cellData) {
            row.append($('<td>' + cellData["name"] + '</td>' + '<td width="200px">' + '<a href="' + cellData["link"] + '"><img src="' + cellData["img"] + '"/></a> </td>'));
        });
        table.append(row);
    });
    return table;
}

function onLoadTable(){
  $('body').append(arrayToTable(getData()));
}

 $(document).ready(onLoadTable());
